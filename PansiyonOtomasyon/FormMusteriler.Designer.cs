
namespace PansiyonOtomasyon
{
    partial class BtnVerileriGoster
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerilerliGoster = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.textBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskdTxtBoxTlfn = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTcNo = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.labelTlfn = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelSoyadı = new System.Windows.Forms.Label();
            this.labelTcNo = new System.Windows.Forms.Label();
            this.labelAdı = new System.Windows.Forms.Label();
            this.dateCikisTarih = new System.Windows.Forms.DateTimePicker();
            this.dateTimeGiris = new System.Windows.Forms.DateTimePicker();
            this.textBoxUcret = new System.Windows.Forms.TextBox();
            this.textBoxOdaNo = new System.Windows.Forms.TextBox();
            this.labelCikisTrh = new System.Windows.Forms.Label();
            this.labelUcret = new System.Windows.Forms.Label();
            this.labelGirisTrh = new System.Windows.Forms.Label();
            this.labelOdaNo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 286);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(927, 164);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 89;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TC";
            this.columnHeader7.Width = 105;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "OdaNo";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ücret";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "GirişTarihi";
            this.columnHeader10.Width = 102;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ÇıkışTarihi";
            this.columnHeader11.Width = 122;
            // 
            // btnVerilerliGoster
            // 
            this.btnVerilerliGoster.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerilerliGoster.Location = new System.Drawing.Point(764, 13);
            this.btnVerilerliGoster.Name = "btnVerilerliGoster";
            this.btnVerilerliGoster.Size = new System.Drawing.Size(151, 32);
            this.btnVerilerliGoster.TabIndex = 1;
            this.btnVerilerliGoster.Text = "Verileri Göster";
            this.btnVerilerliGoster.UseVisualStyleBackColor = true;
            this.btnVerilerliGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(764, 55);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(151, 32);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(764, 93);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(151, 32);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(764, 169);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(151, 32);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // textBoxCinsiyet
            // 
            this.textBoxCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCinsiyet.FormattingEnabled = true;
            this.textBoxCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.textBoxCinsiyet.Location = new System.Drawing.Point(102, 83);
            this.textBoxCinsiyet.Name = "textBoxCinsiyet";
            this.textBoxCinsiyet.Size = new System.Drawing.Size(245, 28);
            this.textBoxCinsiyet.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Cinsiyet:";
            // 
            // mskdTxtBoxTlfn
            // 
            this.mskdTxtBoxTlfn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdTxtBoxTlfn.Location = new System.Drawing.Point(102, 117);
            this.mskdTxtBoxTlfn.Mask = "(999) 000-0000";
            this.mskdTxtBoxTlfn.Name = "mskdTxtBoxTlfn";
            this.mskdTxtBoxTlfn.Size = new System.Drawing.Size(245, 27);
            this.mskdTxtBoxTlfn.TabIndex = 41;
            // 
            // textBoxTcNo
            // 
            this.textBoxTcNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTcNo.Location = new System.Drawing.Point(102, 183);
            this.textBoxTcNo.MaxLength = 11;
            this.textBoxTcNo.Name = "textBoxTcNo";
            this.textBoxTcNo.Size = new System.Drawing.Size(244, 27);
            this.textBoxTcNo.TabIndex = 50;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMail.Location = new System.Drawing.Point(102, 150);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(244, 27);
            this.textBoxMail.TabIndex = 49;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(102, 50);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(244, 27);
            this.textBoxSoyad.TabIndex = 48;
            // 
            // labelTlfn
            // 
            this.labelTlfn.AutoSize = true;
            this.labelTlfn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTlfn.Location = new System.Drawing.Point(42, 122);
            this.labelTlfn.Name = "labelTlfn";
            this.labelTlfn.Size = new System.Drawing.Size(54, 17);
            this.labelTlfn.TabIndex = 47;
            this.labelTlfn.Text = "Telefon:";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(102, 17);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(244, 27);
            this.textBoxAd.TabIndex = 46;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMail.Location = new System.Drawing.Point(63, 155);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(36, 17);
            this.labelMail.TabIndex = 45;
            this.labelMail.Text = "Mail:";
            // 
            // labelSoyadı
            // 
            this.labelSoyadı.AutoSize = true;
            this.labelSoyadı.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyadı.Location = new System.Drawing.Point(42, 55);
            this.labelSoyadı.Name = "labelSoyadı";
            this.labelSoyadı.Size = new System.Drawing.Size(51, 17);
            this.labelSoyadı.TabIndex = 44;
            this.labelSoyadı.Text = "Soyadı:";
            // 
            // labelTcNo
            // 
            this.labelTcNo.AutoSize = true;
            this.labelTcNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTcNo.Location = new System.Drawing.Point(3, 188);
            this.labelTcNo.Name = "labelTcNo";
            this.labelTcNo.Size = new System.Drawing.Size(93, 17);
            this.labelTcNo.TabIndex = 43;
            this.labelTcNo.Text = "T.C. Kimlik No:";
            // 
            // labelAdı
            // 
            this.labelAdı.AutoSize = true;
            this.labelAdı.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdı.Location = new System.Drawing.Point(65, 22);
            this.labelAdı.Name = "labelAdı";
            this.labelAdı.Size = new System.Drawing.Size(31, 17);
            this.labelAdı.TabIndex = 42;
            this.labelAdı.Text = "Adı:";
            // 
            // dateCikisTarih
            // 
            this.dateCikisTarih.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.dateCikisTarih.Location = new System.Drawing.Point(450, 116);
            this.dateCikisTarih.Name = "dateCikisTarih";
            this.dateCikisTarih.Size = new System.Drawing.Size(257, 27);
            this.dateCikisTarih.TabIndex = 60;
            // 
            // dateTimeGiris
            // 
            this.dateTimeGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.dateTimeGiris.Location = new System.Drawing.Point(450, 83);
            this.dateTimeGiris.Name = "dateTimeGiris";
            this.dateTimeGiris.Size = new System.Drawing.Size(257, 27);
            this.dateTimeGiris.TabIndex = 59;
            // 
            // textBoxUcret
            // 
            this.textBoxUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUcret.Location = new System.Drawing.Point(450, 50);
            this.textBoxUcret.Name = "textBoxUcret";
            this.textBoxUcret.Size = new System.Drawing.Size(257, 27);
            this.textBoxUcret.TabIndex = 58;
            // 
            // textBoxOdaNo
            // 
            this.textBoxOdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOdaNo.Location = new System.Drawing.Point(450, 17);
            this.textBoxOdaNo.Name = "textBoxOdaNo";
            this.textBoxOdaNo.Size = new System.Drawing.Size(257, 27);
            this.textBoxOdaNo.TabIndex = 57;
            this.textBoxOdaNo.TextChanged += new System.EventHandler(this.textBoxOdaNo_TextChanged);
            // 
            // labelCikisTrh
            // 
            this.labelCikisTrh.AutoSize = true;
            this.labelCikisTrh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCikisTrh.Location = new System.Drawing.Point(367, 123);
            this.labelCikisTrh.Name = "labelCikisTrh";
            this.labelCikisTrh.Size = new System.Drawing.Size(74, 17);
            this.labelCikisTrh.TabIndex = 56;
            this.labelCikisTrh.Text = "Çıkış Tarihi:";
            // 
            // labelUcret
            // 
            this.labelUcret.AutoSize = true;
            this.labelUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUcret.Location = new System.Drawing.Point(399, 55);
            this.labelUcret.Name = "labelUcret";
            this.labelUcret.Size = new System.Drawing.Size(43, 17);
            this.labelUcret.TabIndex = 55;
            this.labelUcret.Text = "Ücret:";
            // 
            // labelGirisTrh
            // 
            this.labelGirisTrh.AutoSize = true;
            this.labelGirisTrh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGirisTrh.Location = new System.Drawing.Point(368, 90);
            this.labelGirisTrh.Name = "labelGirisTrh";
            this.labelGirisTrh.Size = new System.Drawing.Size(73, 17);
            this.labelGirisTrh.TabIndex = 54;
            this.labelGirisTrh.Text = "Giriş Tarihi:";
            // 
            // labelOdaNo
            // 
            this.labelOdaNo.AutoSize = true;
            this.labelOdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdaNo.Location = new System.Drawing.Point(385, 22);
            this.labelOdaNo.Name = "labelOdaNo";
            this.labelOdaNo.Size = new System.Drawing.Size(58, 17);
            this.labelOdaNo.TabIndex = 53;
            this.labelOdaNo.Text = "Oda No:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(671, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 27);
            this.textBox1.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(634, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "İsim:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(764, 131);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(151, 32);
            this.btnTemizle.TabIndex = 63;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // BtnVerileriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateCikisTarih);
            this.Controls.Add(this.dateTimeGiris);
            this.Controls.Add(this.textBoxUcret);
            this.Controls.Add(this.textBoxOdaNo);
            this.Controls.Add(this.labelCikisTrh);
            this.Controls.Add(this.labelUcret);
            this.Controls.Add(this.labelGirisTrh);
            this.Controls.Add(this.labelOdaNo);
            this.Controls.Add(this.textBoxCinsiyet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskdTxtBoxTlfn);
            this.Controls.Add(this.textBoxTcNo);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.labelTlfn);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelSoyadı);
            this.Controls.Add(this.labelTcNo);
            this.Controls.Add(this.labelAdı);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnVerilerliGoster);
            this.Controls.Add(this.listView1);
            this.Name = "BtnVerileriGoster";
            this.Text = "FormMusteriler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnVerilerliGoster;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox textBoxCinsiyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdTxtBoxTlfn;
        private System.Windows.Forms.TextBox textBoxTcNo;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label labelTlfn;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelSoyadı;
        private System.Windows.Forms.Label labelTcNo;
        private System.Windows.Forms.Label labelAdı;
        private System.Windows.Forms.DateTimePicker dateCikisTarih;
        private System.Windows.Forms.DateTimePicker dateTimeGiris;
        private System.Windows.Forms.TextBox textBoxUcret;
        private System.Windows.Forms.TextBox textBoxOdaNo;
        private System.Windows.Forms.Label labelCikisTrh;
        private System.Windows.Forms.Label labelUcret;
        private System.Windows.Forms.Label labelGirisTrh;
        private System.Windows.Forms.Label labelOdaNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
    }
}