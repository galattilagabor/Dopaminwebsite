using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public string Tipus { get; set; }
        public decimal Magassag { get; set; }
        public decimal Szelesseg { get; set; }
        public decimal Hosszusag { get; set; }
        public decimal Suly { get; set; }
        public string Gyarto { get; set; }
        public string Elado { get; set; }
        public string SzallitasiMod { get; set; }
        public decimal SzallitasiAr { get; set; }
        public bool NemSzallithato { get; set; }
        public string InventoryID { get; set; }
    }
}
