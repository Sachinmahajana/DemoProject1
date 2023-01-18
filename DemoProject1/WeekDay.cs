using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject1
{
    internal class WeekDay
    {
        public static void WeekDayFallsOnWeek(int dayNumber)
        {
         switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("It's a Monday");
                     break;
                case 2:
                    Console.WriteLine("It's a Tuesday");
                    break;
                case 3:
                    Console.WriteLine("It's a Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It's a Thursday");
                    break;
                case 5:
                    Console.WriteLine("It's a Friday");
                    break;
                case 6:
                    Console.WriteLine("It's a Saturday");
                    break;
                case 7:
                    Console.WriteLine("It,s a Sunday");
                    break;
                default:
                    Console.WriteLine("Please choose a given below number");
                    break;
            }
        }
           

        }
    }

   