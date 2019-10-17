using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BT1_15520419
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HelloPage : ContentPage
	{
		public HelloPage()
		{
			InitializeComponent();
		}

        private void OnBtnHelloClicked(object sender, EventArgs e)
        {
            string Name = txtName.Text;

            DisplayAlert("Chào", "Chào bạn: " + Name, "Thoát");
        }

    }
}