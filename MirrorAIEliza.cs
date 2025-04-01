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

using ELIZA.NET;
using System;
using System.IO;

namespace mirror
{
    public class MirrorAIEliza : MirrorAIBase
    {
        private ELIZALib Eliza;
        public MirrorAIEliza (String json) : base (json)
        {
            if (json.Length < 1)
            {
                String data = Utils.ReadResource ("Doctor.txt");
                Eliza = new ELIZALib (data);
            }
            else
            {
                Eliza = new ELIZALib (File.ReadAllText (json));
            }
        }

        public override string Hello ()
        {
            return "Hello?";
        }
        
        public override string Goodbye ()
        {
            return Eliza.Session.GetGoodbye ();
        }

        public override string Respond (String s)
        {
            return Eliza.GetResponse(s);
        }
    }
}
