using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_dz
{
    class DescriptBuilding
    {
        private static byte num;
        private static double hight;
        private static byte floor;
        private static byte apart_num;
        private static byte entrance_num;
        public static byte Num { get { return num; } set { num = value; } }
        public static double Hight { get { return hight; } set { hight = value; } }
        public static byte Floor { get { return floor; } set { floor = value; } }
        public static byte Apart_num { get { return apart_num; } set { apart_num = value; } }
        public static byte Entrance_num { get { return entrance_num; } set { entrance_num = value; } }

        /// <summary>
        /// метод для заполнения полей
        /// </summary>
        public static void Fill_field()  
        {
            try
            {
                Console.WriteLine("Введите высоту дома");
                double highT = double.Parse(Console.ReadLine());
                if (highT <= 0)
                {
                    Console.WriteLine("Высота не может быть отрицательной");
                    Environment.Exit(0);
                }
                else
                {
                    Hight = highT;
                }
                Console.WriteLine("Сколько этажей?");
                byte flooR = byte.Parse(Console.ReadLine());
                if (flooR <= 0)
                {
                    Console.WriteLine("Кол-во этажей не может быть отрицательным");
                    Environment.Exit(0);
                }
                else
                {
                    Floor = flooR;
                }
                Console.WriteLine("Сколько квартир в доме?");
                byte apart_nuM = byte.Parse(Console.ReadLine());
                if (apart_nuM <= 0)
                {
                    Console.WriteLine("Кол-во квартир не может быть отрицательным");
                    Environment.Exit(0);
                }
                else
                {
                    Apart_num = apart_nuM;
                }
                Console.WriteLine("А подъездов??");
                byte entrance_nuM = byte.Parse(Console.ReadLine());
                if (entrance_nuM <= 0)
                {
                    Console.WriteLine("Кол-во подъездов не может быть отрицательным");
                    Environment.Exit(0);
                }
                else
                {
                    Entrance_num = entrance_nuM;
                }
            }
            catch (DivideByZeroException)
            { Console.WriteLine("Вы ввели что-то не то"); }
            catch (FormatException)
            { Console.WriteLine("Вы ввели что-то не то"); }
        }

        /// <summary>
        /// метод вычисления высоты этажа
        /// </summary>
        /// <param name="Hight"></param>
        /// <param name="Floor"></param>
        /// <returns></returns>
        public static double Floor_hight(double Hight, byte Floor)
        {
            double flhight = Hight / Floor;
            return flhight;
        }

        /// <summary>
        /// метод вычисления квартир в подъезде
        /// </summary>
        /// <param name="Apart_num"></param>
        /// <param name="Entrance_num"></param>
        /// <returns></returns>
        public static byte Apart_in_ent(byte Apart_num, byte Entrance_num)
        {
            byte apart_in_ent = (byte)(Apart_num / Entrance_num);
            return apart_in_ent;
        }

        /// <summary>
        /// метод вычисления квартир на этаже
        /// </summary>
        /// <param name="apart_in_ent"></param>
        /// <param name="Floor"></param>
        /// <returns></returns>
        public static byte Apart_in_floor(byte apart_in_ent, byte Floor)
        {
            byte apart_in_floor = (byte)(apart_in_ent / Floor);
            return apart_in_floor;
        }

        /// <summary>
        /// метод генерации номера дома
        /// </summary>
        /// <param name="Num"></param>
        /// <returns></returns>
        public static byte GetNumber(byte Num)
        {
            Random random = new Random(1);
            Num = (byte)(random.Next(1, byte.MaxValue));
            return Num;
        }

        public static void Main(string[] args)
        {
            Fill_field();
            Console.WriteLine($"Номер дома - {GetNumber(num)}");
            Console.WriteLine($"Высота этажа - {Floor_hight(hight, floor)}");
            Console.WriteLine($"Кол-во квартир в подъезде - {Apart_in_ent(apart_num, entrance_num)}");
            byte a = Apart_in_ent(apart_num, entrance_num);
            Console.WriteLine($"Квартир на этаже - {Apart_in_floor(a, floor)}");

        }
    }
}
