using OOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Reuse_OOP2
{
    public class YourUtils
    { 
        public static int Tuoi (this Employee emp)
        {
            return DateTime.Now.Year-emp.Birthday.Year;
        }
    }
}
