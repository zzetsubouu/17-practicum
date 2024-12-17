using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_practicum
{
    /// <summary>
    /// Задание 2. Записана информация о стоимости каждого из 20 видов товара, продаваемых фирмой. С 1 января очередного
    /// года фирма прекращает продавать товар, стоимость которого записана в n-м элементе списка. Получить список со
    /// стоимостью всех оставшихся видов товара.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> prices = new List<int>() {10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
                                                 110, 120, 130, 140, 150, 160, 170, 180, 190, 200};
            Console.WriteLine("какой товар убрать? ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0 && n <= prices.Count)
            {
                prices.RemoveAt(n);
                Output(prices);
            }
            else
            {
                Console.WriteLine("неправильное n");
            }
        }
        static void Output(List<int> prices)
        {
            foreach (var item in prices)
            {
                Console.WriteLine(item);
            }
        }
    }
}
