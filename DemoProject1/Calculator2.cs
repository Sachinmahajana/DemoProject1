using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject1
{
    public class Calculator2
    {
        // Create the instance variables inside the class
        public int first, second, sum;

        /// <summary>
        /// initializes a new instance of the <see cref="Calculator2"/> class.
        /// </summary>
        /// <param name="firstNumb"></param>
        /// <param name="secondNumb"></param>
        public Calculator2(int firstNumb, int secondNumb)
        {
            first = firstNumb;
            second = secondNumb;
        }     

        /// <summary>
        /// Addition of 2 number to get sum
        /// </summary>
        public void Addition()
        {
            sum = first + second;
            Console.WriteLine("Sum:" + sum);                            
        }
        public void Subtraction()
        {
            sum = Math.Abs (first - second);
            Console.WriteLine("Subtraction:" + sum);
        }
        public void Multiplication()
        {
            sum = first * second;
            Console.WriteLine("Multiplication:" + sum);
        }
        public void Dividing()
        {
            sum = first / second;
            Console.WriteLine("Dividing:" + sum);
        }
        
            
    }
}
