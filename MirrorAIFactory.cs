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

using System;
using System.Collections.Generic;

namespace mirror
{
    public static class MirrorAIFactory
    {
        private static readonly String ElizaAI = "Eliza";
        public static List<String> GetAvailableAIEngines ()
        {
            List<String> Engines = new List<string> ();
            Engines.Add (ElizaAI);
            return Engines;
        }


        public static MirrorAIBase GetAIEngine (String name, String configuration)
        {
            if (name.CompareTo (ElizaAI) == 0)
            {
                return new MirrorAIEliza (configuration);
            }

            return null;
        }

        public static String GetConfig (String name)
        {
            return null;
        }
    }
}
