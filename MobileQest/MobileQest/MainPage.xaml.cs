using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.IList;
using Xamarin.Forms;



namespace MobileQest
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
           // MainPage mp = new MainPage();
        }
        public ImageSource ims;
        private void Button_Clicked(object sender, EventArgs e)
        {
            Zalupen.Text = "Чё, залупную кнопку нажал? Молодец блядь!";
            Zalupen.TextColor = Color.Red;
            Zalupen.FontSize = 30;
            ims = "https://i.ytimg.com/vi/fpFzOhU24I0/maxresdefault.jpg";
            this.BackgroundImage = ims.ToString();


        }

        private void back_Click(object sender, EventArgs e)
        {
            PageMain.BackgroundImage = "CoM";
            ims = "https://i.ytimg.com/vi/fpFzOhU24I0/maxresdefault.jpg";
            PageMain.BackgroundImage = amage.ToString();
         
        }
    }
}
