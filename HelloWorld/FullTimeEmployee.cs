using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    
    public class FullTimeEmployee : Employee, IRegistration, ICalculations,IRemoveData 
    {
        public static int NumberOfFullTimeEmployees = 0;


        public static List<FullTimeEmployee> FTEList = new List<FullTimeEmployee>();
         
        public FullTimeEmployee()
        {
            NumberOfFullTimeEmployees++;
        }





        //Getting Employee Data
        public Employee GetEmployeeInfo()
        {

            FullTimeEmployee FullTEmployee = new FullTimeEmployee() { };

            Console.WriteLine("Enter Employee's Full Name");//1
            FullTEmployee.EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee's Age");//2
            FullTEmployee.age = Console.ReadLine();


            FullTEmployee.HireDate = DateTime.Now;//3
            FullTEmployee.Department = "Full Time Employee";//4
            Console.WriteLine("Does This Employee Have Any Commissions ? (Y/N)");
            //string choice =Console.ReadLine();
            //if (choice.Equals("Y") || choice.Equals("y"))
            //{

            //    FullTEmployee.Commission = Convert.ToDouble(Console.ReadLine());
            //    FullTEmployee.CalculateSalary(FullTEmployee.Commission);
            //}
            //else
            //{


            //}
            FullTEmployee.Salary = 0.0;//5

            return FullTEmployee;
        }


         
            //Adding Data To The List
            public void AddEmployee()
        {
            FullTimeEmployee EmployeeToAdd = (FullTimeEmployee)GetEmployeeInfo();
            var _Context = new EmployeeDbContext();
            var Employee = new FullTimeEmployee()
            {
                
                EmployeeName = EmployeeToAdd.EmployeeName,
                age= EmployeeToAdd.age,
                Department = EmployeeToAdd.Department,
                Salary= EmployeeToAdd.Salary
                


            };
            _Context.Employees.Add(Employee);
            
            FTEList.Add(EmployeeToAdd);
            Console.WriteLine("Employee Added Successfully");
            
            

        }




        //public override void DisplayEmployees()
        //{
        //    if (NumberOfFullTimeEmployees != 0)
        //    {
        //        Console.WriteLine("Full Time Employees : ");
        //        foreach (FullTimeEmployee FTE in FTEList)
        //        {
        //            Console.WriteLine("Employee Name: " + FTE.EmployeeName);
        //            Console.WriteLine("Age: " + FTE.age);
        //            Console.WriteLine("HireDate" + FTE.HireDate);

        //            if (FTE.Salary != 0)
        //            {
        //                Console.WriteLine("Salary: " + FTE.Salary);
        //            }
        //            else
        //            {
        //                Console.WriteLine("This Employee Is Newly Hired and Still doesn't Have a Stable Salary");
        //            }
        //        }
        //    }


        //    else
        //    {
        //        Console.WriteLine("There Are No FullTime Employees Hired");

        //    }

        //}


        public void RemoveEmployee(string EmpName)
        {



        }

        public void CalculateSalary(double commission) { 
            Double tax= 0.05;
            Double BaseSalary = 3000;
            Salary = 3000 - (3000 * (tax / 100)) + (3000 * (1 + (commission / 100)));
            Console.WriteLine(EmployeeName + "'s" + " is" + Salary);
        
        
        }



    }




        }

    
