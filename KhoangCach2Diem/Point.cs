using System;

namespace KhoangCach2Diem
{
    public class Point
    {
        public int Ox { get; set; }
        public int Oy { get; set; }

        public Point() { }

        public Point(int ox, int oy)
        {
            Ox = ox;
            Oy = oy;
        }

        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow((Ox - point.Ox), 2) + Math.Pow((Oy - point.Oy), 2));
        }

        public void Input()
        {
            Console.WriteLine("Input Ox: ");
            Ox = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Input Oy: ");
            Oy = Convert.ToInt32(Console.ReadLine());
        }
    }
}