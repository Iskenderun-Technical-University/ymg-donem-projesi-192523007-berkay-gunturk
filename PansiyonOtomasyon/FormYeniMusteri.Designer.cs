
namespace PansiyonOtomasyon
{
    partial class FormYeniMusteri
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
            this.groupBoxMusteriBilgi = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.mskdTxtBoxTlfn = new System.Windows.Forms.MaskedTextBox();
            this.dateCikisTarih = new System.Windows.Forms.DateTimePicker();
            this.dateTimeGiris = new System.Windows.Forms.DateTimePicker();
            this.textBoxUcret = new System.Windows.Forms.TextBox();
            this.textBoxOdaNo = new System.Windows.Forms.TextBox();
            this.textBoxTcNo = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.labelTlfn = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.labelCikisTrh = new System.Windows.Forms.Label();
            this.labelUcret = new System.Windows.Forms.Label();
            this.labelGirisTrh = new System.Windows.Forms.Label();
            this.labelOdaNo = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelSoyadı = new System.Windows.Forms.Label();
            this.labelTcNo = new System.Windows.Forms.Label();
            this.labelAdı = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxOdalar = new System.Windows.Forms.GroupBox();
            this.btnOda109 = new System.Windows.Forms.Button();
            this.btnOda108 = new System.Windows.Forms.Button();
            this.btnOda107 = new System.Windows.Forms.Button();
            this.btnOda106 = new System.Windows.Forms.Button();
            this.btnOda105 = new System.Windows.Forms.Button();
            this.btnOda104 = new System.Windows.Forms.Button();
            this.btnOda103 = new System.Windows.Forms.Button();
            this.btnOda102 = new System.Windows.Forms.Button();
            this.btnOda101 = new System.Windows.Forms.Button();
            this.btnBOŞ = new System.Windows.Forms.Button();
            this.btnDOLU = new System.Windows.Forms.Button();
            this.groupBoxMusteriBilgi.SuspendLayout();
            this.groupBoxOdalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMusteriBilgi
            // 
            this.groupBoxMusteriBilgi.Controls.Add(this.label2);
            this.groupBoxMusteriBilgi.Controls.Add(this.textBoxCinsiyet);
            this.groupBoxMusteriBilgi.Controls.Add(this.label1);
            this.groupBoxMusteriBilgi.Controls.Add(this.btnKaydet);
            this.groupBoxMusteriBilgi.Controls.Add(this.mskdTxtBoxTlfn);
            this.groupBoxMusteriBilgi.Controls.Add(this.dateCikisTarih);
            this.groupBoxMusteriBilgi.Controls.Add(this.dateTimeGiris);
            this.groupBoxMusteriBilgi.Controls.Add(this.textBoxUcret);
            this.groupBoxMusteriBilgi.Controls.Add(this.textBoxOdaNo);
            this.groupBoxMusteriBilgi.Controls.Add(this.textBoxTcNo);
            this.groupBoxMusteriBilgi.Controls.Add(this.textBoxMail);
            this.groupBoxMusteriBilgi.Controls.Add(this.textBoxSoyad);
            this.groupBoxMusteriBilgi.Controls.Add(this.labelTlfn);
            this.groupBoxMusteriBilgi.Controls.Add(this.textBoxAd);
            this.groupBoxMusteriBilgi.Controls.Add(this.labelCikisTrh);
            this.groupBoxMusteriBilgi.Controls.Add(this.labelUcret);
            this.groupBoxMusteriBilgi.Controls.Add(this.labelGirisTrh);
            this.groupBoxMusteriBilgi.Controls.Add(this.labelOdaNo);
            this.groupBoxMusteriBilgi.Controls.Add(this.labelMail);
            this.groupBoxMusteriBilgi.Controls.Add(this.labelSoyadı);
            this.groupBoxMusteriBilgi.Controls.Add(this.labelTcNo);
            this.groupBoxMusteriBilgi.Controls.Add(this.labelAdı);
            this.groupBoxMusteriBilgi.Location = new System.Drawing.Point(2, 2);
            this.groupBoxMusteriBilgi.Name = "groupBoxMusteriBilgi";
            this.groupBoxMusteriBilgi.Size = new System.Drawing.Size(417, 394);
            this.groupBoxMusteriBilgi.TabIndex = 0;
            this.groupBoxMusteriBilgi.TabStop = false;
            this.groupBoxMusteriBilgi.Text = "Müşteri Bilgileri";
            this.groupBoxMusteriBilgi.Enter += new System.EventHandler(this.groupBoxMusteriBilgi_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // textBoxCinsiyet
            // 
            this.textBoxCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCinsiyet.FormattingEnabled = true;
            this.textBoxCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.textBoxCinsiyet.Location = new System.Drawing.Point(105, 90);
            this.textBoxCinsiyet.Name = "textBoxCinsiyet";
            this.textBoxCinsiyet.Size = new System.Drawing.Size(258, 28);
            this.textBoxCinsiyet.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Cinsiyet:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(176, 359);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(95, 30);
            this.btnKaydet.TabIndex = 38;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // mskdTxtBoxTlfn
            // 
            this.mskdTxtBoxTlfn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdTxtBoxTlfn.Location = new System.Drawing.Point(105, 124);
            this.mskdTxtBoxTlfn.Mask = "(999) 000-0000";
            this.mskdTxtBoxTlfn.Name = "mskdTxtBoxTlfn";
            this.mskdTxtBoxTlfn.Size = new System.Drawing.Size(258, 27);
            this.mskdTxtBoxTlfn.TabIndex = 1;
            this.mskdTxtBoxTlfn.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // dateCikisTarih
            // 
            this.dateCikisTarih.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.dateCikisTarih.Location = new System.Drawing.Point(105, 322);
            this.dateCikisTarih.Name = "dateCikisTarih";
            this.dateCikisTarih.Size = new System.Drawing.Size(257, 27);
            this.dateCikisTarih.TabIndex = 37;
            this.dateCikisTarih.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimeGiris
            // 
            this.dateTimeGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.dateTimeGiris.Location = new System.Drawing.Point(105, 289);
            this.dateTimeGiris.Name = "dateTimeGiris";
            this.dateTimeGiris.Size = new System.Drawing.Size(257, 27);
            this.dateTimeGiris.TabIndex = 36;
            this.dateTimeGiris.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBoxUcret
            // 
            this.textBoxUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUcret.Location = new System.Drawing.Point(105, 256);
            this.textBoxUcret.Name = "textBoxUcret";
            this.textBoxUcret.Size = new System.Drawing.Size(257, 27);
            this.textBoxUcret.TabIndex = 35;
            this.textBoxUcret.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBoxOdaNo
            // 
            this.textBoxOdaNo.Enabled = false;
            this.textBoxOdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOdaNo.Location = new System.Drawing.Point(105, 223);
            this.textBoxOdaNo.Name = "textBoxOdaNo";
            this.textBoxOdaNo.Size = new System.Drawing.Size(257, 27);
            this.textBoxOdaNo.TabIndex = 34;
            this.textBoxOdaNo.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBoxTcNo
            // 
            this.textBoxTcNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTcNo.Location = new System.Drawing.Point(105, 190);
            this.textBoxTcNo.MaxLength = 11;
            this.textBoxTcNo.Name = "textBoxTcNo";
            this.textBoxTcNo.Size = new System.Drawing.Size(257, 27);
            this.textBoxTcNo.TabIndex = 33;
            this.textBoxTcNo.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMail.Location = new System.Drawing.Point(105, 157);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(257, 27);
            this.textBoxMail.TabIndex = 32;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(105, 57);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(257, 27);
            this.textBoxSoyad.TabIndex = 30;
            this.textBoxSoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelTlfn
            // 
            this.labelTlfn.AutoSize = true;
            this.labelTlfn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTlfn.Location = new System.Drawing.Point(45, 129);
            this.labelTlfn.Name = "labelTlfn";
            this.labelTlfn.Size = new System.Drawing.Size(54, 17);
            this.labelTlfn.TabIndex = 29;
            this.labelTlfn.Text = "Telefon:";
            this.labelTlfn.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(105, 24);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(257, 27);
            this.textBoxAd.TabIndex = 28;
            this.textBoxAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCikisTrh
            // 
            this.labelCikisTrh.AutoSize = true;
            this.labelCikisTrh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCikisTrh.Location = new System.Drawing.Point(22, 329);
            this.labelCikisTrh.Name = "labelCikisTrh";
            this.labelCikisTrh.Size = new System.Drawing.Size(74, 17);
            this.labelCikisTrh.TabIndex = 27;
            this.labelCikisTrh.Text = "Çıkış Tarihi:";
            this.labelCikisTrh.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelUcret
            // 
            this.labelUcret.AutoSize = true;
            this.labelUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUcret.Location = new System.Drawing.Point(54, 261);
            this.labelUcret.Name = "labelUcret";
            this.labelUcret.Size = new System.Drawing.Size(43, 17);
            this.labelUcret.TabIndex = 26;
            this.labelUcret.Text = "Ücret:";
            this.labelUcret.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // labelGirisTrh
            // 
            this.labelGirisTrh.AutoSize = true;
            this.labelGirisTrh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGirisTrh.Location = new System.Drawing.Point(23, 296);
            this.labelGirisTrh.Name = "labelGirisTrh";
            this.labelGirisTrh.Size = new System.Drawing.Size(73, 17);
            this.labelGirisTrh.TabIndex = 25;
            this.labelGirisTrh.Text = "Giriş Tarihi:";
            this.labelGirisTrh.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // labelOdaNo
            // 
            this.labelOdaNo.AutoSize = true;
            this.labelOdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdaNo.Location = new System.Drawing.Point(40, 228);
            this.labelOdaNo.Name = "labelOdaNo";
            this.labelOdaNo.Size = new System.Drawing.Size(58, 17);
            this.labelOdaNo.TabIndex = 24;
            this.labelOdaNo.Text = "Oda No:";
            this.labelOdaNo.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMail.Location = new System.Drawing.Point(66, 162);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(36, 17);
            this.labelMail.TabIndex = 23;
            this.labelMail.Text = "Mail:";
            this.labelMail.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // labelSoyadı
            // 
            this.labelSoyadı.AutoSize = true;
            this.labelSoyadı.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyadı.Location = new System.Drawing.Point(45, 62);
            this.labelSoyadı.Name = "labelSoyadı";
            this.labelSoyadı.Size = new System.Drawing.Size(51, 17);
            this.labelSoyadı.TabIndex = 22;
            this.labelSoyadı.Text = "Soyadı:";
            this.labelSoyadı.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelTcNo
            // 
            this.labelTcNo.AutoSize = true;
            this.labelTcNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTcNo.Location = new System.Drawing.Point(6, 195);
            this.labelTcNo.Name = "labelTcNo";
            this.labelTcNo.Size = new System.Drawing.Size(93, 17);
            this.labelTcNo.TabIndex = 21;
            this.labelTcNo.Text = "T.C. Kimlik No:";
            this.labelTcNo.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // labelAdı
            // 
            this.labelAdı.AutoSize = true;
            this.labelAdı.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdı.Location = new System.Drawing.Point(68, 29);
            this.labelAdı.Name = "labelAdı";
            this.labelAdı.Size = new System.Drawing.Size(31, 17);
            this.labelAdı.TabIndex = 20;
            this.labelAdı.Text = "Adı:";
            this.labelAdı.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBoxOdalar
            // 
            this.groupBoxOdalar.Controls.Add(this.btnOda109);
            this.groupBoxOdalar.Controls.Add(this.btnOda108);
            this.groupBoxOdalar.Controls.Add(this.btnOda107);
            this.groupBoxOdalar.Controls.Add(this.btnOda106);
            this.groupBoxOdalar.Controls.Add(this.btnOda105);
            this.groupBoxOdalar.Controls.Add(this.btnOda104);
            this.groupBoxOdalar.Controls.Add(this.btnOda103);
            this.groupBoxOdalar.Controls.Add(this.btnOda102);
            this.groupBoxOdalar.Controls.Add(this.btnOda101);
            this.groupBoxOdalar.Location = new System.Drawing.Point(425, 2);
            this.groupBoxOdalar.Name = "groupBoxOdalar";
            this.groupBoxOdalar.Size = new System.Drawing.Size(392, 394);
            this.groupBoxOdalar.TabIndex = 1;
            this.groupBoxOdalar.TabStop = false;
            this.groupBoxOdalar.Text = "Odalar";
            this.groupBoxOdalar.Enter += new System.EventHandler(this.groupBoxOdalar_Enter);
            // 
            // btnOda109
            // 
            this.btnOda109.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOda109.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda109.Location = new System.Drawing.Point(282, 256);
            this.btnOda109.Name = "btnOda109";
            this.btnOda109.Size = new System.Drawing.Size(75, 35);
            this.btnOda109.TabIndex = 46;
            this.btnOda109.Text = "109";
            this.btnOda109.UseVisualStyleBackColor = false;
            this.btnOda109.Click += new System.EventHandler(this.btnOda109_Click);
            // 
            // btnOda108
            // 
            this.btnOda108.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOda108.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda108.Location = new System.Drawing.Point(157, 256);
            this.btnOda108.Name = "btnOda108";
            this.btnOda108.Size = new System.Drawing.Size(75, 35);
            this.btnOda108.TabIndex = 45;
            this.btnOda108.Text = "108";
            this.btnOda108.UseVisualStyleBackColor = false;
            this.btnOda108.Click += new System.EventHandler(this.btnOda108_Click);
            // 
            // btnOda107
            // 
            this.btnOda107.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOda107.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda107.Location = new System.Drawing.Point(28, 256);
            this.btnOda107.Name = "btnOda107";
            this.btnOda107.Size = new System.Drawing.Size(75, 35);
            this.btnOda107.TabIndex = 44;
            this.btnOda107.Text = "107";
            this.btnOda107.UseVisualStyleBackColor = false;
            this.btnOda107.Click += new System.EventHandler(this.btnOda107_Click);
            // 
            // btnOda106
            // 
            this.btnOda106.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOda106.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda106.Location = new System.Drawing.Point(282, 170);
            this.btnOda106.Name = "btnOda106";
            this.btnOda106.Size = new System.Drawing.Size(75, 35);
            this.btnOda106.TabIndex = 43;
            this.btnOda106.Text = "106";
            this.btnOda106.UseVisualStyleBackColor = false;
            this.btnOda106.Click += new System.EventHandler(this.btnOda106_Click);
            // 
            // btnOda105
            // 
            this.btnOda105.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOda105.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda105.Location = new System.Drawing.Point(157, 170);
            this.btnOda105.Name = "btnOda105";
            this.btnOda105.Size = new System.Drawing.Size(75, 35);
            this.btnOda105.TabIndex = 42;
            this.btnOda105.Text = "105";
            this.btnOda105.UseVisualStyleBackColor = false;
            this.btnOda105.Click += new System.EventHandler(this.btnOda105_Click);
            // 
            // btnOda104
            // 
            this.btnOda104.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOda104.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda104.Location = new System.Drawing.Point(28, 170);
            this.btnOda104.Name = "btnOda104";
            this.btnOda104.Size = new System.Drawing.Size(75, 35);
            this.btnOda104.TabIndex = 41;
            this.btnOda104.Text = "104";
            this.btnOda104.UseVisualStyleBackColor = false;
            this.btnOda104.Click += new System.EventHandler(this.btnOda104_Click);
            // 
            // btnOda103
            // 
            this.btnOda103.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOda103.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda103.Location = new System.Drawing.Point(282, 78);
            this.btnOda103.Name = "btnOda103";
            this.btnOda103.Size = new System.Drawing.Size(75, 35);
            this.btnOda103.TabIndex = 40;
            this.btnOda103.Text = "103";
            this.btnOda103.UseVisualStyleBackColor = false;
            this.btnOda103.Click += new System.EventHandler(this.btnOda103_Click);
            // 
            // btnOda102
            // 
            this.btnOda102.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOda102.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda102.Location = new System.Drawing.Point(157, 78);
            this.btnOda102.Name = "btnOda102";
            this.btnOda102.Size = new System.Drawing.Size(75, 35);
            this.btnOda102.TabIndex = 39;
            this.btnOda102.Text = "102";
            this.btnOda102.UseVisualStyleBackColor = false;
            this.btnOda102.Click += new System.EventHandler(this.btnOda102_Click);
            // 
            // btnOda101
            // 
            this.btnOda101.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOda101.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda101.Location = new System.Drawing.Point(28, 78);
            this.btnOda101.Name = "btnOda101";
            this.btnOda101.Size = new System.Drawing.Size(75, 35);
            this.btnOda101.TabIndex = 38;
            this.btnOda101.Text = "101";
            this.btnOda101.UseVisualStyleBackColor = false;
            this.btnOda101.Click += new System.EventHandler(this.btnOda101_Click);
            // 
            // btnBOŞ
            // 
            this.btnBOŞ.BackColor = System.Drawing.Color.GreenYellow;
            this.btnBOŞ.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBOŞ.Location = new System.Drawing.Point(728, 403);
            this.btnBOŞ.Name = "btnBOŞ";
            this.btnBOŞ.Size = new System.Drawing.Size(75, 35);
            this.btnBOŞ.TabIndex = 47;
            this.btnBOŞ.Text = "BOŞ";
            this.btnBOŞ.UseVisualStyleBackColor = false;
            this.btnBOŞ.Click += new System.EventHandler(this.btnBOŞ_Click);
            // 
            // btnDOLU
            // 
            this.btnDOLU.BackColor = System.Drawing.Color.Red;
            this.btnDOLU.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDOLU.Location = new System.Drawing.Point(635, 403);
            this.btnDOLU.Name = "btnDOLU";
            this.btnDOLU.Size = new System.Drawing.Size(75, 35);
            this.btnDOLU.TabIndex = 48;
            this.btnDOLU.Text = "DOLU";
            this.btnDOLU.UseVisualStyleBackColor = false;
            this.btnDOLU.Click += new System.EventHandler(this.btnDOLU_Click);
            // 
            // FormYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.btnDOLU);
            this.Controls.Add(this.btnBOŞ);
            this.Controls.Add(this.groupBoxOdalar);
            this.Controls.Add(this.groupBoxMusteriBilgi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormYeniMusteri";
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.FormYeniMusteri_Load);
            this.groupBoxMusteriBilgi.ResumeLayout(false);
            this.groupBoxMusteriBilgi.PerformLayout();
            this.groupBoxOdalar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMusteriBilgi;
        private System.Windows.Forms.MaskedTextBox mskdTxtBoxTlfn;
        private System.Windows.Forms.DateTimePicker dateCikisTarih;
        private System.Windows.Forms.DateTimePicker dateTimeGiris;
        private System.Windows.Forms.TextBox textBoxUcret;
        private System.Windows.Forms.TextBox textBoxOdaNo;
        private System.Windows.Forms.TextBox textBoxTcNo;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label labelTlfn;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label labelCikisTrh;
        private System.Windows.Forms.Label labelUcret;
        private System.Windows.Forms.Label labelGirisTrh;
        private System.Windows.Forms.Label labelOdaNo;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelSoyadı;
        private System.Windows.Forms.Label labelTcNo;
        private System.Windows.Forms.Label labelAdı;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxOdalar;
        private System.Windows.Forms.Button btnOda109;
        private System.Windows.Forms.Button btnOda108;
        private System.Windows.Forms.Button btnOda107;
        private System.Windows.Forms.Button btnOda106;
        private System.Windows.Forms.Button btnOda105;
        private System.Windows.Forms.Button btnOda104;
        private System.Windows.Forms.Button btnOda103;
        private System.Windows.Forms.Button btnOda102;
        private System.Windows.Forms.Button btnOda101;
        private System.Windows.Forms.Button btnBOŞ;
        private System.Windows.Forms.Button btnDOLU;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox textBoxCinsiyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}