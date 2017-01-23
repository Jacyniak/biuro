using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     abstract class SrodekLokomocji
    {

        protected double cenaBiletu;
        protected int iloscMiejsc;

        public SrodekLokomocji() { }

        public virtual void ObliczCene()
        {
            cenaBiletu = 50;
        }

        public double JakaCenaBiletu()
        {
            return this.cenaBiletu;
        }

    }
}
