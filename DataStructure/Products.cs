namespace DataStructure
{
    public class Products
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Products()
        {
            
        }

        public Products(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}