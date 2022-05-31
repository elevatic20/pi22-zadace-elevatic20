namespace iReservate
{
    partial class FrmRezervacija
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
            this.elevatic20_DBDataSet = new iReservate.elevatic20_DBDataSet();
            this.elevatic20DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elevatic20_DBDataSet1 = new iReservate.elevatic20_DBDataSet();
            this.smjestajTableAdapter = new iReservate.elevatic20_DBDataSetTableAdapters.SmjestajTableAdapter();
            this.naslov = new System.Windows.Forms.Label();
            this.cbSmjestaj = new System.Windows.Forms.ComboBox();
            this.cbGost = new System.Windows.Forms.ComboBox();
            this.lblSmjestaj = new System.Windows.Forms.Label();
            this.lblGost = new System.Windows.Forms.Label();
            this.lblBrojOsoba = new System.Windows.Forms.Label();
            this.txtBrojOsoba = new System.Windows.Forms.TextBox();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.txtOd = new System.Windows.Forms.TextBox();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.txtIdRezervacija = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smjestajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojosobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elevatic20_DBDataSet2 = new iReservate.elevatic20_DBDataSet2();
            this.rezervacijaTableAdapter = new iReservate.elevatic20_DBDataSet2TableAdapters.RezervacijaTableAdapter();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjestajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // elevatic20_DBDataSet
            // 
            this.elevatic20_DBDataSet.DataSetName = "elevatic20_DBDataSet";
            this.elevatic20_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elevatic20DBDataSetBindingSource
            // 
            this.elevatic20DBDataSetBindingSource.DataSource = this.elevatic20_DBDataSet;
            this.elevatic20DBDataSetBindingSource.Position = 0;
            // 
            // smjestajBindingSource
            // 
            this.smjestajBindingSource.DataMember = "Smjestaj";
            this.smjestajBindingSource.DataSource = this.elevatic20_DBDataSet1;
            // 
            // elevatic20_DBDataSet1
            // 
            this.elevatic20_DBDataSet1.DataSetName = "elevatic20_DBDataSet";
            this.elevatic20_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smjestajTableAdapter
            // 
            this.smjestajTableAdapter.ClearBeforeFill = true;
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.naslov.Location = new System.Drawing.Point(359, 9);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(196, 39);
            this.naslov.TabIndex = 5;
            this.naslov.Text = "Rezervacija";
            // 
            // cbSmjestaj
            // 
            this.cbSmjestaj.FormattingEnabled = true;
            this.cbSmjestaj.Location = new System.Drawing.Point(1092, 122);
            this.cbSmjestaj.Name = "cbSmjestaj";
            this.cbSmjestaj.Size = new System.Drawing.Size(121, 21);
            this.cbSmjestaj.TabIndex = 6;
            this.cbSmjestaj.SelectedIndexChanged += new System.EventHandler(this.cbSmjestaj_SelectedIndexChanged);
            // 
            // cbGost
            // 
            this.cbGost.FormattingEnabled = true;
            this.cbGost.Location = new System.Drawing.Point(1092, 92);
            this.cbGost.Name = "cbGost";
            this.cbGost.Size = new System.Drawing.Size(121, 21);
            this.cbGost.TabIndex = 7;
            this.cbGost.SelectedIndexChanged += new System.EventHandler(this.cbGost_SelectedIndexChanged);
            // 
            // lblSmjestaj
            // 
            this.lblSmjestaj.AutoSize = true;
            this.lblSmjestaj.Location = new System.Drawing.Point(1025, 122);
            this.lblSmjestaj.Name = "lblSmjestaj";
            this.lblSmjestaj.Size = new System.Drawing.Size(49, 13);
            this.lblSmjestaj.TabIndex = 8;
            this.lblSmjestaj.Text = "Smještaj:";
            // 
            // lblGost
            // 
            this.lblGost.AutoSize = true;
            this.lblGost.Location = new System.Drawing.Point(1042, 95);
            this.lblGost.Name = "lblGost";
            this.lblGost.Size = new System.Drawing.Size(32, 13);
            this.lblGost.TabIndex = 9;
            this.lblGost.Text = "Gost:";
            // 
            // lblBrojOsoba
            // 
            this.lblBrojOsoba.AutoSize = true;
            this.lblBrojOsoba.Location = new System.Drawing.Point(1014, 154);
            this.lblBrojOsoba.Name = "lblBrojOsoba";
            this.lblBrojOsoba.Size = new System.Drawing.Size(60, 13);
            this.lblBrojOsoba.TabIndex = 10;
            this.lblBrojOsoba.Text = "Broj osoba:";
            // 
            // txtBrojOsoba
            // 
            this.txtBrojOsoba.Location = new System.Drawing.Point(1092, 147);
            this.txtBrojOsoba.Name = "txtBrojOsoba";
            this.txtBrojOsoba.Size = new System.Drawing.Size(121, 20);
            this.txtBrojOsoba.TabIndex = 11;
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(1045, 180);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(24, 13);
            this.lblOd.TabIndex = 14;
            this.lblOd.Text = "Od:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(1045, 207);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(24, 13);
            this.lblDo.TabIndex = 15;
            this.lblDo.Text = "Do:";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(1030, 240);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 16;
            this.lblCijena.Text = "Cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(1092, 237);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 17;
            // 
            // btnPocetna
            // 
            this.btnPocetna.Location = new System.Drawing.Point(12, 85);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(145, 34);
            this.btnPocetna.TabIndex = 18;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // txtOd
            // 
            this.txtOd.Location = new System.Drawing.Point(1092, 172);
            this.txtOd.Name = "txtOd";
            this.txtOd.Size = new System.Drawing.Size(121, 20);
            this.txtOd.TabIndex = 19;
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(1092, 207);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(121, 20);
            this.txtDo.TabIndex = 20;
            // 
            // txtIdRezervacija
            // 
            this.txtIdRezervacija.Location = new System.Drawing.Point(1092, 65);
            this.txtIdRezervacija.Name = "txtIdRezervacija";
            this.txtIdRezervacija.Size = new System.Drawing.Size(100, 20);
            this.txtIdRezervacija.TabIndex = 21;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1048, 72);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(1035, 286);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1149, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Izbriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.gostDataGridViewTextBoxColumn,
            this.smjestajDataGridViewTextBoxColumn,
            this.brojosobaDataGridViewTextBoxColumn,
            this.odDataGridViewTextBoxColumn,
            this.doDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervacijaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(200, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // gostDataGridViewTextBoxColumn
            // 
            this.gostDataGridViewTextBoxColumn.DataPropertyName = "Gost";
            this.gostDataGridViewTextBoxColumn.HeaderText = "Gost";
            this.gostDataGridViewTextBoxColumn.Name = "gostDataGridViewTextBoxColumn";
            // 
            // smjestajDataGridViewTextBoxColumn
            // 
            this.smjestajDataGridViewTextBoxColumn.DataPropertyName = "Smjestaj";
            this.smjestajDataGridViewTextBoxColumn.HeaderText = "Smjestaj";
            this.smjestajDataGridViewTextBoxColumn.Name = "smjestajDataGridViewTextBoxColumn";
            // 
            // brojosobaDataGridViewTextBoxColumn
            // 
            this.brojosobaDataGridViewTextBoxColumn.DataPropertyName = "Broj_osoba";
            this.brojosobaDataGridViewTextBoxColumn.HeaderText = "Broj_osoba";
            this.brojosobaDataGridViewTextBoxColumn.Name = "brojosobaDataGridViewTextBoxColumn";
            // 
            // odDataGridViewTextBoxColumn
            // 
            this.odDataGridViewTextBoxColumn.DataPropertyName = "Od";
            this.odDataGridViewTextBoxColumn.HeaderText = "Od";
            this.odDataGridViewTextBoxColumn.Name = "odDataGridViewTextBoxColumn";
            // 
            // doDataGridViewTextBoxColumn
            // 
            this.doDataGridViewTextBoxColumn.DataPropertyName = "Do";
            this.doDataGridViewTextBoxColumn.HeaderText = "Do";
            this.doDataGridViewTextBoxColumn.Name = "doDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataMember = "Rezervacija";
            this.rezervacijaBindingSource.DataSource = this.elevatic20_DBDataSet2;
            // 
            // elevatic20_DBDataSet2
            // 
            this.elevatic20_DBDataSet2.DataSetName = "elevatic20_DBDataSet2";
            this.elevatic20_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervacijaTableAdapter
            // 
            this.rezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(1092, 339);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeni.TabIndex = 26;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1066, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cijena = Smještaj * Broj osoba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(961, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Šator: 500Kn, Kamp kucica: 1000Kn, Mobilna kucica: 1500Kn";
            // 
            // FrmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtIdRezervacija);
            this.Controls.Add(this.txtDo);
            this.Controls.Add(this.txtOd);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.txtBrojOsoba);
            this.Controls.Add(this.lblBrojOsoba);
            this.Controls.Add(this.lblGost);
            this.Controls.Add(this.lblSmjestaj);
            this.Controls.Add(this.cbGost);
            this.Controls.Add(this.cbSmjestaj);
            this.Controls.Add(this.naslov);
            this.Name = "FrmRezervacija";
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.FrmRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjestajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource elevatic20DBDataSetBindingSource;
        private elevatic20_DBDataSet elevatic20_DBDataSet;
        private elevatic20_DBDataSet elevatic20_DBDataSet1;
        private System.Windows.Forms.BindingSource smjestajBindingSource;
        private elevatic20_DBDataSetTableAdapters.SmjestajTableAdapter smjestajTableAdapter;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.ComboBox cbSmjestaj;
        private System.Windows.Forms.ComboBox cbGost;
        private System.Windows.Forms.Label lblSmjestaj;
        private System.Windows.Forms.Label lblGost;
        private System.Windows.Forms.Label lblBrojOsoba;
        private System.Windows.Forms.TextBox txtBrojOsoba;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.TextBox txtOd;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.TextBox txtIdRezervacija;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private elevatic20_DBDataSet2 elevatic20_DBDataSet2;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private elevatic20_DBDataSet2TableAdapters.RezervacijaTableAdapter rezervacijaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smjestajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojosobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}