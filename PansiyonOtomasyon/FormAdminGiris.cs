using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql; //SQL baglantisi için gerekli kütüphane 1
using System.Data.SqlClient; //SQL baglantisi için gerekli kütüphane 2
namespace PansiyonOtomasyon
{
    public partial class AdminGiriş : Form
    {
        public AdminGiriş()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Sql baglantımın linki..
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5U8T0LG\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //SQL baglantisini açtım

            // Sql komutu ile datebase'de kullanıcıAdı ve Şifre 'nin doğrunun kontrollerini sağladım.
            SqlCommand komut = new SqlCommand("select * from AdminGiris where KullaniciAdi = '" + textBoxKullaniciAdi.Text + "' and Sifre = '" + textBoxSifre.Text + "'", baglanti);
            
            
            SqlDataReader dr = komut.ExecuteReader();// Okuduüum değerleri döndürdüm

            if (dr.Read()) // if else yapısı ile doğru ise giriş, yanlış ise hata vermesini sağlayıp giriş izninin engelledim.
            {
                AnaSayfaForm fr = new AnaSayfaForm();
                fr.Show();
                this.Hide();
                MessageBox.Show("Başarıyla Giriş Yaptınız");


            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı !");
            }

            baglanti.Close();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
