using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Створіть колекцію, яка б за своєю структурою нагадувала «родове дерево» (ім'я людини, рік народження), 
    причому до неї можна додавати/вилучати нового родича, 
    є можливість побачити всіх спадкоємців обраної людини, відібрати родичів за роком народження. 
     */
    class Program
    {
        static void Main()
        {
            var listInts = new List<string> { "Ivan", "Petya", "Vasiliy", "Andrey" };
            var linkList = MyFamily<string>.CreateList(listInts);

            foreach (var item in linkList.LinkListIterator())
                Console.Write("{0}, ", item);

            // Задержка.
            Console.ReadKey();
        }
    }
}

