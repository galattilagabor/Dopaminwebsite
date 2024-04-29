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
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawLine(pen, 0, 10, 300, 10);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
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
    }
}
