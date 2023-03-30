using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "Завтрак в 09:00";
            var regex = new Regex(@"\b(?:[01][0-9]|2[0-3]):[0-5][0-9]\b");
            var matches = regex.Matches(a).Cast<Match>().Select(x => x.Value);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
