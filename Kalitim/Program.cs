using System;

namespace Kalitim
{

    class Program
    {
        public static Dikdortgen d;
        public static Ucgen u;
        public static EskenarDortgen e;
        public static ParalelKenar p;

        public static void Menu()
        {
            byte secim = 0;
            string[] secenekler = { "Dikdortgen", "Ucgen", "EskenarDortgen", "Paralelkenar", "Cikis" };
            for (int i = 1; i <= secenekler.Length; i++)
            {
                Console.WriteLine(i + "-) " + secenekler[i - 1]);
            }
            secim = Convert.ToByte(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("---Dikdortgen---");
                    Console.Write("DikDortgenin Genisligini Giriniz >> ");
                    d.setGenislik(Convert.ToInt16(Console.ReadLine()));
                    Console.Write("DikDortgenin Yuksekligini Giriniz >> ");
                    d.setYukseklik(Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine();
                    DikdortgenMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("---Ucgen---");
                    Console.Write("Ucgenin Kenar Boyutunu Giriniz >> ");
                    u.setKenar(Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine();
                    UcgenMenu();
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
                    Console.WriteLine("Cikis..");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Yanlis Secim Yapildi.");
                    break;
            }

        }
        public static void ParalelKenarMenu() //Paralelkenar icin menu yordami
        {

        }
        public static void EskenarDortgenMenu() //Eskenardortgen icin menu yordami
        {

        }
        public static void UcgenMenu() //Ucgen icin menu yordami
        {
            Console.WriteLine(u.AlanHesapla());
        }
        public static void DikdortgenMenu() //Dikdortgen icin menu yordami
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
                    Console.Clear();
                    Console.WriteLine("Dikdortgenin Alani >>" + d.AlanHesapla());
                    DikdortgenMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Dikdortgenin Cevresi >>" + d.CevreHesapla());
                    DikdortgenMenu();
                    break;
                case 3:
                    Console.WriteLine("CIZ CALISACAK!"); //Sekil ciz
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Dikdortgenin Yeni Genisligini Giriniz >>");
                    d.setGenislik(Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine();
                    DikdortgenMenu();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Dikdortgenin Yeni Yuksekliginiz Giriniz >>");
                    d.setYukseklik(Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine();
                    DikdortgenMenu();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Dikdortgenin Karakterini Giriniz >>");
                    d.setSembol(Convert.ToChar(Console.ReadLine()));
                    Console.WriteLine();
                    DikdortgenMenu();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Dikdortgenin Doluluk Tipini Giriniz >>");
                    d.setDoluMu(Convert.ToBoolean(Console.ReadLine()));
                    Console.WriteLine();
                    DikdortgenMenu();
                    break;
                case 8:

                    break;
                case 9:
                    Console.Clear();
                    Menu();
                    break;
                case 10:
                    Console.WriteLine("Cikis..");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

        }
        static void Main(string[] args) //MAIN
        {
            varsayilanDegerler();
            Menu();
        }
        public static void varsayilanDegerler() //Varsayilan degerer atama
        {
            d = new Dikdortgen();
            u = new Ucgen();
            e = new EskenarDortgen();
            p = new ParalelKenar();
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
