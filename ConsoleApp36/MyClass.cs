﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class MyClass : IMyInterface
    {
        public void Show()
        {
            Console.WriteLine("MyClass.Show() is implemented (реализован).");
        }
    }
}
