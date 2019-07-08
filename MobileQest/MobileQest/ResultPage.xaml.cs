using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileQest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResultPage : ContentPage
	{
        public ResultPage()
        {
            InitializeComponent();
            if (MainPage.ball >= 50)
            {
                resLb.Text = "Лютик, блядь!";

            }
            else if ((MainPage.ball >= 30) && (MainPage.ball < 50))
            {
                resLb.Text = "Ламберт, Ламберт....";
            }
            else if (MainPage.ball <= 30)
            {
                resLb.Text = "Никак вы, блядь, не научитесь";
            }
        }

        async void perehod(object sender, SelectedItemChangedEventArgs e)
        {
            //var DetailPage = new (); 
            mp mp = new mp();
            await Navigation.PushModalAsync(mp);
        }
        public void Start_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            MainPage.ball = 0;
            MainPage.nom = 0;
            perehod(sender, e);

        }
        private void End_Clicked(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().CloseMainWindow();
        }

    }


	}
