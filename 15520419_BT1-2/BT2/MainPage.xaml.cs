using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BT2_15520419
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            FlowerType flowerTypes = new FlowerType();

            lvFlower.ItemsSource = flowerTypes.FlowerTypes;
        }
    }
}
