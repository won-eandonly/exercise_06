using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class exercise06
{
    //public static void Main(string[] args)
    //{
    //    //Question_01();
    //    Vidu_Timkiem();
    //    Console.ReadKey();
    //}

    /// <summary>
    /// 1. Khai báo mảng với n phần tử, n nhập từ bàn phím
    /// 1.1 Enter item values for this array
    /// 1.2 Print the array to screen
    /// 1.3 Write a function that increase each item of the array by adding it with 2.
    /// 1.4 Print to screen again
    /// </summary>
    public static void Question_01()
    {
        Console.Write("Enter the quantity of items: n = ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        Xuatketqua(a);
    }
    static void Xuatketqua(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Enter a number: ");
            bool res = int.TryParse(Console.ReadLine(), out a[i]);
            if (!res)
            {
                Console.WriteLine("Please enter a number");
                i--;
            }
        }
        Console.WriteLine("----//----");
        Console.Write("The array: ");
        foreach (int i in a)
        {
            Console.Write($"{i} ");
        }
        //1.4
        Console.WriteLine();
        Console.Write("New array: ");
        change(a);
    }
    static void change(int[] a) //1.3
    {
        for (int i = 0; i < a.Length; i++)
        {
            a[i] += 2;
        }
        foreach (int i in a)
        {
            Console.Write($"{i} ");
        }
    }
    static void generateRandomArray(int[] a)
    {
        Random rnd = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(0, 100);
        }
    }
    /// <summary>
    /// Tìm một số có trong mảng hay không
    /// </summary>
    /// <param name="a">là mảng số nguyên</param>
    /// <param name="socantim">là số cần tìm trong mảng</param>
    /// <returns>Trả về: -1 nếu không tìm thấy, vị trí xuất hiện nếu tìm thấy
    /// </returns>
    public static void Vidu_Timkiem()
    {
        Console.Write("Nhap so luong phan tu cua mang: n = ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        generateRandomArray(a);
        Array.Sort(a); //sắp xếp theo thứ tự
        Console.Write("Nhap so can tim kiem: ");
        int socantim = int.Parse(Console.ReadLine());
        int pos = Timkiem_Linear(a, socantim); //pos là position
        if (pos == -1)
            Console.WriteLine($"So {socantim} khong ton tai trong mang.");
        else
            Console.WriteLine($"So {socantim} xuat hien tai vi tri {pos}.");
        Console.Write("Mang bao gom cac so sau: ");
        InMang(a);
    }
    static void InMang(int[] a)
    {
        foreach (int i in a)
        {
            Console.Write($"{i} ");
        }
    }
    static int Timkiem_Linear(int[] a, int socantim)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == socantim)
                return i;
        }
        return -1;
    }
}

