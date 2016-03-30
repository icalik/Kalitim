using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        }

        public override void OzellikYazdir()
        {
            
        }
    }
}