using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_practicum
{
    /// <summary>
    /// 1 задание. 3 вариант
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //List <string> people = new List<string>();
            //foreach (string el in people)
            //{
            //    Console.WriteLine(el);
            //}

            //List <string> people1 = new List<string> {"oleg","yarik", "david"};
            //foreach (var item in people1)
            //{
            //    Console.WriteLine(item);
            //}

            //var people2 = new List<string>() { "choto", "choto1", "choto2" };
            //foreach (var item in people2)
            //{
            //    Console.WriteLine(item);
            //}

            //var employer = new List<string>(people2);
            //foreach (var item in employer)
            //{
            //    Console.WriteLine(item);
            //}

            //0
            var disciplines = new List<string>();
            //1
            disciplines.Add("math");
            disciplines.Add("geometry");
            disciplines.Add("physics");
            //2
            Output(disciplines);
            //3,4
            ToUpperMethod(disciplines);
            //5
            Console.WriteLine(disciplines.Count);
            //6
            disciplines.Add("eng");
            //7
            Output(disciplines);
            //8
            disciplines.Insert(0, "russian");
            //9
            Output(disciplines);
            //10
            disciplines.RemoveAt(2);
            //11
            Output(disciplines);
            //12
            disciplines.Reverse();
            Output(disciplines);
        }
        /// <summary>
        /// Mетод вывода списка
        /// </summary>
        /// <param name="disciplines"></param>
        static void Output(List<string> disciplines)
        {
            foreach (string discipline in disciplines) { Console.Write($"{discipline} "); }
            Console.WriteLine();
        }
        /// <summary>
        /// Mетод,выводящий элементы списка в UpperCase
        /// </summary>
        /// <param name="disciplines"></param>
        static void ToUpperMethod(List<string> disciplines)
        {
            foreach (string discipline in disciplines) Console.WriteLine(discipline.ToUpper());
        }
    }
}
