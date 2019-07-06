using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;



namespace MobileQest
{
    
    public partial class MainPage : ContentPage
    {

        public struct ans
        {
            public String strn;
            public int ball;
        }

        struct Paga
        {
            public Image Image;
            public String question;
            public ans answer;
        }

        public static int ball = 0;

        List<Image> images = new List<Image>();
        List<string> questions= new List<string>();
        public List<string> answers = new List<string>();
        List<ans> anses = new List<ans>();

        List<mp> mps = new List<mp>();

       

        void adding()
        {
            //Пикчи
            images[0].Source = "geralt0.jpg";
            images[1].Source = "geralt1.jpg";
            images[2].Source = "geralt2.jpg";
            images[3].Source = "geralt3.jpg";

            //Вопросы
            questions[0] = "Хто це таке?";
            questions[1] = "Гера и ...?";
            questions[2] = "Трисс или Йен?";
            questions[3] = "Ну как?";

            //ответы по 4
          //   anses[0].strn=""

        }

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

        private void Start_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            perehod(sender, e);
        }
        private void End_Clicked(object sender, EventArgs e)
        {
             Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}
