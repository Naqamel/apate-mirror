/*
    Copyright (C) 2021 by Naqamel
    This program is free software: you can redistribute it and/or modify it under the terms of the 
    GNU General Public License as published by the Free Software Foundation, either version 3 of the 
    License, or (at your option) any later version. This program is distributed in the hope that it 
    will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
    or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details. You 
    should have received a copy of the GNU General Public License along with this program. 
    If not, see <http://www.gnu.org/licenses/>.
*/


using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vosk;

namespace mirror
{
    public partial class MainWindow : Form
    {
        private WaveIn waveSource = null;
        private WaveFileWriter waveFile = null;
        private Model model;
        private VoskRecognizer rec;
        private MirrorAIBase MirrorAI;
        private SpeechSynthesizer MirrorVoice;
        private String AIConfig;

        public MainWindow ()
        {
            InitializeComponent ();
        }

        private void MainWindow_Load (object sender, EventArgs e)
        {
            AIConfig = "";
            PopulateInputAudioSources ();
            PopulateOutputAudioSources ();
            cbInputSrc.SelectedIndex = 0;
            cbOutputSrc.SelectedIndex = 0;
            Vosk.Vosk.SetLogLevel (0);
            LoadVoices ();
            LoadAI ();
        }


        private void LoadAI ()
        {
            List<String> AvailableAI = MirrorAIFactory.GetAvailableAIEngines ();
            foreach (String s in AvailableAI)
            {
                cbAI.Items.Add (s);
            }
            cbAI.SelectedIndex = 0;
        }

        private void LoadVoices ()
        {
            var synthesizer = new SpeechSynthesizer ();
            foreach (var voice in synthesizer.GetInstalledVoices ())
            {
                var info = voice.VoiceInfo;
                cbVoice.Items.Add (info.Name.ToString ());
            }
            cbVoice.SelectedIndex = 0;
        }

        private void PopulateInputAudioSources ()
        {
            //create enumerator
            var enumerator = new MMDeviceEnumerator ();
            //cycle through all audio devices
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                String s = enumerator.EnumerateAudioEndPoints (DataFlow.Capture, DeviceState.Active)[i].DeviceFriendlyName;
                int nIndex = cbInputSrc.Items.Add (s);
            }
            //clean up
            enumerator.Dispose ();
        }


