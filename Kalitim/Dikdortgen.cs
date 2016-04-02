using System;
namespace Kalitim
{
    public class Dikdortgen : Sekiller
    {
        private double Yukseklik;
        private double Genislik;

        public Dikdortgen(double yukseklik, double genislik)
        {

        }

        public Dikdortgen()
        {

        }


        public void setYukseklik(double yukseklik)
        {
            Yukseklik = yukseklik;
        }

        public double getYukseklik()
        {
            return Yukseklik;
        }

        public void setGenislik(double genislik)
        {
            Genislik = genislik;
        }

        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
        public override double CevreHesapla()
        {
            return (Genislik + Yukseklik) * 2;
        }


        public double getGenislik()
        {
            return Genislik;
        }

        public override void Ciz()
        {
            int arg1 = (int)Yukseklik;
            int arg2 = (int)Genislik;
            char ch = getSembol();
            if (!getDolumu())
            {
                for (int row = 1; row <= arg1; row++)
                {

                    if (row == 1 || row == arg1)
                    {
                        for (int col = 1; col <= arg2; col++)
                        {
                            Console.Write(ch);
                        }
                        Console.WriteLine();
                    }


                    if (row < arg1 && row < arg1 - 1)
                    {
                        Console.Write(ch);
                        for (int i = 0; i < arg2 - 2; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(ch);
                        Console.WriteLine();
                    }


                }
            }
            else
            {
                for (int row = 1; row <= Yukseklik; row++)
                {
                    for (int i = 1; i <= Genislik; i++)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                }


            }
            Console.ReadKey();
        }

        public override void OzellikYazdir()
        {
            Console.WriteLine("Genisligi >> " + Genislik);
            Console.WriteLine("Yuksekligi >> " + Yukseklik);
            Console.WriteLine("Olusturma Tarihi >> " + getOlusturmaTarihi());
            Console.WriteLine("Alani >> " + AlanHesapla());
            Console.WriteLine("Cevresi >> " + CevreHesapla());
            
        }

    }
}