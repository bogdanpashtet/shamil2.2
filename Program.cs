using System;

namespace PPS_lab2._2
{
    class Program
    {

        static public double check(string str)
        {
            double k = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                k += Char.GetNumericValue(str, i);
            }

            return k;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите двоичное число: ");
            string binary_number = Console.ReadLine();

            double kol = check(binary_number);

            if (kol % 2 == 0)
                binary_number += "0";
            else
                binary_number += "1";

            Console.WriteLine("Двоичное число с контрольным битом: " + binary_number);


            Console.WriteLine("Введите искаженное двоичное число: ");
            string wrong_number = Console.ReadLine();

            if (kol != check(wrong_number))
                Console.WriteLine("Обнаружено искажение.");
            else
                Console.WriteLine("Искажений не обнаружено.");
        }
    }
}