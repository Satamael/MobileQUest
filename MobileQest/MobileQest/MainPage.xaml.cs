using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace MobileQest
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
    }

        async void perehod(object sender, SelectedItemChangedEventArgs e)
        {
            //var DetailPage = new (); 
                mp mp = new mp();
                await Navigation.PushModalAsync(mp);
        }
        private void back_Click(object sender, EventArgs e)
        {
            //PageMain.BackgroundImage = "CoM";
           // PageMain.BackgroundImage = amage.ToString();
         
        }

        private void Ans4_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            perehod(sender, e);
        }
    }
}
