using System;
namespace TongMangNguyen;


class BaiTap
{
    public static void Bai1_04_09_2024()
    {
        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] Arr1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử {i + 1}: ");
            Arr1[i] = int.Parse(Console.ReadLine());
        }
        int Sum1 = 0;
        foreach (int i in Arr1)
        {
            Sum1 += i;
        }
        Console.WriteLine("Tổng các phần tử mảng vừa nhập: " + Sum1);
    }

    public static void Bai2_04_09_2024()
    {
        Console.Write("Nhập 1 chuỗi: ");
        string Str = Console.ReadLine();
        int Count = 0;
        for (int i = 0; i < Str.Length; i++)
        {
            char c = Str[i];
            if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                Count++;
            }
        }
        Console.WriteLine("Số ký tự không phải khoảng trắng và dấu câu trong chuỗi là: " + Count);
    }

    public static void Bai3_04_09_2024()
    {
        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] Arr1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử {i + 1}: ");
            Arr1[i] = int.Parse(Console.ReadLine());
        }
        int Max1 = Arr1[0];
        for (int i = 1; i < n; i++)
        {
            if (Arr1[i] > Max1)
            {
                Max1 = Arr1[i];
            }
        }
        Console.WriteLine("Phần tử lớn nhất trong mảng là: " + Max1);
    }

    public static void Bai4_04_09_2024()
    {
        Console.Write("Nhập 1 chuỗi: ");
        string Str1 = Console.ReadLine();
        char[] Arr1 = Str1.ToCharArray();
        Array.Reverse(Arr1);
        string Str2 = new string(Arr1);
        Console.WriteLine("Chuỗi sau khi đảo: " + Str2);
    }

    public static void Bai5_04_09_2024()
    {
        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] Arr1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử {i + 1}: ");
            Arr1[i] = int.Parse(Console.ReadLine());
        }
        bool a = true;
        for (int i = 0; i < (int)n / 2; i++)
        {
            if (Arr1[i] != Arr1[n - 1 - i])
            {
                a = false;
            }
        }
        if (a == true)
        {
            Console.WriteLine("Mảng đối xứng.");
        }
        else
        {
            Console.WriteLine("Không phải mảng đối xứng.");
        }
    }

    public static void Bai6_04_09_2024()
    {
        Console.Write("Nhập 1 chuỗi: ");
        string Str = Console.ReadLine();
        Console.Write("Nhập ký tự: ");
        char c = Console.ReadLine()[0];
        int Count = 0;
        foreach (char i in Str)
        {
            if (i == c)
            {
                Count++;
            }
        }
        Console.WriteLine($"Số lần xuất hiện ký tự {c} là: " + Count);
    }
    public static void Main(string[] args)
    {
        BaiTap.Bai6_04_09_2024();
    }
}