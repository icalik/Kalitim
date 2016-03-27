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
            throw new System.NotImplementedException();
        }

        public Dikdortgen()
        {
            throw new System.NotImplementedException();
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

        public double getGenislik()
        {
            return Genislik;
        }
    }
}