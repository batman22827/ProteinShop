using System.ComponentModel.DataAnnotations;

namespace ProteinShop
{
    public class Drink
    {
        
     
       

        public Drink() { }

        public Drink(string name, int price,string feature, string path)
        {
            this.Name = name;
            this.Price = price;
            this.Feature = feature;
            this.Path = path;
        }

        [Key]

        public int id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Feature { get; set; }
        public string? Path{ get; set; }

    }
}
