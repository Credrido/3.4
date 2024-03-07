using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Int : RandomType<int>
    {
        public override int Randomise()
        {
            return random.Next(-200, 200);
        }
    }
}
