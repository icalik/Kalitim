using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim
{
    public class ParalelKenar : Dikdortgen
    {
        private bool Yon;

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
    }
}