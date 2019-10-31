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
	public partial class ListFlowerByTypePage : ContentPage
	{
        public int TypeId { get; set; }
        public List<Flower> Flowers { get; set; }

		public ListFlowerByTypePage (int typeId)
		{
			InitializeComponent ();

            TypeId = typeId;

            Database db = new Database();

            Flowers = db.SelectFlowerByType(TypeId);
            lsvFlowers.ItemsSource = Flowers;
        }
	}
}