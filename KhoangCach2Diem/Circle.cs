using System;

namespace KhoangCach2Diem
{
    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle()
        {
            Center = new Point();
        }

        public Circle(Point point)
        {
            Center = point;
        }

        public Circle(Point point, double radius): this(point)
        {
            Radius = radius;
        }
        
        public void Input()
        {
            Console.WriteLine("Center: ");
            Center.Input();
            
            Console.WriteLine("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
        }
        //
        public Location GetLocation(Point point)
        {
            var distance = Center.Distance(point);
            if (distance == Radius)
            {
                return Location.ON;
            }
            else if ( distance > Radius)
            {
                return Location.OUT;
            }
           
            return Location.IN;
            
        }
    }
}