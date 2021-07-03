using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ForLoop
    {
        public static string Looper(int from, int to, int step)
        {
            string output = "";
            for(int i = from; i <= to; i = i + step)
            {
                output += i + " ";
            }
            return output;
        }

    }
}
