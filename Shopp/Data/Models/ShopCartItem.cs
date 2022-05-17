namespace Shopp.Data.Models
{
    public class ShopCartItem
    {


        public int id { get; set; }//id самого товару
        public Flower flower { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }//id товару в кошику
    }
}
