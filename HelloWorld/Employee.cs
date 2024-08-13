using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Employee ///////: IDisplayData 
    {
        //protected List<Employee> = new List<Employee>();
        public static int NumberOfEmployees=0;
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string Department { get; set; }
        public DateTime HireDate  { get; set; }
      
        public string age { get; set; }
        public double Salary { get; set; }
        public double Commission { get; set; }

        ///public abstract void DisplayEmployees();





    }
}
