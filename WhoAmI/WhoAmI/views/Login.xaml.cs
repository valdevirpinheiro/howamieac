using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WhoAmI.views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            Title = "WhoAmIEAC";
            InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);

        }
        public void Login_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
        public void CadastroUsuario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroUsuario());
        }
    }
}
