using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProteinShop
{
    public class MainViewModel
    {
        public ObservableCollection<ImageViewModel> Images { get; set; } = new ObservableCollection<ImageViewModel>();

        
        
        public MainViewModel()
        {
            using (UserDataContext context = new UserDataContext())

            {
                List<Drink> drinks = context.Drinks.ToList();
               
                
               



                    foreach (var drink in drinks)
                    {
                   


                    Images.Add(new ImageViewModel(drink.Name,drink.Price+"₸"+" (тенге)", drink.Feature, Directory.GetCurrentDirectory()+drink.Path));
                    
                    }
                
            }
        }
    }
}

