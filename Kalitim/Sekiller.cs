using System;

namespace Kalitim
{
    public abstract class Sekiller
    {
        private char Sembol;
        private bool DoluMu;
        private DateTime OlusturmaTarihi;

        public Sekiller(char sembol)
        {

        }

        public Sekiller(char sembol, bool doluMu)
        {
        }

        public Sekiller()
        {

        }

        public void setSembol(char sembol)
        {
            Sembol = sembol;
        }

        public char getSembol()
        {
            return Sembol;
        }

        public void setDoluMu(bool doluMu)
        {
            DoluMu = doluMu;
        }

        public bool getDolumu()
        {
            return DoluMu;
        }

        public void setOlusturmaTarihi(DateTime tarih)
        {
            OlusturmaTarihi = tarih;
        }

        public DateTime getOlusturmaTarihi()
        {
            return OlusturmaTarihi;
        }

        public abstract double AlanHesapla();

        public abstract double CevreHesapla();

        public abstract void Ciz();

        public abstract void OzellikYazdir();
    }
}