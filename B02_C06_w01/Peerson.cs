using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_C06_w01
{
    public enum Designation {
        GM = 1,
        DGM = 2,
        AGM = 3,
        SM = 4,
        Manager = 5,
        Executive = 6,
        Assistant = 7
    }

    public abstract class Person
    {
        //field
       internal  string firstName = "";
        internal string lastName = string.Empty;
        internal DateTime birthDate;
        //property
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateTime BirthDate { get; set; }
        //method
        public abstract string GetFullName();
        public abstract string GetAge();

    }
}
