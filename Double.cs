using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Double : RandomType<double>
    {
        public override double Randomise()
        {
            return random.NextDouble();
        }
    }
}