        private void PopulateOutputAudioSources ()
        {
            var enumerator = new MMDeviceEnumerator ();
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                String s = enumerator.EnumerateAudioEndPoints (DataFlow.Render, DeviceState.Active)[i].DeviceFriendlyName;
                cbOutputSrc.Items.Add (s);
            }
            enumerator.Dispose ();
        }

        private void btnStart_Click (object sender, EventArgs e)
        {
            this.logBox.Text = "";
            LogMessage ("Loading AI...");
            int index = cbAI.SelectedIndex;
            string s = cbAI.Items[index].ToString ();
            string jsonpath = txtElizaJSON.Text;
            MirrorAI = MirrorAIFactory.GetAIEngine (s, jsonpath);
            LogMessage ("AI Loaded");

            LogMessage ("Loading VOSK (this will take some time)...");
            try
            {
                model = new Model (txtVOSKPath.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
                MessageBox.Show (ex.Message, "Fatal Error Loading VOSK Speech To Text Engine");
                return;
            }

            LogMessage ("VOSK Loaded");
            LogMessage ("Configuring Text To Speech...");

            MirrorVoice = new SpeechSynthesizer ();
            MirrorVoice.Volume = trackVolume.Value;
            MirrorVoice.Rate = trackRate.Value;
            String sVoice = cbVoice.SelectedItem.ToString ();
            MirrorVoice.SelectVoice (sVoice);

            LogMessage ("Text To Speech Configured");
            LogMessage ("Opening Audio Streams...");

            int nIndex = cbInputSrc.SelectedIndex;
            String sInput = cbInputSrc.SelectedItem.ToString ();

            int micIndex = 0;
            var enumerator = new MMDeviceEnumerator ();
            //cycle through all audio devices
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                String sel = enumerator.EnumerateAudioEndPoints (DataFlow.Capture, DeviceState.Active)[i].DeviceFriendlyName;
                if (sel.CompareTo (sInput) == 0)
                {
                    micIndex = i;
                }
            }
            //clean up
            enumerator.Dispose ();

            waveSource = new WaveIn ();
            waveSource.WaveFormat = new WaveFormat (16000, 1);

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs> (waveSource_DataAvailable);
            waveSource.RecordingStopped += new EventHandler<StoppedEventArgs> (waveSource_RecordingStopped);
            
            rec = new VoskRecognizer (model, 16000.0f);
            waveSource.StartRecording ();

            pictEyes.Visible = true;

            LogMessage ("Audio Streams Open...");
            LogMessage ("I'M LISTENING...");

            SayIt (MirrorAI.Hello ());
        }


        private void btnStop_Click (object sender, EventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.StopRecording ();
                waveSource = null;
            }
            pictEyes.Visible = false;
        }

        
        void waveSource_DataAvailable (object sender, WaveInEventArgs e)
        {
            try
            {
                if (rec.AcceptWaveform (e.Buffer, e.Buffer.Length))
                {
                    String s = rec.Result ();
                    Task.Run (() => Respond (s));
                }
                else
                {
                }
            }
            catch (Exception )
            {
            }
        }


        private void Respond (String msg)
        {
            // parse out the JSON
            String p = parseVOSK (msg);

            if (p.Length > 0)
            {
                LogHeard (p);
                // now post it to the AI. 
                String response = MirrorAI.Respond (p);
                SayIt (response);
            }
        }


        private String parseVOSK (String s)
        {
            int nIndex = s.IndexOf (":");
            int openquote = s.IndexOf ("\"", nIndex);
            int closequote = s.IndexOf ("\"", openquote + 1);
            return s.Substring (openquote + 1, closequote - openquote - 1);
        }

        void waveSource_RecordingStopped (object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose ();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose ();
                waveFile = null;
            }
        }


        private void btnVoskBrowse_Click (object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog ())
            {
                if (dlg.ShowDialog () == DialogResult.OK)
                {
                    txtVOSKPath.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnTestSpeech_Click (object sender, EventArgs e)
        {
            SpeechSynthesizer talker = new SpeechSynthesizer ();
            talker.Volume = trackVolume.Value;
            talker.Rate = trackRate.Value;
            String s = cbVoice.SelectedItem.ToString ();
            talker.SelectVoice (s);
            String sayit = txtTestSpeech.Text;
            talker.Speak (sayit);
        }

        private void SayIt (String msg)
        {
            if (MirrorVoice != null)
            {
                MirrorVoice.Speak (msg);
                LogSpoken (msg);
            }
        }

        private void btnCurse_Click (object sender, EventArgs e)
        {
            MirrorAIEliza ai = new MirrorAIEliza ("");
            String text = ai.CurseInHindi ();
            SpeechSynthesizer talker = new SpeechSynthesizer ();
            talker.Volume = trackVolume.Value;
            talker.Rate = trackRate.Value;
            String s = cbVoice.SelectedItem.ToString ();
            talker.SelectVoice (s);
            talker.Speak (text);
        }

        private void btnConfigureAI_Click (object sender, EventArgs e)
        {
            int index = cbAI.SelectedIndex;
            String s = cbAI.Items[index].ToString ();
            AIConfig = MirrorAIFactory.GetConfig (s);
        }

        private void LogMessage (String s)
        {
            String log = "[Message] " + s + "\n";
            logBox.Text += log;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.SelectionLength = 0;
            logBox.Refresh ();
        }

        private void LogHeard (String s)
        {
            String log = "[Heard] " + s + "\n";
            Invoke (new Action (() =>
            {
                logBox.Text += log;
                logBox.SelectionStart = logBox.Text.Length;
                logBox.SelectionLength = 0;
            }));
        }

        private void LogSpoken (String s)
        {
            String log = "[Spoke] " + s + "\n";
            Invoke (new Action (() =>
            {
                logBox.Text += log;
                logBox.SelectionStart = logBox.Text.Length;
                logBox.SelectionLength = 0;
            }));
        }

        private void btnBrowseJSON_Click (object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog ())
            {
                if (dlg.ShowDialog () == DialogResult.OK)
                {
                    txtElizaJSON.Text = dlg.FileName;
                }
            }
        }
    }
}

