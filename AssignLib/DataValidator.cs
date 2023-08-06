using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignLib
{
   
    public class DataValidator
    {
        public bool IsValidEmail(string email)
        {     // Your email validation logic here (simplified for example)
            return email.Contains("@") && email.Contains(".");
        }
    }

}
