
namespace PansiyonOtomasyon
{
    partial class FormGiderler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGidalar = new System.Windows.Forms.TextBox();
            this.txtboxIcecekler = new System.Windows.Forms.TextBox();
            this.txtboxAtistirmaliklar = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBoxMutfak = new System.Windows.Forms.GroupBox();
            this.groupBoxFaturalar = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelElektrik = new System.Windows.Forms.Label();
            this.btnKaydet2 = new System.Windows.Forms.Button();
            this.labelInternet = new System.Windows.Forms.Label();
            this.textBoxElektrik = new System.Windows.Forms.TextBox();
            this.labelSu = new System.Windows.Forms.Label();
            this.textBoxInternet = new System.Windows.Forms.TextBox();
            this.textBoxSu = new System.Windows.Forms.TextBox();
            this.groupBoxMutfak.SuspendLayout();
            this.groupBoxFaturalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecek Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atıştırmalıklar:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 226);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 132);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalıklar";
            this.columnHeader3.Width = 133;
            // 
            // txtGidalar
            // 
            this.txtGidalar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGidalar.Location = new System.Drawing.Point(130, 53);
            this.txtGidalar.Name = "txtGidalar";
            this.txtGidalar.Size = new System.Drawing.Size(185, 25);
            this.txtGidalar.TabIndex = 4;
            // 
            // txtboxIcecekler
            // 
            this.txtboxIcecekler.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxIcecekler.Location = new System.Drawing.Point(130, 83);
            this.txtboxIcecekler.Name = "txtboxIcecekler";
            this.txtboxIcecekler.Size = new System.Drawing.Size(185, 25);
            this.txtboxIcecekler.TabIndex = 5;
            // 
            // txtboxAtistirmaliklar
            // 
            this.txtboxAtistirmaliklar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxAtistirmaliklar.Location = new System.Drawing.Point(130, 114);
            this.txtboxAtistirmaliklar.Name = "txtboxAtistirmaliklar";
            this.txtboxAtistirmaliklar.Size = new System.Drawing.Size(185, 25);
            this.txtboxAtistirmaliklar.TabIndex = 6;
            this.txtboxAtistirmaliklar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(169, 157);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 27);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBoxMutfak
            // 
            this.groupBoxMutfak.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxMutfak.Controls.Add(this.listView1);
            this.groupBoxMutfak.Controls.Add(this.btnKaydet);
            this.groupBoxMutfak.Controls.Add(this.txtGidalar);
            this.groupBoxMutfak.Controls.Add(this.txtboxAtistirmaliklar);
            this.groupBoxMutfak.Controls.Add(this.label1);
            this.groupBoxMutfak.Controls.Add(this.txtboxIcecekler);
            this.groupBoxMutfak.Controls.Add(this.label2);
            this.groupBoxMutfak.Controls.Add(this.label3);
            this.groupBoxMutfak.Location = new System.Drawing.Point(-2, 1);
            this.groupBoxMutfak.Name = "groupBoxMutfak";
            this.groupBoxMutfak.Size = new System.Drawing.Size(407, 358);
            this.groupBoxMutfak.TabIndex = 8;
            this.groupBoxMutfak.TabStop = false;
            this.groupBoxMutfak.Text = "Mutfak";
            // 
            // groupBoxFaturalar
            // 
            this.groupBoxFaturalar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxFaturalar.Controls.Add(this.listView2);
            this.groupBoxFaturalar.Controls.Add(this.labelElektrik);
            this.groupBoxFaturalar.Controls.Add(this.btnKaydet2);
            this.groupBoxFaturalar.Controls.Add(this.labelInternet);
            this.groupBoxFaturalar.Controls.Add(this.textBoxElektrik);
            this.groupBoxFaturalar.Controls.Add(this.labelSu);
            this.groupBoxFaturalar.Controls.Add(this.textBoxInternet);
            this.groupBoxFaturalar.Controls.Add(this.textBoxSu);
            this.groupBoxFaturalar.Location = new System.Drawing.Point(411, 1);
            this.groupBoxFaturalar.Name = "groupBoxFaturalar";
            this.groupBoxFaturalar.Size = new System.Drawing.Size(403, 358);
            this.groupBoxFaturalar.TabIndex = 9;
            this.groupBoxFaturalar.TabStop = false;
            this.groupBoxFaturalar.Text = "Faturalar";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 220);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(404, 138);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            this.columnHeader4.Width = 143;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 124;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İnternet";
            this.columnHeader6.Width = 133;
            // 
            // labelElektrik
            // 
            this.labelElektrik.AutoSize = true;
            this.labelElektrik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelElektrik.Location = new System.Drawing.Point(72, 53);
            this.labelElektrik.Name = "labelElektrik";
            this.labelElektrik.Size = new System.Drawing.Size(59, 17);
            this.labelElektrik.TabIndex = 8;
            this.labelElektrik.Text = "Elektrik:";
            // 
            // btnKaydet2
            // 
            this.btnKaydet2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet2.Location = new System.Drawing.Point(176, 154);
            this.btnKaydet2.Name = "btnKaydet2";
            this.btnKaydet2.Size = new System.Drawing.Size(107, 27);
            this.btnKaydet2.TabIndex = 15;
            this.btnKaydet2.Text = "Kaydet";
            this.btnKaydet2.UseVisualStyleBackColor = true;
            this.btnKaydet2.Click += new System.EventHandler(this.btnKaydet2_Click);
            // 
            // labelInternet
            // 
            this.labelInternet.AutoSize = true;
            this.labelInternet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelInternet.Location = new System.Drawing.Point(70, 114);
            this.labelInternet.Name = "labelInternet";
            this.labelInternet.Size = new System.Drawing.Size(61, 17);
            this.labelInternet.TabIndex = 10;
            this.labelInternet.Text = "İnternet:";
            // 
            // textBoxElektrik
            // 
            this.textBoxElektrik.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxElektrik.Location = new System.Drawing.Point(137, 50);
            this.textBoxElektrik.Name = "textBoxElektrik";
            this.textBoxElektrik.Size = new System.Drawing.Size(185, 25);
            this.textBoxElektrik.TabIndex = 12;
            // 
            // labelSu
            // 
            this.labelSu.AutoSize = true;
            this.labelSu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSu.Location = new System.Drawing.Point(104, 83);
            this.labelSu.Name = "labelSu";
            this.labelSu.Size = new System.Drawing.Size(27, 17);
            this.labelSu.TabIndex = 9;
            this.labelSu.Text = "Su:";
            // 
            // textBoxInternet
            // 
            this.textBoxInternet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxInternet.Location = new System.Drawing.Point(137, 111);
            this.textBoxInternet.Name = "textBoxInternet";
            this.textBoxInternet.Size = new System.Drawing.Size(185, 25);
            this.textBoxInternet.TabIndex = 14;
            // 
            // textBoxSu
            // 
            this.textBoxSu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSu.Location = new System.Drawing.Point(137, 80);
            this.textBoxSu.Name = "textBoxSu";
            this.textBoxSu.Size = new System.Drawing.Size(185, 25);
            this.textBoxSu.TabIndex = 13;
            // 
            // FormGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(816, 359);
            this.Controls.Add(this.groupBoxFaturalar);
            this.Controls.Add(this.groupBoxMutfak);
            this.MinimizeBox = false;
            this.Name = "FormGiderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FormStoklar_Load);
            this.groupBoxMutfak.ResumeLayout(false);
            this.groupBoxMutfak.PerformLayout();
            this.groupBoxFaturalar.ResumeLayout(false);
            this.groupBoxFaturalar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtGidalar;
        private System.Windows.Forms.TextBox txtboxIcecekler;
        private System.Windows.Forms.TextBox txtboxAtistirmaliklar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBoxMutfak;
        private System.Windows.Forms.GroupBox groupBoxFaturalar;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelElektrik;
        private System.Windows.Forms.Button btnKaydet2;
        private System.Windows.Forms.Label labelInternet;
        private System.Windows.Forms.TextBox textBoxElektrik;
        private System.Windows.Forms.Label labelSu;
        private System.Windows.Forms.TextBox textBoxInternet;
        private System.Windows.Forms.TextBox textBoxSu;
    }
}