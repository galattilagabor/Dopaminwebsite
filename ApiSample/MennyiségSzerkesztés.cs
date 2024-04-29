using Kliensalkalmazas;
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
    public partial class MennyiségSzerkesztés : Form
    {
        public MennyiségSzerkesztés()
        {
            InitializeComponent();
          
            pictureBox1.Refresh();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox_mennyiseg.Text) > 0)
            {
                int mennyiseg = int.Parse(textBox_mennyiseg.Text);
                mennyiseg--;
                textBox_mennyiseg.Text = mennyiseg.ToString();
            }
            else
            {
                MessageBox.Show("Nem lehet negatív értékű a mennyiség!");
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            int mennyiseg = int.Parse(textBox_mennyiseg.Text);
            mennyiseg++;
            textBox_mennyiseg.Text = mennyiseg.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawLine(pen, 0, 10, 500, 10);
        }
    }
}
