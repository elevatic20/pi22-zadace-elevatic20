namespace iReservate
{
    partial class FrmGosti
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
            this.lblGosti = new System.Windows.Forms.Label();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.elevatic20DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elevatic20_DBDataSet = new iReservate.elevatic20_DBDataSet();
            this.smjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smjestajTableAdapter = new iReservate.elevatic20_DBDataSetTableAdapters.SmjestajTableAdapter();
            this.elevatic20DBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.btnDodajGosta = new System.Windows.Forms.Button();
            this.btnIzbisiGosta = new System.Windows.Forms.Button();
            this.elevatic20DBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gostBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gostBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gostBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.elevatic20_DBDataSet3 = new iReservate.elevatic20_DBDataSet3();
            this.gostBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gostTableAdapter2 = new iReservate.elevatic20_DBDataSet3TableAdapters.GostTableAdapter();
            this.elevatic20_DBDataSet1 = new iReservate.elevatic20_DBDataSet1();
            this.gostBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.gostTableAdapter = new iReservate.elevatic20_DBDataSet1TableAdapters.GostTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjestajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20DBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20DBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGosti
            // 
            this.lblGosti.AutoSize = true;
            this.lblGosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblGosti.Location = new System.Drawing.Point(347, 9);
            this.lblGosti.Name = "lblGosti";
            this.lblGosti.Size = new System.Drawing.Size(96, 39);
            this.lblGosti.TabIndex = 2;
            this.lblGosti.Text = "Gosti";
            // 
            // btnPocetna
            // 
            this.btnPocetna.Location = new System.Drawing.Point(12, 80);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(145, 34);
            this.btnPocetna.TabIndex = 3;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // elevatic20DBDataSetBindingSource
            // 
            this.elevatic20DBDataSetBindingSource.DataSource = this.elevatic20_DBDataSet;
            this.elevatic20DBDataSetBindingSource.Position = 0;
            // 
            // elevatic20_DBDataSet
            // 
            this.elevatic20_DBDataSet.DataSetName = "elevatic20_DBDataSet";
            this.elevatic20_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smjestajBindingSource
            // 
            this.smjestajBindingSource.DataMember = "Smjestaj";
            this.smjestajBindingSource.DataSource = this.elevatic20DBDataSetBindingSource;
            // 
            // smjestajTableAdapter
            // 
            this.smjestajTableAdapter.ClearBeforeFill = true;
            // 
            // elevatic20DBDataSetBindingSource1
            // 
            this.elevatic20DBDataSetBindingSource1.DataSource = this.elevatic20_DBDataSet;
            this.elevatic20DBDataSetBindingSource1.Position = 0;
            // 
            // gostBindingSource
            // 
            this.gostBindingSource.DataMember = "Gost";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(336, 279);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(28, 13);
            this.lblOIB.TabIndex = 5;
            this.lblOIB.Text = "OIB:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(336, 308);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 6;
            this.lblIme.Text = "Ime:";
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(317, 357);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(47, 13);
            this.lblKontakt.TabIndex = 7;
            this.lblKontakt.Text = "Kontakt:";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(379, 279);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(100, 20);
            this.txtOIB.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(379, 305);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 9;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(379, 357);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(100, 20);
            this.txtKontakt.TabIndex = 10;
            // 
            // btnDodajGosta
            // 
            this.btnDodajGosta.Location = new System.Drawing.Point(305, 415);
            this.btnDodajGosta.Name = "btnDodajGosta";
            this.btnDodajGosta.Size = new System.Drawing.Size(75, 23);
            this.btnDodajGosta.TabIndex = 11;
            this.btnDodajGosta.Text = "Dodaj";
            this.btnDodajGosta.UseVisualStyleBackColor = true;
            this.btnDodajGosta.Click += new System.EventHandler(this.btnDodajGosta_Click);
            // 
            // btnIzbisiGosta
            // 
            this.btnIzbisiGosta.Location = new System.Drawing.Point(386, 415);
            this.btnIzbisiGosta.Name = "btnIzbisiGosta";
            this.btnIzbisiGosta.Size = new System.Drawing.Size(75, 23);
            this.btnIzbisiGosta.TabIndex = 12;
            this.btnIzbisiGosta.Text = "Izbriši";
            this.btnIzbisiGosta.UseVisualStyleBackColor = true;
            this.btnIzbisiGosta.Click += new System.EventHandler(this.btnIzbisiGosta_Click);
            // 
            // gostBindingSource1
            // 
            this.gostBindingSource1.DataMember = "Gost";
            this.gostBindingSource1.DataSource = this.elevatic20DBDataSet1BindingSource;
            // 
            // gostBindingSource2
            // 
            this.gostBindingSource2.DataMember = "Gost";
            // 
            // gostBindingSource4
            // 
            this.gostBindingSource4.DataMember = "Gost";
            this.gostBindingSource4.DataSource = this.elevatic20_DBDataSet3;
            // 
            // elevatic20_DBDataSet3
            // 
            this.elevatic20_DBDataSet3.DataSetName = "elevatic20_DBDataSet3";
            this.elevatic20_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gostBindingSource3
            // 
            this.gostBindingSource3.DataMember = "Gost";
            this.gostBindingSource3.DataSource = this.elevatic20_DBDataSet3;
            // 
            // gostTableAdapter2
            // 
            this.gostTableAdapter2.ClearBeforeFill = true;
            // 
            // elevatic20_DBDataSet1
            // 
            this.elevatic20_DBDataSet1.DataSetName = "elevatic20_DBDataSet1";
            this.elevatic20_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gostBindingSource5
            // 
            this.gostBindingSource5.DataMember = "Gost";
            this.gostBindingSource5.DataSource = this.elevatic20_DBDataSet1;
            // 
            // gostTableAdapter
            // 
            this.gostTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gostBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(176, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 174);
            this.dataGridView1.TabIndex = 13;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(379, 330);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 15;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(317, 333);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 14;
            this.lblPrezime.Text = "Prezime:";
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(467, 415);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeni.TabIndex = 16;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // FrmGosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzbisiGosta);
            this.Controls.Add(this.btnDodajGosta);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.lblGosti);
            this.Name = "FrmGosti";
            this.Text = "Gosti";
            this.Load += new System.EventHandler(this.FrmGosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjestajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20DBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20DBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGosti;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.BindingSource elevatic20DBDataSetBindingSource;
        private elevatic20_DBDataSet elevatic20_DBDataSet;
        private System.Windows.Forms.BindingSource smjestajBindingSource;
        private elevatic20_DBDataSetTableAdapters.SmjestajTableAdapter smjestajTableAdapter;
        private System.Windows.Forms.BindingSource elevatic20DBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource gostBindingSource;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Button btnDodajGosta;
        private System.Windows.Forms.Button btnIzbisiGosta;
        private System.Windows.Forms.BindingSource gostBindingSource1;
        private System.Windows.Forms.BindingSource elevatic20DBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource gostBindingSource2;
        private elevatic20_DBDataSet3 elevatic20_DBDataSet3;
        private System.Windows.Forms.BindingSource gostBindingSource3;
        private elevatic20_DBDataSet3TableAdapters.GostTableAdapter gostTableAdapter2;
        private System.Windows.Forms.BindingSource gostBindingSource4;
        private elevatic20_DBDataSet1 elevatic20_DBDataSet1;
        private System.Windows.Forms.BindingSource gostBindingSource5;
        private elevatic20_DBDataSet1TableAdapters.GostTableAdapter gostTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Button btnIzmjeni;
    }
}