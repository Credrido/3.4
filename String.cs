using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class String : RandomType<string>
    {
        public override string Randomise()
        {
            string letters = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю";

            char[] chars = new char[10];

            for (int i = 0; i < 10; i++)
            {
                chars[i] = letters[random.Next(0, letters.Length)];
            }

            return new string(chars);
        }

        public override string ConvertString(string input)
        {
            return input;
        }
    }
}
