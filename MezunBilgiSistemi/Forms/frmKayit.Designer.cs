﻿namespace MezunBilgiSistemi.Forms
{
    partial class frmKayit
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
            this.lbOgrBilgi = new System.Windows.Forms.Label();
            this.lbAd = new System.Windows.Forms.Label();
            this.lbAdres = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbEposta = new System.Windows.Forms.Label();
            this.lbDil = new System.Windows.Forms.Label();
            this.lbUyruk = new System.Windows.Forms.Label();
            this.lbDogumTarih = new System.Windows.Forms.Label();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtUyruk = new System.Windows.Forms.TextBox();
            this.lbStajBilgi = new System.Windows.Forms.Label();
            this.cboxDil = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbOgrNo = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.btnOgrAra = new System.Windows.Forms.Button();
            this.btnOgrKaldir = new System.Windows.Forms.Button();
            this.lbBolAd = new System.Windows.Forms.Label();
            this.lbBaslangic = new System.Windows.Forms.Label();
            this.lbBitis = new System.Windows.Forms.Label();
            this.lbNotOrt = new System.Windows.Forms.Label();
            this.lbBasariBelgesi = new System.Windows.Forms.Label();
            this.chbBasari = new System.Windows.Forms.CheckBox();
            this.txtNotOrt = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridStaj = new System.Windows.Forms.DataGridView();
            this.btnStajEkle = new System.Windows.Forms.Button();
            this.txtBaslangicYili = new System.Windows.Forms.TextBox();
            this.txtBitisYili = new System.Windows.Forms.TextBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaj)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOgrBilgi
            // 
            this.lbOgrBilgi.AutoSize = true;
            this.lbOgrBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbOgrBilgi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbOgrBilgi.Location = new System.Drawing.Point(175, 30);
            this.lbOgrBilgi.Name = "lbOgrBilgi";
            this.lbOgrBilgi.Size = new System.Drawing.Size(224, 20);
            this.lbOgrBilgi.TabIndex = 0;
            this.lbOgrBilgi.Text = "- - - Öğrenci Bilgileri - - -";
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Location = new System.Drawing.Point(27, 85);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(69, 17);
            this.lbAd.TabIndex = 1;
            this.lbAd.Text = "Ad Soyad";
            // 
            // lbAdres
            // 
            this.lbAdres.AutoSize = true;
            this.lbAdres.Location = new System.Drawing.Point(27, 119);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(45, 17);
            this.lbAdres.TabIndex = 2;
            this.lbAdres.Text = "Adres";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(27, 245);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(56, 17);
            this.lbTel.TabIndex = 3;
            this.lbTel.Text = "Telefon";
            // 
            // lbEposta
            // 
            this.lbEposta.AutoSize = true;
            this.lbEposta.Location = new System.Drawing.Point(27, 285);
            this.lbEposta.Name = "lbEposta";
            this.lbEposta.Size = new System.Drawing.Size(66, 17);
            this.lbEposta.TabIndex = 4;
            this.lbEposta.Text = "E - Posta";
            // 
            // lbDil
            // 
            this.lbDil.AutoSize = true;
            this.lbDil.Location = new System.Drawing.Point(27, 323);
            this.lbDil.Name = "lbDil";
            this.lbDil.Size = new System.Drawing.Size(135, 17);
            this.lbDil.TabIndex = 5;
            this.lbDil.Text = "Yabancı Dil Seviyesi";
            // 
            // lbUyruk
            // 
            this.lbUyruk.AutoSize = true;
            this.lbUyruk.Location = new System.Drawing.Point(27, 361);
            this.lbUyruk.Name = "lbUyruk";
            this.lbUyruk.Size = new System.Drawing.Size(45, 17);
            this.lbUyruk.TabIndex = 6;
            this.lbUyruk.Text = "Uyruk";
            // 
            // lbDogumTarih
            // 
            this.lbDogumTarih.AutoSize = true;
            this.lbDogumTarih.Location = new System.Drawing.Point(27, 397);
            this.lbDogumTarih.Name = "lbDogumTarih";
            this.lbDogumTarih.Size = new System.Drawing.Size(93, 17);
            this.lbDogumTarih.TabIndex = 7;
            this.lbDogumTarih.Text = "Doğum Tarihi";
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Location = new System.Drawing.Point(189, 397);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dateDogumTarihi.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(189, 80);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 9;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(189, 119);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 107);
            this.txtAdres.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(189, 240);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 22);
            this.txtTel.TabIndex = 11;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(189, 280);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(200, 22);
            this.txtEposta.TabIndex = 12;
            // 
            // txtUyruk
            // 
            this.txtUyruk.Location = new System.Drawing.Point(189, 356);
            this.txtUyruk.Name = "txtUyruk";
            this.txtUyruk.Size = new System.Drawing.Size(200, 22);
            this.txtUyruk.TabIndex = 14;
            // 
            // lbStajBilgi
            // 
            this.lbStajBilgi.AutoSize = true;
            this.lbStajBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbStajBilgi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbStajBilgi.Location = new System.Drawing.Point(185, 451);
            this.lbStajBilgi.Name = "lbStajBilgi";
            this.lbStajBilgi.Size = new System.Drawing.Size(191, 20);
            this.lbStajBilgi.TabIndex = 15;
            this.lbStajBilgi.Text = "- - - Staj Bilgileri - - -";
            // 
            // cboxDil
            // 
            this.cboxDil.FormattingEnabled = true;
            this.cboxDil.Items.AddRange(new object[] {
            "PreIntermediate",
            "Intermediate",
            "UpperIntermediate",
            "Advanced"});
            this.cboxDil.Location = new System.Drawing.Point(189, 316);
            this.cboxDil.Name = "cboxDil";
            this.cboxDil.Size = new System.Drawing.Size(200, 24);
            this.cboxDil.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(858, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "- - - Öğrenci Arama - - -";
            // 
            // lbOgrNo
            // 
            this.lbOgrNo.AutoSize = true;
            this.lbOgrNo.Location = new System.Drawing.Point(702, 59);
            this.lbOgrNo.Name = "lbOgrNo";
            this.lbOgrNo.Size = new System.Drawing.Size(80, 17);
            this.lbOgrNo.TabIndex = 25;
            this.lbOgrNo.Text = "Öğrenci No";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(862, 54);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(228, 22);
            this.txtOgrNo.TabIndex = 26;
            // 
            // btnOgrAra
            // 
            this.btnOgrAra.Location = new System.Drawing.Point(855, 540);
            this.btnOgrAra.Name = "btnOgrAra";
            this.btnOgrAra.Size = new System.Drawing.Size(106, 36);
            this.btnOgrAra.TabIndex = 27;
            this.btnOgrAra.Text = "Öğrenci Ara";
            this.btnOgrAra.UseVisualStyleBackColor = true;
            // 
            // btnOgrKaldir
            // 
            this.btnOgrKaldir.Location = new System.Drawing.Point(967, 540);
            this.btnOgrKaldir.Name = "btnOgrKaldir";
            this.btnOgrKaldir.Size = new System.Drawing.Size(116, 36);
            this.btnOgrKaldir.TabIndex = 28;
            this.btnOgrKaldir.Text = "Öğrenci Kaldır";
            this.btnOgrKaldir.UseVisualStyleBackColor = true;
            // 
            // lbBolAd
            // 
            this.lbBolAd.AutoSize = true;
            this.lbBolAd.Location = new System.Drawing.Point(702, 85);
            this.lbBolAd.Name = "lbBolAd";
            this.lbBolAd.Size = new System.Drawing.Size(71, 17);
            this.lbBolAd.TabIndex = 29;
            this.lbBolAd.Text = "Bölüm Adı";
            // 
            // lbBaslangic
            // 
            this.lbBaslangic.AutoSize = true;
            this.lbBaslangic.Location = new System.Drawing.Point(702, 125);
            this.lbBaslangic.Name = "lbBaslangic";
            this.lbBaslangic.Size = new System.Drawing.Size(91, 17);
            this.lbBaslangic.TabIndex = 30;
            this.lbBaslangic.Text = "Başlangıç Yılı";
            // 
            // lbBitis
            // 
            this.lbBitis.AutoSize = true;
            this.lbBitis.Location = new System.Drawing.Point(702, 163);
            this.lbBitis.Name = "lbBitis";
            this.lbBitis.Size = new System.Drawing.Size(56, 17);
            this.lbBitis.TabIndex = 31;
            this.lbBitis.Text = "Bitiş Yılı";
            // 
            // lbNotOrt
            // 
            this.lbNotOrt.AutoSize = true;
            this.lbNotOrt.Location = new System.Drawing.Point(702, 201);
            this.lbNotOrt.Name = "lbNotOrt";
            this.lbNotOrt.Size = new System.Drawing.Size(102, 17);
            this.lbNotOrt.TabIndex = 32;
            this.lbNotOrt.Text = "Not Ortalaması";
            // 
            // lbBasariBelgesi
            // 
            this.lbBasariBelgesi.AutoSize = true;
            this.lbBasariBelgesi.Location = new System.Drawing.Point(702, 237);
            this.lbBasariBelgesi.Name = "lbBasariBelgesi";
            this.lbBasariBelgesi.Size = new System.Drawing.Size(98, 17);
            this.lbBasariBelgesi.TabIndex = 33;
            this.lbBasariBelgesi.Text = "Başarı Belgesi";
            // 
            // chbBasari
            // 
            this.chbBasari.AutoSize = true;
            this.chbBasari.Location = new System.Drawing.Point(862, 237);
            this.chbBasari.Name = "chbBasari";
            this.chbBasari.Size = new System.Drawing.Size(52, 21);
            this.chbBasari.TabIndex = 34;
            this.chbBasari.Text = "Var";
            this.chbBasari.UseVisualStyleBackColor = true;
            // 
            // txtNotOrt
            // 
            this.txtNotOrt.Location = new System.Drawing.Point(862, 196);
            this.txtNotOrt.Name = "txtNotOrt";
            this.txtNotOrt.Size = new System.Drawing.Size(200, 22);
            this.txtNotOrt.TabIndex = 38;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(862, 291);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 44);
            this.btnKaydet.TabIndex = 39;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridStaj
            // 
            this.dataGridStaj.AllowUserToAddRows = false;
            this.dataGridStaj.AllowUserToDeleteRows = false;
            this.dataGridStaj.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridStaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStaj.Location = new System.Drawing.Point(30, 474);
            this.dataGridStaj.Name = "dataGridStaj";
            this.dataGridStaj.ReadOnly = true;
            this.dataGridStaj.RowTemplate.Height = 24;
            this.dataGridStaj.Size = new System.Drawing.Size(458, 119);
            this.dataGridStaj.TabIndex = 43;
            // 
            // btnStajEkle
            // 
            this.btnStajEkle.Location = new System.Drawing.Point(511, 474);
            this.btnStajEkle.Name = "btnStajEkle";
            this.btnStajEkle.Size = new System.Drawing.Size(101, 60);
            this.btnStajEkle.TabIndex = 44;
            this.btnStajEkle.Text = "Staj Ekle";
            this.btnStajEkle.UseVisualStyleBackColor = true;
            this.btnStajEkle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtBaslangicYili
            // 
            this.txtBaslangicYili.Location = new System.Drawing.Point(862, 120);
            this.txtBaslangicYili.Name = "txtBaslangicYili";
            this.txtBaslangicYili.Size = new System.Drawing.Size(200, 22);
            this.txtBaslangicYili.TabIndex = 45;
            // 
            // txtBitisYili
            // 
            this.txtBitisYili.Location = new System.Drawing.Point(862, 160);
            this.txtBitisYili.Name = "txtBitisYili";
            this.txtBitisYili.Size = new System.Drawing.Size(200, 22);
            this.txtBitisYili.TabIndex = 46;
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Items.AddRange(new object[] {
            "Yazılım Mühendisliği",
            "Makine Mühendisliği"});
            this.cmbBolum.Location = new System.Drawing.Point(862, 82);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(200, 24);
            this.cmbBolum.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(862, 491);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Öğrenci No";
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 665);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.txtBitisYili);
            this.Controls.Add(this.txtBaslangicYili);
            this.Controls.Add(this.btnStajEkle);
            this.Controls.Add(this.dataGridStaj);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtNotOrt);
            this.Controls.Add(this.chbBasari);
            this.Controls.Add(this.lbBasariBelgesi);
            this.Controls.Add(this.lbNotOrt);
            this.Controls.Add(this.lbBitis);
            this.Controls.Add(this.lbBaslangic);
            this.Controls.Add(this.lbBolAd);
            this.Controls.Add(this.btnOgrKaldir);
            this.Controls.Add(this.btnOgrAra);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.lbOgrNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboxDil);
            this.Controls.Add(this.lbStajBilgi);
            this.Controls.Add(this.txtUyruk);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dateDogumTarihi);
            this.Controls.Add(this.lbDogumTarih);
            this.Controls.Add(this.lbUyruk);
            this.Controls.Add(this.lbDil);
            this.Controls.Add(this.lbEposta);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbAdres);
            this.Controls.Add(this.lbAd);
            this.Controls.Add(this.lbOgrBilgi);
            this.Name = "frmKayit";
            this.Text = "Öğrenci Bilgileri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKayit_FormClosed);
            this.Load += new System.EventHandler(this.frmKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOgrBilgi;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbEposta;
        private System.Windows.Forms.Label lbDil;
        private System.Windows.Forms.Label lbUyruk;
        private System.Windows.Forms.Label lbDogumTarih;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtUyruk;
        private System.Windows.Forms.Label lbStajBilgi;
        private System.Windows.Forms.ComboBox cboxDil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbOgrNo;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Button btnOgrAra;
        private System.Windows.Forms.Button btnOgrKaldir;
        private System.Windows.Forms.Label lbBolAd;
        private System.Windows.Forms.Label lbBaslangic;
        private System.Windows.Forms.Label lbBitis;
        private System.Windows.Forms.Label lbNotOrt;
        private System.Windows.Forms.Label lbBasariBelgesi;
        private System.Windows.Forms.CheckBox chbBasari;
        private System.Windows.Forms.TextBox txtNotOrt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridStaj;
        private System.Windows.Forms.Button btnStajEkle;
        private System.Windows.Forms.TextBox txtBaslangicYili;
        private System.Windows.Forms.TextBox txtBitisYili;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}