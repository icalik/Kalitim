using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim
{
    public abstract class Sekiller
    {
        private char Sembol;
        private bool DoluMu;
        private DateTime OlusturmaTarihi;

        public Sekiller(char sembol)
        {
            throw new System.NotImplementedException();
        }

        public Sekiller(char sembol, bool doluMu)
        {
            throw new System.NotImplementedException();
        }

        public Sekiller()
        {
            throw new System.NotImplementedException();
        }

        public void setSembol(char sembol)
        {
            throw new System.NotImplementedException();
        }

        public char getSembol()
        {
            throw new System.NotImplementedException();
        }

        public void setDoluMu(bool doluMu)
        {
            throw new System.NotImplementedException();
        }

        public bool getDolumu()
        {
            throw new System.NotImplementedException();
        }

        private void setOlusturmaTarihi(DateTime tarih)
        {
            throw new System.NotImplementedException();
        }

        public DateTime getOlusturmaTarihi()
        {
            throw new System.NotImplementedException();
        }

        public abstract double AlanHesapla();

        public abstract double CevreHesapla();

        public abstract void Ciz();

        public abstract void OzellikYazdir();
    }
}