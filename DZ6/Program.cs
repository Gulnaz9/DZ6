using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Exercise7_1
{
    /// <summary>
    /// класс счета в банке
    /// </summary>
    class Bank
    {
        private uint acc_num;
        private long balans;
        private string type;
        public string Type { get { return type; } set { type = value; } }
        public uint AccountNumber { get { return acc_num; } set { acc_num = value; } }
        public long Balans { get { return balans; } set { balans = value; } }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Упр 7.1, создать класс счёта в банке");
            try
            {
                Bank bank = new Bank();
                Console.WriteLine("Введите номер аккаунта: ");
                bank.AccountNumber = uint.Parse(Console.ReadLine());
                Console.WriteLine("Введите тип аккаунта: ");
                string typE = Console.ReadLine().ToLower();
                if (typE == "текущий" || typE == "сберегательный" || typE == "current" || typE == "saving")
                {
                    bank.Type = typE;
                }
                else
                {
                    Console.WriteLine("Такого типа не существует");
                }

                Console.WriteLine("Введите количество денег на счету: ");
                bank.Balans = int.Parse(Console.ReadLine());

                Console.WriteLine($"Номер счёта - {bank.AccountNumber},\nбаланс - {bank.Balans},\nтип - {bank.Type}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Слишком много цифр...");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите цифры");
            }
        }
    }
}
