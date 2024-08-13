using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class DBConnections
    {
       public const string DbConstr= @"""Server=DESKTOP-VLVULJ4\SQLEXPRESS ;Initial Catalog=EmployeesManagementSystem;
                        Integrated Security=True;Connect Timeout=30;
                        Encrypt=True;
                        Trust Server Certificate=True;
                        Application Intent=ReadWrite;
                        Multi Subnet Failover=False;""";
    }
}
