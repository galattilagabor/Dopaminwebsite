using ApiSample;
using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            var snaps = proxy.ProductsFindAll();

            for (int i = 0; i < snaps.Content.Count; i++)
            {
                var prodinv = proxy.ProductInventoryFindForProduct(snaps.Content[i].Bvin);
                listBox1.Items.Add(snaps.Content[i].ProductName);
                Termek termek = new Termek();
                termek.ID = i + 1;
                termek.Nev = snaps.Content[i].ProductName;
                termek.Mennyiseg = prodinv.Content[0].QuantityOnHand;
                termek.InventoryID = prodinv.Content[0].Bvin;

                termeklista.Add(termek);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Szures();
        }

        private void Szures()
        {
            List<string> szures = new List<string>();
            for (int i = 0; i < termeklista.Count; i++)
            {
                if (termeklista[i].Nev.StartsWith(textBox1.Text))
                {
                    szures.Add(termeklista[i].Nev);
                }
            }

            listBox1.DataSource = szures;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex + 1;
            textBox_mennyiseg.Text = (termeklista[index].Mennyiseg).ToString();
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
    }
}
