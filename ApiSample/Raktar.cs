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
using System.Runtime.InteropServices;
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

            ProductsInventory();

            pictureBox1.Refresh();
        }

        private void ProductsInventory()
        {
            ApiResponse<List<ProductDTO>> productsData = proxy.ProductsFindAll();

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

        private void textBox_kereses_TextChanged(object sender, EventArgs e)
        {
            string search = textBox_kereses.Text.ToLower();

            var filteredList = termeklista
                .Where(x => x.Nev.ToLower().Contains(search)).ToList();

            termekBindingSource.DataSource = filteredList;
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            var currentProduct = (Termek)termekBindingSource.Current;
            var Bvin = currentProduct.Bvin;
            var updatedProduct = proxy.ProductsFind(Bvin).Content;

            Modositas modositas = new Modositas();
            modositas.textBox_mennyiseg.Text = (from x in termeklista
                                                where x.Bvin == Bvin
                                                select x.Mennyiseg).FirstOrDefault().ToString();

            if (modositas.ShowDialog() == DialogResult.OK)
            {
                currentProduct.Mennyiseg = int.Parse(modositas.textBox_mennyiseg.Text);
                updatedProduct.MinimumQty = int.Parse(modositas.textBox_mennyiseg.Text);
                ApiResponse<ProductDTO> updateResponse = proxy.ProductsUpdate(updatedProduct);

                termekBindingSource.ResetBindings(false);
            }
            else
            {
                return;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var currentProduct = (Termek)termekBindingSource.Current;
            var deleteBvin = currentProduct.Bvin;

            var confirmDelete = MessageBox.Show(
                $"Biztosan törölni szeretnéd a(z) {currentProduct.Nev} nevű terméket?",
                "Igen",
                MessageBoxButtons.YesNo);

            if (confirmDelete == DialogResult.Yes)
            {
                ApiResponse<bool> productDeleteResponse = proxy.ProductsDelete(deleteBvin);

                if (productDeleteResponse != null)
                {

                    termekBindingSource.Remove(currentProduct);
                }
                else
                {
                    MessageBox.Show("A termék törlése sikertelen volt. Próbálja újra.");
                }
            }
            else
            {
                MessageBox.Show("A törlés megszakítva.");
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            // mentés hiányzik
            MessageBox.Show("Sikeres mentés!");
        }

        private void dataGridView_raktar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = ((Termek)termekBindingSource.Current).Bvin;
            textBox_SKU.Text = (from x in termeklista
                                where x.Bvin == current
                                select x.SKU).FirstOrDefault();
            textBox_nev.Text = (from x in termeklista
                                where x.Bvin == current
                                select x.Nev).FirstOrDefault();
            textBox_ar.Text = (from x in termeklista
                               where x.Bvin == current
                               select x.Ar).FirstOrDefault().ToString();
            textBox_mennyiseg.Text = (from x in termeklista
                                      where x.Bvin == current
                                      select x.Mennyiseg).FirstOrDefault().ToString();
            textBox_leiras.Text = (from x in termeklista
                                   where x.Bvin == current
                                   select x.Leiras).FirstOrDefault();
            textBox_tipus.Text = (from x in termeklista
                                  where x.Bvin == current
                                  select x.Tipus).FirstOrDefault();
            textBox_magassag.Text = (from x in termeklista
                                     where x.Bvin == current
                                     select x.Magassag).FirstOrDefault().ToString();
            textBox_szelesseg.Text = (from x in termeklista
                                      where x.Bvin == current
                                      select x.Szelesseg).FirstOrDefault().ToString();
            textBox_hosszusag.Text = (from x in termeklista
                                      where x.Bvin == current
                                      select x.Hosszusag).FirstOrDefault().ToString();
            textBox_suly.Text = (from x in termeklista
                                 where x.Bvin == current
                                 select x.Suly).FirstOrDefault().ToString();
            textBox_gyarto.Text = (from x in termeklista
                                   where x.Bvin == current
                                   select x.Gyarto).FirstOrDefault();
            textBox_elado.Text = (from x in termeklista
                                  where x.Bvin == current
                                  select x.Elado).FirstOrDefault();
            textBox_szallitasiMod.Text = (from x in termeklista
                                          where x.Bvin == current
                                          select x.SzallitasiMod).FirstOrDefault();
            textBox_nemSzallithato.Text = (from x in termeklista
                                           where x.Bvin == current
                                           select x.NemSzallithato).FirstOrDefault().ToString();
            textBox_kulonSzallithato.Text = (from x in termeklista
                                             where x.Bvin == current
                                             select x.KulonSzallihato).FirstOrDefault().ToString();
            textBox_szallitasiKoltseg.Text = (from x in termeklista
                                              where x.Bvin == current
                                              select x.SzallitasiAr).FirstOrDefault().ToString();
            textBox_velemenyek.Text = (from x in termeklista
                                       where x.Bvin == current
                                       select x.Velemenyek).FirstOrDefault().ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawLine(pen, 0, 10, 300, 10);
        }
    }
}
