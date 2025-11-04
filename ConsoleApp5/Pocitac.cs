using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2A_OOP2.Tridy
{

    public class Pocitac
    {
        public Pocitac(string procesor, string grafika, int ram)
        {
            Procesor = procesor;
            Grafika = grafika;
            RAM = ram;
        }

        public string Procesor { get; set; }
        public string Grafika { get; set; }
        public int RAM { get; set; }

        public void Zapnout()
        {
            Console.WriteLine("Zapínám počítač...");
        }
    }
}
