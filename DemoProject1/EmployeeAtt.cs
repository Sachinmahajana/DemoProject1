using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject1
{
    internal class EmployeeAtt
    {
        int isPresent = 1;
        
        public void EmployeeAttendence()
        {
            Random myObj4 = new Random();
            int empAttendence = myObj4.Next(0, 2);

            if (empAttendence == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
