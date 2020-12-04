using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PidorTest
{
    class Program
    {
        static int PidorValue = 0;   //очки пидора
        // ты пидор

        static string[] Questions = { "Ты любишь постарше или помладше?", "dfdfdf", "dfdfdf", "dfdfdf", "dfdfdf", "dfdfdf", "dfdfdf", "dfdfdf", "dfdfdf", "dfdfdf" };
        static string[,] Answers = new string[10, 6];


        static void Main(string[] args)   //Вступление и приветствие
        {
            Answers[0, 0] = "помладше"; Answers[0, 1] = "постарше"; Answers[0, 2] = "я ассексуал";
            Answers[0, 3] = "-5"; Answers[0, 4] = "5"; Answers[0, 5] = "0";

            Answers[1, 0] = "dsdsd"; Answers[1, 1] = "пgfdgdfg"; Answers[1, 2] = "hgfhл";
            Answers[1, 3] = "-5"; Answers[1, 4] = "5"; Answers[1, 5] = "0";

            Answers[2, 0] = "dsdsd"; Answers[2, 1] = "пgfdgdfg"; Answers[2, 2] = "hgfhл";
            Answers[2, 3] = "-5"; Answers[2, 4] = "5"; Answers[2, 5] = "0";

            Answers[3, 0] = "dsdsd"; Answers[3, 1] = "пgfdgdfg"; Answers[3, 2] = "hgfhл";
            Answers[3, 3] = "-5"; Answers[3, 4] = "5"; Answers[3, 5] = "0";

            Answers[4, 0] = "dsdsd"; Answers[4, 1] = "пgfdgdfg"; Answers[4, 2] = "hgfhл";
            Answers[4, 3] = "-5"; Answers[4, 4] = "5"; Answers[4, 5] = "0";

            Answers[5, 0] = "dsdsd"; Answers[5, 1] = "пgfdgdfg"; Answers[5, 2] = "hgfhл";
            Answers[5, 3] = "-5"; Answers[5, 4] = "5"; Answers[5, 5] = "0";

            Answers[6, 0] = "dsdsd"; Answers[6, 1] = "пgfdgdfg"; Answers[6, 2] = "hgfhл";
            Answers[6, 3] = "-5"; Answers[6, 4] = "5"; Answers[6, 5] = "0";

            Answers[7, 0] = "dsdsd"; Answers[7, 1] = "пgfdgdfg"; Answers[7, 2] = "hgfhл";
            Answers[7, 3] = "-5"; Answers[7, 4] = "5"; Answers[7, 5] = "0";

            Answers[8, 0] = "dsdsd"; Answers[8, 1] = "пgfdgdfg"; Answers[8, 2] = "hgfhл";
            Answers[8, 3] = "-5"; Answers[8, 4] = "5"; Answers[8, 5] = "0";

            Answers[9, 0] = "dsdsd"; Answers[9, 1] = "пgfdgdfg"; Answers[9, 2] = "hgfhл";
            Answers[9, 3] = "-5"; Answers[9, 4] = "5"; Answers[9, 5] = "0";






            string[] IntroText = { "Wake up, Neo", "You are P.I.D.O.R", "Или нет?", "Сейчас и узнаем",
                                   "Честно отвечай на вопросы и истина откроется", "Так же как и твое очко\n\n\n\n",
                                   "Приступим..." };

            Matrix();
            Thread.Sleep(400);
            Console.Clear();

            foreach (string text in IntroText)
            {
                DelayedText(text, 800);
            }
            Timer();
            TestStartTerms(true);
        }


        public static void StartQuestion(int Index)  //ВЫВОД ВОПРОСОВ
        {
            bool Skip = true;
            DelayedText(Questions[Index], 700);
            string Answer = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (Answers[Index, i] == Answer)
                {
                    PidorValue += Convert.ToInt32(Answers[Index, i + 3]);
                    DelayedText("Pidor_Value = " + PidorValue.ToString(), 700);
                    Skip = false;
                    break;
                }
            }
            if (Skip)
            {
                DelayedText("Ты мудак", 700);
                StartQuestion(Index);
            }
        }



        static void QuestionManager()
        {
            for (int i = 0; i < 10; i++)
            {
                StartQuestion(i);
            }

            if (PidorValue < 0)
            {
                DelayedText("Поздраляю, ты не пидор" + "\nТвой Pidor_Value = " + PidorValue.ToString(), 700);            //ДОДЕЛАТЬ УСЛОВИЯ ПИДОРА
            }
            else
            {
                DelayedText("Поздраляю, ты пидор" + "\nТвой Pidor_Value = " + PidorValue.ToString(), 700);
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
                for (int j = 1; j <= 50; j++)
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
            for (int Counter = 3; Counter > 0; Counter--)
            {
                Console.WriteLine(Counter.ToString() + "...");
                System.Threading.Thread.Sleep(1000);
            }

        }


        static void DelayedText(string text, int delay)
        {

            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(80);
            }
            Console.Write("\n");
            Thread.Sleep(delay);
        }


        static void TestStartTerms(bool first_time)
        {
            if (first_time) { Console.WriteLine("Нажми себе на пупок или <ENTER> чтобы продолжить"); }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                QuestionManager();
            }
            else
            {
                Console.WriteLine("\nЯ пока не знаю пидор ты или нет, но умом явно не блещешь\nНажми <ENTER> или катись колбаской");
                TestStartTerms(false);
            }

            Console.Read();
        }
    }
}

