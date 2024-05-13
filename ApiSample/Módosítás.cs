using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiSample
{
    public partial class Módosítás : Form
    {
        public Módosítás()
        {
            InitializeComponent();

            pictureBox1.Refresh();

            Design();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            e.Graphics.DrawLine(pen, 0, 10, 300, 10);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Sikeres mentés!");
                this.Close();
            }
        }

        private bool CheckName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }

        private bool CheckPrice(string price)
        {
            double output;
            return double.TryParse(price, out output);
        }

        private void textBox_nev_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBox_nev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_nev, "A név nem lehet üres!");
            }
        }

        private void textBox_nev_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_nev, "");
        }

        private void textBox_ar_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPrice(textBox_ar.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_ar, "Nem számot írt be!");
            }
        }

        private void textBox_ar_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_ar, "");
        }

        private void Design()
        {
            this.BackColor = Color.FromArgb(50, 50, 50);

            button_save.ForeColor = Color.FromArgb(50, 50, 50);
            button_save.BackColor = Color.White;
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
        }
    }
}
