using System;
namespace SinhSoRandom;
class SsRandom
{
    public static int taoRandom()
    {
        Random rd1 = new ();
        int a = rd1.Next(1,7);
        return a;
    }
    public static void Main(string[] args)
    {
        int n;
        do
        {
            Console.WriteLine("Nhập số bạn dự đoán: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0 || n > 6)
            {
                Console.WriteLine("Số cần nhập nằm trong đoạn [0;6].");
            }
        } while (n <= 0 || n > 6);
        int m = taoRandom();
        if (n == m)
        {
            Console.WriteLine("Bạn đã thắng!");
        }
        else
        {
            Console.WriteLine("Bạn đã thua!");
            Console.WriteLine("Số của tôi là " + m);
        }
    }
}