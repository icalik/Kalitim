using System;

namespace Kalitim
{
    public class Ucgen : Sekiller
    {
        private double Kenar;

        public Ucgen(double kenar)
        {

        }

        public Ucgen()
        {

        }

        public void setKenar(double kenar)
        {
            Kenar = kenar;
        }

        public double getKenar()
        {
            return Kenar;
        }

        public override double AlanHesapla()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(Kenar, 2);
        }

        public override double CevreHesapla()
        {
            return Kenar * 3;
        }

        public override void Ciz()
        {

        }
        public override void OzellikYazdir()
        {

        }
    }
}