using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02
{
    class Converter
    {
       private double usdcource;
       private double eurcource;
       private double rubcource;

        public double ToUAH(string type, double count)
        {
            double result = 0;
            switch (type.ToLower())
            {
                case "uah":
                    result = count;
                    break;
                case "usd":
                    result = count * usdcource;
                    break;
                case "eur":
                    result = count * eurcource;
                    break;
                case "rub":
                    result = count * rubcource;
                    break;
                default:
                    throw new Exception("Некорректное название валюты");
                    break;
            }

            return result;
        }
        public double ToAnother(string type, double uahcount)
        {
            double result = 0;
            switch (type.ToLower())
            {
                case "uah":
                    result = uahcount;
                    break;
                case "usd":
                    result = uahcount / usdcource;
                    break;
                case "eur":
                    result = uahcount / eurcource;
                    break;
                case "rub":
                    result = uahcount / rubcource;
                    break;
                default:
                    throw new Exception("Некорректное название валюты");
                    break;
            }

            return result;
        }
        
           
        
        public Converter(double usd, double eur, double rub)
        {
            usdcource = usd;
            eurcource = eur;
            rubcource = rub;
        }

    }
}
