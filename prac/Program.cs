using System;

namespace prac
{
    class Program
    {
        public delegate int TinhToan(int a, int b);
        static void Main(string[] args)
        {
            // kiểu giá trị
            //.............//
            // kiểu số nguyên: int, byte , long
            // kiểu số thực: float, double, decimal,...
            // kiểu bool
            // kiểu char 
            // kiểu cấu trúc struct
            // kiểu dữ liệu liệt kê Enum,
            // kiểu tuple


            // kiểu dữ liệu tham chiếu
            // class
            // delegate 
            // interface
            // dynamic
            // object
            // string


            // ref vs out

            // int a;
            // ThamSoThamChieu(out a);
            // Console.WriteLine(a);

            //kiểu vô danh

            // var myprofile = new
            // {
            //     name ="bảo cute ",
            //     age = 19,
            //     skill = "lady killer"
            // };
            //
            // Console.WriteLine(myprofile.name);
            // Console.WriteLine(myprofile.age);
            // Console.WriteLine(myprofile.skill);


            // var and dynamic;
            // var a=1;
            // dynamic a;
            // a = 1;
            //TestFunc("fdafsdfadsfsd");


            // lambda c# -- hàm nặc danh
            // (tham so) => Bieu thuc;
            // (tham so) => { các biểu thức }


            //var a = sum(1,1);

            // int Tong(int x, int y)
            // {
            //     Console.WriteLine("fdsfafd");
            //     // code
            //     return x + y;
            // }
            
            //delegate 

            // TinhToan tinhTong = (int x, int y) =>
            // {
            //     return x + y;
            // };
            //
            // int result = tinhTong(5, 1); // 6
            //
            // Console.WriteLine(result);
            
            // Func vs Action 
            // Func có kiểu trả về: Func<ts1, ts2,..., tv>
            // Action ko có kiểu trả về: Action<ts1, ts2 ,....>
            
            // gán lambda cho function
            Func<int, int, int> tinhTong1 = (int x, int y) =>
            {
                return x + y;
            };
            
            // Gán lambda cho Action
            Action<int> thongBao = (int vl) =>
            {
                Console.WriteLine(vl);
            };

            int result = tinhTong1(5, 3);
            thongBao(result);
            
            
            // null = rỗng nullable cho phép biến có thể null
            int? a = 1;
            a = null;
        }
    
        
        public static void ThamSoThamChieu(out int x)
        {
            x = 100;
        }

        public static void TestFunc(dynamic c)
        {
            Console.WriteLine(c);
        }
        
        public static int sum(int a, int b)
        {
            return a + b;
        }
    }
}