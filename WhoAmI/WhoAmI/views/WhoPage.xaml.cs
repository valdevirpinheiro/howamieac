using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WhoAmI.views
{
    public partial class WhoPage : ContentPage
    {
		class Opcao
		{
			public Opcao(string name)
			{
				this.Name = name;
	
			}

			public string Name { private set; get; }

		};

        public WhoPage()
        {
            InitializeComponent();
            //BackgroundColor = Color.FromHex("333333");
            Title = "Who";
            Icon = "icecream.png";
			List<Opcao> opcoes = new List<Opcao>{
				new Opcao("Marcações do Dia"),
				new Opcao("Marcações por Período"),
				new Opcao("Saldo Horas do Dia"),
				new Opcao("Saldo Horas do Período"),
				new Opcao("Próximas Féria")
			};
			string[] nomesContatos = new string[] { 
				"Marcações do Dia",
				"Marcações por Período",
				"Saldo Horas do Dia",
				"Saldo Horas do Período",
				"Próximas Férias",

			};
			//listMenus.BackgroundColor = Color.White;
			//listMenus.ItemTemplate = new DataTemplate (typeof(CellCustom));
			// Create the ListView.
			ListView listMenus = new ListView
			{
				// Source of data items.
				ItemsSource = opcoes,

				// Define template for displaying each item.
				// (Argument of DataTemplate constructor is called for 
				//      each item; it must return a Cell derivative.)
				ItemTemplate = new DataTemplate(() =>
					{
						// Create views with bindings for displaying each property.
						Label nameLabel = new Label();
						nameLabel.TextColor = Color.Gray;
						nameLabel.SetBinding(Label.TextProperty, "Name");



						// Return an assembled ViewCell.
						return new ViewCell
						{
							View = new StackLayout
							{
								Padding = new Thickness(0, 5),
								Orientation = StackOrientation.Horizontal,
								Children = 
								{
							
									new StackLayout
									{
										VerticalOptions = LayoutOptions.Center,
										Spacing = 0,
										Children = 
										{
											nameLabel,

										}
									}
								}
							}

						};
					})
			};
			this.Content = new StackLayout
			{
				Children = 
				{
					
					listMenus
				}
			};
			//listMenus.ItemsSource = nomesContatos;
        }
    }
}
