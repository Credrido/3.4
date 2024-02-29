using System;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool randif;

            IArrayBase[] arrays = new IArrayBase[2];

            Console.WriteLine("Хотите заполнить массивы сами? Введите Да или Нет");

            if (Console.ReadLine() == "Да")
            {
                randif = true;
            }
            else
            {
                randif = false;
            }

            arrays[0] = new Onedimensional(randif);
            arrays[1] = new Twodimensional(randif);

            foreach (ArrayBase array in arrays)
            {
                array.Print();
                array.Getmiddle();
            }


            Console.WriteLine();

            IPrinter[] arraysP = new IPrinter[2];
            
            arraysP[0] = new Onedimensional(randif);
            arraysP[1] = new Twodimensional(randif);

            foreach (IPrinter arr in arraysP)
            {
                arr.Print();
            }

        }
    }
}
