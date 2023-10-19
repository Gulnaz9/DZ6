using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Exercise7_2
{
    class Bankk
    {
        private int acc_num = 0;
        private long balans;
        private string type;

        public string Type { get { return type; } set { type = value; } }
        public int AccountNumber { get { return acc_num; } set { acc_num = value; } }
        public long Balans { get { return balans; } set { balans = value; } }
    }
    class Program
    {
        enum BankAccType
        {
            Текущий,
            Сберегательный
        }
        public static void Main()
        {
            Console.WriteLine("Упр 7.2, номер счета генерируется сам");

            Bankk bank = new Bankk();
            Random rand = new Random();
            bank.AccountNumber = rand.Next(100000000, 999999999);
            BankAccType typE = BankAccType.Текущий;
            bank.Type = typE.ToString();
            bank.Balans = 4000;
            Console.WriteLine($"Номер счёта - {bank.AccountNumber},\nбаланс - {bank.Balans},\nтип - {bank.Type}");
        }

    }
}
