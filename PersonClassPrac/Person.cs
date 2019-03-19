using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassPrac
{
    public class Person
    {
        private string _EyeColor;
        private string _FirstName;
        private string _LastName;
        private int _Age;

        public string EyeColor { get => _EyeColor; set => _EyeColor = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public int Age { get => _Age; set => _Age = value; }
        public Person()
        {

        }

        public Person(string firstName,string lastName,int age)
        {
            this._FirstName = firstName;
            this._LastName = lastName;
            this._Age = age;
        }


        public string Walk()
        {
            return "Person " + _FirstName + " " + _LastName + " is walking down the road";
        }

        public string TellMeAge()
        {
            return "" + _FirstName + " is " + _Age.ToString() + " years old.";
        }

        public string UpdateInfo()
        {           
            
             return "\n" + "First Name: " + _FirstName + "\n" + "Last Name: " + _LastName + "\n" + "EyeColor: " + _EyeColor + "\n" + "Age: " + Convert.ToInt32(_Age);
        }
    }
}
