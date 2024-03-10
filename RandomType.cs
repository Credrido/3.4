using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public abstract class RandomType<T>
    {
        public Random random = new Random();

        public abstract T Randomise();

        public abstract T ConvertString(string input);
    }
}
