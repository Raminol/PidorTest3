using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PidorTest
{
    class Program
    {
        static bool debug = false; // ТОГГЛ ДЕБАГ РЕЖИМА
        static int PidorValue = 0;   //очки пидора
        // ты пидор
        // сам пидор

        static string[] Questions = 
        {   
                #region Questions_and_Answers

                "Начнем с простого: " +"\nВ парадный или в шоколадный?"+
                "\n\nA: В парадный\nB: В шоколадный\nC: Я убил секс",                                                               //1

                "\n\nЕдем дальше..."+"\nБрал ли ты своего братюню за руку, идя с ним по улице?"+
                "\n\nA: Брал"+"\nB: Не брал"+"\nC: Я брал кое что другое и не совсем руку",                                         //2

                "\n\nПродолжим...\nКак ты относишься к Gachi ремиксам?"+"\nA: Одобряю"+                                             
                "\nB: Хуета для малолетних дебилов"+"\nC: Я к ним не отношусь",                                                     //3

                "\n\nРекламной паузы не будет, продолжаем!"+"\nПредпочту скоротать вечер в..."+
                "\n\nA: В Доте"+"\nB: В Gayshit Impact'е"+"\nC: В своем друге",                                                     //4

                "\n\nХочешь перерыв?............................"+"\nА мне похуй что ты хочешь, продолжаем."+
                "\nЭто типично, но нужно узнать твое отношение к АНИМЭ"+
                "\n\nA: Анимэ хуета, но хентайчик посмотреть не грех..."+"\nB: Ненавижу анимешников!" +
                "\nВот мой друг был анимешником...\n\nНо был же!!!"+"\n\nC: Да мне как-то похуй",                                   //5

                "\n\nТы же не тупой и понимаешь, что сейчас с тобой говорит не Морфеус?"+
                "\nТак вот, каково твое отношение к разработчику этого теста?"+
                "\n\nA: Я его на хую вертел и шутки у него не смешные"+"\nB: Хз, какой-то обрыган сбежал с КВНа"+
                "\nC: В смысле блять это не Морфеус пишет? А КТО?",                                                                 //6

                "\n\nОбъективно кто лучше для отношений: женщина или мужчина?..."+
                "\n\nA: Женщина заменяет большинство бытовых приборов...\nну и плюс регулируемая влажность входных отверстий"+
                "\nB: Ничто не сравнится с настоящим мужским сексом. А бытовуха - она и в Африке бытовуха."+
                "\nC: Ты ахуел? Почему всего два гендера? Вот мой партнер - это боевой вертолет McDonnell Douglas AH-64!",          //7

                "\n\nЕсли ты усталО, то мы почти закончили. Еще три вопроса, включая этот"+
                "\nДавно закупал технику Apple?"+
                "\n\nA: Никогда, развод для лохов"+"\nB: Когда-то был у меня пятый Айфон...хорошая была весчь..."+
                "\nC: Да вот буквально неск дней назад заказал колесики для своего Mac Pro за 69.990",                              //8

                "\n\nПредпоследний вопрос. "+"\nВ Москве жить хорошо?"+
                "\n\nA: Ну его нахуй эту Москву"+"\nB: А разве это не райцентр для пидоров?"+"\nC: Есть регионы кроме Москвы?..",     //9

                "\n\nФинал! Последний вопрос..."+"\nТы пидор?..."+"\n\n\n\nНу серьезно...."+"\n\n\nТы пидор? Только честно!"+
                "\n\nA: да"+"\nB: нет"+"\nC: иди-ка ты нахуй))"                                                                       //10

                #endregion
        };

        static string[,] Answers = new string[10, 6];


        static void Main(string[] args)   //Выводит вступительный текст и содержит массив вопросов и ответов
        {
            Console.Title = "с#_game_of_the_year_ultimate_mega_giga_edition_Cyberpunk2077_Limited_Version_PIDOR_probability";
            Console.SetWindowSize(120, 45); 

            Answers[0, 0] = "A"; Answers[0, 1] = "B"; Answers[0, 2] = "C";      //1
            Answers[0, 3] = "-5"; Answers[0, 4] = "5"; Answers[0, 5] = "0";

            Answers[1, 0] = "A"; Answers[1, 1] = "B"; Answers[1, 2] = "C";      //2
            Answers[1, 3] = "0"; Answers[1, 4] = "5"; Answers[1, 5] = "10";

            Answers[2, 0] = "A"; Answers[2, 1] = "B"; Answers[2, 2] = "C";      //3
            Answers[2, 3] = "-10"; Answers[2, 4] = "-5"; Answers[2, 5] = "0";

            Answers[3, 0] = "A"; Answers[3, 1] = "B"; Answers[3, 2] = "C";      //4
            Answers[3, 3] = "2"; Answers[3, 4] = "5"; Answers[3, 5] = "10";

            Answers[4, 0] = "A"; Answers[4, 1] = "B"; Answers[4, 2] = "C";      //5
            Answers[4, 3] = "-5"; Answers[4, 4] = "-5"; Answers[4, 5] = "5";

            Answers[5, 0] = "A"; Answers[5, 1] = "B"; Answers[5, 2] = "C";      //6
            Answers[5, 3] = "-5"; Answers[5, 4] = "5"; Answers[5, 5] = "0";

            Answers[6, 0] = "A"; Answers[6, 1] = "B"; Answers[6, 2] = "C";      //7
            Answers[6, 3] = "-10"; Answers[6, 4] = "10"; Answers[6, 5] = "0";

            Answers[7, 0] = "A"; Answers[7, 1] = "B"; Answers[7, 2] = "C";      //8
            Answers[7, 3] = "-5"; Answers[7, 4] = "0"; Answers[7, 5] = "10";

            Answers[8, 0] = "A"; Answers[8, 1] = "B"; Answers[8, 2] = "C";      //9
            Answers[8, 3] = "-5"; Answers[8, 4] = "5"; Answers[8, 5] = "10";

            Answers[9, 0] = "A"; Answers[9, 1] = "B"; Answers[9, 2] = "C";      //10
            Answers[9, 3] = "5"; Answers[9, 4] = "20"; Answers[9, 5] = "-10";



                if (debug) {
                    TestStartTerms(true);
                    return;
                }


            string[] IntroText = { "Wake up, Neo", "Are you P.I.D.O.R.?", "#5^3$#$@  @! )%#1010012___!",".....Сбой вычисления характеристики P.I.D.O.R", "Необходим новый ввод данных",
                                   "Честно отвечай на вопросы и истина откроется", "Так же как и твое очко\n\n\n\n",
                                   "Приступим..." };

                Matrix();
                Thread.Sleep(400);
                Console.Clear();

                    foreach (string text in IntroText)
                    {
                        DelayedText(text, 600);
                    }

                Timer();
                TestStartTerms(true);
        }


        public static void StartQuestion(int Index)  //ВЫВОД ВОПРОСОВ
        {
            bool Skip = true;
            DelayedText(Questions[Index], 600);
            string Answer = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (Answers[Index, i] == Answer)
                {
                    PidorValue += Convert.ToInt32(Answers[Index, i + 3]);
                    DelayedText("Pidor_Value = " + PidorValue.ToString(), 600);
                    Skip = false;
                    break;
                }
            }

            if (Skip)
            {
                DelayedText("Ты, тупое уебище, вводи символы на английском языке и строго по вариантам!", 600);
                StartQuestion(Index);
            }

        }


        static void ReplaceLastLine(string new_line)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine(new_line);
        }


            static void QuestionManager()  //Позволяет последовательно выводить вопросы в коносль//Содержит условия для вывода результата
            {

                //Console.ReadKey(true);

                    for (int i = 0; i < 10; i++)
                    {
                        StartQuestion(i);
                    }

                    if (PidorValue >= 15)
                    {
                        DelayedText("ВЫЧИСЛЯЮ ВЕРОЯТНОСТЬ" + "\nЗАПУСКАЮ ФОРМУЛУ" + "\n" + PidorValue.ToString() + "\n" + PidorValue.ToString() + "\n" + PidorValue.ToString() +
                                    "\nТвой Pidor_Value = " + PidorValue.ToString(), 1400);
                        ProgressBar();
                        DelayedText("\n\nПлохие новости, сын...ТЫ ПИДОР!" + "\n\nБЕГИ!" + "\n\nВОН ИЗ ЗАМКА!" + "\n\nНАРОД НЕ ЛЮБИТ ТЕБЯ", 1000);
                        Timer();
                        System.Environment.Exit(0);
                    }
                    else if(PidorValue<15 && PidorValue>-15)
                    {
                        DelayedText("ВЫЧИСЛЯЮ ВЕРОЯТНОСТЬ" + "\nЗАПУСКАЮ ФОРМУЛУ" + "\n" + PidorValue.ToString() + "\n" + PidorValue.ToString() + "\n" + PidorValue.ToString() +
                                    "\nТвой Pidor_Value = " + PidorValue.ToString(), 1400);
                        ProgressBar();
                        DelayedText("Хуй знает что тебе сказать..." + "\n\nНи рыба, ни мясо" + "\n\nНи туда, ни сюда..." + "\n\nСам выбери свою судьбу!", 800);
                        Timer();
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        DelayedText("ВЫЧИСЛЯЮ ВЕРОЯТНОСТЬ" + "\nЗАПУСКАЮ ФОРМУЛУ" + "\n" + PidorValue.ToString() + "\n" + PidorValue.ToString() + "\n" + PidorValue.ToString(), 1400);
                        ProgressBar();
                        DelayedText("\nТвой Pidor_Value = " + PidorValue.ToString() + "\n\nПоздраляю, ты НЕ пидор"+
                                    "\nЭто все, можешь идти. Закрывай консоль или нажми любую клавишу.", 700);
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
        }


        static void ProgressBar()
        {
            StringBuilder bar = new StringBuilder("[                         ]");
            int BarIndex = 1;
            Random RandomBar = new Random();

                Console.WriteLine(bar.ToString());

                    while (BarIndex < 25)
                    {
                        int Next=RandomBar.Next(1,5);
                        switch (Next)
                            {
                            case 1:
                                BarIndex++;
                                bar = bar.Replace(' ', '#', 1, BarIndex);
                            break;
                            case 2:
                                BarIndex+=2;
                                bar = bar.Replace(' ', '#', 1, BarIndex);
                            break;
                        }
                        ReplaceLastLine( bar.ToString() );
                        Thread.Sleep( RandomBar.Next(100, 250) );
                     }

        }


        static void Matrix()  //Зеленый дождик
        {
            int a = 0;
            string[] strArr = { " ", "!", "@", "#", " ", "$", "%", "^", " ", "&", "*", "-", " ", "+", "|", "<", " ", ">", "?", "№" };
            Random str = new Random();

                Console.ForegroundColor = ConsoleColor.Green;

                    for (int time = 2500; time > 0; time -= 80)
                    {
                        for (int j = 1; j <= 110; j++)
                        {
                            a = str.Next(strArr.Length);
                            Console.Write("{0,2}", strArr[a]);
                        }
                        Console.WriteLine();
                        Thread.Sleep(80);
                    }

        }


        static void Timer()   //отсчет в приветствии
        {
            for (int Counter = 5; Counter > 0; Counter--)
            {
                Console.WriteLine(Counter.ToString() + "...");
                System.Threading.Thread.Sleep(1000);
            }
        }


        static void DelayedText(string text, int delay) //Функция вывода текста на экран побуквенно
        {

                foreach (char letter in text)
                {
                    Console.Write(letter);
                    Thread.Sleep(50);
                }

            Console.Write("\n");
            Thread.Sleep(delay);
        }


        static void TestStartTerms(bool first_time)  //Содержит условия для очистки консоли и запуска теста
        {
                if (first_time) { DelayedText("Небольшая ремарка: ответом пиши в консоль букву варианта (А, В, С и тд). \n" +
                                              "В противном случае результат будет неверен." +
                                              "\nТак, например, если вариант предлагает ответ /А/ - пиши /А/ с учетом изначального регистра(не /а/)." +
                                              "\nБукву варианта ответа пиши на АНГЛИЙСКОЙ раскладке иначе консоль пошлет тебя нахер."+
                                              "\nМне просто было лень ебаться с форматированием текста." +
                                              "\n\nЕсли ты все понял нажми себе на пупок или <ENTER> чтобы продолжить",600); 
                }

            
            ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter && Console.ReadLine() == "")
                {
                    Console.Clear();
                    QuestionManager();
                }
                else
                {
                    DelayedText("\nЯ пока не знаю пидор ты или нет, но умом явно не блещешь\nНажми <ENTER> или катись колбаской",600);
                    TestStartTerms(false);
                }
            
            
        }
    }
}

