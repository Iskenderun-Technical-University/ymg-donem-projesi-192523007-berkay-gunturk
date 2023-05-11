using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonOtomasyon
{
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }

        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            AdminGiriş fr = new AdminGiriş();
            fr.Show();  //Sayfa Yönlendirilmesi yapıldı
            this.Hide(); // gizleme işlemi yapıldı

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormYeniMusteri fr = new FormYeniMusteri();
            fr.Show();

        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            BtnVerileriGoster fr = new BtnVerileriGoster();
            fr.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Türkiyenin En Kaliteli Pansiyon Uygulaması");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOdalar fr = new FormOdalar();
            fr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textTarih.Text = DateTime.Now.ToLongDateString();
            textTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            FormGelirGider fr = new FormGelirGider();
            fr.Show();
            this.Hide();
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            FormGiderler fr = new FormGiderler();
            fr.Show();
            

        }

        private void btnRadyo_Click(object sender, EventArgs e)
        {
            FormRadyo fr = new FormRadyo();
            fr.Show();
        }

        private void btnGazeteler_Click(object sender, EventArgs e)
        {
            FormGazeteler fr = new FormGazeteler();
            fr.Show();
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            FormSifreGuncelle fr = new FormSifreGuncelle();
            fr.Show();
        }

        private void btnMusteriMsj_Click(object sender, EventArgs e)
        {
            FormMesajlar fr = new FormMesajlar();
            fr.Show();
        }
    }
}
