using System;
namespace TimMax;

class TimSoLonNhat
{
    public static void Main(string[] args)
    {
        Console.Write("Nhập số phần tử mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write($"A[{i}] = ");
            arr1[i] = int.Parse(Console.ReadLine());
        }
        int max = arr1[0];
        foreach (int i in arr1)
        {
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine("Phần tử lớn nhất trong mảng: " + max);
    }
}