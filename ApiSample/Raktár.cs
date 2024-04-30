using ApiSample;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Contacts;
using Hotcakes.CommerceDTO.v1.Shipping;
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
    public partial class Raktár : Form
    {
        static string url = "http://20.234.113.211:8104/";
        static string key = "1-41509684-cb1e-4c19-a11a-e930a10ec7a6";

        Api proxy = new Api(url, key);

        List<Termék> termeklista = new List<Termék>();

        public Raktár()
        {
            InitializeComponent();

            ProductsInventory();

            pictureBox1.Refresh();

            Design();
        }

        private void ProductsInventory()
        {
            ApiResponse<List<ProductDTO>> productsData = proxy.ProductsFindAll();

            for (int i = 0; i < productsData.Content.Count; i++)
            {
                var product = productsData.Content[i];

                ApiResponse<List<ProductInventoryDTO>> productInventory = proxy.ProductInventoryFindForProduct(product.Bvin);
                var inventory = productInventory.Content.FirstOrDefault();

                ApiResponse<List<CategorySnapshotDTO>> categories = proxy.CategoriesFindForProduct(product.Bvin);
                ApiResponse<VendorManufacturerDTO> vendors = proxy.VendorFind(product.VendorId);
                ApiResponse<VendorManufacturerDTO> manufactures = proxy.ManufacturerFind(product.ManufacturerId);

                Termék termek = new Termék();
                termek.ID = i + 1;
                termek.Bvin = product.Bvin;
                termek.SKU = product.Sku;
                termek.Nev = product.ProductName;
                termek.Ar = Math.Round(product.SitePrice);
                termek.Mennyiseg = int.Parse(inventory != null ? inventory.QuantityOnHand.ToString() : "0");
                termek.Tipus = categories.Content.FirstOrDefault()?.Name ?? "Nincs besorolva";
                termek.Magassag = Math.Round(product.ShippingDetails.Height);
                termek.Szelesseg = Math.Round(product.ShippingDetails.Width);
                termek.Hosszusag = Math.Round(product.ShippingDetails.Length);
                termek.Suly = Math.Round(product.ShippingDetails.Weight);
                termek.Gyarto = manufactures.Content.DisplayName;
                termek.Elado = vendors.Content.DisplayName;
                termek.SzallitasiMod = product.ShippingMode.ToString();
                termek.SzallitasiAr = Math.Round(product.ShippingDetails.ExtraShipFee);
                termek.NemSzallithato = product.ShippingDetails.IsNonShipping;
                termek.InventoryID = productInventory.Content[0].Bvin;

                termeklista.Add(termek);
            }

            termékBindingSource.DataSource = termeklista;
        }

        private void textBox_kereses_TextChanged(object sender, EventArgs e)
        {
            string search = textBox_kereses.Text.ToLower();

            var filteredList = termeklista
                .Where(x => x.Nev.ToLower().Contains(search)).ToList();

            termékBindingSource.DataSource = filteredList;
        }

        private void button_change_quantity_Click(object sender, EventArgs e)
        {
            var currentProduct = (Termék)termékBindingSource.Current;
            var Bvin = currentProduct.Bvin;

            ApiResponse<List<ProductInventoryDTO>> productInventory = proxy.ProductInventoryFindForProduct(Bvin);
            var inventory = productInventory.Content.FirstOrDefault();

            MennyiségSzerkesztés szerkesztés = new MennyiségSzerkesztés();
            szerkesztés.textBox_mennyiseg.Text = (from x in termeklista
                                                where x.Bvin == Bvin
                                                select x.Mennyiseg).FirstOrDefault().ToString();

            if (szerkesztés.ShowDialog() == DialogResult.OK)
            {
                textBox_mennyiseg.Text = szerkesztés.textBox_mennyiseg.Text;
                currentProduct.Mennyiseg = int.Parse(szerkesztés.textBox_mennyiseg.Text);
                inventory.QuantityOnHand = int.Parse(szerkesztés.textBox_mennyiseg.Text);
                ApiResponse<ProductInventoryDTO> response = proxy.ProductInventoryUpdate(inventory);

                termékBindingSource.ResetBindings(false);
            }
            else
            {
                return;
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            var currentProduct = (Termék)termékBindingSource.Current;
            var Bvin = currentProduct.Bvin;

            var product = proxy.ProductsFind(Bvin).Content;

            Módosítás módosítás = new Módosítás();
            módosítás.textBox_SKU.Text = currentProduct.SKU;
            módosítás.textBox_nev.Text = currentProduct.Nev;
            módosítás.textBox_ar.Text = currentProduct.Ar.ToString();
            módosítás.textBox_tipus.Text = currentProduct.Tipus;
            módosítás.textBox_magassag.Text = currentProduct.Magassag.ToString();
            módosítás.textBox_szelesseg.Text = currentProduct.Szelesseg.ToString();
            módosítás.textBox_hosszusag.Text = currentProduct.Hosszusag.ToString();
            módosítás.textBox_suly.Text = currentProduct.Suly.ToString();
            módosítás.textBox_gyarto.Text = currentProduct.Gyarto;
            módosítás.textBox_elado.Text = currentProduct.Elado;
            módosítás.textBox_szallitasiMod.Text = currentProduct.SzallitasiMod;
            módosítás.textBox_szallitasiKoltseg.Text = currentProduct.SzallitasiAr.ToString();
            módosítás.textBox_nemSzallithato.Text = currentProduct.NemSzallithato.ToString();

            if (módosítás.ShowDialog() == DialogResult.OK)
            {
                textBox_nev.Text = módosítás.textBox_nev.Text;
                textBox_ar.Text = módosítás.textBox_ar.Text;
                currentProduct.Nev = módosítás.textBox_nev.Text;
                currentProduct.Ar = int.Parse(módosítás.textBox_ar.Text);
                product.ProductName = módosítás.textBox_nev.Text;
                product.SitePrice = int.Parse(módosítás.textBox_ar.Text);

                ApiResponse<ProductDTO> response = proxy.ProductsUpdate(product);

                termékBindingSource.ResetBindings(false);
            }
            else
            {
                return;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var currentProduct = (Termék)termékBindingSource.Current;
            var deleteBvin = currentProduct.Bvin;

            ApiResponse<List<ProductInventoryDTO>> productInventory = proxy.ProductInventoryFindForProduct(currentProduct.Bvin);
            var inventory = productInventory.Content.FirstOrDefault();

            if (inventory.QuantityReserved != 0)
            {
                MessageBox.Show($"A(z) {currentProduct.Nev} nevű terméket nem lehet törölni, mivel le van foglalva!");
            }
            else
            {
                var confirmDelete = MessageBox.Show(
                    $"Biztosan törölni szeretnéd a(z) {currentProduct.Nev} nevű terméket?",
                    "Termék törlése",
                    MessageBoxButtons.YesNo);

                if (confirmDelete == DialogResult.Yes)
                {
                    ApiResponse<bool> productDeleteResponse = proxy.ProductsDelete(deleteBvin);

                    if (productDeleteResponse != null)
                    {

                        termékBindingSource.Remove(currentProduct);
                        MessageBox.Show($"A(z) {currentProduct.Nev} nevű termék törölve lett!");
                    }
                    else
                    {
                        MessageBox.Show("A termék törlése sikertelen volt. Próbálja újra.");
                    }
                }
            }            
        }

        private void button_out_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                            "Biztosan ki szeretnél lépni?",
                            "Kilépés",
                            MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView_raktar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = ((Termék)termékBindingSource.Current).Bvin;
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
            textBox_szallitasiKoltseg.Text = (from x in termeklista
                                              where x.Bvin == current
                                              select x.SzallitasiAr).FirstOrDefault().ToString();
            textBox_nemSzallithato.Text = (from x in termeklista
                                           where x.Bvin == current
                                           select x.NemSzallithato).FirstOrDefault().ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            e.Graphics.DrawLine(pen, 0, 10, 300, 10);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            //pictureBox2.Image = Image.FromFile("C:/Users/user/Desktop/egyetem/negyedik_félév/Rendszerfejlesztés/gyakorlat/Kliensalkalmazas/logó.png");
        }

        private void Design()
        {
            this.BackColor = Color.FromArgb(50, 50, 50);

            button_change_quantity.ForeColor = Color.FromArgb(50, 50, 50);
            button_change_quantity.BackColor = Color.White;
            button_change.ForeColor = Color.FromArgb(50, 50, 50);
            button_change.BackColor = Color.White;
            button_delete.ForeColor = Color.FromArgb(50, 50, 50);
            button_delete.BackColor = Color.White;
            button_out.ForeColor = Color.FromArgb(50, 50, 50);
            button_out.BackColor = Color.White;

            textBox_SKU.BackColor = Color.FromArgb(50, 50, 50);
            textBox_SKU.BorderStyle = BorderStyle.None;
            textBox_SKU.TextAlign = HorizontalAlignment.Right;
            textBox_nev.BackColor = Color.FromArgb(50, 50, 50);
            textBox_nev.BorderStyle = BorderStyle.None;
            textBox_nev.TextAlign = HorizontalAlignment.Right;
            textBox_ar.BackColor = Color.FromArgb(50, 50, 50);
            textBox_ar.BorderStyle = BorderStyle.None;
            textBox_ar.TextAlign = HorizontalAlignment.Right;
            textBox_mennyiseg.BackColor = Color.FromArgb(50, 50, 50);
            textBox_mennyiseg.BorderStyle = BorderStyle.None;
            textBox_mennyiseg.TextAlign = HorizontalAlignment.Right;
            textBox_tipus.BackColor = Color.FromArgb(50, 50, 50);
            textBox_tipus.BorderStyle = BorderStyle.None;
            textBox_tipus.TextAlign = HorizontalAlignment.Right;
            textBox_magassag.BackColor = Color.FromArgb(50, 50, 50);
            textBox_magassag.BorderStyle = BorderStyle.None;
            textBox_magassag.TextAlign = HorizontalAlignment.Right;
            textBox_szelesseg.BackColor = Color.FromArgb(50, 50, 50);
            textBox_szelesseg.BorderStyle = BorderStyle.None;
            textBox_szelesseg.TextAlign = HorizontalAlignment.Right;
            textBox_hosszusag.BackColor = Color.FromArgb(50, 50, 50);
            textBox_hosszusag.BorderStyle = BorderStyle.None;
            textBox_hosszusag.TextAlign = HorizontalAlignment.Right;
            textBox_suly.BackColor = Color.FromArgb(50, 50, 50);
            textBox_suly.BorderStyle = BorderStyle.None;
            textBox_suly.TextAlign = HorizontalAlignment.Right;
            textBox_gyarto.BackColor = Color.FromArgb(50, 50, 50);
            textBox_gyarto.BorderStyle = BorderStyle.None;
            textBox_gyarto.TextAlign = HorizontalAlignment.Right;
            textBox_elado.BackColor = Color.FromArgb(50, 50, 50);
            textBox_elado.BorderStyle = BorderStyle.None;
            textBox_elado.TextAlign = HorizontalAlignment.Right;
            textBox_szallitasiMod.BackColor = Color.FromArgb(50, 50, 50);
            textBox_szallitasiMod.BorderStyle = BorderStyle.None;
            textBox_szallitasiMod.TextAlign = HorizontalAlignment.Right;
            textBox_szallitasiKoltseg.BackColor = Color.FromArgb(50, 50, 50);
            textBox_szallitasiKoltseg.BorderStyle = BorderStyle.None;
            textBox_szallitasiKoltseg.TextAlign = HorizontalAlignment.Right;
            textBox_nemSzallithato.BackColor = Color.FromArgb(50, 50, 50);
            textBox_nemSzallithato.BorderStyle = BorderStyle.None;
            textBox_nemSzallithato.TextAlign = HorizontalAlignment.Right;

            dataGridView_raktar.GridColor = Color.FromArgb(192, 192, 192);
        }
    }
}
