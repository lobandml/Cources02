using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02.Library
{
    class Content
    {
        public string Value {get;set; }

        public Content()
        {

        }
        public Content(string inputval)
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
