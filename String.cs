using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class String : RandomType<string>
    {
        public override string Randomise()
        {
            string letters = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю";

            int length = 10;

            char[] chars = new char[length];

            for(int i =0; i < length; i++)
            {
                chars[i] = letters[random.Next(0, letters.Length)];
            }

            return new string(chars);
        }
    }
}
