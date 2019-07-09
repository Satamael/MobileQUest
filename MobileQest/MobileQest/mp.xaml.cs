using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileQest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mp : ContentPage
    {
        public mp()
        {
            InitializeComponent();
            Lb.Text = MainPage.questions[MainPage.nom];
            BackgroundImage = MainPage.images[MainPage.nom];
            bt1.Text = MainPage.anses[MainPage.nom].strn;
            bt2.Text = MainPage.anses[MainPage.nom + 1].strn;
            bt3.Text = MainPage.anses[MainPage.nom + 2].strn;
            bt4.Text = MainPage.anses[MainPage.nom + 3].strn;


        }

        private void Bt4_Clicked(object sender, EventArgs e)
        {
            MainPage.ball += MainPage.anses[MainPage.nom * 4 + 3].ball;
            if (MainPage.nom >= MainPage.Count - 1)
            {
                result();
            }
            else
            {
               
                MainPage.nom++;
                Lb.Text = MainPage.questions[MainPage.nom];
                BackgroundImage = MainPage.images[MainPage.nom];
                bt1.Text = MainPage.anses[MainPage.nom * 4].strn;
                bt2.Text = MainPage.anses[MainPage.nom * 4 + 1].strn;
                bt3.Text = MainPage.anses[MainPage.nom * 4 + 2].strn;
                bt4.Text = MainPage.anses[MainPage.nom * 4 + 3].strn;
            }
        }

        private void Bt3_Clicked(object sender, EventArgs e)
        {
            MainPage.ball += MainPage.anses[MainPage.nom * 4 + 2].ball;
            if (MainPage.nom >= MainPage.Count - 1)
            {
                result();
            }
            else
            {
              
                MainPage.nom++;
                Lb.Text = MainPage.questions[MainPage.nom];
                BackgroundImage = MainPage.images[MainPage.nom];
                bt1.Text = MainPage.anses[MainPage.nom * 4].strn;
                bt2.Text = MainPage.anses[MainPage.nom * 4 + 1].strn;
                bt3.Text = MainPage.anses[MainPage.nom * 4 + 2].strn;
                bt4.Text = MainPage.anses[MainPage.nom * 4 + 3].strn;
            }

        }
        async void result()
        {
            ResultPage res = new ResultPage();
            await Navigation.PushModalAsync(res);
        }
        private void Bt2_Clicked(object sender, EventArgs e)
        {
            MainPage.ball += MainPage.anses[MainPage.nom * 4 + 1].ball;
            if (MainPage.nom >= MainPage.Count - 1)
            {
                result();
            }
            else
            {
                
                MainPage.nom++;
                Lb.Text = MainPage.questions[MainPage.nom];
                BackgroundImage = MainPage.images[MainPage.nom];
                bt1.Text = MainPage.anses[MainPage.nom * 4].strn;
                bt2.Text = MainPage.anses[MainPage.nom * 4 + 1].strn;
                bt3.Text = MainPage.anses[MainPage.nom * 4 + 2].strn;
                bt4.Text = MainPage.anses[MainPage.nom * 4 + 3].strn;
            }
        }

        private void Bt1_Clicked(object sender, EventArgs e)
        {
            MainPage.ball += MainPage.anses[MainPage.nom * 4].ball;

            if (MainPage.nom >= MainPage.Count-1)
            {
                result();
            }
            else
            {
               
                MainPage.nom++;
                Lb.Text = MainPage.questions[MainPage.nom];
                BackgroundImage = MainPage.images[MainPage.nom];
                bt1.Text = MainPage.anses[MainPage.nom * 4].strn;
                bt2.Text = MainPage.anses[MainPage.nom * 4 + 1].strn;
                bt3.Text = MainPage.anses[MainPage.nom * 4 + 2].strn;
                bt4.Text = MainPage.anses[MainPage.nom * 4 + 3].strn;
            }

        }
    }
}
    
