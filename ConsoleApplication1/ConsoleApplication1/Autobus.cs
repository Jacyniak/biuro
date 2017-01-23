using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Autobus : SrodekLokomocji
    {
        public Autobus(int iloscMiejsc)
        {
            base.iloscMiejsc = iloscMiejsc;
            ObliczCene();
        }
        public override string ToString()
        {
            string temp = "Autobus: ilosc miejsc: "+ iloscMiejsc + ", cena biletu: "+ cenaBiletu;
            return temp;
        }
    }
}
