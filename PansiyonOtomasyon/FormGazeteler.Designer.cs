
namespace PansiyonOtomasyon
{
    partial class FormGazeteler
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnHurriyet = new System.Windows.Forms.Button();
            this.btnHaberTurk = new System.Windows.Forms.Button();
            this.btnSozcu = new System.Windows.Forms.Button();
            this.btnMilliyet = new System.Windows.Forms.Button();
            this.btnSabah = new System.Windows.Forms.Button();
            this.btnPosta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 30);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(841, 426);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnHurriyet
            // 
            this.btnHurriyet.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.btnHurriyet.Location = new System.Drawing.Point(0, 1);
            this.btnHurriyet.Name = "btnHurriyet";
            this.btnHurriyet.Size = new System.Drawing.Size(122, 23);
            this.btnHurriyet.TabIndex = 1;
            this.btnHurriyet.Text = "Hürriyet";
            this.btnHurriyet.UseVisualStyleBackColor = true;
            this.btnHurriyet.Click += new System.EventHandler(this.btnHurriyet_Click);
            // 
            // btnHaberTurk
            // 
            this.btnHaberTurk.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.btnHaberTurk.Location = new System.Drawing.Point(145, 1);
            this.btnHaberTurk.Name = "btnHaberTurk";
            this.btnHaberTurk.Size = new System.Drawing.Size(122, 23);
            this.btnHaberTurk.TabIndex = 2;
            this.btnHaberTurk.Text = "HaberTürk";
            this.btnHaberTurk.UseVisualStyleBackColor = true;
            this.btnHaberTurk.Click += new System.EventHandler(this.btnHaberTurk_Click);
            // 
            // btnSozcu
            // 
            this.btnSozcu.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.btnSozcu.Location = new System.Drawing.Point(435, 1);
            this.btnSozcu.Name = "btnSozcu";
            this.btnSozcu.Size = new System.Drawing.Size(122, 23);
            this.btnSozcu.TabIndex = 4;
            this.btnSozcu.Text = "Sözcü";
            this.btnSozcu.UseVisualStyleBackColor = true;
            this.btnSozcu.Click += new System.EventHandler(this.btnSozcu_Click);
            // 
            // btnMilliyet
            // 
            this.btnMilliyet.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.btnMilliyet.Location = new System.Drawing.Point(290, 1);
            this.btnMilliyet.Name = "btnMilliyet";
            this.btnMilliyet.Size = new System.Drawing.Size(122, 23);
            this.btnMilliyet.TabIndex = 3;
            this.btnMilliyet.Text = "Milliyet";
            this.btnMilliyet.UseVisualStyleBackColor = true;
            this.btnMilliyet.Click += new System.EventHandler(this.btnMilliyet_Click);
            // 
            // btnSabah
            // 
            this.btnSabah.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.btnSabah.Location = new System.Drawing.Point(719, 1);
            this.btnSabah.Name = "btnSabah";
            this.btnSabah.Size = new System.Drawing.Size(122, 23);
            this.btnSabah.TabIndex = 6;
            this.btnSabah.Text = "Sabah";
            this.btnSabah.UseVisualStyleBackColor = true;
            this.btnSabah.Click += new System.EventHandler(this.btnSabah_Click);
            // 
            // btnPosta
            // 
            this.btnPosta.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.btnPosta.Location = new System.Drawing.Point(581, 1);
            this.btnPosta.Name = "btnPosta";
            this.btnPosta.Size = new System.Drawing.Size(122, 23);
            this.btnPosta.TabIndex = 5;
            this.btnPosta.Text = "Posta";
            this.btnPosta.UseVisualStyleBackColor = true;
            this.btnPosta.Click += new System.EventHandler(this.btnPosta_Click);
            // 
            // FormGazeteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.btnSabah);
            this.Controls.Add(this.btnPosta);
            this.Controls.Add(this.btnSozcu);
            this.Controls.Add(this.btnMilliyet);
            this.Controls.Add(this.btnHaberTurk);
            this.Controls.Add(this.btnHurriyet);
            this.Controls.Add(this.webBrowser1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGazeteler";
            this.Text = "Gazeteler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnHurriyet;
        private System.Windows.Forms.Button btnHaberTurk;
        private System.Windows.Forms.Button btnSozcu;
        private System.Windows.Forms.Button btnMilliyet;
        private System.Windows.Forms.Button btnSabah;
        private System.Windows.Forms.Button btnPosta;
    }
}