using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydacProject
{
    internal class LoginHandler
    {
        String username;
        String password;

        public LoginHandler() {
            Employee employee = new Employee();
            username = employee.personName;
            password = employee.password;
        }
        public String getUsername() { 

            return username;
        }
        public String getPassword() {
            return password;
            
        }
       // Use FileHandler to compare username/password from employees to the entred values
    }
}
