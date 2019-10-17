using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BT1_15520419
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBtnHelloClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HelloPage());
        }

        private void OnBtnCalcukatorClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalTotalPage());
        }

        private void OnBtnLoginClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void OnBtnCalculatorClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalculatorPage());
        }

        private void OnBtnStackLayoutClicked(object sender, EventArgs e)
        {

        }

        private void OnBtnAsoluteLayoutClicked(object sender, EventArgs e)
        {

        }

        private void OnBtnGridLayoutClicked(object sender, EventArgs e)
        {

        }

        private void OnBtnFlexLayoutClicked(object sender, EventArgs e)
        {

        }

        private void OnBtnScrollViewClicked(object sender, EventArgs e)
        {

        }

        private void OnBtnEntryClicked(object sender, EventArgs e)
        {

        }

        private void OnBtnListViewClicked(object sender, EventArgs e)
        {

        }
    }
}
