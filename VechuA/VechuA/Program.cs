using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) {
            string chuoi1 = "Ve chu cai A bang cac dau sao trong C#:";
            Console.WriteLine(chuoi1);
            int size = chuoi1.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n");
            for (int hang = 0; hang <= 7; hang++)
            {
                for (int cot = 0; cot <= 4; cot++)
                {
                    if (((cot == 0 || cot == 4) && hang != 0) || ((hang == 0 || hang == 3) && (cot != 0 && cot != 4)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}