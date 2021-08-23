using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array

            // array - mảng 
            
            
            
            // kdl[so phan tu] ===> int[5]
            //cách khởi tạo một mảng
            
            //int[] text = new int[5];

            //string[] productName = new string[3] {"Iphone", "Ipad", "Macbook"};
            
            //Console.WriteLine(productName[2]);
            
            // length -- số phần tử trong mảng
            //Console.WriteLine(productName.Length);
            
            //Rank 
            //Console.WriteLine(productName.Rank);
            
            //Clone 
            //string[] productNameClone = productName.Clone() as string[];
            //Console.WriteLine(productNameClone[2]);
            
            // GetValue(index)
            //Console.WriteLine(productName.GetValue(1));
            
            //Min max sum

            // int[] numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // Console.WriteLine(numbers.Max());
            // Console.WriteLine(numbers.Min());
            // Console.WriteLine(numbers.Sum());
            
            // sort sắp xếp

            //int[] number2 = new[] {30, 20, 10, 15, 14, 13, 50};
            //Array.Sort(number2);

            // for (int i = 0; i < number2.Length; i++)
            // {
            //     Console.WriteLine(number2[i]);
            // }
            
            // Array.ForEach(number2, (int n) =>
            // {
            //     Console.WriteLine(n);
            // });

            // foreach (var i in number2)
            // {
            //     Console.WriteLine(i);
            // }
            
            // mảng nhiều chiều -- hàng trc cột sau
            //int[,] array2side = new int[3, 4] {{1, 2, 3, 4}, {0, 3, 1, 3}, {4, 2, 3, 4}};
            
            // 1 2 3 4
            // 0 3 1 3
            // 4 2 3 4 

            // for (int i = 0; i <= 2; i++)
            // {
            //     for (int j = 0; j <= 3; j++)
            //     {
            //         Console.Write(array2side[i,j] + " ");
            //     }
            //     Console.WriteLine();
            // }

            // int[][] arrayInArray = new int[][]
            // {
            //     new[] {1, 2},
            //     new[] {2, 3, 4},
            //     new[] {3, 5, 7, 8},
            //     new[] {1}
            // };
            //
            // foreach (var arr in arrayInArray)
            // {
            //     foreach (var e in arr)
            //     {
            //         Console.Write(e + " "); // in ra trên 1 dòng
            //     }
            //     Console.WriteLine(); // in ra xuống dòng
            // }
            

            #endregion

            #region List

            // =============================================== //
            
            // List 
            
            //cách khởi tạo một list
            // List<int> list = new List<int>();
            // var list2 = new List<int>();
            // var numbers = new List<int>() {1, 2, 3, 4, 5};
            
            // var ProductList = List<Products>()
            // {
            //     new Products("Iphone", 4000),
            //         new Products("Ipad", 3000)
            // };
            // var productList = new List<Products>();
            // var p = new Products("Iphone xs", 3000);
            // productList.Add(p);
            // productList.Add(new Products("Ipad", 400));
            //
            // var arrayProducts = new Products[]
            // {
            //     new Products("Bvs", 40000),
            //     new Products("Bcs", 3000)
            // };
            // productList.AddRange(arrayProducts);
            
            //count đếm số phần tử
            //Console.WriteLine(productList.Count);
            
            // in ra 1 phần tử tại index 2 
            //Console.WriteLine(productList[2].Name);
            
            // productList.Insert(2, new Products("macbook", 1000));
            
            
            // Remove
            // var temp = productList[2];
            // productList.Remove(temp);
            // productList.RemoveAt(2);
            // productList.Clear();

            #endregion

            #region LinQ

            // ====================================== //
            // LinQ - Language Integration Query
            
            
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 3, Name = "Công ty CCC"},
            };
            
            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            // var ketqua = from productItem in products
            //     where productItem.Price == 400
            //     select productItem;
            
            // var ketqua = from productItem in products
            //     select new
            //     {
            //         ten = productItem.Name.ToUpper(),
            //         mauSac = string.Join(',', productItem.Colors)
            //     };
            
            var ketqua = from productItem in products
                where ( productItem.Price >= 400 && productItem.Price <= 700)
                select productItem;

            foreach (var product in ketqua)
            {
                Console.WriteLine(product.ToString());
            }

            #endregion


        }
    }
    
    public class Product
    {
        public int ID {set; get;}
        public string Name {set; get;}         // tên
        public double Price {set; get;}        // giá
        public string[] Colors {set; get;}     // cá màu
        public int BrandId {set; get;}           // ID Nhãn hiệu, hãng
        
        
        public Product(int id, string name, double price, string[] colors, int brandId) 
        {
            ID = id; Name = name; Price = price; Colors = colors; BrandId = brandId;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString() 
            => $"{ID,3} {Name, 12} {Price, 5} {BrandId, 2} {string.Join(",", Colors)}";

    }
    
    public class  Brand {
        public string Name {set; get;}
        public int ID {set; get;}
    }
}





















