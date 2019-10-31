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
	public partial class AddFlowerTypePage : ContentPage
	{
		public AddFlowerTypePage ()
		{
			InitializeComponent ();
		}

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            Database db = new Database();

            FlowerType flowerType = new FlowerType();
            flowerType.Name = txtFlowerTypeName.Text;

            try
            {
                db.InsertFlowerType(flowerType);

                DisplayAlert("Thành công", "Thêm loại hoa thành công!", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Thất bại", "Thêm loại hoa thất bại!", "OK");
            }
        }
    }
}