using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BT3_15520419
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListFlowerTypePage : ContentPage
	{
        public List<FlowerType> FlowerTypes { get; set; }

        public ListFlowerTypePage ()
		{
			InitializeComponent ();

            Database db = new Database();

            FlowerTypes = db.SelectFlowerType();
            lsvFlowerTypes.ItemsSource = FlowerTypes;
        }

        private void lsvFlowerTypes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            FlowerType flowerType = (FlowerType)e.SelectedItem;

            Navigation.PushAsync(new ListFlowerByTypePage(flowerType.Id));
        }
    }
}