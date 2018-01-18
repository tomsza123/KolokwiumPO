using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Serwis : ISerwis
    {
        private LinkedList<Elektronika> doNaprawy = new LinkedList<Elektronika>();
        private LinkedList<Komputer> komputery = new LinkedList<Komputer>();

        

        public void DodajTelewizor(string marka, int numerSeryjny, string usterka)
        {
            doNaprawy.AddFirst(new Telewizor(marka, numerSeryjny, usterka));            
        }

        public void DodajKomputer(string marka, int numerSeryjny, string usterka)
        {
            doNaprawy.AddFirst(new Komputer(marka, numerSeryjny, usterka));
        }

        /*public override string ToString()
        {
            
        }*/

        public void Napraw(int numerSeryjny)
        {
            
            
        }

        public void Napraw()
        {
            doNaprawy.RemoveFirst();
        }

        public void Polacz()
        {
            //doNaprawy.AddLast(Elektronika);
        }

        public void Podziel()
        {
            //doNaprawy.Remove();
        }
    }
}
