using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv1
{
    public class User
    {
        private string firstName;
        private string lastName;

        public User()
        {
        }

        public User(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set 
            {
                firstName = Capitalize(value);
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = Capitalize(value);
            }
        }

        private static string Capitalize(string value)
        {
            return value.Replace(value[0], char.ToUpper(value[0]));
        }

        public string Greeting()
        {
            return Greeting(FirstName, LastName);
        }

        public static string Greeting(string firstName, string lastName)
        {
            return "Greetings " + firstName + " " + lastName + ".";
        }
    }
}
