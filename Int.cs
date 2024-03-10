using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Int : RandomType<int>
    {
        public override int Randomise()
        {
            return random.Next(-200, 200);
        }

        public override int ConvertString(string input)
        {
            return int.Parse(input);
        }
    }
}
