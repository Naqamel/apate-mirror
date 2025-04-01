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
using System.Linq;

namespace mirror
{
    public abstract class MirrorAIBase
    {
        private List<String> HindiSwears;
        protected String Configuration;
        public MirrorAIBase (String cfg)
        {
            Configuration = cfg;
            HindiSwears = new List<String> ();

            HindiSwears.Add ("rundi");
            HindiSwears.Add ("rundi kabacha");
            HindiSwears.Add ("terra ma key bose oda");
            HindiSwears.Add ("lund");
            HindiSwears.Add ("terra ma key chew");
            HindiSwears.Add ("ben ka load A");
            HindiSwears.Add ("boss ODK");
            HindiSwears.Add ("bock ree chode");
            HindiSwears.Add ("mud R chode");
            HindiSwears.Add ("ben chode");
            HindiSwears.Add ("chew tea uh");
            HindiSwears.Add ("gandu");
            HindiSwears.Add ("betty chod");

        }


        public abstract string Hello ();
        public abstract string Goodbye ();
        public abstract string Respond (String s);
        public string CurseInHindi ()
        {
            Random r = new Random ();
            int count = HindiSwears.Count ();
            int num = r.Next (0, count - 1);
            return HindiSwears[num];
        }
    }
}
