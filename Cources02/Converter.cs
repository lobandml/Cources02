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

       enum MType
       {
           UAH,
           USD,
           EUR,
           RUB
       }

       private MType RetType(string input)
       {
           MType result;
           switch (input.ToLower())
           {
               case "uah":
                    result = MType.UAH;
                    break;
                case "usd":
                    result = MType.USD;
                    break;
                case "eur":
                    result = MType.EUR;
                    break;
                case "rub":
                    result = MType.RUB;
                    break;
                default:
                    throw new Exception("Некорректное название валюты");
                    break;
           }
           return result;
       }

        public double ToUAH(string type, double count)
        {
            double result = 0;
            switch (RetType(type))
            {
                case MType.UAH:
                    result = count;
                    break;
                case MType.USD:
                    result = count * usdcource;
                    break;
                case MType.EUR:
                    result = count * eurcource;
                    break;
                case MType.RUB:
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
            switch (RetType(type))
            {
                case MType.UAH:
                    result = uahcount;
                    break;
                case MType.USD:
                    result = uahcount / usdcource;
                    break;
                case MType.EUR:
                    result = uahcount / eurcource;
                    break;
                case MType.RUB:
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
