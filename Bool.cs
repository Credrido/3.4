﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Bool : RandomType<bool>
    {
        public override bool Randomise()
        {
            if (random.Next(0, 1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool ConvertString(string input)
        {
            return bool.Parse(input);
        }
    }
}
