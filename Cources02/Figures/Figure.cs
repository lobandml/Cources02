using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02.Figures
{
    class Figure
    {
        public List<Point> PointsContainer { get; private set; } 
        

        public Figure(Point A, Point B, Point C)
        {
            PointsContainer = new List<Point>();
            this.PointsContainer.Add(A);
            this.PointsContainer.Add(B);
            this.PointsContainer.Add(C);
        }
        public Figure(Point A, Point B, Point C, Point D): this(A, B, C)
        {
            PointsContainer.Add(D);
        }
        public Figure(Point A, Point B, Point C, Point D, Point E) : this(A, B, C, D)
        {
            PointsContainer.Add(E);
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.PointsContainer.Count; i++)
            {
                result.Append(this.PointsContainer[i].Name);
                result.Append(" ");
            }
            return result.ToString();
        }
        public static double LengthSize(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(B.X - B.Y, 2));
        }

        public double PerimeterCalculator()
        {
            double sum = 0;
            for (int i = 1; i < this.PointsContainer.Count; i++)
            {
                sum += LengthSize(this.PointsContainer[i - 1], this.PointsContainer[i]);
            }
            sum += LengthSize(this.PointsContainer[this.PointsContainer.Count - 1], this.PointsContainer[0]);
            return sum;
        }
    }
}
