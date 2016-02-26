using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02.Library
{
    class Title
    {
        public string Value {get;set; }

        public Title()
        {

        }
        public Title(string inputval)
        {
            Value = inputval;
        }
        public void Show(ConsoleColor color)
        {
            Console.ForegroundColor=color;
            Console.WriteLine(Value);
            Console.ResetColor();
        }
    }
}
