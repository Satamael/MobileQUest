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

        public struct ans // Структура ответов
        {
            public String strn; // Текст ответа. Выводится на кнопку
            public int ball; // Баллов даёт. Плюсуется по клику

            public ans(string strn, int ball) //Конструктор для структуры
            {
                this.ball = ball;  // Не докапывай меня
                this.strn = strn;  // Я в душе не понимаю, зачем он нужен
            }                      // Пусть будет


        }

    

        public static int ball = 0; // Баллов набрано
        public static int nom = 0; // На каком вопросе
        public static int Count = 4; // Вопросов всего-1 (с 0 же)

        public static List<String> images = new List<String>(); // Лист фонов
        public static List<string> questions= new List<string>(); // Лист вопросов (выводится на лейбл)
        public static List<ans> anses = new List<ans>(); // Лист ответов

        List<mp> mps = new List<mp>();

       

       public static void adding() // функция добавления. Не используется. Не трогай.
        {
            //Пикчи. В массив
            images.Add("geralt0.jpg");
            images.Add("geralt1.jpg");
            images.Add("geralt2.jpg");
            images.Add("geralt3.jpg");

            //Вопросы. В массив
            questions.Add("Хто це таке?");
            questions.Add("Гера и ...?");
            questions.Add("Трисс или Йен?");
            questions.Add("Ну как?");

            //ответы по 4 штуки добавляются в массив. Вова пидр
            // первый вопрос
            anses.Add(new ans("Поляк", 5));
            anses.Add(new ans("Ведьмак", 10));
            anses.Add(new ans("Курва!", 15));
            anses.Add(new ans("Никак вы блядь не научитесь!", 20));
            // второй вопрос
            anses.Add(new ans("Бульба", 5));
            anses.Add(new ans("Тарас", 10));
            anses.Add(new ans("Пидорас", 15));
            anses.Add(new ans("Боня", 20));
            // третий вопрос
            anses.Add(new ans("Трисс", 5));
            anses.Add(new ans("Обе", 10));
            anses.Add(new ans("Цири, хули нам", 15));
            anses.Add(new ans("Йен", 20));
            // четвёртый вопрос, пидр вова
            anses.Add(new ans("Заебись", 5));
            anses.Add(new ans("Ведьмак", 10));
            anses.Add(new ans("Курва!", 15));
            anses.Add(new ans("Никак вы блядь не научитесь!", 20));


        }

        public MainPage() // главный код
        {
            InitializeComponent();
            //Пикчи. В массив
            images.Add("geralt0.jpg");
            images.Add("geralt1.jpg");
            images.Add("geralt2.jpg");
            images.Add("geralt3.jpg");

            //Вопросы. В массив
            questions.Add("Хто це таке?");
            questions.Add("Гера и ...?");
            questions.Add("Трисс или Йен?");
            questions.Add("Ну как?");

            //ответы по 4 штуки добавляются в массив. Вова пидр
            // первый вопрос
            anses.Add(new ans("Поляк", 5));
            anses.Add(new ans("Ведьмак", 10));
            anses.Add(new ans("Курва!", 15));
            anses.Add(new ans("Никак вы блядь не научитесь!", 20));
            // второй вопрос
            anses.Add(new ans("Бульба", 5));
            anses.Add(new ans("Тарас", 10));
            anses.Add(new ans("Пидорас", 15));
            anses.Add(new ans("Боня", 20));
            // третий вопрос
            anses.Add(new ans("Трисс", 5));
            anses.Add(new ans("Обе", 10));
            anses.Add(new ans("Цири, хули нам", 15));
            anses.Add(new ans("Йен", 20));
            // четвёртый вопрос, пидр вова
            anses.Add(new ans("Заебись", 5));
            anses.Add(new ans("Ведьмак", 10));
            anses.Add(new ans("Курва!", 15));
            anses.Add(new ans("Никак вы блядь не научитесь!", 20));

        }

        async void perehod(object sender, SelectedItemChangedEventArgs e)
        {
            //var DetailPage = new (); 
                mp mp = new mp(); // переменная "страница с вопросами". Так надо.
                await Navigation.PushModalAsync(mp); // Не знаю, атань
        }
       

        public void Start_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            perehod(sender, e); // функция перехода на страницу с вопросами (mp)

        }
        private void End_Clicked(object sender, EventArgs e) // функция которая закрывает
        {
             Process.GetCurrentProcess().CloseMainWindow(); // закрывает она, чего пристал
        }
    }
}
