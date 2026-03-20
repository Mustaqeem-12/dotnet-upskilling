namespace LuLuMall.Models
{
    public class Product
    {
        public int id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Gst { get; set; }
        public double TotalPrice {get; set;}
    }
}
