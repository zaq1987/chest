using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("введи дату в формате  01 01 2000");
            string dat = Console.ReadLine();
            DateTime dr = DateTime.Parse(dat);
            DateTime now = DateTime.Now;

            Console.Title = "ГОРОСКОП";

            if (dr > now) { Console.WriteLine("Ты из будущего?"); }

            int vozrast = now.Year - dr.Year;
            if (now.Month < dr.Month)
            {
                vozrast--;
            }
                if (now.Day < dr.Day)
                {
                    vozrast--;
                }
            

            Console.WriteLine($"Возраст: {vozrast }");
            //1
            int p1 = dr.Year / 19;  // 104,5789....
            decimal pp1 = p1;
            decimal punkt1 = (decimal)dr.Year / (decimal)19 - pp1; // 0,5789....
            //2
            decimal punkt2 = punkt1 * (decimal)209;
            punkt2 = Math.Round(punkt2);
            //3
            decimal punkt3 = 0.0m;
            /* if (dataRozhdeniya.Month == 1 || dataRozhdeniya.Month == 2 )
             {
                  decimal p3 = punkt2 + (decimal)dataRozhdeniya.Month + (decimal)12;
                 punkt3 = p3;
             }*/
            //     else
            // {
            decimal p3 = punkt2 + (decimal)dr.Month;
            punkt3 = p3;
            //      }
            //4
            decimal punkt4 = punkt3 - (decimal)3;
            //5
            decimal punkt5 = punkt4 + (decimal)dr.Day;
            //6
            decimal p6 = punkt5 / 30;
            int puk6 = (int)p6;
            decimal punkt6 = p6 - (decimal)puk6;
            //7
            decimal puk7 = punkt6 * (decimal)30;
            decimal punkt7 = Math.Round(puk7);
            decimal lunniyDen = punkt7 - 1;
            Console.WriteLine(lunniyDen + " лунный день");

            // какому из трех уровней славянского мироздания этот лунный день соответствует
            int lunniyUroven = 0;
            int solnechniyUroven = 0;
            int itoguroven = 0;

            if (lunniyDen == 1 || lunniyDen == 4 || lunniyDen == 8 || lunniyDen == 9 || lunniyDen == 10 || lunniyDen == 11 || lunniyDen == 13 || lunniyDen == 18 || lunniyDen == 20 || lunniyDen == 22 || lunniyDen == 23 || lunniyDen == 27 || lunniyDen == 30)
            {
                 lunniyUroven = 2;
            }
            if (lunniyDen == 2 || lunniyDen == 3 || lunniyDen == 6 || lunniyDen == 7 || lunniyDen == 14 || lunniyDen == 15 || lunniyDen == 16 || lunniyDen == 19 || lunniyDen == 21 || lunniyDen == 24 || lunniyDen == 28 || lunniyDen == 29)
            {
                 lunniyUroven = 3;
            }
            if (lunniyDen == 5 || lunniyDen == 12 || lunniyDen == 17 || lunniyDen == 25 || lunniyDen == 26)
            {
                 lunniyUroven = 1;
            }
            if (lunniyUroven == 1)
            {
                Console.WriteLine("Ваш мир по лунному календарю НИЖНИЙ" );
            }
            if (lunniyUroven == 2)
            {
                Console.WriteLine("Ваш мир по лунному календарю СРЕДНИЙ");
            }
            if (lunniyUroven == 3)
            {
                Console.WriteLine("Ваш мир по лунному календарю ВЕРХНИЙ");
            }



            // определяем по солнечному календарю принадлежность к одному из трех миров:
            if (dr.Month == 1)
            { if (dr.Day == 1 || dr.Day == 5 || dr.Day == 10 || dr.Day == 14 || dr.Day == 15 || dr.Day == 17 || dr.Day == 20 || dr.Day == 23 || dr.Day == 25 || dr.Day == 28)
                { goto Verhniy; }
            }
            if (dr.Month == 2)
            { if (dr.Day == 2 || dr.Day == 4 || dr.Day == 5 || dr.Day == 9 || dr.Day == 14 || dr.Day == 23 || dr.Day == 25)
                { goto Verhniy; }
            }
            if (dr.Month == 3)
            { if (dr.Day == 1 || dr.Day == 2 || dr.Day == 3 || dr.Day == 4 || dr.Day == 7 || dr.Day == 8 || dr.Day == 12 || dr.Day == 15 || dr.Day == 17 || dr.Day == 18 || dr.Day == 19 || dr.Day == 26 || dr.Day == 28 || dr.Day == 29)
                { goto Verhniy; }
            }
            if (dr.Month == 4)
            { if (dr.Day == 3 || dr.Day == 11 || dr.Day == 12 || dr.Day == 13 || dr.Day == 20 || dr.Day == 26 || dr.Day == 30)
                { goto Verhniy; }
            }
            if (dr.Month == 5)
            { if (dr.Day == 5 || dr.Day == 12 || dr.Day == 13 || dr.Day == 17 || dr.Day == 19 || dr.Day == 20 || dr.Day == 21 || dr.Day == 23 || dr.Day == 28 || dr.Day == 29 || dr.Day == 30)
                { goto Verhniy; }
            }
            if (dr.Month == 6)
            { if (dr.Day == 3 || dr.Day == 6 || dr.Day == 9 || dr.Day == 13 || dr.Day == 18 || dr.Day == 22 || dr.Day == 27 || dr.Day == 29)
                { goto Verhniy; }
            }
            if (dr.Month == 7)
            { if (dr.Day == 2 || dr.Day == 4 || dr.Day == 6 || dr.Day == 9 || dr.Day == 10 || dr.Day == 11 || dr.Day == 16 || dr.Day == 21 || dr.Day == 26 || dr.Day == 29 || dr.Day == 30)
                { goto Verhniy; }
            }
            if (dr.Month == 8)
            { if (dr.Day == 6 || dr.Day == 9 || dr.Day == 12 || dr.Day == 17 || dr.Day == 20 || dr.Day == 21 || dr.Day == 24 || dr.Day == 25)
                { goto Verhniy; }
            }
            if (dr.Month == 9)
            { if (dr.Day == 1 || dr.Day == 2 || dr.Day == 3 || dr.Day == 4 || dr.Day == 5 || dr.Day == 7 || dr.Day == 8 || dr.Day == 11 || dr.Day == 16 || dr.Day == 18 || dr.Day == 19 || dr.Day == 21 || dr.Day == 24 || dr.Day == 25 || dr.Day == 26)
                { goto Verhniy; }
            }
            if (dr.Month == 10)
            { if (dr.Day == 3 || dr.Day == 11 || dr.Day == 14 || dr.Day == 17 || dr.Day == 18 || dr.Day == 24 || dr.Day == 27 || dr.Day == 31)
                { goto Verhniy; }
            }
            if (dr.Month == 11)
            { if (dr.Day == 1 || dr.Day == 2 || dr.Day == 7 || dr.Day == 12 || dr.Day == 13 || dr.Day == 18 || dr.Day == 22 || dr.Day == 29)
                { goto Verhniy; }
            }
            if (dr.Month == 12)
            { if (dr.Day == 5 || dr.Day == 6 || dr.Day == 9 || dr.Day == 12 || dr.Day == 16 || dr.Day == 19 || dr.Day == 20 || dr.Day == 23 || dr.Day == 24 || dr.Day == 25)
                { goto Verhniy; }
            }

            if (dr.Month == 1)
            { if (dr.Day == 3 || dr.Day == 6 || dr.Day == 8 || dr.Day == 9 || dr.Day == 13 || dr.Day == 16 || dr.Day == 18 || dr.Day == 19 || dr.Day == 26 || dr.Day == 27)
                { goto Nizhniy; }
            }
            if (dr.Month == 2)
            { if (dr.Day == 3 || dr.Day == 6 || dr.Day == 7 || dr.Day == 8 || dr.Day == 10 || dr.Day == 11 || dr.Day == 12 || dr.Day == 15 || dr.Day == 18 || dr.Day == 19 || dr.Day == 21 || dr.Day == 22 || dr.Day == 24 || dr.Day == 29)
                { goto Nizhniy; }
            }
            if (dr.Month == 3)
            { if (dr.Day == 13 || dr.Day == 14 || dr.Day == 16 || dr.Day == 24 || dr.Day == 25 || dr.Day == 30 || dr.Day == 31)
                { goto Nizhniy; }
            }
            if (dr.Month == 4)
            { if (dr.Day == 1 || dr.Day == 4 || dr.Day == 6 || dr.Day == 7 || dr.Day == 8 || dr.Day == 9 || dr.Day == 14 || dr.Day == 15 || dr.Day == 16 || dr.Day == 21 || dr.Day == 22 || dr.Day == 24 || dr.Day == 25 || dr.Day == 27 || dr.Day == 28)
                { goto Nizhniy; }
            }
            if (dr.Month == 5)
            { if (dr.Day == 1 || dr.Day == 2 || dr.Day == 3 || dr.Day == 7 || dr.Day == 9 || dr.Day == 14 || dr.Day == 15 || dr.Day == 16 || dr.Day == 26 || dr.Day == 31)
                { goto Nizhniy; }
            }
            if (dr.Month == 6)
            { if (dr.Day == 1 || dr.Day == 4 || dr.Day == 7 || dr.Day == 8 || dr.Day == 10 || dr.Day == 14 || dr.Day == 15 || dr.Day == 17 ||  dr.Day == 19 || dr.Day == 24 || dr.Day == 26 || dr.Day == 28 || dr.Day == 30)
                { goto Nizhniy; }
            }
            if (dr.Month == 7)
            { if (dr.Day == 1 || dr.Day == 5 || dr.Day == 7 || dr.Day == 12 || dr.Day == 15 || dr.Day == 17 || dr.Day == 20 || dr.Day == 24 || dr.Day == 31)
                { goto Nizhniy; }
            }
            if (dr.Month == 8)
            { if (dr.Day == 1 || dr.Day == 2 || dr.Day == 3 || dr.Day == 4 || dr.Day == 7 || dr.Day == 8 || dr.Day == 10 || dr.Day == 13 || dr.Day == 14 || dr.Day == 16 || dr.Day == 19 || dr.Day == 27 || dr.Day == 30 || dr.Day == 31)
                { goto Nizhniy; }
            }
            if (dr.Month == 9)
            { if (dr.Day == 10 || dr.Day == 12 || dr.Day == 14 || dr.Day == 15 || dr.Day == 28 || dr.Day == 29)
                { goto Nizhniy; }
            }
            if (dr.Month == 10)
            { if (dr.Day == 1 || dr.Day == 2 || dr.Day == 5 || dr.Day == 8 || dr.Day == 10 || dr.Day == 13 || dr.Day == 16 || dr.Day == 19 || dr.Day == 21 || dr.Day == 22 || dr.Day == 28 || dr.Day == 30)
                { goto Nizhniy; }
            }
            if (dr.Month == 11)
            { if (dr.Day == 4 || dr.Day == 9 || dr.Day == 14 || dr.Day == 15 || dr.Day == 17 || dr.Day == 20 || dr.Day == 21 || dr.Day == 23 || dr.Day == 24 || dr.Day == 26 || dr.Day == 27 || dr.Day == 30)
                { goto Nizhniy; }
            }
            if (dr.Month == 12)
            {
                if (dr.Day == 4 || dr.Day == 7 || dr.Day == 11 || dr.Day == 13 || dr.Day == 17 || dr.Day == 21 || dr.Day == 22 || dr.Day == 27 || dr.Day == 29 || dr.Day == 30 || dr.Day == 31)
                { goto Nizhniy; }
            }
            if (dr.Month == 1)
            { if (dr.Day == 2 || dr.Day == 4 || dr.Day == 7 || dr.Day == 11 || dr.Day == 12 || dr.Day == 21 || dr.Day == 22 || dr.Day == 24 ||  dr.Day == 29 || dr.Day == 30 || dr.Day == 31)
                { goto Sredniy; }
            }
            if (dr.Month == 2)
            { if (dr.Day == 1 || dr.Day == 13 || dr.Day == 16 || dr.Day == 17 || dr.Day == 20 || dr.Day == 26 || dr.Day == 27 || dr.Day == 28)
                    goto Sredniy;
            }
            if (dr.Month == 3)
            { if (dr.Day == 5 || dr.Day == 6 || dr.Day == 9 || dr.Day == 10 || dr.Day == 11 || dr.Day == 20 || dr.Day == 21 || dr.Day == 22 || dr.Day == 23 || dr.Day == 27)
                { goto Sredniy; }
            }
            if (dr.Month == 4)
            { if (dr.Day == 2 || dr.Day == 5 || dr.Day == 10 || dr.Day == 17 || dr.Day == 19 || dr.Day == 29)
                { goto Sredniy; }
            }
            if (dr.Month == 5)
            { if (dr.Day == 4 || dr.Day == 6 || dr.Day == 8 || dr.Day == 10 || dr.Day == 11 || dr.Day == 18 || dr.Day == 22 || dr.Day == 24 || dr.Day == 25 || dr.Day == 27)
                { goto Sredniy; }
            }
            if (dr.Month == 6)
            { if (dr.Day == 2 || dr.Day == 5 || dr.Day == 11 || dr.Day == 12 || dr.Day == 16 || dr.Day == 20 || dr.Day == 21 || dr.Day == 23 || dr.Day == 25)
                { goto Sredniy; }
            }
            if (dr.Month == 7)
            { if (dr.Day == 3 || dr.Day == 8 || dr.Day == 13 || dr.Day == 14 || dr.Day == 18 || dr.Day == 19 || dr.Day == 22 || dr.Day == 23 || dr.Day == 25 || dr.Day == 27 || dr.Day == 28)
                { goto Sredniy; }
            }
            if (dr.Month == 8)
            { if (dr.Day == 5 || dr.Day == 11 || dr.Day == 1518 || dr.Day == 22 || dr.Day == 23 || dr.Day == 26 || dr.Day == 28 || dr.Day == 29)
                { goto Sredniy; }
            }
            if (dr.Month == 9)
            { if (dr.Day == 6 || dr.Day == 9 || dr.Day == 13 || dr.Day == 17 || dr.Day == 20 || dr.Day == 22 || dr.Day == 23 || dr.Day == 27 || dr.Day == 30)
                { goto Sredniy; }
            }
            if (dr.Month == 10)
            { if (dr.Day == 4 || dr.Day == 6 || dr.Day == 7 || dr.Day == 9 || dr.Day == 12 || dr.Day == 15 || dr.Day == 20 || dr.Day == 23 || dr.Day == 25 || dr.Day == 26 || dr.Day == 29)
                { goto Sredniy; }
            }
            if (dr.Month == 11)
            { if (dr.Day == 3 || dr.Day == 5 || dr.Day == 6 || dr.Day == 8 || dr.Day == 10 || dr.Day == 11 || dr.Day == 16 || dr.Day == 19 || dr.Day == 25 || dr.Day == 28)
                { goto Sredniy; }
            }
            if (dr.Month == 12)
            {
                if (dr.Day == 1 || dr.Day == 2 || dr.Day == 3 || dr.Day == 8 || dr.Day == 10 || dr.Day == 14 || dr.Day == 15 || dr.Day == 18 || dr.Day == 26 || dr.Day == 28)
                { goto Sredniy; }
            }

            Verhniy: Console.WriteLine("Ваш мир по солнечному календарю ВЕРХНИЙ"); solnechniyUroven = 3; goto Next;
            Sredniy: Console.WriteLine("Ваш мир по солнечному календарю СРЕДНИЙ"); solnechniyUroven = 2; goto Next;
            Nizhniy: Console.WriteLine("Ваш мир по солнечному календарю НИЖНИЙ"); solnechniyUroven = 1; goto Next;

        Next:

            // что получается в результате объединения показателей солнечного и лунного календарей
            string itogoviyUroven = "null";
            if (solnechniyUroven == 3 && lunniyUroven == 3 || solnechniyUroven == 3 && lunniyUroven == 1 || solnechniyUroven == 1 && lunniyUroven == 3)
            {
                itogoviyUroven = "ВЕРХНИЙ";
            }
            if (solnechniyUroven == 3 && lunniyUroven == 2 || solnechniyUroven == 2 && lunniyUroven == 2 )
            {
                itogoviyUroven = "СРЕДНИЙ";
            }
            if (solnechniyUroven == 2 && lunniyUroven == 1 || solnechniyUroven == 1 && lunniyUroven == 2 || solnechniyUroven ==1 && lunniyUroven == 1)
            {
                itogoviyUroven = "НИЖНИЙ";
            }
            Console.WriteLine($"В итоге у вас {itogoviyUroven} мир");

            // определение круга славянского мироздания
            int slavanskiyKrug = 0;

            if (dr.Month == 12 && dr.Day > 24 && dr.Day < 28 || dr.Month == 4 && dr.Day > 23 && dr.Day < 27 || dr.Month == 8 && dr.Day > 26 && dr.Day < 30)
            {
                slavanskiyKrug = 7;
            }
            if (dr.Month == 12 && dr.Day > 27 && dr.Day < 31 || dr.Month == 4 && dr.Day > 26 && dr.Day < 30 || dr.Month == 8 && dr.Day > 29 && dr.Month == 9 && dr.Day == 1)
            {
                slavanskiyKrug = 9;
            }
            if (dr.Month == 12 && dr.Day == 31 || dr.Month == 1 && dr.Day < 5 || dr.Month == 4 && dr.Day > 29 || dr.Month == 5 && dr.Day < 6 || dr.Month == 9 && dr.Day >1 && dr.Day < 7)
            {
                slavanskiyKrug = 3;
            }
            if (dr.Month == 1 && dr.Day > 4 && dr.Day < 8 || dr.Month == 5 && dr.Day > 4 && dr.Day < 8 || dr.Month == 9 && dr.Day > 6 && dr.Day < 10)
            {
                slavanskiyKrug = 8;
            }
            if (dr.Month == 1 && dr.Day > 7 && dr.Day < 12 || dr.Month == 5 && dr.Day > 7 && dr.Day < 12 || dr.Month == 9 && dr.Day > 9 && dr.Day < 14)
            {
                slavanskiyKrug = 1;
            }
            if (dr.Month == 1 && dr.Day > 11 && dr.Day < 15 || dr.Month == 5 && dr.Day > 11 & dr.Day < 15 || dr.Month == 9 && dr.Day > 13 && dr.Day < 17)
            {
                slavanskiyKrug = 6;
            }
            if (dr.Month == 1 && dr.Day > 14 && dr.Day < 18 || dr.Month == 5 && dr.Day > 14 && dr.Day < 18 || dr.Month == 9 && dr.Day > 16 && dr.Day < 20)
            {
                slavanskiyKrug = 4;
            }
            if (dr.Month == 1 && dr.Day > 17 && dr.Day < 21 || dr.Month == 5 && dr.Day > 17 && dr.Day < 21 || dr.Month == 9 && dr.Day > 19 && dr.Day < 22)
            {
                slavanskiyKrug = 2;
            }
            if (dr.Month == 1 && dr.Day > 20 && dr.Day < 24 || dr.Month == 5 && dr.Day > 20 && dr.Day < 24 || dr.Month == 9 && dr.Day > 21 && dr.Day < 25)
            {
                slavanskiyKrug = 5;
            }
            if (dr.Month == 1 && dr.Day > 23 && dr.Day < 27 || dr.Month == 5 && dr.Day > 23 && dr.Day < 27 || dr.Month == 9 && dr.Day > 24 && dr.Day < 28)
            {
                slavanskiyKrug = 7;
            }
            if (dr.Month == 1 && dr.Day > 26 && dr.Day < 31 || dr.Month == 5 && dr.Day > 26 && dr.Day < 30 || dr.Month == 9 && dr.Day > 27 && dr.Day < 31)
            {
                slavanskiyKrug = 9;
            }
            if (dr.Month == 1 && dr.Day == 31 || dr.Month == 2 && dr.Day < 5 || dr.Month == 5 && dr.Day > 28 && dr.Month == 6 && dr.Day < 4 || dr.Month == 10 &&  dr.Day < 6)
            {
                slavanskiyKrug = 3;
            }
            if (dr.Month == 2 && dr.Day > 4 && dr.Day < 8 || dr.Month == 6 && dr.Day > 3 && dr.Day < 7 || dr.Month == 10 && dr.Day > 5 && dr.Day < 9)
            {
                slavanskiyKrug = 8;
            }
            if (dr.Month == 2 && dr.Day > 7 && dr.Day < 12 || dr.Month == 6 && dr.Day > 6 && dr.Day < 11 || dr.Month == 10 && dr.Day > 8 && dr.Day < 13)
            {
                slavanskiyKrug = 1;
            }
            if (dr.Month == 2 && dr.Day > 11 && dr.Day < 15 || dr.Month == 6 && dr.Day > 10 && dr.Day < 14 || dr.Month == 10 && dr.Day > 12 && dr.Day < 16)
            {
                slavanskiyKrug = 6;
            }
            if (dr.Month == 2 && dr.Day > 14 && dr.Day < 18 || dr.Month == 6 && dr.Day > 13 && dr.Day < 17 || dr.Month == 10 && dr.Day > 15 && dr.Day < 21)
            {
                slavanskiyKrug = 4;
            }
            if (dr.Month == 2 && dr.Day > 17 && dr.Day < 21 || dr.Month == 6 && dr.Day > 16 && dr.Day < 22 || dr.Month == 10 && dr.Day > 20 && dr.Day < 24)
            {
                slavanskiyKrug = 2;
            }
            if (dr.Month == 2 && dr.Day > 20 && dr.Day < 24 || dr.Month == 6 && dr.Day > 21 && dr.Day < 25 || dr.Month == 10 && dr.Day > 23 && dr.Day < 27)
            {
                slavanskiyKrug = 5;
            }
            if (dr.Month == 2 && dr.Day > 23 && dr.Day < 27 || dr.Month == 6 && dr.Day > 24 && dr.Day < 28 || dr.Month == 10 && dr.Day > 26 && dr.Day < 30)
            {
                slavanskiyKrug = 7;
            }
            if (dr.Month == 2 && dr.Day > 26 || dr.Month == 3 && dr.Day == 1 || dr.Month == 6 && dr.Day > 27 && dr.Day < 31 || dr.Month == 10 && dr.Day > 29 || dr.Month == 11 && dr.Day == 1)
            {
                slavanskiyKrug = 9;
            }
            if (dr.Month == 3 && dr.Day > 1 && dr.Day < 7 || dr.Month == 7 && dr.Day < 6 || dr.Month == 11 && dr.Day > 1 && dr.Day < 7)
            {
                slavanskiyKrug = 3;
            }
            if (dr.Month == 3 && dr.Day > 6 && dr.Day < 10 || dr.Month == 7 && dr.Day > 5 && dr.Day < 9 || dr.Month == 11 && dr.Day > 6 && dr.Day < 10)
            {
                slavanskiyKrug = 8;
            }
            if (dr.Month == 3 && dr.Day > 9 && dr.Day < 14 || dr.Month == 7 && dr.Day > 8 && dr.Day < 13 || dr.Month == 11 && dr.Day > 9 && dr.Day < 14)
            {
                slavanskiyKrug = 1;
            }
            if (dr.Month == 3 && dr.Day > 13 && dr.Day < 17 || dr.Month == 7 && dr.Day > 12 && dr.Day < 17 || dr.Month == 11 && dr.Day > 13 && dr.Day < 17)
            {
                slavanskiyKrug = 6;
            }
            if (dr.Month == 3 && dr.Day > 16 && dr.Day < 20 || dr.Month == 7 && dr.Day > 16 && dr.Day < 20 || dr.Month == 11 && dr.Day > 16 && dr.Day < 20)
            {
                slavanskiyKrug = 4;
            }
            if (dr.Month == 3 && dr.Day > 19 && dr.Day < 22 || dr.Month == 7 && dr.Day > 19 && dr.Day < 24 || dr.Month == 11 && dr.Day > 19 && dr.Day < 23)
            {
                slavanskiyKrug = 2;
            }
            if (dr.Month == 3 && dr.Day > 21 && dr.Day < 25 || dr.Month == 7 && dr.Day > 23 && dr.Day < 27 || dr.Month == 11 && dr.Day > 22 && dr.Day < 26)
            {
                slavanskiyKrug = 5;
            }
            if (dr.Month == 3 && dr.Day > 24 && dr.Day < 28 || dr.Month == 7 && dr.Day > 26 && dr.Day < 30 || dr.Month == 11 && dr.Day > 25 && dr.Day < 29)
            {
                slavanskiyKrug = 7;
            }
            if (dr.Month == 3 && dr.Day > 27 && dr.Day < 31 || dr.Month == 7 && dr.Day > 29 || dr.Month == 8 && dr.Day == 1|| dr.Month == 11 && dr.Day > 28 ||dr.Month == 12 && dr.Day < 2)
            {
                slavanskiyKrug = 9;
            }
            if (dr.Month == 3 && dr.Day == 31 || dr.Month == 4 && dr.Day < 5 || dr.Month == 8 && dr.Day > 1 && dr.Day < 7 || dr.Month == 12 && dr.Day > 1 && dr.Day < 7)
            {
                slavanskiyKrug = 3;
            }
            if (dr.Month == 4 && dr.Day > 4 && dr.Day < 8 || dr.Month == 8 && dr.Day > 6 && dr.Day < 10 || dr.Month == 12 && dr.Day > 6 && dr.Day < 10)
            {
                slavanskiyKrug = 8;
            }
            if (dr.Month == 4 && dr.Day > 7 && dr.Day < 12 || dr.Month == 8 && dr.Day > 9 && dr.Day < 14 || dr.Month == 12 && dr.Day > 9 && dr.Day < 14)
            {
                slavanskiyKrug = 1;
            }
            if (dr.Month == 4 && dr.Day > 11 && dr.Day < 15 || dr.Month == 8 && dr.Day > 13 && dr.Day < 17 || dr.Month == 12 && dr.Day > 13 && dr.Day < 17)
            {
                slavanskiyKrug = 6;
            }
            if (dr.Month == 4 && dr.Day > 14 && dr.Day < 18 || dr.Month == 8 && dr.Day > 16 && dr.Day < 20 || dr.Month == 12 && dr.Day > 16 && dr.Day < 20)
            {
                slavanskiyKrug = 4;
            }
            if (dr.Month == 4 && dr.Day > 17 && dr.Day < 21 || dr.Month == 8 && dr.Day > 19 && dr.Day < 24 || dr.Month == 12 && dr.Day > 19 && dr.Day < 22)
            {
                slavanskiyKrug = 2;
            }
            if (dr.Month == 4 && dr.Day > 20 && dr.Day < 24 || dr.Month == 8 && dr.Day > 23 && dr.Day < 27 || dr.Month == 12 && dr.Day > 23 && dr.Day < 25)
            {
                slavanskiyKrug = 5;
            }
            
            Console.WriteLine($"Ваш круг {slavanskiyKrug}");

            // теперь собственно само описание
            if (slavanskiyKrug == 1 && itogoviyUroven == "ВЕРХНИЙ")
            {
                Console.WriteLine("1В - (ОРЕШНИК) - ЭНЕРГИ БОГА");
                Console.WriteLine("Дар: Духовное лидерство, ...");
            }
            if (slavanskiyKrug == 1 && itogoviyUroven == "СРЕДНИЙ")
            {
                Console.WriteLine("1С - (СТРЕЛОЛИСТ) - ПРОЯВЛЕННАЯ ЭНЕРГИ БОГА, ");
                Console.WriteLine("МИРОЛЮБИЯ ОБЩЕНИЯ, ЛЮБВИ К МИРУ, ВЕЗЕНИЯ");
                Console.WriteLine("Дар: Успех в общении, общительность, дипломатичность ...");
            }
            if (slavanskiyKrug == 1 && itogoviyUroven == "НИЖНИЙ")
            {
                Console.WriteLine("1Н - (ЧЕРЕДА) - ЭНЕРГИЯ БОЖЕСТВЕННОГО  ");
                Console.WriteLine("В МАТЕРИАЛЬНОМ МИРЕ, ИНТУИЦИЯ");
                Console.WriteLine("Дар: Яснознание, интуиция, открытая родовая память, ...");
            }
            if (slavanskiyKrug == 2 && itogoviyUroven == "ВЕРХНИЙ")
            {
                Console.WriteLine("2В - (ОСОКА) - УСПЕХ В КАРЬЕРЕ, В БИЗНЕС-ПРОЕКТАХ,");
                Console.WriteLine("ДУХОВНОЕ НАЧАЛО С КАЧЕСТВОМ ПЕРЕХОДА В ЯВЬ");
                Console.WriteLine("(Т.Е. РЕАЛИЗАЦИИ В ЖИЗНИ");
                Console.WriteLine("Дар: Способность дать жизнь любой идее успех в деятельности, ...");
            }
            if (slavanskiyKrug == 2 && itogoviyUroven == "СРЕДНИЙ")
            {
                Console.WriteLine("2С - (ХВОЩ) - ЖИЗНЬ В ЯВИ, ДЕНЬГИ");
                Console.WriteLine("Дар: 2С - это энергия процветания, прибыли, денег. ...");
            }
            if (slavanskiyKrug == 2 && itogoviyUroven == "НИЖНИЙ")
            {
                Console.WriteLine("2Н - (ТОПОЛЬ) - ЖИЗНЬ В НАВИ, БАЛАНС, МАГИЯ, ");
                Console.WriteLine("УСТРАНЕНИЕ ЗАЦЕПОК И ПРИВЯЗАННОСТЕЙ");
                Console.WriteLine("Дар: Знахарство, магические способности, управление стихиями, ...");
            }
            if (slavanskiyKrug == 3 && itogoviyUroven == "ВЕРХНИЙ")
            {
                Console.WriteLine("3В - (РЯБИНА) - ЭНЕРГИЯ ОСОЗНАННОСТИ,");
                Console.WriteLine("ДУХОВНЫЙ ОПЫТ, ЗНАНИЯ ОТ БОГОВ");
                Console.WriteLine("Дар: Осознанность, духовное провидение, прозрение., ...");
            }
            if (slavanskiyKrug == 3 && itogoviyUroven == "СРЕДНИЙ")
            {
                Console.WriteLine("3С - (РОГОЗ) - ОТНОШЕНИЯ С ПРОТИВОПОЛОЖНЫМ");
                Console.WriteLine("ПОЛОМ, ЛЮБОВЬ, ГАРМОНИЯ В ПАРЕ");
                Console.WriteLine("Дар: Настройка на гармоничные отношения в паре, ...");
            }
            if (slavanskiyKrug == 3 && itogoviyUroven == "НИЖНИЙ")
            {
                Console.WriteLine("3Н - (ПОЛЫНЬ БЕЛАЯ) - ЗНАНИЯ ИЗ МИРА НАВИ,");
                Console.WriteLine("ЗНАНИЯ РОДА");
                Console.WriteLine("Дар: Общение с потусторонним миром, ясновидение, ...");
            }
            if (slavanskiyKrug == 4 && itogoviyUroven == "ВЕРХНИЙ")
            {
                Console.WriteLine("4В - (КУБЫШКА) - ЭНЕРГИЯ НАКОПЛЕНИЯ, ПОИСКА");
                Console.WriteLine("И НАХОЖДЕНИЯ ВОЗМОЖНОСТЕЙ, А ТАКЖЕ ЭНЕРГИЯ");
                Console.WriteLine("КРЕАТИВА, БОГАТОЙ ФАНТАЗИИ");
                Console.WriteLine("Дар: Ченнелинг, нестандартное мышление, умение создавать уникальное, ...");
            }
            if (slavanskiyKrug == 4 && itogoviyUroven == "СРЕДНИЙ")
            {
                Console.WriteLine("4С - (КЛЕН) - ТВОРЧЕСТВО, СОЗИДАНИЕ В ЯВИ,");
                Console.WriteLine("СОСТОЯНИЕ РЕБЕНКА, ВЗАИМОПОНИМАНИЕ С МЛАДНИМ ПОКОЛЕНИЕМ");
                Console.WriteLine("Дар: Сотворение из самого сердца, творческие способности ...");
            }
            if (slavanskiyKrug == 4 && itogoviyUroven == "НИЖНИЙ")
            {
                Console.WriteLine("4Н - (ПРЯНЫЕ ТРАВЫ) - ТВОРЧЕСТВО В НАВИ,");
                Console.WriteLine("ПРИВЛЕЧЕНИЕ ПОКРОВИТЕЛЕЙ, МАТЕРИАЛИЗАЦИЯ ЗАДУМАННОГО");
                Console.WriteLine("Дар: Привленчение сил миров Нави и Прави для созидания в Яви, помощь покровителей, ...");
            }
            if (slavanskiyKrug == 5 && itogoviyUroven == "ВЕРХНИЙ")
            {
                Console.WriteLine("5В - (ОЛЬХА) - МОЛИТВА К БОГАМ, ПУТЕШЕСТВИЯ,");
                Console.WriteLine("РАСШИРЕНИЕ КРУГОЗОРА");
                Console.WriteLine("КРЕАТИВА, БОГАТОЙ ФАНТАЗИИ");
                Console.WriteLine("Дар: Широкий кругозор, динамичный ум, любовь к переменам, ...");
            }
            if (slavanskiyKrug == 5 && itogoviyUroven == "СРЕДНИЙ")
            {
                Console.WriteLine("5С - (ЯСЕНЬ) - ПРОСЬБА К ЛЮДЯМ, ДИПЛОМАТИЧНОСТЬ,");
                Console.WriteLine("СИЛА ВЛИЯНИЯ НА ЛЮДЕЙ");
                Console.WriteLine("Дар: Убеждения, способность влиять на мнение собеседника. ...");
            }
            if (slavanskiyKrug == 5 && itogoviyUroven == "НИЖНИЙ")
            {
                Console.WriteLine("5Н - (ПОЛЫНЬ ЧЕРНАЯ) - МОЛИТВА К ПРЕДКАМ, ");
                Console.WriteLine("МАТЕРИНСТВО, ПОЧИТАНИЕ РОДА");
                Console.WriteLine("Дар: Заботливость, обрести счастье в многодетности, ...");
            }
            if (slavanskiyKrug == 6 && itogoviyUroven == "ВЕРХНИЙ")
            {
                Console.WriteLine("6В - (СОСНА) - ЗАЩИТА БОГОВ, ЭНЕРГИЯ ПЕРЕМЕН,");
                Console.WriteLine("ТРАНСФОРМАЦИИ");
                Console.WriteLine("Дар: Смелость, решительность, чувство справедливости.  ...");
            }
            if (slavanskiyKrug == 6 && itogoviyUroven == "СРЕДНИЙ")
            {
                Console.WriteLine("6С - (ЛУК) - ЗАЩИТА В ЯВИ");
                Console.WriteLine("( В ОТНОШЕНИЯХ С ДРУГИМИ ЛЮДЬМИ)");
                Console.WriteLine("Дар: Слышать душу окружающих, чувствительность. ...");
            }
            if (slavanskiyKrug == 6 && itogoviyUroven == "НИЖНИЙ")
            {
                Console.WriteLine("6Н - (ТРОСТНИК) - ЗАЩИТА В НАВИ: ОТ РИСКА, ОТ НЕПРОЯВЛЕННОГО МИРА, ");
                Console.WriteLine("ЗАЩИТА РОДА, СЕМЬИ, ИМУЩЕСТВО И МАТЕРИАЛЬНЫХ ЦЕННОСТЕЙ");
                Console.WriteLine("Дар: Энергетическая защита. ...");
            }
            if (slavanskiyKrug == 7 && itogoviyUroven == "ВЕРХНИЙ")
            {
                Console.WriteLine("7В - (КУВШИНКА) - ЭНЕРГИЯ ОБНОВЛЕНИЯ");
                Console.WriteLine("Дар: Проницательность прозорливость, ясный ум. ...");
            }
            if (slavanskiyKrug == 7 && itogoviyUroven == "СРЕДНИЙ")
            {
                Console.WriteLine("7С - (ЧЕСНОК) - СМЕЛОСТЬ, ЕСТЕСТВЕННЫЙ ОГОНЬ, ");
                Console.WriteLine("АКТИВНОСТЬ, ДВИЖЕНИЕ, УДАЧА, ПРОНИЦАТЕЛЬНОСТЬ");
                Console.WriteLine("Дар: Удача, активность, умение находить гармонию во всем. ...");
            }
            if (slavanskiyKrug == 7 && itogoviyUroven == "НИЖНИЙ")
            {
                Console.WriteLine("7Н - (ЛИПА) - ПОДЗЕМНЫЙ ОГОНЬ, ");
                Console.WriteLine("ЭНЕРГИЯ РАЗРУШЕНИЯ, ОЧИЩЕНИЯ, УСТРАНЕНИЯ ПРЕГРАД");
                Console.WriteLine("Дар: Смелость, решительность, устранение препятствий, разрушения отжившего. ...");
            }
            if (slavanskiyKrug == 8 && itogoviyUroven == "ВЕРХНИЙ")
            {
                Console.WriteLine("8В - (ВАСИЛЕК) - ОЩУЩЕНИЕ СЕБЯ ЧАСТЬЮ ВСЕЛЕННОЙ");
                Console.WriteLine("Дар: Энергия миролюбия, бесконфликтности, правильных решений, удачи. ...");
            }
            if (slavanskiyKrug == 8 && itogoviyUroven == "СРЕДНИЙ")
            {
                Console.WriteLine("8С - (КАМЫШ) - ОТНОШЕНИЯ С РОДИТЕЛЯМИ, СТАРШИМ ПОКОЛЕНИЕМ,");
                Console.WriteLine("СЕМЕЙНАЯ МУДРОСТЬ И ПОЧИТАНИЕ");
                Console.WriteLine("Дар: Создание лада в семье, удача в любых вопросах связанных с семьей (Родом). ...");
            }
            if (slavanskiyKrug == 8 && itogoviyUroven == "НИЖНИЙ")
            {
                Console.WriteLine("8Н - (БЕРЕЗА) - ЦЕЛИТЕЛЬСТВО, СВЯЗЬ С УШЕДШИМИ ПРЕДКАМИ");
                Console.WriteLine("Дар: Целительство, здоровье. Есть дар исцелять людей - словом, делом. ...");
            }
            if (slavanskiyKrug == 9 && itogoviyUroven == "ВЕРХНИЙ")
            {
                Console.WriteLine("9В - (РОМАШКА) - ЭНЕРГИЯ ДУШЕВНОГО РАВНОВЕСИЯ");
                Console.WriteLine("Дар: Умиротворение, спокойствие, уверенность в завтрашнем дне. ...");
            }
            if (slavanskiyKrug == 9 && itogoviyUroven == "СРЕДНИЙ")
            {
                Console.WriteLine("9С - (ИВА) - ЭНЕРГИЯ МАТЕРИАЛЬНОГО РОСТА");
                Console.WriteLine("Дар: Способность увеличивать, развивать, способствовать росту. ...");
            }
            if (slavanskiyKrug == 9 && itogoviyUroven == "НИЖНИЙ")
            {
                Console.WriteLine("9Н - (ДУБ) - ЭНЕРГИЯ ДОСТАТКА - ");
                Console.WriteLine("(ЗЕМЛЛЯ В КВАДРАТЕ)");
                Console.WriteLine("Дар: Состояние стабильности, достаточности. ...");
            }



            Console.ReadKey();
        }
    }
}
