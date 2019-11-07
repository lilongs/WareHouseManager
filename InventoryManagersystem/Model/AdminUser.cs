using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class AdminUser
    {
        
        int Employee_ID;

        public int EmployeeID
        {
            get { return Employee_ID; }
            set { Employee_ID = value; }
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        
    }
}
