using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BT3_15520419
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAddFlowerType_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddFlowerTypePage());
        }

        private void btnAddFlower_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddFlowerPage());
        }

        private void btnListFlowerType_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListFlowerTypePage());
        }
    }
}
