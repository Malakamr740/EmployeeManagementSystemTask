using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public interface IRegistration
    {
        public Employee GetEmployeeInfo();//Main Purpose To Make Sure Data Is Taken Correctly From the User
        public void AddEmployee();//Main Purpose To Make Sure Employee Is Added Correctly To The Database
    }
}
