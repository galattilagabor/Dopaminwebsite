﻿namespace Kliensalkalmazas
{
    partial class Raktár
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
            this.button_change_quantity = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_out = new System.Windows.Forms.Button();
            this.dataGridView_raktar = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bvinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szallitasiModDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szallitasiArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemSzallithatoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inventoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termékBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_SKU = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_ar = new System.Windows.Forms.TextBox();
            this.textBox_mennyiseg = new System.Windows.Forms.TextBox();
            this.textBox_tipus = new System.Windows.Forms.TextBox();
            this.textBox_gyarto = new System.Windows.Forms.TextBox();
            this.textBox_elado = new System.Windows.Forms.TextBox();
            this.textBox_szallitasiMod = new System.Windows.Forms.TextBox();
            this.textBox_nemSzallithato = new System.Windows.Forms.TextBox();
            this.textBox_szallitasiKoltseg = new System.Windows.Forms.TextBox();
            this.button_change = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_magassag = new System.Windows.Forms.TextBox();
            this.textBox_szelesseg = new System.Windows.Forms.TextBox();
            this.textBox_hosszusag = new System.Windows.Forms.TextBox();
            this.textBox_suly = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_raktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termékBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_kereses
            // 
            this.textBox_kereses.Location = new System.Drawing.Point(30, 125);
            this.textBox_kereses.Name = "textBox_kereses";
            this.textBox_kereses.Size = new System.Drawing.Size(300, 20);
            this.textBox_kereses.TabIndex = 1;
            this.textBox_kereses.TextChanged += new System.EventHandler(this.textBox_kereses_TextChanged);
            // 
            // button_change_quantity
            // 
            this.button_change_quantity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_change_quantity.ForeColor = System.Drawing.Color.White;
            this.button_change_quantity.Location = new System.Drawing.Point(356, 42);
            this.button_change_quantity.Margin = new System.Windows.Forms.Padding(7);
            this.button_change_quantity.Name = "button_change_quantity";
            this.button_change_quantity.Size = new System.Drawing.Size(149, 23);
            this.button_change_quantity.TabIndex = 3;
            this.button_change_quantity.Text = "Mennyiség szerkesztése";
            this.button_change_quantity.UseVisualStyleBackColor = false;
            this.button_change_quantity.Click += new System.EventHandler(this.button_change_quantity_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(644, 42);
            this.button_delete.Margin = new System.Windows.Forms.Padding(7);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_out
            // 
            this.button_out.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_out.ForeColor = System.Drawing.Color.White;
            this.button_out.Location = new System.Drawing.Point(937, 42);
            this.button_out.Margin = new System.Windows.Forms.Padding(7);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(75, 23);
            this.button_out.TabIndex = 5;
            this.button_out.Text = "Kilépés";
            this.button_out.UseVisualStyleBackColor = false;
            this.button_out.Click += new System.EventHandler(this.button_out_Click);
            // 
            // dataGridView_raktar
            // 
            this.dataGridView_raktar.AutoGenerateColumns = false;
            this.dataGridView_raktar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_raktar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bvinDataGridViewTextBoxColumn,
            this.sKUDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.arDataGridViewTextBoxColumn,
            this.mennyisegDataGridViewTextBoxColumn,
            this.tipusDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.gyartoDataGridViewTextBoxColumn,
            this.eladoDataGridViewTextBoxColumn,
            this.szallitasiModDataGridViewTextBoxColumn,
            this.szallitasiArDataGridViewTextBoxColumn,
            this.nemSzallithatoDataGridViewCheckBoxColumn,
            this.inventoryIDDataGridViewTextBoxColumn});
            this.dataGridView_raktar.DataSource = this.termékBindingSource;
            this.dataGridView_raktar.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_raktar.Location = new System.Drawing.Point(356, 97);
            this.dataGridView_raktar.Name = "dataGridView_raktar";
            this.dataGridView_raktar.Size = new System.Drawing.Size(656, 464);
            this.dataGridView_raktar.TabIndex = 6;
            this.dataGridView_raktar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_raktar_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // bvinDataGridViewTextBoxColumn
            // 
            this.bvinDataGridViewTextBoxColumn.DataPropertyName = "Bvin";
            this.bvinDataGridViewTextBoxColumn.HeaderText = "Bvin";
            this.bvinDataGridViewTextBoxColumn.Name = "bvinDataGridViewTextBoxColumn";
            this.bvinDataGridViewTextBoxColumn.Visible = false;
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            this.sKUDataGridViewTextBoxColumn.Visible = false;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // arDataGridViewTextBoxColumn
            // 
            this.arDataGridViewTextBoxColumn.DataPropertyName = "Ar";
            this.arDataGridViewTextBoxColumn.HeaderText = "Ar";
            this.arDataGridViewTextBoxColumn.Name = "arDataGridViewTextBoxColumn";
            this.arDataGridViewTextBoxColumn.Visible = false;
            // 
            // mennyisegDataGridViewTextBoxColumn
            // 
            this.mennyisegDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg";
            this.mennyisegDataGridViewTextBoxColumn.HeaderText = "Mennyiseg";
            this.mennyisegDataGridViewTextBoxColumn.Name = "mennyisegDataGridViewTextBoxColumn";
            // 
            // tipusDataGridViewTextBoxColumn
            // 
            this.tipusDataGridViewTextBoxColumn.DataPropertyName = "Tipus";
            this.tipusDataGridViewTextBoxColumn.HeaderText = "Tipus";
            this.tipusDataGridViewTextBoxColumn.Name = "tipusDataGridViewTextBoxColumn";
            this.tipusDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Magassag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Magassag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Szelesseg";
            this.dataGridViewTextBoxColumn2.HeaderText = "Szelesseg";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Hosszusag";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hosszusag";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Suly";
            this.dataGridViewTextBoxColumn4.HeaderText = "Suly";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // gyartoDataGridViewTextBoxColumn
            // 
            this.gyartoDataGridViewTextBoxColumn.DataPropertyName = "Gyarto";
            this.gyartoDataGridViewTextBoxColumn.HeaderText = "Gyarto";
            this.gyartoDataGridViewTextBoxColumn.Name = "gyartoDataGridViewTextBoxColumn";
            this.gyartoDataGridViewTextBoxColumn.Visible = false;
            // 
            // eladoDataGridViewTextBoxColumn
            // 
            this.eladoDataGridViewTextBoxColumn.DataPropertyName = "Elado";
            this.eladoDataGridViewTextBoxColumn.HeaderText = "Elado";
            this.eladoDataGridViewTextBoxColumn.Name = "eladoDataGridViewTextBoxColumn";
            this.eladoDataGridViewTextBoxColumn.Visible = false;
            // 
            // szallitasiModDataGridViewTextBoxColumn
            // 
            this.szallitasiModDataGridViewTextBoxColumn.DataPropertyName = "SzallitasiMod";
            this.szallitasiModDataGridViewTextBoxColumn.HeaderText = "SzallitasiMod";
            this.szallitasiModDataGridViewTextBoxColumn.Name = "szallitasiModDataGridViewTextBoxColumn";
            this.szallitasiModDataGridViewTextBoxColumn.Visible = false;
            // 
            // szallitasiArDataGridViewTextBoxColumn
            // 
            this.szallitasiArDataGridViewTextBoxColumn.DataPropertyName = "SzallitasiAr";
            this.szallitasiArDataGridViewTextBoxColumn.HeaderText = "SzallitasiAr";
            this.szallitasiArDataGridViewTextBoxColumn.Name = "szallitasiArDataGridViewTextBoxColumn";
            this.szallitasiArDataGridViewTextBoxColumn.Visible = false;
            // 
            // nemSzallithatoDataGridViewCheckBoxColumn
            // 
            this.nemSzallithatoDataGridViewCheckBoxColumn.DataPropertyName = "NemSzallithato";
            this.nemSzallithatoDataGridViewCheckBoxColumn.HeaderText = "NemSzallithato";
            this.nemSzallithatoDataGridViewCheckBoxColumn.Name = "nemSzallithatoDataGridViewCheckBoxColumn";
            this.nemSzallithatoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // inventoryIDDataGridViewTextBoxColumn
            // 
            this.inventoryIDDataGridViewTextBoxColumn.DataPropertyName = "InventoryID";
            this.inventoryIDDataGridViewTextBoxColumn.HeaderText = "InventoryID";
            this.inventoryIDDataGridViewTextBoxColumn.Name = "inventoryIDDataGridViewTextBoxColumn";
            this.inventoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // termékBindingSource
            // 
            this.termékBindingSource.DataSource = typeof(ApiSample.Termék);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "SKU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mennyiség";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Termék kategória";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(30, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Gyártó";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(30, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Eladó";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(30, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Szállítási mód";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(30, 544);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Nem szállítható termék";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(30, 518);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Szállítási költség";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(130, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Termékinformációk";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 25);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // textBox_SKU
            // 
            this.textBox_SKU.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_SKU.ForeColor = System.Drawing.Color.White;
            this.textBox_SKU.Location = new System.Drawing.Point(165, 203);
            this.textBox_SKU.Name = "textBox_SKU";
            this.textBox_SKU.Size = new System.Drawing.Size(165, 20);
            this.textBox_SKU.TabIndex = 26;
            // 
            // textBox_nev
            // 
            this.textBox_nev.ForeColor = System.Drawing.Color.White;
            this.textBox_nev.Location = new System.Drawing.Point(165, 229);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(165, 20);
            this.textBox_nev.TabIndex = 27;
            // 
            // textBox_ar
            // 
            this.textBox_ar.ForeColor = System.Drawing.Color.White;
            this.textBox_ar.Location = new System.Drawing.Point(165, 255);
            this.textBox_ar.Name = "textBox_ar";
            this.textBox_ar.Size = new System.Drawing.Size(149, 20);
            this.textBox_ar.TabIndex = 28;
            // 
            // textBox_mennyiseg
            // 
            this.textBox_mennyiseg.ForeColor = System.Drawing.Color.White;
            this.textBox_mennyiseg.Location = new System.Drawing.Point(165, 281);
            this.textBox_mennyiseg.Name = "textBox_mennyiseg";
            this.textBox_mennyiseg.Size = new System.Drawing.Size(148, 20);
            this.textBox_mennyiseg.TabIndex = 29;
            // 
            // textBox_tipus
            // 
            this.textBox_tipus.ForeColor = System.Drawing.Color.White;
            this.textBox_tipus.Location = new System.Drawing.Point(165, 307);
            this.textBox_tipus.Name = "textBox_tipus";
            this.textBox_tipus.Size = new System.Drawing.Size(165, 20);
            this.textBox_tipus.TabIndex = 31;
            // 
            // textBox_gyarto
            // 
            this.textBox_gyarto.ForeColor = System.Drawing.Color.White;
            this.textBox_gyarto.Location = new System.Drawing.Point(165, 437);
            this.textBox_gyarto.Name = "textBox_gyarto";
            this.textBox_gyarto.Size = new System.Drawing.Size(165, 20);
            this.textBox_gyarto.TabIndex = 36;
            // 
            // textBox_elado
            // 
            this.textBox_elado.ForeColor = System.Drawing.Color.White;
            this.textBox_elado.Location = new System.Drawing.Point(165, 463);
            this.textBox_elado.Name = "textBox_elado";
            this.textBox_elado.Size = new System.Drawing.Size(165, 20);
            this.textBox_elado.TabIndex = 37;
            // 
            // textBox_szallitasiMod
            // 
            this.textBox_szallitasiMod.ForeColor = System.Drawing.Color.White;
            this.textBox_szallitasiMod.Location = new System.Drawing.Point(165, 489);
            this.textBox_szallitasiMod.Name = "textBox_szallitasiMod";
            this.textBox_szallitasiMod.Size = new System.Drawing.Size(165, 20);
            this.textBox_szallitasiMod.TabIndex = 38;
            // 
            // textBox_nemSzallithato
            // 
            this.textBox_nemSzallithato.ForeColor = System.Drawing.Color.White;
            this.textBox_nemSzallithato.Location = new System.Drawing.Point(165, 541);
            this.textBox_nemSzallithato.Name = "textBox_nemSzallithato";
            this.textBox_nemSzallithato.Size = new System.Drawing.Size(165, 20);
            this.textBox_nemSzallithato.TabIndex = 39;
            // 
            // textBox_szallitasiKoltseg
            // 
            this.textBox_szallitasiKoltseg.ForeColor = System.Drawing.Color.White;
            this.textBox_szallitasiKoltseg.Location = new System.Drawing.Point(165, 515);
            this.textBox_szallitasiKoltseg.Name = "textBox_szallitasiKoltseg";
            this.textBox_szallitasiKoltseg.Size = new System.Drawing.Size(149, 20);
            this.textBox_szallitasiKoltseg.TabIndex = 41;
            // 
            // button_change
            // 
            this.button_change.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_change.ForeColor = System.Drawing.Color.White;
            this.button_change.Location = new System.Drawing.Point(563, 42);
            this.button_change.Margin = new System.Windows.Forms.Padding(7);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 42;
            this.button_change.Text = "Módosítás";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Magasság";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Szélesség";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Hosszúság";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Súly";
            // 
            // textBox_magassag
            // 
            this.textBox_magassag.ForeColor = System.Drawing.Color.White;
            this.textBox_magassag.Location = new System.Drawing.Point(165, 333);
            this.textBox_magassag.Name = "textBox_magassag";
            this.textBox_magassag.Size = new System.Drawing.Size(147, 20);
            this.textBox_magassag.TabIndex = 47;
            // 
            // textBox_szelesseg
            // 
            this.textBox_szelesseg.ForeColor = System.Drawing.Color.White;
            this.textBox_szelesseg.Location = new System.Drawing.Point(165, 359);
            this.textBox_szelesseg.Name = "textBox_szelesseg";
            this.textBox_szelesseg.Size = new System.Drawing.Size(147, 20);
            this.textBox_szelesseg.TabIndex = 48;
            // 
            // textBox_hosszusag
            // 
            this.textBox_hosszusag.ForeColor = System.Drawing.Color.White;
            this.textBox_hosszusag.Location = new System.Drawing.Point(165, 385);
            this.textBox_hosszusag.Name = "textBox_hosszusag";
            this.textBox_hosszusag.Size = new System.Drawing.Size(147, 20);
            this.textBox_hosszusag.TabIndex = 49;
            // 
            // textBox_suly
            // 
            this.textBox_suly.ForeColor = System.Drawing.Color.White;
            this.textBox_suly.Location = new System.Drawing.Point(165, 411);
            this.textBox_suly.Name = "textBox_suly";
            this.textBox_suly.Size = new System.Drawing.Size(148, 20);
            this.textBox_suly.TabIndex = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(30, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(317, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Ft";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(315, 281);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "db";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(313, 333);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 54;
            this.label18.Text = "cm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(313, 359);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "cm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(317, 515);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "Ft";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(313, 385);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 13);
            this.label21.TabIndex = 57;
            this.label21.Text = "cm";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(315, 411);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 13);
            this.label22.TabIndex = 58;
            this.label22.Text = "kg";
            // 
            // Raktár
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_suly);
            this.Controls.Add(this.textBox_hosszusag);
            this.Controls.Add(this.textBox_szelesseg);
            this.Controls.Add(this.textBox_magassag);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.textBox_szallitasiKoltseg);
            this.Controls.Add(this.textBox_nemSzallithato);
            this.Controls.Add(this.textBox_szallitasiMod);
            this.Controls.Add(this.textBox_elado);
            this.Controls.Add(this.textBox_gyarto);
            this.Controls.Add(this.textBox_tipus);
            this.Controls.Add(this.textBox_mennyiseg);
            this.Controls.Add(this.textBox_ar);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.textBox_SKU);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_raktar);
            this.Controls.Add(this.button_out);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_change_quantity);
            this.Controls.Add(this.textBox_kereses);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Raktár";
            this.Text = "Raktar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_raktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termékBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
