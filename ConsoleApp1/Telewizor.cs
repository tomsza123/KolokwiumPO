using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Telewizor : Elektronika
    {
        
        public Telewizor(string marka,int numerSeryjny,string usterka)
        {
            this.marka = marka;
            this.numerSeryjny = numerSeryjny;
            this.usterka = usterka;
        }

        public override string ToString()
        {
            return ("Telewizor :" + "Marka: " + marka + ", numer seryjny: " + numerSeryjny + ", usterka: " + usterka);
        }

    }
}
