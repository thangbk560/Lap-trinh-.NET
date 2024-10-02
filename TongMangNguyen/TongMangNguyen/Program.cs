using System;
namespace TongMangNguyen;

//Bai 1
/*
class SumArr
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] Arr1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu {i + 1}: ");
            Arr1[i] = int.Parse(Console.ReadLine());
        }
        int Sum1 = 0;
        foreach (int i in Arr1)
        {
            Sum1 += i;
        }
        Console.WriteLine("Tong cac phan tu mang vua nhap: " + Sum1);
    }
}
*/

//Bai 2
/*
class CountString
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap 1 chuoi: ");
        string Str = Console.ReadLine();
        int Count = 0;
        for (int i = 0; i < Str.Length; i++)
        {
            char c = Str[i];
            if(!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                Count++;
            }
        }
        Console.WriteLine("So ky tu khong phai khoang trang va dau cau trong chuoi la: " + Count);
    }
}
*/

//Bai 3
/*
class MaxArr
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] Arr1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu {i + 1}: ");
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
        Console.WriteLine("Phan tu lon nhat trong mang la: " + Max1);
    }
}
*/

//Bai 4
/*
class ReverseArr
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap 1 chuoi: ");
        string Str1 = Console.ReadLine();
        char[] Arr1 = Str1.ToCharArray();
        Array.Reverse(Arr1);
        string Str2 = new string(Arr1);
        Console.WriteLine("Chuoi sau khi dao: " + Str2);
    }
}
*/

//Bai 5
/*
class Palindrome
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] Arr1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu {i + 1}: ");
            Arr1[i] = int.Parse(Console.ReadLine());
        }
        bool a = true;
        for (int i = 0; i < (int)n/2; i++)
        {
            if (Arr1[i] != Arr1[n - 1 - i])
            {
                a = false;
            }
        }
        if (a == true) 
        {
            Console.WriteLine("Mang doi xung.");
        }
        else
        {
            Console.WriteLine("Khong phai mang doi xung.");
        }
    }
}
*/

//Bai 6
class CountAppear
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap 1 chuoi: ");
        string Str = Console.ReadLine();
        Console.Write("Nhap ky tu: ");
        char c = Console.ReadLine()[0];
        int Count = 0;
        foreach (char i in Str)
        { 
            if (i == c)
            {
                Count++;
            }
        }
        Console.WriteLine($"So lan xuat hien ky tu {c} la: " + Count);
    }
}