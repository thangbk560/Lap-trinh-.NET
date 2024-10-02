using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Bai1()
    {
        ArrayList numbers = new ArrayList();
        Console.WriteLine("Nhập các số nguyên (nhập 'x' để dừng): ");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "x") break;

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số nguyên hợp lệ.");
            }
        }

        numbers.Sort();
        Console.WriteLine("Danh sách các số nguyên theo thứ tự tăng dần:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    static void Bai2()
    {
        Hashtable people = new Hashtable();
        Console.WriteLine("Nhập tên và tuổi (nhập 'x' để dừng): ");
        while (true)
        {
            Console.Write("Tên: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "x") break;

            Console.Write("Tuổi: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                people[name] = age;
            }
            else
            {
                Console.WriteLine("Tuổi không hợp lệ. Vui lòng nhập lại.");
            }
        }

        Console.WriteLine("Danh sách tên và tuổi:");
        foreach (DictionaryEntry entry in people)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} tuổi");
        }
    }

    static void Bai3()
    {
        Dictionary<string, int> students = new Dictionary<string, int>();
        Console.WriteLine("Nhập tên và điểm học sinh (nhập 'x' để dừng): ");
        while (true)
        {
            Console.Write("Tên học sinh: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "x") break;

            Console.Write("Điểm: ");
            if (int.TryParse(Console.ReadLine(), out int score))
            {
                students[name] = score;
            }
            else
            {
                Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại.");
            }
        }

        Console.WriteLine("Danh sách học sinh và điểm:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key}: {student.Value} điểm");
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChọn một chức năng:");
            Console.WriteLine("1. Nhập và sắp xếp danh sách số nguyên (ArrayList)");
            Console.WriteLine("2. Nhập tên và tuổi (Hashtable)");
            Console.WriteLine("3. Nhập tên học sinh và điểm (Dictionary)");
            Console.WriteLine("4. Thoát");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Bai1();
                    break;
                case "2":
                    Bai2();
                    break;
                case "3":
                    Bai3();
                    break;
                case "4":
                    Console.WriteLine("Chương trình kết thúc.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }
}
