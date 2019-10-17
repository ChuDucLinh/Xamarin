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
	public partial class CalTotalPage : ContentPage
	{
		public CalTotalPage ()
		{
			InitializeComponent ();
		}

        private void btnCal_Clicked(object sender, EventArgs e)
        {
            double NumberA = double.Parse(txtNumberA.Text);
            double NumberB = double.Parse(txtNumberB.Text);
            lblTotal.Text = "Tổng: " + (NumberA + NumberB);
        }
    }
}