using System;

namespace KhoangCach2Diem
{
    class Program
    {
        static void Main(string[] args)
        {
            // khởi tạo hình tròn
            Circle circle = new Circle();
            circle.Input();
            // khỏi tạo điểm dùng để so sánh
            Console.WriteLine("Imput point 2");
            Point p2 = new Point();
            p2.Input();
            var location = circle.GetLocation(p2);
            
            switch (location)
            {
                case Location.IN:
                    Console.WriteLine("Trong duong tron");
                    break;
                case Location.ON:
                    Console.WriteLine("Tren duong tron");
                    break;
                case Location.OUT:
                    Console.WriteLine("Ngoai duong tron");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}