namespace iReservate
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnSmjestaj = new System.Windows.Forms.Button();
            this.btnGosti = new System.Windows.Forms.Button();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.naslov = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(13, 415);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(145, 34);
            this.btnOdjava.TabIndex = 0;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btn_odjava_Click);
            // 
            // btnSmjestaj
            // 
            this.btnSmjestaj.Location = new System.Drawing.Point(13, 153);
            this.btnSmjestaj.Name = "btnSmjestaj";
            this.btnSmjestaj.Size = new System.Drawing.Size(145, 34);
            this.btnSmjestaj.TabIndex = 1;
            this.btnSmjestaj.Text = "Smještaj";
            this.btnSmjestaj.UseVisualStyleBackColor = true;
            this.btnSmjestaj.Click += new System.EventHandler(this.btnSmjestaj_Click);
            // 
            // btnGosti
            // 
            this.btnGosti.Location = new System.Drawing.Point(13, 113);
            this.btnGosti.Name = "btnGosti";
            this.btnGosti.Size = new System.Drawing.Size(145, 34);
            this.btnGosti.TabIndex = 2;
            this.btnGosti.Text = "Gosti";
            this.btnGosti.UseVisualStyleBackColor = true;
            this.btnGosti.Click += new System.EventHandler(this.btnGosti_Click);
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.Location = new System.Drawing.Point(13, 73);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(145, 34);
            this.btnRezervacija.TabIndex = 3;
            this.btnRezervacija.Text = "Rezervacija";
            this.btnRezervacija.UseVisualStyleBackColor = true;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.naslov.Location = new System.Drawing.Point(410, 21);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(180, 39);
            this.naslov.TabIndex = 4;
            this.naslov.Text = "iReservate";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 376);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.btnGosti);
            this.Controls.Add(this.btnSmjestaj);
            this.Controls.Add(this.btnOdjava);
            this.Name = "FrmHome";
            this.Text = "iReservate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnSmjestaj;
        private System.Windows.Forms.Button btnGosti;
        private System.Windows.Forms.Button btnRezervacija;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}