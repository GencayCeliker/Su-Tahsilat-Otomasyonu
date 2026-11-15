namespace SuTahsilat
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgAbone = new System.Windows.Forms.DataGridView();
            this.dgTuketim = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtEndeks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.btnTuketimDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTuketim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAbone
            // 
            this.dgAbone.AllowUserToAddRows = false;
            this.dgAbone.AllowUserToDeleteRows = false;
            this.dgAbone.AllowUserToOrderColumns = true;
            this.dgAbone.AllowUserToResizeColumns = false;
            this.dgAbone.AllowUserToResizeRows = false;
            this.dgAbone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbone.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgAbone.Location = new System.Drawing.Point(224, 77);
            this.dgAbone.MultiSelect = false;
            this.dgAbone.Name = "dgAbone";
            this.dgAbone.RowHeadersVisible = false;
            this.dgAbone.RowHeadersWidth = 51;
            this.dgAbone.RowTemplate.Height = 24;
            this.dgAbone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbone.Size = new System.Drawing.Size(682, 402);
            this.dgAbone.TabIndex = 0;
            this.dgAbone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAbone_CellClick);
            // 
            // dgTuketim
            // 
            this.dgTuketim.AllowUserToAddRows = false;
            this.dgTuketim.AllowUserToDeleteRows = false;
            this.dgTuketim.AllowUserToOrderColumns = true;
            this.dgTuketim.AllowUserToResizeColumns = false;
            this.dgTuketim.AllowUserToResizeRows = false;
            this.dgTuketim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTuketim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTuketim.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgTuketim.Location = new System.Drawing.Point(912, 77);
            this.dgTuketim.MultiSelect = false;
            this.dgTuketim.Name = "dgTuketim";
            this.dgTuketim.RowHeadersVisible = false;
            this.dgTuketim.RowHeadersWidth = 51;
            this.dgTuketim.RowTemplate.Height = 24;
            this.dgTuketim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTuketim.Size = new System.Drawing.Size(670, 402);
            this.dgTuketim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abone Adı";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(12, 37);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(207, 28);
            this.txtAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Abone Soyadı";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(12, 105);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(207, 28);
            this.txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "TCKimlikNumarası";
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(12, 173);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(207, 28);
            this.txtTC.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adresi";
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(12, 241);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(207, 102);
            this.txtAdres.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(12, 374);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(207, 28);
            this.txtTel.TabIndex = 3;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(1374, 502);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(138, 51);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(429, 487);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(145, 51);
            this.btnKayit.TabIndex = 5;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtEndeks
            // 
            this.txtEndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEndeks.Location = new System.Drawing.Point(901, 536);
            this.txtEndeks.Name = "txtEndeks";
            this.txtEndeks.Size = new System.Drawing.Size(162, 28);
            this.txtEndeks.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(896, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Endeks";
            // 
            // btnEKaydet
            // 
            this.btnEKaydet.Location = new System.Drawing.Point(1079, 522);
            this.btnEKaydet.Name = "btnEKaydet";
            this.btnEKaydet.Size = new System.Drawing.Size(74, 42);
            this.btnEKaydet.TabIndex = 8;
            this.btnEKaydet.Text = "Kaydet";
            this.btnEKaydet.UseVisualStyleBackColor = true;
            this.btnEKaydet.Click += new System.EventHandler(this.btnEKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Location = new System.Drawing.Point(12, 441);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(207, 28);
            this.txtMarka.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Seri ";
            // 
            // txtSeri
            // 
            this.txtSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeri.Location = new System.Drawing.Point(12, 510);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(207, 28);
            this.txtSeri.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Numara";
            // 
            // txtNumara
            // 
            this.txtNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumara.Location = new System.Drawing.Point(12, 569);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(207, 28);
            this.txtNumara.TabIndex = 3;
            // 
            // btnTuketimDuzenle
            // 
            this.btnTuketimDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTuketimDuzenle.Location = new System.Drawing.Point(1374, 24);
            this.btnTuketimDuzenle.Name = "btnTuketimDuzenle";
            this.btnTuketimDuzenle.Size = new System.Drawing.Size(197, 52);
            this.btnTuketimDuzenle.TabIndex = 9;
            this.btnTuketimDuzenle.Text = "Tüketim Düzenle";
            this.btnTuketimDuzenle.UseVisualStyleBackColor = true;
            this.btnTuketimDuzenle.Click += new System.EventHandler(this.btnTuketimDuzenle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 647);
            this.Controls.Add(this.btnTuketimDuzenle);
            this.Controls.Add(this.btnEKaydet);
            this.Controls.Add(this.txtEndeks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtSeri);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTuketim);
            this.Controls.Add(this.dgAbone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAbone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTuketim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAbone;
        private System.Windows.Forms.DataGridView dgTuketim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtEndeks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Button btnTuketimDuzenle;
    }
}

