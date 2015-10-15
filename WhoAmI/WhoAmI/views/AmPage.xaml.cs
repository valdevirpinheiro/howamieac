using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WhoAmI.views
{
    public partial class AmPage : ContentPage
    {
        public AmPage()
        {
            InitializeComponent();
           // BackgroundColor = Color.FromHex("333333");
            Title = "Am";
            Icon = "icecream.png";
			BackgroundColor = Color.White;
        }
    }
}
