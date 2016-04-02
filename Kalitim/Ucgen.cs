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
            int k = (int) getKenar();
            char ch = getSembol();
            bool dolu = getDolumu();
            char dl = ' ';
            if (dolu)
            {
                dl = ch;
            }
            int n = k - 1;
            int x = 2 * (k - 1) + 1;
            for (int p = 0; p <= n; p++)
            {
                for (int j = k - 1; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i <= (x - 2 * (k - 1)); i++)
                {
                    if ((i % 2 == 1 && i == 1) || (i % 2 == 1 && i == (x - 2 * (k - 1))) || (i % 2 == 1 && p == n))
                    {
                        Console.Write(ch);
                    }
                    else
                    {
                        Console.Write(dl);
                    }
                }
                Console.WriteLine();
                k--;
            }
        }
        public override void OzellikYazdir()
        {
     
            Console.WriteLine("Ucgenin Kenari >> " + Kenar);
            Console.WriteLine("Ucgenin Olusturma Tarihi >> " + getOlusturmaTarihi());
            Console.WriteLine("Ucgenin Alani >> " + AlanHesapla());
            Console.WriteLine("Ucgenin Cevresi >> " + CevreHesapla());
        }
    }
}