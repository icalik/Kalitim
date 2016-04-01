using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim
{
    public class ParalelKenar : Dikdortgen
    {
        private bool Yon;
        private double Genislik;
        private double Yukseklik;
        public ParalelKenar(bool yon)
        {

        }

        public ParalelKenar(double yukseklik, double genislik)
        {

        }

        public ParalelKenar(bool yon, double yukseklik, double genislik)
        {

        }

        public ParalelKenar()
        {

        }

        public bool getYon()
        {
            return Yon;
        }

        public void setYon(bool yon)
        {
            Yon = yon;
        }
        public new void setYukseklik(double yukseklik)
        {
            Yukseklik = yukseklik;
        }

        public new double getYukseklik()
        {
            return Yukseklik;
        }

        public new void setGenislik(double genislik)
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


        public new double getGenislik()
        {
            return Genislik;
        }

        public override void Ciz()
        {
        }
        public override void OzellikYazdir()
        {
            Console.WriteLine("Genisligi >> " + Genislik);
            Console.WriteLine("Yuksekligi >> " + Yukseklik);
            Console.WriteLine("Olusturma Tarihi >> " + getOlusturmaTarihi());
            Console.WriteLine("Yonu >> " + getYon());
            Console.WriteLine("Alani >> " + AlanHesapla());
            Console.WriteLine("Cevresi >> " + CevreHesapla());
        }

    }
}