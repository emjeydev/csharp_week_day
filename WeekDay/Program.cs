using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This file is made by EmJey
// Project: Get Days Of The Week
// FileName: WeekDay
// Date: 2023/02/06
// Email: emjeydev@gmail.com
// Github: emjeydev

namespace WeekDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number Of The Week: ");
            int dayNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDay(dayNum));

            Console.ReadLine();
        }

        static String GetDay(int dayNum) {
            String dayName;

            switch (dayNum)
            {
                case 0:
                    dayName= "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
    }
}
