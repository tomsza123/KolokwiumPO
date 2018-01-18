using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Komputer:Elektronika
    {
        public Komputer(string marka, int numerSeryjny, string usterka)
        {
            this.marka = marka;
            this.numerSeryjny = numerSeryjny;
            this.usterka = usterka;
        }

        public override string ToString()
        {
            return ("Komputer :" + "Marka: " + marka + ", numer seryjny: " + numerSeryjny + ", usterka: " + usterka);
        }
    }
}
