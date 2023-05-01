using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// SQL Bağlantısı için gerekli kütüphaneler.
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonOtomasyon
{
    public partial class FormYeniMusteri : Form
    {
        public FormYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5U8T0LG\\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True"); // çift slaş ekledim bağlantı için
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormYeniMusteri_Load(object sender, EventArgs e)
        {

        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "106";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "105";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "104";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //baglanti pasifti önce aktif etmemiz gerekli !
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) " +
            "values ('" + textBoxAd.Text + "','" + textBoxSoyad.Text + "','" + textBoxCinsiyet.Text + "','" + mskdTxtBoxTlfn.Text + "','" + textBoxMail.Text+ "','"+ textBoxTcNo.Text+ "','" + textBoxOdaNo.Text+ "','" +textBoxUcret.Text + "','" +dateTimeGiris.Value.ToString("yyyy-MM-dd")+ "','"+ dateCikisTarih.Value.ToString("yyyy-MM-dd")+  "')", baglanti); // başlangıçta açılan çift tek tırnak
            // Values.ToString Değeri al ve String ifadeye dönüştür.
            komut.ExecuteNonQuery();
            baglanti.Close(); // baglanti içi değişikliğimiz bittiğine göre kapatabiliriz
            MessageBox.Show("Başarıyla Yeni Müşteri Kaydı Yapıldı");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dateTimeGiris.Text); //.Text sebebi tarihi text halini dönüştürdük
            DateTime BuyukTarih = Convert.ToDateTime(dateCikisTarih.Text); 

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label2.Text = Sonuc.TotalDays.ToString(); 



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "103";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "109";
        }

        private void btnDOLU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Buton Dolu Odaları Gösterir.");
        }

        private void btnBOŞ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Buton Boş Odaları Gösterir.");
        }
    }
}
