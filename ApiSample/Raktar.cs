using ApiSample;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kliensalkalmazas
{
    public partial class Raktar : Form
    {
        static string url = "http://20.234.113.211:8104/";
        static string key = "1-41509684-cb1e-4c19-a11a-e930a10ec7a6";

        Api proxy = new Api(url, key);

        List<Termek> termeklista = new List<Termek>();

        public Raktar()
        {
            InitializeComponent();

            var productsData = proxy.ProductsFindAll();

            for (int i = 0; i < productsData.Content.Count; i++)
            {                
                Termek termek = new Termek();
                termek.ID = i + 1;
                termek.Bvin = productsData.Content[i].Bvin;
                termek.SKU = productsData.Content[i].Sku;
                termek.Nev = productsData.Content[i].ProductName;
                termek.Ar = productsData.Content[i].SitePrice;
                termek.Mennyiseg = productsData.Content[i].MinimumQty;
                termek.Leiras = productsData.Content[i].LongDescription;
                //termek.Tipus = response.Content[i];
                //termek.Magassag = response.Content[i].;
                //termek.Szelesseg = response.Content[i];
                //termek.Hosszusag = response.Content[i];
                //termek.Suly = response.Content[i];
                termek.Gyarto = productsData.Content[i].ManufacturerId;
                termek.Elado = productsData.Content[i].VendorId;
                termek.SzallitasiMod = productsData.Content[i].ShippingMode.ToString();
                //termek.NemSzallithato = response.Content[i];
                //termek.KulonSzallihato = response.Content[i];
                //termek.SzallitasiAr = response.Content[i];
                termek.Velemenyek = productsData.Content[i].AllowReviews;
                
                termeklista.Add(termek);
            }

            termekBindingSource.DataSource = termeklista;
        }
    }
}
