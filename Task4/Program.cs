using System;

namespace Task4
{
    /*
    Створіть колекцію, в яку можна записувати два значення одного слова, на кшталт російсько-англо-українського словника. 
    І в ній можна для українського слова знайти або лише російське значення, або лише англійське та вивести його на екран. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стiл"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблyко"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
