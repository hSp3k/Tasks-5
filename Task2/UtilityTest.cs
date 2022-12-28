using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Tests.Source
{
    public static class UtilityTest
    {
        public static string CreateLine(int length)
        {
            var line = new StringBuilder();
            while(line.Length != length)
            {
                line.Append('a');
            }
            return line.ToString();
        }
    }
}
