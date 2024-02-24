namespace Kütüphane_Otomasyonu_Uygulaması
{
    partial class UyeSayfasi
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
            this.btnkitapara = new System.Windows.Forms.Button();
            this.btnkitapyenile = new System.Windows.Forms.Button();
            this.txtkitapidara = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncikisyap = new System.Windows.Forms.Button();
            this.iddd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapppisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitappyazari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitappdil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitappyayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapptur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitappadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitappsayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitappbasimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkitapara
            // 
            this.btnkitapara.Location = new System.Drawing.Point(247, 61);
            this.btnkitapara.Name = "btnkitapara";
            this.btnkitapara.Size = new System.Drawing.Size(129, 37);
            this.btnkitapara.TabIndex = 0;
            this.btnkitapara.Text = "Ara";
            this.btnkitapara.UseVisualStyleBackColor = true;
            this.btnkitapara.Click += new System.EventHandler(this.btnkitapara_Click);
            // 
            // btnkitapyenile
            // 
            this.btnkitapyenile.Location = new System.Drawing.Point(656, 61);
            this.btnkitapyenile.Name = "btnkitapyenile";
            this.btnkitapyenile.Size = new System.Drawing.Size(110, 37);
            this.btnkitapyenile.TabIndex = 0;
            this.btnkitapyenile.Text = "Yenile";
            this.btnkitapyenile.UseVisualStyleBackColor = true;
            this.btnkitapyenile.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtkitapidara
            // 
            this.txtkitapidara.Location = new System.Drawing.Point(382, 61);
            this.txtkitapidara.Multiline = true;
            this.txtkitapidara.Name = "txtkitapidara";
            this.txtkitapidara.Size = new System.Drawing.Size(268, 37);
            this.txtkitapidara.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddd,
            this.kitapppisim,
            this.kitappyazari,
            this.kitappdil,
            this.kitappyayinevi,
            this.kitapptur,
            this.kitappadet,
            this.kitappsayfa,
            this.kitappbasimyili});
            this.dataGridView1.Location = new System.Drawing.Point(61, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 198);
            this.dataGridView1.TabIndex = 2;
            // 
            // btncikisyap
            // 
            this.btncikisyap.Location = new System.Drawing.Point(412, 382);
            this.btncikisyap.Name = "btncikisyap";
            this.btncikisyap.Size = new System.Drawing.Size(214, 45);
            this.btncikisyap.TabIndex = 0;
            this.btncikisyap.Text = "Çıkış Yap";
            this.btncikisyap.UseVisualStyleBackColor = true;
            this.btncikisyap.Click += new System.EventHandler(this.btncikisyap_Click);
            // 
            // iddd
            // 
            this.iddd.HeaderText = "Kitap ID";
            this.iddd.Name = "iddd";
            // 
            // kitapppisim
            // 
            this.kitapppisim.HeaderText = "Kitap İsmi";
            this.kitapppisim.Name = "kitapppisim";
            // 
            // kitappyazari
            // 
            this.kitappyazari.HeaderText = "Yazar";
            this.kitappyazari.Name = "kitappyazari";
            // 
            // kitappdil
            // 
            this.kitappdil.HeaderText = "Dil";
            this.kitappdil.Name = "kitappdil";
            // 
            // kitappyayinevi
            // 
            this.kitappyayinevi.HeaderText = "Yayınevi";
            this.kitappyayinevi.Name = "kitappyayinevi";
            // 
            // kitapptur
            // 
            this.kitapptur.HeaderText = "Tür";
            this.kitapptur.Name = "kitapptur";
            // 
            // kitappadet
            // 
            this.kitappadet.HeaderText = "Adet";
            this.kitappadet.Name = "kitappadet";
            // 
            // kitappsayfa
            // 
            this.kitappsayfa.HeaderText = "Sayfa Sayısı";
            this.kitappsayfa.Name = "kitappsayfa";
            // 
            // kitappbasimyili
            // 
            this.kitappbasimyili.HeaderText = "Basım Yılı";
            this.kitappbasimyili.Name = "kitappbasimyili";
            // 
            // UyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtkitapidara);
            this.Controls.Add(this.btncikisyap);
            this.Controls.Add(this.btnkitapyenile);
            this.Controls.Add(this.btnkitapara);
            this.Name = "UyeSayfasi";
            this.Text = "UyeSayfasi";
            this.Load += new System.EventHandler(this.UyeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkitapara;
        private System.Windows.Forms.Button btnkitapyenile;
        private System.Windows.Forms.TextBox txtkitapidara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncikisyap;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddd;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapppisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitappyazari;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitappdil;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitappyayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapptur;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitappadet;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitappsayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitappbasimyili;
    }
}