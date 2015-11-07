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
			WhoAmI.ApiCall apiCall = new ApiCall ();
            List<RegistroPonto> lista = apiCall.GetResponse<List<RegistroPonto>> ("registrosDiaModulo", "1").ContinueWith(t =>
				{
					//O ContinueWith é responsavel por fazer algo após o request finalizar

					//Aqui verificamos se houve problema ne requisição
					if (t.IsFaulted)
					{
						//Debug.WriteLine(t.Exception.Message);
						Device.BeginInvokeOnMainThread(() =>
							{
								DisplayAlert("Falha", "Ocorreu um erro na Requisição :(", "Ok");
							});
					}
					//Aqui verificamos se a requisição foi cancelada por algum Motivo
					else if (t.IsCanceled)
					{
						//Debug.WriteLine("Requisição cancelada");

						Device.BeginInvokeOnMainThread(() =>
							{
								DisplayAlert("Cancela", "Requisição Cancelada :O", "Ok");
							});
					}
					//Caso a requisição ocorra sem problemas, cairemos aqui
					else
					{
						//Se Chegarmos aqui, está tudo ok, agora itemos tratar nossa Lista
						//Aqui Usaremos a Thread Principal, ou seja, a que possui as references da UI
						Device.BeginInvokeOnMainThread(() =>
							{
								//ListRanking.ItemsSource = t.Result;
							});

					}
				});
		
		

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