#pragma warning disable CS0169 // The field 'Raktár.leirasDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn leirasDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Raktár.leirasDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Raktár.magassagDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn magassagDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Raktár.magassagDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Raktár.szelessegDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn szelessegDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Raktár.szelessegDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Raktár.hosszusagDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn hosszusagDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Raktár.hosszusagDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Raktár.sulyDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn sulyDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Raktár.sulyDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Raktár.kulonSzallihatoDataGridViewCheckBoxColumn' is never used
        private System.Windows.Forms.DataGridViewCheckBoxColumn kulonSzallihatoDataGridViewCheckBoxColumn;
#pragma warning restore CS0169 // The field 'Raktár.kulonSzallihatoDataGridViewCheckBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Raktár.velemenyekDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn velemenyekDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Raktár.velemenyekDataGridViewTextBoxColumn' is never used
        public System.Windows.Forms.DataGridView dataGridView_raktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource termékBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bvinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyisegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eladoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szallitasiModDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szallitasiArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nemSzallithatoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.Button button_change_quantity;
        public System.Windows.Forms.TextBox textBox_kereses;
        public System.Windows.Forms.Button button_delete;
        public System.Windows.Forms.Button button_out;
        public System.Windows.Forms.TextBox textBox_SKU;
        public System.Windows.Forms.TextBox textBox_nev;
        public System.Windows.Forms.TextBox textBox_ar;
        public System.Windows.Forms.TextBox textBox_mennyiseg;
        public System.Windows.Forms.TextBox textBox_tipus;
        public System.Windows.Forms.TextBox textBox_gyarto;
        public System.Windows.Forms.TextBox textBox_elado;
        public System.Windows.Forms.TextBox textBox_szallitasiMod;
        public System.Windows.Forms.TextBox textBox_nemSzallithato;
        public System.Windows.Forms.TextBox textBox_szallitasiKoltseg;
        public System.Windows.Forms.Button button_change;
        public System.Windows.Forms.TextBox textBox_magassag;
        public System.Windows.Forms.TextBox textBox_szelesseg;
        public System.Windows.Forms.TextBox textBox_hosszusag;
        public System.Windows.Forms.TextBox textBox_suly;
    }
}