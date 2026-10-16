using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqDenisov
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Задание 1:");
            int[] nums1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var even = from n in nums1
                       where n % 2 == 0
                       select n;
            Console.WriteLine("Числа, в остатке дают 0 после деления на 2:");
            foreach (var n in even)
                Console.Write(n + " ");
            Console.WriteLine("\n");




            // 2
            Console.WriteLine("Задание 2:");
            int[] nums2 = { 1, 3, 6, 9, 10, 15, 20 };
            var range = nums2.Where(n => n > 0 && n < 11);
            Console.WriteLine("Числа в диапазоне от 1 до 11:");
            foreach (var n in range)
                Console.Write(n + " ");
            Console.WriteLine("\n");




            // 3
            Console.WriteLine("Задание 3:");
            int[] nums3 = { 9, 8, 6, 5 };
            var squares = nums3.Select(n => new { Number = n, SqrNo = n * n });
            foreach (var item in squares)
                Console.WriteLine("{Number = " + item.Number + ", SqrNo = " + item.SqrNo + "}");
            Console.WriteLine();




            // 4
            Console.WriteLine("Задание 4:");
            int[] nums4 = { 5, 9, 1, 5, 5, 9 };
            var freq4 = nums4.GroupBy(n => n);
            Console.WriteLine("Число и частота:");
            foreach (var g in freq4)
                Console.WriteLine("Номер " + g.Key + " появляется " + g.Count() + " раз");
            Console.WriteLine();



            // 5
            Console.WriteLine("Задание 5:");
            Console.Write("Введите строку(слово): ");
            string str = Console.ReadLine();
            var freq5 = str.GroupBy(c => c);
            Console.WriteLine("Частота символов:");
            foreach (var g in freq5)
                Console.WriteLine("Персонаж " + g.Key + ": " + g.Count() + " раз");
            Console.WriteLine();



            // 6
            Console.WriteLine("Задание 6:");
            string[] days = { "воскресенье", "понедельник", "вторник", "среда", "четверг", "пятница", "суббота" };
            foreach (var d in days)
                Console.WriteLine(d);
            Console.WriteLine();




            // 7
            Console.WriteLine("Задание 7:");
            int[] nums7 = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            Console.WriteLine("Номер  Номер*Частота  Частота");
            Console.WriteLine("------------------------------------");
            var res7 = nums7.GroupBy(n => n);
            foreach (var g in res7)
                Console.WriteLine(g.Key + "\t" + (g.Key * g.Count()) + "\t\t" + g.Count());
            Console.WriteLine();



            // 8
            Console.WriteLine("Задание 8:");
            string[] cities = { "РИМ", "ЛОНДОН", "НАИРОБИ", "КАЛИФОРНИЯ", "ЦЮРИХ", "НЬЮ-ДЕЛИ", "АМСТЕРДАМ", "АБУ-ДАБИ", "ПАРИЖ" };
            Console.Write("Введите первую букву названия города: ");
            char start = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Введите последнюю букву названия города: ");
            char end = char.Parse(Console.ReadLine().ToUpper());
            var found = cities.Where(c => c.StartsWith(start.ToString()) && c.EndsWith(end.ToString()));
            Console.WriteLine("Город, начинающийся с " + start + " и заканчивающийся " + end + ":");
            foreach (var c in found)
                Console.WriteLine(c);
            Console.WriteLine();



            //9
            Console.WriteLine("Задание 9:");
            List<int> list9 = new List<int> { 55, 200, 740, 76, 230, 482, 95 };
            var big = list9.Where(n => n > 80);
            Console.WriteLine("Числа больше 80:");
            foreach (var n in big)
                Console.WriteLine(n);
            Console.WriteLine();




            // 10
            Console.WriteLine("Задание 10:");
            Console.Write("Введите количество членов в списке: ");
            int count = int.Parse(Console.ReadLine());
            List<int> list10 = new List<int>();
            for (int i = 0; i < count; i++)
            {
                Console.Write("Участник " + i + ": ");
                list10.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Введите значение выше, чтобы вы хотели отобразить членов списка: ");
            int val = int.Parse(Console.ReadLine());
            var filtered = list10.Where(n => n > val);
            Console.WriteLine("Числа больше " + val + ":");
            foreach (var n in filtered)
                Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
