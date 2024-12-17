using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_practicum
{
    /// <summary>
    /// Задание 3. Создать список из целых чисел. Определить сумму значений элементов списка, кратных 5.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {11, 20, 34, 40, 53, 60, 72, 804, 90, 100,
                                                 110, 129, 13, 140, 159, 161, 170, 180, 190, 201};
            Console.WriteLine(Sum(list));
        }
        static int Sum(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 5 == 0)
                {
                    sum += list[i];
                }
            }
            return sum;
        }
    }
}
