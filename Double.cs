using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Double :RandomType<double>
    {
        public override double Randomise()
        {
            return random.NextDouble();
        }

        public override double ConvertString(string input)
        {
            return double.Parse(input);
        }
    }
}
