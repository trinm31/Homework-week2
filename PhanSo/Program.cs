using System;

namespace PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo f1 = new PhanSo(3,4);
            PhanSo f2 = new PhanSo(4,5);

            PhanSo sum = f1.Cong(f2);

            Console.WriteLine($"{f1.Display()} + {f2.Display()} = {sum.Display()}");
        }
    }
}