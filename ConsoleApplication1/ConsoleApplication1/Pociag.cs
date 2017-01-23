using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pociag : SrodekLokomocji
    {
        private int dlugoscTrasy;
        public override void ObliczCene()
        {
            if (this.dlugoscTrasy > 100)
            {
                base.cenaBiletu = dlugoscTrasy * 1.43;
            }
            else
            {
                base.ObliczCene();
            }
        }
            public Pociag(int iloscMiejsc, int dlugoscTrasy)
        {
            base.iloscMiejsc = iloscMiejsc;
            this.dlugoscTrasy = dlugoscTrasy;
            this.ObliczCene();
        }
        public override string ToString()
        {
            return "Pociag: ilosc miejsc: " + iloscMiejsc + ", dlugosc trrasy: " + dlugoscTrasy + ", cena biletu: " + cenaBiletu; ;
        }
    }
}
