using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class MainMenuDialogs
    {

        // Add Employee Menu
        public void AddEmployeeMenu()
        {
            Console.WriteLine("Choose Which Employee Would You Like To Add");
            Console.WriteLine("press 1 For Full Time Employees");
            Console.WriteLine("press 2 For Part Time Employees");
            Console.WriteLine("press 3 For The Main Menu");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    IRegistration EmployeeData = new FullTimeEmployee();
                    EmployeeData.AddEmployee();

                    //EmployeeData.AddEmployee();
                    break;
                case 2:

                    break;
                case 3:
                    break;
              

            }

        }


        //Display Employee Menu

        public void DisplayEmployeeMenu() {

            Console.WriteLine("Choose Which Employees Would You Like To Display");
            Console.WriteLine("press 1 For Full Time Employees");
            Console.WriteLine("press 2 For Part Time Employees");
            Console.WriteLine("press 3 For All Departments Employees");
            Console.WriteLine("press 4 For The Main Menu");
            int choice = Convert.ToInt16(Console.ReadLine());
            Employee f = new FullTimeEmployee();
            switch (choice)
            {

                case 1:
                    ////f.DisplayEmployees();
                    break;
                case 2:

                    break;
                case 3:
                    //f.DisplayEmployees();
                    break;
                case 4:
                    break;


            }


        }


        //Remove Employee Menu

        public void RemoveEmployeeMenu() {
            Console.WriteLine("Choose Which Department The Employee(s) is(are) Working In");
            Console.WriteLine("press 1 For Full Time Employees");
            Console.WriteLine("press 2 For Part Time Employees");
            Console.WriteLine("press 3 For All Departments Employees");
            Console.WriteLine("press 4 For The Main Menu");
            int choice = Convert.ToInt16(Console.ReadLine());
            Employee f = new FullTimeEmployee();
            switch (choice)
            {

                //case 1:

                //    f.DisplayEmployees();
                //    break;
                //case 2:

                //    break;
                //case 3:
                //    f.DisplayEmployees();
                //    break;
                //case 4:
                //    break;


            }



        }


        //Calculate Salary Menu
        public void CalculatingSalary()
        {

            Console.WriteLine("Choose Which Employees Would You Like To Their Salary");
            Console.WriteLine("press 1 For Full Time Employees");
            Console.WriteLine("press 2 For Part Time Employees");
            Console.WriteLine("press 3 For All Departments Employees");
            Console.WriteLine("press 4 For The Main Menu");
            int choice = Convert.ToInt16(Console.ReadLine());
            Employee f = new FullTimeEmployee();
            switch (choice)
            {

                case 1:
                   
                    break;
                case 2:

                    break;
                case 3:
                    ///f.DisplayEmployees();
                    break;
                case 4:
                    break;


            }


        }

    }

}