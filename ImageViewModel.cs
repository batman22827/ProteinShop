using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProteinShop
{
    public class ImageViewModel
    {
        public ImageViewModel(string name, string price, string feature, string path)
        {
            this.Name = name;
            this.Price = price;
            this.Feature = feature;
            this.Path = path;
            
            

        }

        public string? Name { get; set; }
        public string? Price { get; set; }
        public string? Feature { get; set; }
        public string Path { get; set; }

        
    }
}
