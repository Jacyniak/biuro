using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static string coNacisnieto;
        public static Podroz nowyPlan = new Podroz();
        static void Main(string[] args)
        {
            Data();
            EkranStartowy();

        }
        public static void EkranStartowy()
        {
            Console.Write("Zaplanuj swoja podroz!" + Environment.NewLine
            + "[A] - dodaj autobus" + Environment.NewLine
            + "[P] - dodaj pociag" + Environment.NewLine
            + "[U] - usun ostatnie" + Environment.NewLine
            + "[Z] - pokaz plan" + Environment.NewLine
            + "[D] - sprawdz date" + Environment.NewLine);
            
            coNacisnieto = Console.ReadKey().Key.ToString();
            Console.WriteLine(Environment.NewLine);
            switch (coNacisnieto)
            {
                case ("A"):
                    {
                        DodajAutobus();
                        break;
                    }
                case ("a"):
                    {
                        DodajAutobus();
                        break;
                    }
                case ("P"):
                    {
                        DodajPociag();
                        break;
                    }
                case ("p"):
                    {
                        DodajPociag();
                        break;
                    }
                case ("U"):
                    {
                        UsunOstatni();
                        break;
                    }
                case ("u"):
                    {
                        UsunOstatni();
                        break;
                    }
                case ("Z"):
                    {
                        PokazPlan();
                        break;
                    }
                case ("z"):
                    {
                        PokazPlan();
                        break;
                    }
                case ("D"):
                    {
                        SprawdzDate();
                        break;
                    }
                case ("d"):
                    {
                        SprawdzDate();
                        break;
                    }

            }
            EkranStartowy();
        }
        public static void DodajAutobus()
        {
            Console.Clear();
            bool czyPodanoLiczbe = false;
            int liczba;
            Console.WriteLine("Dodawanie autobusu");
            do
            {
                Console.WriteLine("Podaj ilosc mijesc (liczba calkowita): ");

                if (Int32.TryParse(Console.ReadLine(), out liczba))
                {
                    czyPodanoLiczbe = true;
                }                
            } while (!czyPodanoLiczbe);
            
            nowyPlan.DodajAutobus(Convert.ToInt32(liczba));

        }
        public static void DodajPociag()
        {
            Console.Clear();
            bool czyPodanoLiczbe = false;
            bool czyPodanoLiczbe2 = false;
            int liczba;
            int liczba2;
            Console.WriteLine("Dodawanie pociagu");
            do
            {
                Console.WriteLine("Podaj ilosc mijesc (liczba calkowita): ");

                if (Int32.TryParse(Console.ReadLine(), out liczba))
                {
                    czyPodanoLiczbe = true;
                }
            } while (!czyPodanoLiczbe);
            do
            {
                Console.WriteLine("Podaj dlugos trasy (liczba calkowita): ");

                if (Int32.TryParse(Console.ReadLine(), out liczba2))
                {
                    czyPodanoLiczbe2 = true;
                }
            } while (!czyPodanoLiczbe2);

            nowyPlan.DodajPociag(Convert.ToInt32(liczba), Convert.ToInt32(liczba2));

        }
        public static void UsunOstatni()
        {
            nowyPlan.UsunOstatni();
            Console.WriteLine("Usunieto ostatni element");
        }
        public static void PokazPlan()
        {
            Console.WriteLine(nowyPlan.ToString());
        }
        public static void SprawdzDate()
        {
            if (nowyPlan.SprawdzDate())
            {
                Console.WriteLine("Data poprawna");
            }
            else
            {
                Console.WriteLine("Data niepoprawna");
            }
            
        }
        public static void Data()
        {
            bool x = false;
            
            DateTime data;
            do
            {
                Console.WriteLine("Podaj date (dd-MM-yyyy): ");
                if(DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out data))
                {
                    x = true;
                }
            } while (!x);
        }

    }
}
