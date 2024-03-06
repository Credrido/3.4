using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public sealed class OnedimensionalDouble : ArrayBase
    {
        private double[] array;

        public OnedimensionalDouble(bool randif) : base(randif) { }

        protected override void Fillarray()
        {
            Console.WriteLine();

            Console.WriteLine("Введите длину массива:");

            int length = int.Parse(Console.ReadLine());

            array = new double[length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива:");

                array[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        protected override void Fillarrayrandomly()
        {
            Random random = new Random();

            array = new double[4];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-200, 200);
            }
            Console.WriteLine();
        }

        public override void Getmiddle()
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double result = sum / array.Length;

            Console.WriteLine();

            Console.WriteLine("Среднее значение массива:");

            Console.WriteLine(result);

            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine("Итоги одномерного массива");
            Console.WriteLine();
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}
