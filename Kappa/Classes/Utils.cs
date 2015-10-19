/*
* Thiago Diniz Maia
* dinizthiagobr@gmail.com
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kappa.Classes
{
    static class Utils
    {
        static public List<string> readLines(string filename)
        {
            List<string> items = new List<string>();
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Path\To\" + filename))
            {
                while (!file.EndOfStream)
                    items.Add(file.ReadLine());
            }

            return items;
        }
    }
}
