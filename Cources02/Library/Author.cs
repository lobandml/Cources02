using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02.Library
{
    class Author
    {
        public string Value {get;set; }

        public Author()
        {

        }
        public Author(string inputval)
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
