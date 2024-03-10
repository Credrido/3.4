using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool randif;

            Console.WriteLine("Хотите заполнить массивы сами? Введите Да или Нет");

            if (Console.ReadLine() == "Да")
            {
                randif = true;
            }
            else
            {
                randif = false;
            }

            IPrinter[] arraysP = new IPrinter[8];

            Int int1 = new Int();
            Bool bool1 = new Bool();
            Double double1 = new Double();
            String string1 = new String();

            arraysP[0] = new Onedimensional<int>(randif,int1);
            arraysP[1] = new Onedimensional<double>(randif, double1);
            arraysP[2] = new Onedimensional<string>(randif, string1);
            arraysP[3] = new Onedimensional<bool>(randif, bool1);


            arraysP[4] = new Twodimensional<int>(randif, int1);
            arraysP[5] = new Twodimensional<double>(randif, double1);
            arraysP[6] = new Twodimensional<string>(randif, string1);
            arraysP[7] = new Twodimensional<bool>(randif, bool1);

            foreach (IPrinter arrP in arraysP)
            {
                arrP.Print();
                Console.WriteLine();
            }
        }
    }
}