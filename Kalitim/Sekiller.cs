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

        }

        public char getSembol()
        {
            return Sembol;
        }

        public void setDoluMu(bool doluMu)
        {

        }

        public bool getDolumu()
        {
            return DoluMu;
        }

        private void setOlusturmaTarihi(DateTime tarih)
        {

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