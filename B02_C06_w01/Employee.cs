using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_C06_w01
{
    internal class Employee : Person,IRole
    {
        public override string FirstName { get => firstName; 
                                    set => firstName=value; }
        public override string LastName { 
                            get =>lastName;
                            set => lastName=value; }
        public override DateTime BirthDate { get => birthDate; set =>birthDate=value; }
        public int Id { get; set; }
        public DateTime JoiningDate { get; set; }
        public Designation Designation { get; set; }
        public string[] Roles { get; set; }
        public override string GetAge()
        {
            TimeSpan age = DateTime.Now - BirthDate;
            int years = age.Days / 365;
            int months = (age.Days - years * 365) / 30;
            int days = (age.Days - years * 365 - months * 30);
            return years.ToString() + " years " + months.ToString() + " months " + days.ToString() + " days.";

        }

        public override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string[] GetRoles(string role)
        {
            var s = role.Split(',');
            return s;
        }
        public void ReturnROle()
        {
            Roles.ToList().ForEach(r=>Console.WriteLine(r));
        }

         
    }
}
