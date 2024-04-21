using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample
{
    internal class Termek
    {
        public int ID { get; set; }
        public string Bvin { get; set; }
        public string SKU { get; set; }
        public string Nev { get; set; }
        public decimal Ar { get; set; }
        public int Mennyiseg { get; set; }
        public string Leiras { get; set; }
        public string Tipus { get; set; }
        public double Magassag { get; set; }
        public double Szelesseg { get; set; }
        public double Hosszusag { get; set; }
        public double Suly { get; set; }
        public string Gyarto { get; set; }
        public string Elado { get; set; }
        public string SzallitasiMod { get; set; }
        public bool NemSzallithato { get; set; }
        public bool KulonSzallihato { get; set; }
        public double SzallitasiAr { get; set; }
        public bool? Velemenyek { get; set; }
    }
}
