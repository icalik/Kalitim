using System;

namespace Kalitim
{
    class Program
    {



       public  void Menu()
        {
            int secim = 0;
            string[] secenekler = { "Dikdortgen", "Ucgen", "EskenarDortgen", "Paralelkenar", "Cikis" };
            for (int i = 1; i <= secenekler.Length; i++)
            {
                Console.WriteLine(i + "-) " + secenekler[i - 1]);
            }
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("---Dikdortgen---");
                    Program d1 = new Program();
                    d1.DikdortgenMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("---Ucgen---");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("---Eskenar Dortgen---");

                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("---Paralel Kenar---");

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

        private void ParalelKenarMenu() //Paralelkenar icin menu yordami
        {
            throw new NotImplementedException();
        }

        private void EskenarDortgenMenu() //Eskenardortgen icin menu yordami
        {
            throw new NotImplementedException();
        }

        private void UcgenMenu() //Ucgen icin menu yordami
        {
            throw new NotImplementedException();
        }

        public void DikdortgenMenu() //Dikdortgen icin menu yordami
        {
            int secim = 0;
            string[] secenekler = {
                "Alan Hesapla",
                "Cevre Hesapla",
                "Ciz",
                "Genislik Degistir",
                "Uzunluk Degistir",
                "Karekter Degistir",
                "Dolumu Degistir",
                "Bilgileri Yazdir",
                "Ust Menu",
                "Cikis"};
            for (int i = 1; i <= secenekler.Length; i++)
            {
                Console.WriteLine(i + "-) " + secenekler[i - 1]);
            }
            secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:

                    Console.WriteLine(d.AlanHesapla());

                    Console.WriteLine(d.getYukseklik());
                    Console.WriteLine(d.getGenislik());

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:
                    Console.Clear();
                    Menu();
                    break;
                case 10:
                    Console.WriteLine("Byee..");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

        }


        static void Main(string[] args)
        {
            Dikdortgen d = new Dikdortgen();
            Ucgen u = new Ucgen();
            EskenarDortgen e = new EskenarDortgen();
            ParalelKenar p = new ParalelKenar();
            Program varsayilan = new Program();
            //----Dikdortgen icin----
            d.setSembol('*');
            d.setDoluMu(true);
            d.setYukseklik(5);
            d.setGenislik(10);
            //----Ucgen icin----
            u.setSembol('*');
            u.setDoluMu(true);
            u.setKenar(5);
            //----EskenarDortgen icin----
            e.setSembol('*');
            e.setDoluMu(true);
            e.setYukseklik(5);
            e.setGenislik(5);
            //----Dikdortgen icin----
            p.setSembol('*');
            p.setDoluMu(true);
            p.setYukseklik(5);
            p.setGenislik(5);
            p.setYon(true);

            Menu();
        }

        

          
        
    }
}
