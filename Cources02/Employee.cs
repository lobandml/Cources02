using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02
{
    class Employee
    {

       public string FirstName{get;private set;}
        public string LastName{get;private set;}
        public string Work{get; set;}
        public int Time{get; set;}

        public Employee(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public double GetMoneys()
        {
            double coeffitient = (Time > 3) ? 1.2 : 1.0;
            double result;

            switch (Work.ToLower())
            {
                case "кассир":
                    result= 1000 * coeffitient;
                    break;
                case "консультант":
                    result = 1500 * coeffitient;
                    break;
                case "менеджер":
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
