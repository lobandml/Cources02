using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02
{

    
    class Employee
    {
       enum WType
         {
           Cashier,
           Adviser,
           Manager
         }
       public string FirstName{get;private set;}
        public string LastName{get;private set;}
        public string Work{get; set;}
        public int Time{get; set;}

        public Employee(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        private WType RetType(string input)
        { 
            WType result;
            switch (input.ToLower())
            {
                   
                case "кассир":
                    result= WType.Cashier;
                    break;
                case "консультант":
                    result = WType.Adviser;
                    break;
                case "менеджер":
                    result = WType.Manager;
                    break;
                default:
                    throw new Exception("некорректная должность");
            }
            return result;
        }

        public double GetMoneys()
        {
            double coeffitient = (Time > 3) ? 1.2 : 1.0;
            double result;

            switch (RetType(Work))
            {
                case WType.Cashier:
                    result= 1000 * coeffitient;
                    break;
                case WType.Adviser:
                    result = 1500 * coeffitient;
                    break;
                case WType.Manager:
                    result = 2000 * coeffitient;
                    break;
                default:
                    throw new Exception("некорректная должность");
            }
            return result;
        }
        public double Tax()
        {
            return GetMoneys() * 0.2;
        }
        public override string ToString()
        {
           return FirstName.ToString()+", "+LastName.ToString()+", "+Time.ToString()+", "+ Work.ToString();
        }

    }
}
