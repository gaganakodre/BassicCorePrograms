﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasicCorePrograms
{
    internal class VowelOrConsonant
    {
        Console.Write("Input an Alphabet A-Z or a-z : ");
            int ch = Convert.ToChar(Console.ReadLine().ToLower());
        int i = ch;
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is not a vowel");
                    break;
            }
}
    }
}
