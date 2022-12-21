using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Director:ICloneable
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Director(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public object Clone()
        {
            return new Director(FirstName, LastName);
        }


        string toString()
        {
            return $"Director's name: {FirstName} {LastName}";
        }
    }
}
