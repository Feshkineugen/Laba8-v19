using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using songgenre;

public class Program
{
    static void Main(string[] args)
    {
        isonggenre roz = new roz();
        isonggenre zar = new zar();
        isonggenre glaza = new glaza();
        isonggenre napos = new napos();
        isonggenre seni = new seni();
        isonggenre dush = new dush();


        Console.WriteLine("-------------------");
        Console.WriteLine("Привет друг, это программа для того чтобы найти нужную музыку по жанру, а также её текст,пожалуйста введи название своего жанра: ");
        Console.WriteLine("народная музыка");
        Console.WriteLine("романс");
        Console.WriteLine("классическая музыка");
        Console.WriteLine("-------------------");
        string answer = Console.ReadLine().ToLower();

        switch (answer)
        {
            case "народная музыка":
                Console.WriteLine("-------------------");
                Console.WriteLine("Выберете музыку из  списка:");
                Console.WriteLine("ах вы сени мои сени");
                Console.WriteLine("ах ты душечка");
                Console.WriteLine("-------------------");
                string songgenre = Console.ReadLine().ToLower();
                switch (songgenre)
                {
                    case "ах вы сени мои сени":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Текст этой песни: ");
                        seni.GetMusic();
                        Console.WriteLine("-------------------");
                        break;

                    case "ах ты душечка":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Текст этой песни: ");
                        dush.GetMusic();
                        Console.WriteLine("-------------------");
                        break;
                }
                break;
            case "романс":
                Console.WriteLine("-------------------");
                Console.WriteLine("Выберете музыку из списка:");
                Console.WriteLine("а напоследок я скажу");
                Console.WriteLine("ах эти чёрные глаза");
                Console.WriteLine("-------------------");
                string songgenre1 = Console.ReadLine().ToLower();
                switch (songgenre1)
                {
                    case "а напоследок я скажу":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Текст этой песни: ");
                        napos.GetMusic();
                        Console.WriteLine("-------------------");
                        break;

                    case "ах эти чёрные глаза":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Текст этой песни: ");
                        glaza.GetMusic();
                        Console.WriteLine("-------------------");
                        break;
                }
                break;
            case "классическая музыка":
                Console.WriteLine("-------------------");
                Console.WriteLine("Выберете музыку списка:");
                Console.WriteLine("елассические розы");
                Console.WriteLine("на заре ты её не буди");
                Console.WriteLine("-------------------");
                string songgenre2 = Console.ReadLine().ToLower();
                switch (songgenre2)
                {
                    case "классические розы":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Текст этой песни: ");
                        roz.GetMusic();
                        Console.WriteLine("-------------------");
                        break;

                    case "на заре ты её не буди":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Текст этой песни: ");
                        zar.GetMusic();
                        Console.WriteLine("-------------------");
                        break;
                }
                break;
        }

    }
}
