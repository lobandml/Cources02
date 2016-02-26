using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02
{
    class User
    {
        private  string login;
        private  string firstName;
        private  string lastName;
        private  int age;
        private readonly DateTime registrationTime;

        public string Login
        {
            get
            {
                return login;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
        public DateTime RegTime
        {
            get
            {
                return registrationTime;
            }
        }

        public User(string login, string firstName, string lastName, int age, DateTime time)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.registrationTime = new DateTime(time.Ticks);
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder(255);
            result.Append(Login);
            result.Append(" ");
            result.Append(FirstName);
            result.Append(" ");
            result.Append(LastName);
            result.Append(" ");
            result.Append(Age);
            result.Append(" ");
            result.Append(RegTime.ToShortDateString());
            result.Append(" ");
            return result.ToString();
        }
    }
    
}
