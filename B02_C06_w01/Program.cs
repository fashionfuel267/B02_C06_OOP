using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_C06_w01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            string ans=string.Empty;
            do
            {
            Employee employee = new Employee();
            Console.WriteLine("Enter your Id");
            employee.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your First Name");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Date of Birth Date (mm/dd/yy)");
            employee.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter your Joining Date(mm/dd/yy)");
            employee.JoiningDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\nDESIGNATIONS:\n============\n1.GM\n 2.DGM\n 3. AGM\n4. SM\n5. Manager\n6. Executive\n7. Assistant");
            Console.Write("\nInput any one serial number of the designations given above: ");
            int desigCode = Int32.Parse(Console.ReadLine());
                switch (desigCode) { 
                case 1: employee.Designation= Designation.GM; break;
                    case 2: employee.Designation = Designation.DGM; break;
                    case 3: employee.Designation = Designation.AGM; break;
                    case 4: employee.Designation = Designation.SM ; break;
                    case 5: employee.Designation = Designation.Manager ; break;
                    case 6: employee.Designation = Designation.Executive; break;
                    case 7: employee.Designation = Designation.Assistant; break;
                }
                
                //  employee.Designation= Designation.SM; 



                Console.Write("\nGive roles of the employee (Seperate by comma[,]): ");
           employee.Roles = employee.GetRoles(Console.ReadLine());
                employees.Add(employee);
            
                Console.WriteLine(  "Do you want to continue?[y/n]");
                ans = Console.ReadLine();
            } while (ans =="y");
            Console.WriteLine("-----------All Employees are listed below--------");

            Console.Write($"ID\tName\t\tDOB\t\tDesignation\t\tJOining\tRoles\n");
            Console.WriteLine("==================================================");
           foreach(var employee in  employees)
            {
                Console.Write($"{employee.Id}\t{employee.GetFullName()}\t\t{employee.BirthDate}\t \t{employee.JoiningDate}\t\nRoles are given below\n");
                employee.ReturnROle();
            }
           
         
            Console.ReadKey();


        }
    }
}
