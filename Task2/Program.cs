using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Створіть колекцію, в якій зберігалися б найменування 12 місяців, порядковий номер і кількість днів у відповідному місяці. 
    Реалізуйте можливість вибору місяців як за порядковим номером, так і кількістю днів у місяці, 
    при цьому результатом може бути не тільки один місяць.
     */
    class Program
    {
        static void Main()
        {
            Calendar calendar = new Calendar();

            foreach (var item in calendar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 10));
            Console.WriteLine(calendar.GetDaysByMonth(5));

            Console.WriteLine(new string('-', 10));
            Console.WriteLine(calendar.GetMonthByDays(30));

            Console.ReadKey();
        }
    }
}
