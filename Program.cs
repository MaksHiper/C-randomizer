using System;

namespace Govno
{
    class Program
    {
        private static int Num { get; set; }

        public static void Main()
        {
            Console.Write("Введите количество генерируемых значений >>>> ");
            try
            {
                Num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(File_Name(Num));
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вводите числа!!");
            }
        }

        public static string File_Name(int num)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[num];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            string finalString = new String(stringChars);
            return finalString;
        }
    }
}
