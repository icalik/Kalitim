using System;

namespace Kalitim
{
    class Program
    {
        static void Menu()
        {
            int secim = 0;
            string[] secenekler = { "Dikdortgen", "Ucgen", "EskenarDortgen", "Paralelkenar", "Cikis" };
            for (int i = 1; i <= secenekler.Length; i++)
            {
                Console.WriteLine(i + "-) " + secenekler[i - 1]);
            }
            secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("---Dikdortgen---");
                    DikdortgenMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("---Ucgen---");
                    UcgenMenu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("---Eskenar Dortgen---");
                    EskenarDortgenMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("---Paralel Kenar---");
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

        private static void ParalelKenarMenu() //Paralelkenar icin menu yordami
        {
            throw new NotImplementedException();
        }

        private static void EskenarDortgenMenu() //Eskenardortgen icin menu yordami
        {
            throw new NotImplementedException();
        }

        private static void UcgenMenu() //Ucgen icin menu yordami
        {
            throw new NotImplementedException();
        }

        private static void DikdortgenMenu() //Dikdortgen icin menu yordami
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
                    DikdortgenAlanHesapla();
                    break;
                case 2:
                    DikdortgenCevreHesapla();
                    break;
                case 3:
                    DikdortgenCiz();
                    break;
                case 4:
                    DikdortgenGenislikDegistir();
                    break;
                case 5:
                    DikdortgenUzunlukDegistir();
                    break;
                case 6:
                    DikdortgenKarakterDegistir();
                    break;
                case 7:
                    DikdortgenDolumuDegistir();
                    break;
                case 8:
                    DikdortgenBilgileriYazdir();
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

        private static void DikdortgenBilgileriYazdir()
        {
            throw new NotImplementedException();
        }

        private static void DikdortgenDolumuDegistir()
        {
            throw new NotImplementedException();
        }

        private static void DikdortgenKarakterDegistir()
        {
            throw new NotImplementedException();
        }

        private static void DikdortgenUzunlukDegistir()
        {
            throw new NotImplementedException();
        }

        private static void DikdortgenGenislikDegistir()
        {
            throw new NotImplementedException();
        }

        private static void DikdortgenCiz()
        {
            throw new NotImplementedException();
        }

        private static void DikdortgenCevreHesapla()
        {
            throw new NotImplementedException();
        }

        private static void DikdortgenAlanHesapla()
        {
            
        }

        static void Main(string[] args)
        {
            varsayilanDegerler();
            Menu();
        }

        private static void varsayilanDegerler()
        {
            Dikdortgen d = new Dikdortgen();
            Ucgen u = new Ucgen();
            EskenarDortgen e = new EskenarDortgen();
            ParalelKenar p = new ParalelKenar();
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
        }
    }
}
