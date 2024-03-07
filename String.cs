using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class String : RandomType<string>
    {
        string[] bukvi = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l"};

        public override string Randomise()
        {
            string randomBukva = bukvi[random.Next(0, 15)];

            return randomBukva;
        }
    }
}
