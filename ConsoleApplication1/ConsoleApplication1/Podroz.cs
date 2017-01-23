using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Podroz : IData, IZarzadzaj
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy = new List<SrodekLokomocji>();
        private double koszt = 0;
        public void UstawDate(DateTime data)
        {
            dataPodrozy = data;
        }
        public bool SprawdzDate()
        {
            if(dataPodrozy>DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DodajAutobus(int iloscMiejsc)
        {
            planPodrozy.Add(new Autobus(iloscMiejsc));
            koszt += planPodrozy.Last().JakaCenaBiletu();
        }
        public void DodajPociag(int iloscMiejsc, int dlugoscTrasy)
        {
            planPodrozy.Add(new Pociag(iloscMiejsc,dlugoscTrasy));
            koszt += planPodrozy.Last().JakaCenaBiletu();
        }
        public void UsunOstatni()
        {
            if (planPodrozy.Count > 0)
            {
                planPodrozy.RemoveAt(planPodrozy.Count - 1);
            }else
            {
                Console.WriteLine("Plan pusty");
            }
            

        }
        public void Wyczysc()
        {
            planPodrozy.Clear();
        }
        public override string ToString()
        {
            string temp = "";
            foreach (Object obj in planPodrozy)
            {
                temp += obj.ToString() + Environment.NewLine;
            }
            return temp;
        }

    }
}
