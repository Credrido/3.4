using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public sealed class Twodimensional<T> : ArrayBase<T>
    {
        private T[,] array;

        public Twodimensional(bool randif, RandomType<T> Type) : base(randif, Type) { }

        protected override void Fillarray()
        {
            Console.WriteLine("Введите кол-во строк:");

            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите кол-во столбцов:");

            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine();

            array = new T[rows, columns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент массива:");

                    array[i, j] = Type1.ConvertString(Console.ReadLine());

                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        protected override void Fillarrayrandomly()
        {
            Random random = new Random();

            array = new T[4, 4];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Type1.Randomise();
                }
            }
            Console.WriteLine();
        }


        public override void Print()
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
