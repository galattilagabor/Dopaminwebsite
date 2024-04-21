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
                termek.InventoryID = productsData.Content[i].Bvin;
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

            dataGridView_raktar.DataSource = termeklista;

            /*for (int i = 0; i < snaps.Content.Count; i++)
            {
                var prodinv = proxy.ProductInventoryFindForProduct(snaps.Content[i].Bvin);
                listBox1.Items.Add(snaps.Content[i].ProductName);
                Termek termek = new Termek();
                termek.ID = i + 1;
                termek.Nev = snaps.Content[i].ProductName;
                termek.Mennyiseg = prodinv.Content[0].QuantityOnHand;
                termek.InventoryID = prodinv.Content[0].Bvin;

                termeklista.Add(termek);
            }*/
        }

        /*
        private void Kereses()
        {
            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();

            var kereses = from x in proxy.ProductInventoryFindForProduct(response.Content[x].Bvin)
                          where .Contains(textBox_kereses.Text)
                          select x;

            listBoxNyersanyagok.DataSource = hv.ToList();
            listBoxNyersanyagok.DisplayMember = "NyersanyagNev";

            List<string> szures = new List<string>();
            for (int i = 0; i < termeklista.Count; i++)
            {
                if (termeklista[i].Nev.StartsWith(textBox_kereses.Text))
                {
                    szures.Add(termeklista[i].Nev);
                }
            }

            listBox1.DataSource = szures;
        }

        private void button_plus_Click_1(object sender, EventArgs e)
        {
            var z = int.Parse(textBox_mennyiseg.Text);
            z = z + 1;
            textBox_mennyiseg.Text = z.ToString();
        }

        private void button_minus_Click_1(object sender, EventArgs e)
        {
            var z = int.Parse(textBox_mennyiseg.Text);
            z = z - 1;
            textBox_mennyiseg.Text = z.ToString();
        }

        private void button_save_Click_1(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex + 1;
            var curproduct = termeklista[index];
            var inv = proxy.ProductInventoryFind(curproduct.InventoryID).Content;
            inv.QuantityOnHand = int.Parse(textBox_mennyiseg.Text);
            var response = proxy.ProductInventoryUpdate(inv);
        }
        */
    }
}
