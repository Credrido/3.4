using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Bool : RandomType<bool>
    {
        public override bool Randomise()
        {
            if(random.Next(0,1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
