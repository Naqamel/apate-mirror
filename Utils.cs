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
using System.IO;
using System.Linq;
using System.Reflection;

namespace mirror
{
    public static class Utils
    {
        public static String ReadResource (string name)
        {
            // Determine path
            var assembly = Assembly.GetExecutingAssembly ();
            string resourcePath = name;
            
            
            resourcePath = assembly.GetManifestResourceNames ()
                    .Single (str => str.EndsWith (name));
            
            using (Stream stream = assembly.GetManifestResourceStream (resourcePath))
            using (StreamReader reader = new StreamReader (stream))
            {
                return reader.ReadToEnd ();
            }
        }
    }
}
