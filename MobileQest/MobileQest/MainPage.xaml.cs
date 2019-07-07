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

            public ans(string strn, int ball)
            {
                this.ball = ball;
                this.strn = strn;
            }


        }

    

        public static int ball = 0;
        public static int nom = 0;

        public static List<String> images = new List<String>();
        public static List<string> questions= new List<string>();
        public static List<string> answers = new List<string>();
        public static List<ans> anses = new List<ans>();

        List<mp> mps = new List<mp>();

       

       public static void adding()
        {
            //Пикчи
            images.Add("geralt0.jpg");
            images.Add("geralt1.jpg");
            images.Add("geralt2.jpg");
            images.Add("geralt3.jpg");

            //Вопросы
            questions.Add("Хто це таке?");
            questions.Add("Гера и ...?");
            questions.Add("Трисс или Йен?");
            questions.Add("Ну как?");

            //ответы по 4
            anses.Add(new ans("Поляк", 5));
            anses.Add(new ans("Ведьмак", 10));
            anses.Add(new ans("Курва!", 15));
            anses.Add(new ans("Никак вы блядь не научитесь!", 20));

            anses.Add(new ans("Бульба", 5));
            anses.Add(new ans("Тарас", 10));
            anses.Add(new ans("Пидорас", 15));
            anses.Add(new ans("Боня", 20));

            anses.Add(new ans("Трисс", 5));
            anses.Add(new ans("Обе", 10));
            anses.Add(new ans("Цири, хули нам", 15));
            anses.Add(new ans("Йен", 20));

            anses.Add(new ans("Заебись", 5));
            anses.Add(new ans("Ведьмак", 10));
            anses.Add(new ans("Курва!", 15));
            anses.Add(new ans("Никак вы блядь не научитесь!", 20));


        }

        public MainPage()
        {
            InitializeComponent();
            //Пикчи
            //Пикчи
            images.Add("geralt0");
            images.Add("geralt1");
            images.Add("geralt2");
            images.Add("geralt3");

            //Вопросы
            questions.Add("Хто це таке?");
            questions.Add("Гера и ...?");
            questions.Add("Трисс или Йен?");
            questions.Add("Ну как?");

            //ответы по 4
            anses.Add(new ans("Поляк", 5));
            anses.Add(new ans("Ведьмак", 10));
            anses.Add(new ans("Курва!", 15));
            anses.Add(new ans("Никак вы блядь не научитесь!", 20));

            anses.Add(new ans("Бульба", 5));
            anses.Add(new ans("Тарас", 10));
            anses.Add(new ans("Пидорас", 15));
            anses.Add(new ans("Боня", 20));

            anses.Add(new ans("Трисс", 5));
            anses.Add(new ans("Обе", 10));
            anses.Add(new ans("Цири, хули нам", 15));
            anses.Add(new ans("Йен", 20));

            anses.Add(new ans("Заебись", 5));
            anses.Add(new ans("Ведьмак", 10));
            anses.Add(new ans("Курва!", 15));
            anses.Add(new ans("Никак вы блядь не научитесь!", 20));


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
