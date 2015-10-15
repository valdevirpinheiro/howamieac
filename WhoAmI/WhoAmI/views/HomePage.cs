using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace WhoAmI.views
{
    public class HomePage : TabbedPage
    {
        public HomePage()
        {
			this.BackgroundColor = Color.Gray;
            this.Title = "WhoAmIEAC";
            this.Children.Add(new WhoPage());
            this.Children.Add(new AmPage());
            this.Children.Add(new IPage());
            NavigationPage.SetHasBackButton(this, false);
        }
        protected override bool OnBackButtonPressed()
        {

            DisplayAlert("Logout", "Deseja sair da aplicação", "Não", "Sim");

            return base.OnBackButtonPressed();
        }
        async void sairAplicacao()
        {
            // O await só vai deixar que o que estiver abaixo desta linha ser executado quando esta linha for processada. 
            await DisplayAlert("Sucesso", "A sua conta foi criada com sucesso", "OK");
            Navigation.PopAsync();
        }
    }
}
