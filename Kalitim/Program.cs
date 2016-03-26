using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Program
    {
        static void Menu()
        {
            int secim = 0;
            string[] secenekler = { "Dikdortgen", "Ucgen", "EskenarDortgen", "Paralelkenar","Cikis" };
            for (int i = 1; i <= secenekler.Length; i++)
            {
                Console.WriteLine(i + "-) "+secenekler[i - 1]);
            }
            secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    DikdortgenMenu();
                    break;
                case 2:
                    UcgenMenu();
                    break;
                case 3:
                    EskenarDortgenMenu();
                    break;
                case 4:
                    ParalelKenarMenu();
                    break;
                case 5:
                    Console.WriteLine("Byee..");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Yanlis Secim Yapildi.");
                    break;
            }

        }

        private static void ParalelKenarMenu()
        {
            throw new NotImplementedException();
        }

        private static void EskenarDortgenMenu()
        {
            throw new NotImplementedException();
        }

        private static void UcgenMenu()
        {
            throw new NotImplementedException();
        }

        private static void DikdortgenMenu()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Menu();
        }

    }
}
