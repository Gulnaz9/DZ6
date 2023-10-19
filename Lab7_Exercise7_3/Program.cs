using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Exercise7_3
{
    /// <summary>
    /// класс счета в банке с методами меняющими баланс
    /// </summary>
    class Bank
    {
        private uint acc_num = 1234567891;
        private int balans = 4000000;
        private string type = "Текущий";
        public string Type { get { return type; } set { type = value; } }
        public uint AccountNumber { get { return acc_num; } set { acc_num = value; } }
        public int Balans { get { return balans; } set { balans = value; } }


        public static int AddMoney(int a, int b)
        {
            a += b;
            return a;
        }
        public static int MinusMoney(int a, int b)
        {
            if (a > b)
            {
                a -= b;
                return a;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
            return a;
        }


        static void Main()
        {
            Console.WriteLine("Упр 7.3\nдобавление методов для изменения баланса");
            Bank b = new Bank();
            int a = b.Balans;
            Console.WriteLine("Вы хотите снять деньги со счета или положить?(напишите <снять> или <положить>");
            string action = Console.ReadLine().ToLower();
            if (action == "снять")
            {
                Console.WriteLine("Сколько вы хотите снять со счета?");
                int minus = int.Parse(Console.ReadLine());
                MinusMoney(a, minus);
                Console.WriteLine($"Номер счёта - {b.AccountNumber},\nбаланс - {a},\nтип - {b.Type}");
            }
            else
            {
                Console.WriteLine("Сколько вы хотите положить на счет?");
                int add = int.Parse(Console.ReadLine());
                AddMoney(a, add);
                Console.WriteLine($"Номер счёта - {b.AccountNumber},\nбаланс - {a},\nтип - {b.Type}");
            }
            //почему то переменная баланс не меняется, не могу найти в чём проблема
        }
    }
}
   

