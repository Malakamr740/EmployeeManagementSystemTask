namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Welcome To The Employee Management System ******** ");
            int ChoiceAnswer;
            do //Main Menu 
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1.To Add An Employee Press 1 ");
                Console.WriteLine("2.To Remove An Existing Employee press 2");
                Console.WriteLine("3.To Display Registered Employees press 3");
                Console.WriteLine("4.To Calculate The Salary For A Certain Employee 4");
                Console.WriteLine("5.If You Want To Exit Press 5");
                
                ChoiceAnswer = Convert.ToInt16(Console.ReadLine()); //User's Answer Choice To Main Menu
                MainMenuDialogs m = new MainMenuDialogs();
                switch (ChoiceAnswer) {
                    case 1 :
                        m.AddEmployeeMenu();
                        //m.AddEmployeeMenu();
                        break;
                    case 2 :
                        m.RemoveEmployeeMenu();
                        break;
                    case 3 :
                        m.DisplayEmployeeMenu();
                        break;
                    case 4:
                        m.CalculatingSalary();
                        break;
                    case 5:
                        Console.WriteLine("Good Bye ...Have A Great Day!");
                        break; 
                
                
                }
                

            }
            while (ChoiceAnswer!=5);



        }
    }
}
