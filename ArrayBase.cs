using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public abstract class ArrayBase<T> : IArrayBase, IPrinter
    {
        protected RandomType<T> Type1;
        public ArrayBase(bool randif, RandomType<T> Type)
        {
            Type1 = Type;
            Createarray(randif);
        }

        public void Createarray(bool randif)
        {
            if (randif)
            {
                Fillarray();
            }
            else
            {
                Fillarrayrandomly();
            }
        }

        protected abstract void Fillarray();

        protected abstract void Fillarrayrandomly();

        public abstract void Print();
    }
}
