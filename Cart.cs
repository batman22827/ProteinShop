using System.ComponentModel.DataAnnotations;

namespace ProteinShop
{
    public class Cart
    {



        public Cart() { }

        public Cart(int order, string drinks,string price)
        {
            this.Order = order;
            this.Drinks = drinks;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Номер заказа:{Order} напиток в заказе: {Drinks} цена:{Price}";
        }
        [Key]

        public int id { get; set; }
        public int Order { get; set; }
        public string? Drinks { get; set; }
        public string Price { get; set; }
    }
}