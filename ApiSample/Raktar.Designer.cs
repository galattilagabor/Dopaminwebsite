namespace Kliensalkalmazas
{
    partial class Raktar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_kereses = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView_raktar = new System.Windows.Forms.DataGridView();
            this.termekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_SKU = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_ár = new System.Windows.Forms.TextBox();
            this.textBox_mennyiseg = new System.Windows.Forms.TextBox();
            this.textBox_leiras = new System.Windows.Forms.TextBox();
            this.textBox_tipus = new System.Windows.Forms.TextBox();
            this.textBox_magassag = new System.Windows.Forms.TextBox();
            this.textBox_szelesseg = new System.Windows.Forms.TextBox();
            this.textBox_hosszusag = new System.Windows.Forms.TextBox();
            this.textBox_suly = new System.Windows.Forms.TextBox();
            this.textBox_gyarto = new System.Windows.Forms.TextBox();
            this.textBox_elado = new System.Windows.Forms.TextBox();
            this.textBox_szallitasiMod = new System.Windows.Forms.TextBox();
            this.textBox_nemSzallithato = new System.Windows.Forms.TextBox();
            this.textBox_kulonSzallithato = new System.Windows.Forms.TextBox();
            this.textBox_szallitasiKoltseg = new System.Windows.Forms.TextBox();
            this.textBox_velemenyek = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_raktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_kereses
            // 
            this.textBox_kereses.Location = new System.Drawing.Point(30, 125);
            this.textBox_kereses.Name = "textBox_kereses";
            this.textBox_kereses.Size = new System.Drawing.Size(300, 20);
            this.textBox_kereses.TabIndex = 1;
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(551, 42);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(75, 23);
            this.button_plus.TabIndex = 3;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(644, 42);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(75, 23);
            this.button_minus.TabIndex = 4;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(937, 42);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Mentés";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // dataGridView_raktar
            // 
            this.dataGridView_raktar.AutoGenerateColumns = false;
            this.dataGridView_raktar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_raktar.DataSource = this.termekBindingSource;
            this.dataGridView_raktar.Location = new System.Drawing.Point(356, 97);
            this.dataGridView_raktar.Name = "dataGridView_raktar";
            this.dataGridView_raktar.Size = new System.Drawing.Size(656, 542);
            this.dataGridView_raktar.TabIndex = 6;
            // 
            // termekBindingSource
            // 
            this.termekBindingSource.DataSource = typeof(ApiSample.Termek);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "SKU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mennyiség";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Leírás";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Termék típus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Magasság";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Szélesség";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Hosszúság";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Súly";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Gyártó";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Eladó";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 518);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Szállítási mód";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 544);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Nem szállítható termék";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 570);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Külön dobozban szállítható";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 596);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Szállítási költség";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 622);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Vélemények engedélyezve vannak";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F);
            this.label18.Location = new System.Drawing.Point(130, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 15);
            this.label18.TabIndex = 24;
            this.label18.Text = "Termékinformációk";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 25);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_SKU
            // 
            this.textBox_SKU.Location = new System.Drawing.Point(230, 203);
            this.textBox_SKU.Name = "textBox_SKU";
            this.textBox_SKU.Size = new System.Drawing.Size(100, 20);
            this.textBox_SKU.TabIndex = 26;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(230, 229);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(100, 20);
            this.textBox_nev.TabIndex = 27;
            // 
            // textBox_ár
            // 
            this.textBox_ár.Location = new System.Drawing.Point(230, 255);
            this.textBox_ár.Name = "textBox_ár";
            this.textBox_ár.Size = new System.Drawing.Size(100, 20);
            this.textBox_ár.TabIndex = 28;
            // 
            // textBox_mennyiseg
            // 
            this.textBox_mennyiseg.Location = new System.Drawing.Point(230, 281);
            this.textBox_mennyiseg.Name = "textBox_mennyiseg";
            this.textBox_mennyiseg.Size = new System.Drawing.Size(100, 20);
            this.textBox_mennyiseg.TabIndex = 29;
            // 
            // textBox_leiras
            // 
            this.textBox_leiras.Location = new System.Drawing.Point(230, 307);
            this.textBox_leiras.Name = "textBox_leiras";
            this.textBox_leiras.Size = new System.Drawing.Size(100, 20);
            this.textBox_leiras.TabIndex = 30;
            // 
            // textBox_tipus
            // 
            this.textBox_tipus.Location = new System.Drawing.Point(230, 333);
            this.textBox_tipus.Name = "textBox_tipus";
            this.textBox_tipus.Size = new System.Drawing.Size(100, 20);
            this.textBox_tipus.TabIndex = 31;
            // 
            // textBox_magassag
            // 
            this.textBox_magassag.Location = new System.Drawing.Point(230, 359);
            this.textBox_magassag.Name = "textBox_magassag";
            this.textBox_magassag.Size = new System.Drawing.Size(100, 20);
            this.textBox_magassag.TabIndex = 32;
            // 
            // textBox_szelesseg
            // 
            this.textBox_szelesseg.Location = new System.Drawing.Point(230, 385);
            this.textBox_szelesseg.Name = "textBox_szelesseg";
            this.textBox_szelesseg.Size = new System.Drawing.Size(100, 20);
            this.textBox_szelesseg.TabIndex = 33;
            // 
            // textBox_hosszusag
            // 
            this.textBox_hosszusag.Location = new System.Drawing.Point(230, 411);
            this.textBox_hosszusag.Name = "textBox_hosszusag";
            this.textBox_hosszusag.Size = new System.Drawing.Size(100, 20);
            this.textBox_hosszusag.TabIndex = 34;
            // 
            // textBox_suly
            // 
            this.textBox_suly.Location = new System.Drawing.Point(230, 437);
            this.textBox_suly.Name = "textBox_suly";
            this.textBox_suly.Size = new System.Drawing.Size(100, 20);
            this.textBox_suly.TabIndex = 35;
            // 
            // textBox_gyarto
            // 
            this.textBox_gyarto.Location = new System.Drawing.Point(230, 463);
            this.textBox_gyarto.Name = "textBox_gyarto";
            this.textBox_gyarto.Size = new System.Drawing.Size(100, 20);
            this.textBox_gyarto.TabIndex = 36;
            // 
            // textBox_elado
            // 
            this.textBox_elado.Location = new System.Drawing.Point(230, 489);
            this.textBox_elado.Name = "textBox_elado";
            this.textBox_elado.Size = new System.Drawing.Size(100, 20);
            this.textBox_elado.TabIndex = 37;
            // 
            // textBox_szallitasiMod
            // 
            this.textBox_szallitasiMod.Location = new System.Drawing.Point(230, 515);
            this.textBox_szallitasiMod.Name = "textBox_szallitasiMod";
            this.textBox_szallitasiMod.Size = new System.Drawing.Size(100, 20);
            this.textBox_szallitasiMod.TabIndex = 38;
            // 
            // textBox_nemSzallithato
            // 
            this.textBox_nemSzallithato.Location = new System.Drawing.Point(230, 541);
            this.textBox_nemSzallithato.Name = "textBox_nemSzallithato";
            this.textBox_nemSzallithato.Size = new System.Drawing.Size(100, 20);
            this.textBox_nemSzallithato.TabIndex = 39;
            // 
            // textBox_kulonSzallithato
            // 
            this.textBox_kulonSzallithato.Location = new System.Drawing.Point(230, 567);
            this.textBox_kulonSzallithato.Name = "textBox_kulonSzallithato";
            this.textBox_kulonSzallithato.Size = new System.Drawing.Size(100, 20);
            this.textBox_kulonSzallithato.TabIndex = 40;
            // 
            // textBox_szallitasiKoltseg
            // 
            this.textBox_szallitasiKoltseg.Location = new System.Drawing.Point(230, 593);
            this.textBox_szallitasiKoltseg.Name = "textBox_szallitasiKoltseg";
            this.textBox_szallitasiKoltseg.Size = new System.Drawing.Size(100, 20);
            this.textBox_szallitasiKoltseg.TabIndex = 41;
            // 
            // textBox_velemenyek
            // 
            this.textBox_velemenyek.Location = new System.Drawing.Point(230, 619);
            this.textBox_velemenyek.Name = "textBox_velemenyek";
            this.textBox_velemenyek.Size = new System.Drawing.Size(100, 20);
            this.textBox_velemenyek.TabIndex = 42;
            // 
            // Raktar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.textBox_velemenyek);
            this.Controls.Add(this.textBox_szallitasiKoltseg);
            this.Controls.Add(this.textBox_kulonSzallithato);
            this.Controls.Add(this.textBox_nemSzallithato);
            this.Controls.Add(this.textBox_szallitasiMod);
            this.Controls.Add(this.textBox_elado);
            this.Controls.Add(this.textBox_gyarto);
            this.Controls.Add(this.textBox_suly);
            this.Controls.Add(this.textBox_hosszusag);
            this.Controls.Add(this.textBox_szelesseg);
            this.Controls.Add(this.textBox_magassag);
            this.Controls.Add(this.textBox_tipus);
            this.Controls.Add(this.textBox_leiras);
            this.Controls.Add(this.textBox_mennyiseg);
            this.Controls.Add(this.textBox_ár);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.textBox_SKU);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_raktar);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.textBox_kereses);
            this.Name = "Raktar";
            this.Text = "Raktar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_raktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_kereses;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridView dataGridView_raktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_SKU;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_ár;
        private System.Windows.Forms.TextBox textBox_mennyiseg;
        private System.Windows.Forms.TextBox textBox_leiras;
        private System.Windows.Forms.TextBox textBox_tipus;
        private System.Windows.Forms.TextBox textBox_magassag;
        private System.Windows.Forms.TextBox textBox_szelesseg;
        private System.Windows.Forms.TextBox textBox_hosszusag;
        private System.Windows.Forms.TextBox textBox_suly;
        private System.Windows.Forms.TextBox textBox_gyarto;
        private System.Windows.Forms.TextBox textBox_elado;
        private System.Windows.Forms.TextBox textBox_szallitasiMod;
        private System.Windows.Forms.TextBox textBox_nemSzallithato;
        private System.Windows.Forms.TextBox textBox_kulonSzallithato;
        private System.Windows.Forms.TextBox textBox_szallitasiKoltseg;
        private System.Windows.Forms.TextBox textBox_velemenyek;
        private System.Windows.Forms.BindingSource termekBindingSource;
    }
}