
namespace mirror
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOutputSrc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInputSrc = new System.Windows.Forms.ComboBox();
            this.lblInputSource = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVoskBrowse = new System.Windows.Forms.Button();
            this.txtVOSKPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbAI = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCurse = new System.Windows.Forms.Button();
            this.trackRate = new System.Windows.Forms.TrackBar();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVoice = new System.Windows.Forms.ComboBox();
            this.btnTestSpeech = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestSpeech = new System.Windows.Forms.TextBox();
            this.pictSkull = new System.Windows.Forms.PictureBox();
            this.pictEyes = new System.Windows.Forms.PictureBox();
            this.btnBrowseJSON = new System.Windows.Forms.Button();
            this.txtElizaJSON = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSkull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictEyes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOutputSrc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbInputSrc);
            this.groupBox1.Controls.Add(this.lblInputSource);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio Settings";
            // 
            // cbOutputSrc
            // 
            this.cbOutputSrc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputSrc.FormattingEnabled = true;
            this.cbOutputSrc.Location = new System.Drawing.Point(130, 45);
            this.cbOutputSrc.Name = "cbOutputSrc";
            this.cbOutputSrc.Size = new System.Drawing.Size(316, 21);
            this.cbOutputSrc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output Audio Source:";
            // 
            // cbInputSrc
            // 
            this.cbInputSrc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputSrc.FormattingEnabled = true;
            this.cbInputSrc.Location = new System.Drawing.Point(130, 17);
            this.cbInputSrc.Name = "cbInputSrc";
            this.cbInputSrc.Size = new System.Drawing.Size(316, 21);
            this.cbInputSrc.TabIndex = 1;
            // 
            // lblInputSource
            // 
            this.lblInputSource.AutoSize = true;
            this.lblInputSource.Location = new System.Drawing.Point(6, 20);
            this.lblInputSource.Name = "lblInputSource";
            this.lblInputSource.Size = new System.Drawing.Size(101, 13);
            this.lblInputSource.TabIndex = 0;
            this.lblInputSource.Text = "Input Audio Source:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(502, 417);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Listening";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(608, 417);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(98, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop Listening";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.Black;
            this.logBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.logBox.Location = new System.Drawing.Point(6, 19);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.logBox.Size = new System.Drawing.Size(692, 205);
            this.logBox.TabIndex = 3;
            this.logBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 230);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rolling Log";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVoskBrowse);
            this.groupBox3.Controls.Add(this.txtVOSKPath);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 77);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speech To Text Configuration";
            // 
            // btnVoskBrowse
            // 
            this.btnVoskBrowse.Location = new System.Drawing.Point(371, 46);
            this.btnVoskBrowse.Name = "btnVoskBrowse";
            this.btnVoskBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnVoskBrowse.TabIndex = 2;
            this.btnVoskBrowse.Text = "Browse...";
            this.btnVoskBrowse.UseVisualStyleBackColor = true;
            this.btnVoskBrowse.Click += new System.EventHandler(this.btnVoskBrowse_Click);
            // 
            // txtVOSKPath
            // 
            this.txtVOSKPath.Location = new System.Drawing.Point(130, 20);
            this.txtVOSKPath.Name = "txtVOSKPath";
            this.txtVOSKPath.Size = new System.Drawing.Size(316, 20);
            this.txtVOSKPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "VOSK Engine Path";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrowseJSON);
            this.groupBox4.Controls.Add(this.txtElizaJSON);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbAI);
            this.groupBox4.Location = new System.Drawing.Point(13, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 138);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AI Configuration";
            // 
            // cbAI
            // 
            this.cbAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAI.FormattingEnabled = true;
            this.cbAI.Location = new System.Drawing.Point(11, 30);
            this.cbAI.Name = "cbAI";
            this.cbAI.Size = new System.Drawing.Size(434, 21);
            this.cbAI.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCurse);
            this.groupBox5.Controls.Add(this.trackRate);
            this.groupBox5.Controls.Add(this.trackVolume);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.cbVoice);
            this.groupBox5.Controls.Add(this.btnTestSpeech);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtTestSpeech);
            this.groupBox5.Location = new System.Drawing.Point(13, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(451, 141);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Text To Speech Configuration";
            // 
            // btnCurse
            // 
            this.btnCurse.Location = new System.Drawing.Point(370, 114);
            this.btnCurse.Name = "btnCurse";
            this.btnCurse.Size = new System.Drawing.Size(75, 23);
            this.btnCurse.TabIndex = 10;
            this.btnCurse.Text = "Curse!";
            this.btnCurse.UseVisualStyleBackColor = true;
            this.btnCurse.Click += new System.EventHandler(this.btnCurse_Click);
            // 
            // trackRate
            // 
            this.trackRate.Location = new System.Drawing.Point(287, 55);
            this.trackRate.Minimum = -10;
            this.trackRate.Name = "trackRate";
            this.trackRate.Size = new System.Drawing.Size(158, 45);
            this.trackRate.TabIndex = 9;
            this.trackRate.TickFrequency = 2;
            this.trackRate.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackRate.Value = 3;
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(59, 55);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(158, 45);
            this.trackVolume.TabIndex = 8;
            this.trackVolume.TickFrequency = 10;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackVolume.Value = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Volume:";
            // 
            // cbVoice
            // 
            this.cbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoice.FormattingEnabled = true;
            this.cbVoice.Location = new System.Drawing.Point(59, 22);
            this.cbVoice.Name = "cbVoice";
            this.cbVoice.Size = new System.Drawing.Size(386, 21);
            this.cbVoice.TabIndex = 5;
            // 
            // btnTestSpeech
            // 
            this.btnTestSpeech.Location = new System.Drawing.Point(287, 114);
            this.btnTestSpeech.Name = "btnTestSpeech";
            this.btnTestSpeech.Size = new System.Drawing.Size(75, 23);
            this.btnTestSpeech.TabIndex = 3;
            this.btnTestSpeech.Text = "Test";
            this.btnTestSpeech.UseVisualStyleBackColor = true;
            this.btnTestSpeech.Click += new System.EventHandler(this.btnTestSpeech_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Voice:";
            // 
            // txtTestSpeech
            // 
            this.txtTestSpeech.Location = new System.Drawing.Point(6, 114);
            this.txtTestSpeech.Name = "txtTestSpeech";
            this.txtTestSpeech.Size = new System.Drawing.Size(275, 20);
            this.txtTestSpeech.TabIndex = 0;
            // 
            // pictSkull
            // 
            this.pictSkull.Image = ((System.Drawing.Image)(resources.GetObject("pictSkull.Image")));
            this.pictSkull.InitialImage = null;
            this.pictSkull.Location = new System.Drawing.Point(474, 12);
            this.pictSkull.Name = "pictSkull";
            this.pictSkull.Size = new System.Drawing.Size(246, 394);
            this.pictSkull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictSkull.TabIndex = 8;
            this.pictSkull.TabStop = false;
            // 
            // pictEyes
            // 
            this.pictEyes.Image = ((System.Drawing.Image)(resources.GetObject("pictEyes.Image")));
            this.pictEyes.InitialImage = null;
            this.pictEyes.Location = new System.Drawing.Point(474, 12);
            this.pictEyes.Name = "pictEyes";
            this.pictEyes.Size = new System.Drawing.Size(246, 394);
            this.pictEyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictEyes.TabIndex = 9;
            this.pictEyes.TabStop = false;
            this.pictEyes.Visible = false;
            // 
            // btnBrowseJSON
            // 
            this.btnBrowseJSON.Location = new System.Drawing.Point(370, 93);
            this.btnBrowseJSON.Name = "btnBrowseJSON";
            this.btnBrowseJSON.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseJSON.TabIndex = 5;
            this.btnBrowseJSON.Text = "Browse...";
            this.btnBrowseJSON.UseVisualStyleBackColor = true;
            this.btnBrowseJSON.Click += new System.EventHandler(this.btnBrowseJSON_Click);
            // 
            // txtElizaJSON
            // 
            this.txtElizaJSON.Location = new System.Drawing.Point(129, 67);
            this.txtElizaJSON.Name = "txtElizaJSON";
            this.txtElizaJSON.Size = new System.Drawing.Size(316, 20);
            this.txtElizaJSON.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Eliza JSON Path";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 720);
            this.Controls.Add(this.pictEyes);
            this.Controls.Add(this.pictSkull);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "The Apate Mirror";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSkull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictEyes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbInputSrc;
        private System.Windows.Forms.Label lblInputSource;
        private System.Windows.Forms.ComboBox cbOutputSrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVoskBrowse;
        private System.Windows.Forms.TextBox txtVOSKPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictSkull;
        private System.Windows.Forms.PictureBox pictEyes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbVoice;
        private System.Windows.Forms.Button btnTestSpeech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestSpeech;
        private System.Windows.Forms.TrackBar trackRate;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCurse;
        private System.Windows.Forms.ComboBox cbAI;
        private System.Windows.Forms.Button btnBrowseJSON;
        private System.Windows.Forms.TextBox txtElizaJSON;
        private System.Windows.Forms.Label label6;
    }
}

