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
                    d.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
                    DikdortgenMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("---Ucgen---");
                    Console.Write("Ucgenin Kenar Boyutunu Giriniz >> ");
                    u.setKenar(Convert.ToInt16(Console.ReadLine()));
                    u.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
                    UcgenMenu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("---Eskenardortgen---");
                    Console.Write("Eskenardortgenin Genisligini Giriniz >> ");
                    e.setGenislik(Convert.ToInt16(Console.ReadLine()));
                    Console.Write("Eskenardortgenin Yuksekligini Giriniz >> ");
                    e.setYukseklik(Convert.ToInt16(Console.ReadLine()));
                    e.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
                    EskenarDortgenMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("---Paralel Kenar---");
                    Console.Write("Paralelkenar Genisligini Giriniz >> ");
                    p.setGenislik(Convert.ToInt16(Console.ReadLine()));
                    Console.Write("Paralelkenar Yuksekligini Giriniz >> ");
                    p.setYukseklik(Convert.ToInt16(Console.ReadLine()));
                    p.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
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
        public static void ParalelKenarMenu() //Paralelkenar icin menu yordami
        {
            int secim = 0;
            string[] secenekler = {
                "Alan Hesapla",
                "Cevre Hesapla",
                "Ciz",
                "Genislik Degistir",
                "Uzunluk Degistir",
                "Yon Degistir",
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
                    Console.WriteLine("Paralelkenar Alani >>" + p.AlanHesapla());
                    ParalelKenarMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Paralelkenar Cevresi >>" + p.CevreHesapla());
                    ParalelKenarMenu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("CIZ CALISACAK!"); //Sekil ciz
                    ParalelKenarMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Paralelkenar Yeni Genisligini Giriniz >>"); //Yeni Genislik
                    p.setGenislik(Convert.ToInt16(Console.ReadLine()));
                    p.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
                    ParalelKenarMenu();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Paralelkenar Yeni Yuksekliginiz Giriniz >>"); //Yeni Yukseklik
                    p.setYukseklik(Convert.ToInt16(Console.ReadLine()));
                    p.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
                    ParalelKenarMenu();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Paralelkenar Yonunu Giriniz >>"); //Yeni Yon
                    p.setYon(Convert.ToBoolean(Console.ReadLine()));
                    p.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
                    ParalelKenarMenu();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Paralelkenar Karakterini Giriniz >>");
                    p.setSembol(Convert.ToChar(Console.ReadLine()));
                    Console.WriteLine();
                    ParalelKenarMenu();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Paralelkenar Doluluk Tipini Giriniz >>");
                    p.setDoluMu(Convert.ToBoolean(Console.ReadLine()));
                    Console.WriteLine();
                    ParalelKenarMenu();
                    break;
                case 9:
                    Console.Clear();//Bilgileri yazdirma
                    Console.WriteLine("---Paralelkenar Bilgiler---");
                    p.OzellikYazdir();
                    Console.WriteLine("Doluluk Durumu >>" + p.getDolumu());
                    Console.WriteLine("Sembolu >> " + p.getSembol());
                    Console.WriteLine();
                    ParalelKenarMenu();
                    break;
                case 10:
                    Console.Clear();
                    Menu();
                    break;
                case 11:
                    Console.WriteLine("Byee..");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Yanlis secim!");
                    Console.ReadLine();
                    break;
            }
        }
        public static void EskenarDortgenMenu() //Eskenardortgen icin menu yordami
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
                    Console.WriteLine("Eskenardortgenin Alani >> " + e.AlanHesapla());
                    EskenarDortgenMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Eskenardortgenin Cevresi >>" + e.CevreHesapla());
                    EskenarDortgenMenu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("CIZ CALISACAK!"); //Sekil ciz
                    EskenarDortgenMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Eskenardortgenin Yeni Genisligini Giriniz >>"); //Yeni Genislik
                    e.setGenislik(Convert.ToInt16(Console.ReadLine()));
                    e.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
                    EskenarDortgenMenu();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Eskenardortgenin Yeni Yuksekliginiz Giriniz >>"); //Yeni Yukseklik
                    e.setYukseklik(Convert.ToInt16(Console.ReadLine()));
                    e.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
                    EskenarDortgenMenu();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Eskenardortgenin Karakterini Giriniz >>");
                    e.setSembol(Convert.ToChar(Console.ReadLine()));
                    Console.WriteLine();
                    EskenarDortgenMenu();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Eskenardortgenin Doluluk Tipini Giriniz >>");
                    e.setDoluMu(Convert.ToBoolean(Console.ReadLine()));
                    Console.WriteLine();
                    EskenarDortgenMenu();
                    break;
                case 8:
                    Console.Clear();//Bilgileri yazdirma
                    Console.WriteLine("---Eskenardortgen Bilgiler---");
                    e.OzellikYazdir();
                    Console.WriteLine("Doluluk Durumu >>" + e.getDolumu());
                    Console.WriteLine("Sembolu >> " + e.getSembol());
                    Console.WriteLine();
                    EskenarDortgenMenu();
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
                    Console.WriteLine("Yanlis secim!");
                    Console.ReadLine();
                    break;
            }
        }
        public static void UcgenMenu() //Ucgen icin menu yordami
        {
            int secim = 0;
            string[] secenekler = {
                "Alan Hesapla",
                "Cevre Hesapla",
                "Ciz",
                "Kenar Degistir",
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
                    Console.WriteLine("Ucgenin Alani >>" + u.AlanHesapla());
                    UcgenMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ucgenin Cevresi >>" + u.CevreHesapla());
                    UcgenMenu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("CIZ CALISACAK!"); //Sekil ciz
                    UcgenMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Ucgenin Yeni Kenarini Giriniz >>"); //Yeni Kenar
                    u.setKenar(Convert.ToInt16(Console.ReadLine()));
                    u.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
                    UcgenMenu();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Ucgenin Karakterini Giriniz >>");
                    u.setSembol(Convert.ToChar(Console.ReadLine()));
                    Console.WriteLine();
                    UcgenMenu();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Ucgenin Doluluk Tipini Giriniz >>");
                    u.setDoluMu(Convert.ToBoolean(Console.ReadLine()));
                    Console.WriteLine();
                    UcgenMenu();
                    break;
                case 7:
                    Console.Clear();//Bilgileri yazdirma
                    Console.WriteLine("---Ucgen Bilgiler---");
                    u.OzellikYazdir();
                    Console.WriteLine("Doluluk Durumu >> "+u.getDolumu());
                    Console.WriteLine("Sembol >> " + u.getSembol());
                    Console.WriteLine();
                    UcgenMenu();
                    break;
                case 8:
                    Console.Clear();
                    Menu();
                    break;
                case 9:
                    Console.WriteLine("Byee..");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Yanlis secim!");
                    Console.ReadLine();
                    break;
            }
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
                    Console.Clear();
                    Console.WriteLine("CIZ CALISACAK!"); //Sekil ciz
                    DikdortgenMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Dikdortgenin Yeni Genisligini Giriniz >>"); //Yeni Genislik
                    d.setGenislik(Convert.ToInt16(Console.ReadLine()));
                    d.setOlusturmaTarihi(DateTime.Now);
                    Console.WriteLine();
                    DikdortgenMenu();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Dikdortgenin Yeni Yuksekliginiz Giriniz >>"); //Yeni Yukseklik
                    d.setYukseklik(Convert.ToInt16(Console.ReadLine()));
                    d.setOlusturmaTarihi(DateTime.Now);
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
                    Console.Clear();//Bilgileri yazdirma
                    Console.WriteLine("---Dikdortgen Bilgiler---");
                    d.OzellikYazdir();
                    Console.WriteLine("Doluluk Durumu >>" + d.getDolumu());
                    Console.WriteLine("Sembolu >> " + d.getSembol());
                    Console.WriteLine();
                    DikdortgenMenu();
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
                    Console.WriteLine("Yanlis secim!");
                    Console.ReadLine();
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
            d = new Dikdortgen(); //Dikdortgen object
            u = new Ucgen(); //Ucgen object
            e = new EskenarDortgen(); //EskenarDortgen object
            p = new ParalelKenar(); //Paralelkenar object
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
            p.setYukseklik(8);
            p.setGenislik(8);
            p.setYon(true);
        }


    }
}
