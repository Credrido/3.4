using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public sealed class Onedimensional<T> : ArrayBase<T>
    {
        private T[] array;

        public Onedimensional(bool randif, RandomType<T> Type) : base(randif, Type) { }

        protected override void Fillarray()
        {
            Console.WriteLine();

            Console.WriteLine("Введите длину массива:");

            int length = int.Parse(Console.ReadLine());

            array = new T[length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива:");

                array[i] = Type1.ConvertString(Console.ReadLine());

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        protected override void Fillarrayrandomly()
        {
            Random random = new Random();

            array = new T[4];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Type1.Randomise();
            }
            Console.WriteLine();
        }

        public override void Print()
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}
