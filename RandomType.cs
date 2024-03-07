using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public abstract class RandomType<T>
    {
       public Random random = new Random();
       public abstract T Randomise();
    }
}
