using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02.Figures
{
    class Point
    {
        private int x;
        private int y;
        private string name;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Point(int inputx, int inputy, string inputname)
        {
            x = inputx;
            y = inputy;
            name = inputname;
        }


    }
}
