using AppSneakers.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace AppSneakers.ViewModels
{
    public class SneakersViewModel
    {
        public ObservableCollection<Sneakers> sneakers { get; set; }
        public ObservableCollection<SneakerColor> sneakerColor { get; set; }

        public SneakersViewModel()
        {
            sneakers = new ObservableCollection<Sneakers>
            {
                new Sneakers
                {
                    Name = "Candy", Price = "170", Picture="Sneakers1.png"
                },
            };

            sneakerColor = new ObservableCollection<SneakerColor>
            {
                new SneakerColor
                {
                    ColorOption = ColorConverters.FromHex("#dd5edd")
                },
            };
        }
    }

}
