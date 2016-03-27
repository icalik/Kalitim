using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim
{
    public class Ucgen : Sekiller
    {
        private double Kenar;

        public Ucgen(double kenar)
        {
            throw new System.NotImplementedException();
        }

        public Ucgen()
        {
            throw new System.NotImplementedException();
        }

        public void setKenar(double kenar)
        {
            Kenar = kenar;
        }

        public double getKenar()
        {
            return Kenar;
        }
    }
}