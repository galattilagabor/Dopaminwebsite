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

            Design();
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
            Pen pen = new Pen(Color.White);
            e.Graphics.DrawLine(pen, 0, 10, 500, 10);
        }


        private void Design()
        {
            this.BackColor = Color.FromArgb(50, 50, 50);

            button_minus.ForeColor = Color.FromArgb(50, 50, 50);
            button_minus.BackColor = Color.White;
            button_plus.ForeColor = Color.FromArgb(50, 50, 50);
            button_plus.BackColor = Color.White;
            button_save.ForeColor = Color.FromArgb(50, 50, 50);
            button_save.BackColor = Color.White;
            button_out.ForeColor = Color.FromArgb(50, 50, 50);
            button_out.BackColor =  Color.White;

            textBox_mennyiseg.BackColor = Color.FromArgb(50, 50, 50);
            textBox_mennyiseg.BorderStyle = BorderStyle.None;
            textBox_mennyiseg.TextAlign = HorizontalAlignment.Center;
        }
    }
}
