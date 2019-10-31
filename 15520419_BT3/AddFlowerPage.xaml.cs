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
	public partial class AddFlowerPage : ContentPage
	{
        public List<FlowerType> FlowerTypes { get; set; }
        public int TypeId { get; set; }

		public AddFlowerPage ()
		{
			InitializeComponent ();

            Database db = new Database();

            FlowerTypes = db.SelectFlowerType();
            pkrFlowerType.ItemsSource = FlowerTypes;
		}

        private void pkrFlowerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;
            if (picker.SelectedIndex != -1)
            {
                TypeId = FlowerTypes[picker.SelectedIndex].Id;
            }
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            Database db = new Database();

            Flower flower = new Flower();
            flower.TypeId = TypeId;
            flower.Name = txtFlowerTypeName.Text;
            flower.Image = txtFlowerTypeImage.Text;
            flower.Price = Convert.ToDouble(txtFlowerTypePrice.Text);
            flower.Description = txtFlowerTypeDescription.Text;

            try
            {
                db.InsertFlower(flower);

                DisplayAlert("Thành công", "Thêm hoa thành công!", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Thất bại", "Thêm hoa thất bại!", "OK");
            }
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {

        }
    }
}