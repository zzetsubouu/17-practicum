using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _17_practicum
{
    /// <summary>
    /// Задание 4. Создать список из целых чисел. Вставить в список число 10 после каждого элемента с отрицательным значением.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, -1, -2, 3, 4, -3, -4};
            InsertingTen(list);
            Output(list);
            Console.ReadKey();
        }
        /// <summary>
        /// метод, который вставляет 10. если перебирать с начала, то цикл никогда не закончится 
        /// </summary>
        /// <param name="list"></param>
        static void InsertingTen(List<int> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                if (list[i] < 0)
                {
                    list.Insert(i + 1, 10);
                }

            }
        }
        /// <summary>
        /// вывод списка
        /// </summary>
        /// <param name="list"></param>
        static void Output(List<int> list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
                
        }
    }
}
