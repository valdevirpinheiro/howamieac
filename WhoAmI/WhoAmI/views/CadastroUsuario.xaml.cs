using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WhoAmI.views
{
    public partial class CadastroUsuario : ContentPage
    {
        public StackLayout Layout { get; set; }
        public Entry LoginEntry { get; set; }
        public Entry SenhaEntry { get; set; }
        public Entry NomeEntry { get; set; }
        public Button CriaConta { get; set; }

        public CadastroUsuario()
        {
            InitializeComponent();
            //Este tipo de criação de objeto faz parte do conceito de lambda do .net
            Layout = new StackLayout()
            {

            };
            LoginEntry = new Entry()
            {
                Placeholder = "Login"
            };
            SenhaEntry = new Entry()
            {
                Placeholder = "Senha"
            };
            NomeEntry = new Entry()
            {
                Placeholder = "Nome"
            };
            CriaConta = new Button()
            {
                Text = "Cria Conta"
            };

            Layout.Children.Add(LoginEntry);
            Layout.Children.Add(SenhaEntry);
            Layout.Children.Add(NomeEntry);
            Layout.Children.Add(CriaConta);
            CriaConta.Clicked += CriaConta_Clicked;
            Content = Layout;
        }
        async void CriaConta_Clicked(object sender, EventArgs eventArgs)
        {
            // O await só vai deixar que o que estiver abaixo desta linha ser executado quando esta linha for processada. 
            await DisplayAlert("Sucesso", "A sua conta foi criada com sucesso", "OK");
            Navigation.PopAsync();
        }

    }
}
