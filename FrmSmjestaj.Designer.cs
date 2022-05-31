namespace iReservate
{
    partial class FrmSmjestaj
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lblSmjestaj = new System.Windows.Forms.Label();
            this.elevatic20_DBDataSet = new iReservate.elevatic20_DBDataSet();
            this.elevatic20DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblIDSmjestaj = new System.Windows.Forms.Label();
            this.lblTextSmjestaj = new System.Windows.Forms.Label();
            this.txtIDSmjestaja = new System.Windows.Forms.TextBox();
            this.txtNazivSmjestaja = new System.Windows.Forms.TextBox();
            this.btnAddSmjestaj = new System.Windows.Forms.Button();
            this.btnDelSmjestaj = new System.Windows.Forms.Button();
            this.dgvSmjestaj = new System.Windows.Forms.DataGridView();
            this.iDsmjestajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsmjestajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smjestajTableAdapter = new iReservate.elevatic20_DBDataSetTableAdapters.SmjestajTableAdapter();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjestajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 86);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(145, 34);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Početna";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblSmjestaj
            // 
            this.lblSmjestaj.AutoSize = true;
            this.lblSmjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblSmjestaj.Location = new System.Drawing.Point(378, 23);
            this.lblSmjestaj.Name = "lblSmjestaj";
            this.lblSmjestaj.Size = new System.Drawing.Size(148, 39);
            this.lblSmjestaj.TabIndex = 1;
            this.lblSmjestaj.Text = "Smještaj";
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
            // lblIDSmjestaj
            // 
            this.lblIDSmjestaj.AutoSize = true;
            this.lblIDSmjestaj.Location = new System.Drawing.Point(652, 130);
            this.lblIDSmjestaj.Name = "lblIDSmjestaj";
            this.lblIDSmjestaj.Size = new System.Drawing.Size(21, 13);
            this.lblIDSmjestaj.TabIndex = 3;
            this.lblIDSmjestaj.Text = "ID:";
            // 
            // lblTextSmjestaj
            // 
            this.lblTextSmjestaj.AutoSize = true;
            this.lblTextSmjestaj.Location = new System.Drawing.Point(590, 167);
            this.lblTextSmjestaj.Name = "lblTextSmjestaj";
            this.lblTextSmjestaj.Size = new System.Drawing.Size(83, 13);
            this.lblTextSmjestaj.TabIndex = 4;
            this.lblTextSmjestaj.Text = "Naziv smještaja:";
            // 
            // txtIDSmjestaja
            // 
            this.txtIDSmjestaja.Location = new System.Drawing.Point(689, 127);
            this.txtIDSmjestaja.Name = "txtIDSmjestaja";
            this.txtIDSmjestaja.Size = new System.Drawing.Size(149, 20);
            this.txtIDSmjestaja.TabIndex = 5;
            // 
            // txtNazivSmjestaja
            // 
            this.txtNazivSmjestaja.Location = new System.Drawing.Point(689, 167);
            this.txtNazivSmjestaja.Name = "txtNazivSmjestaja";
            this.txtNazivSmjestaja.Size = new System.Drawing.Size(149, 20);
            this.txtNazivSmjestaja.TabIndex = 6;
            // 
            // btnAddSmjestaj
            // 
            this.btnAddSmjestaj.Location = new System.Drawing.Point(621, 243);
            this.btnAddSmjestaj.Name = "btnAddSmjestaj";
            this.btnAddSmjestaj.Size = new System.Drawing.Size(75, 23);
            this.btnAddSmjestaj.TabIndex = 7;
            this.btnAddSmjestaj.Text = "Dodaj";
            this.btnAddSmjestaj.UseVisualStyleBackColor = true;
            this.btnAddSmjestaj.Click += new System.EventHandler(this.btnAddSmjestaj_Click);
            // 
            // btnDelSmjestaj
            // 
            this.btnDelSmjestaj.Location = new System.Drawing.Point(702, 243);
            this.btnDelSmjestaj.Name = "btnDelSmjestaj";
            this.btnDelSmjestaj.Size = new System.Drawing.Size(75, 23);
            this.btnDelSmjestaj.TabIndex = 8;
            this.btnDelSmjestaj.Text = "Izbriši";
            this.btnDelSmjestaj.UseVisualStyleBackColor = true;
            this.btnDelSmjestaj.Click += new System.EventHandler(this.btnDelSmjestaj_Click);
            // 
            // dgvSmjestaj
            // 
            this.dgvSmjestaj.AutoGenerateColumns = false;
            this.dgvSmjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSmjestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDsmjestajDataGridViewTextBoxColumn,
            this.nazivsmjestajaDataGridViewTextBoxColumn});
            this.dgvSmjestaj.DataSource = this.smjestajBindingSource;
            this.dgvSmjestaj.Location = new System.Drawing.Point(262, 86);
            this.dgvSmjestaj.Name = "dgvSmjestaj";
            this.dgvSmjestaj.Size = new System.Drawing.Size(244, 261);
            this.dgvSmjestaj.TabIndex = 9;
            // 
            // iDsmjestajDataGridViewTextBoxColumn
            // 
            this.iDsmjestajDataGridViewTextBoxColumn.DataPropertyName = "ID_smjestaj";
            this.iDsmjestajDataGridViewTextBoxColumn.HeaderText = "ID_smjestaj";
            this.iDsmjestajDataGridViewTextBoxColumn.Name = "iDsmjestajDataGridViewTextBoxColumn";
            // 
            // nazivsmjestajaDataGridViewTextBoxColumn
            // 
            this.nazivsmjestajaDataGridViewTextBoxColumn.DataPropertyName = "Naziv_smjestaja";
            this.nazivsmjestajaDataGridViewTextBoxColumn.HeaderText = "Naziv_smjestaja";
            this.nazivsmjestajaDataGridViewTextBoxColumn.Name = "nazivsmjestajaDataGridViewTextBoxColumn";
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
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(784, 243);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeni.TabIndex = 10;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // FrmSmjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.dgvSmjestaj);
            this.Controls.Add(this.btnDelSmjestaj);
            this.Controls.Add(this.btnAddSmjestaj);
            this.Controls.Add(this.txtNazivSmjestaja);
            this.Controls.Add(this.txtIDSmjestaja);
            this.Controls.Add(this.lblTextSmjestaj);
            this.Controls.Add(this.lblIDSmjestaj);
            this.Controls.Add(this.lblSmjestaj);
            this.Controls.Add(this.btnHome);
            this.Name = "FrmSmjestaj";
            this.Text = "Smještajevi";
            this.Load += new System.EventHandler(this.FrmSmjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatic20DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smjestajBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblSmjestaj;
        private System.Windows.Forms.BindingSource elevatic20DBDataSetBindingSource;
        private elevatic20_DBDataSet elevatic20_DBDataSet;
        private System.Windows.Forms.Label lblIDSmjestaj;
        private System.Windows.Forms.Label lblTextSmjestaj;
        private System.Windows.Forms.TextBox txtIDSmjestaja;
        private System.Windows.Forms.TextBox txtNazivSmjestaja;
        private System.Windows.Forms.Button btnAddSmjestaj;
        private System.Windows.Forms.Button btnDelSmjestaj;
        private System.Windows.Forms.DataGridView dgvSmjestaj;
        private System.Windows.Forms.BindingSource smjestajBindingSource;
        private elevatic20_DBDataSetTableAdapters.SmjestajTableAdapter smjestajTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsmjestajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsmjestajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIzmjeni;
    }
}