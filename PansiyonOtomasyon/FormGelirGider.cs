using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;


namespace PansiyonOtomasyon
{
    public partial class FormGelirGider : Form
    {
        public FormGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5U8T0LG\\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True"); // çift slaş ekledim bağlantı için

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Kasada ki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                lblKasaToplam.Text = oku["toplam"].ToString();

            }
            baglanti.Close();
             
            //Gıdalar
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
               lblAlinanUrunler.Text = oku2["toplam1"].ToString();

            }
            baglanti.Close();

            //İcecekler
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(İcecek) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                label7.Text = oku3["toplam3"].ToString();

            }
            baglanti.Close();

            //Atıştırmalıklar
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam4 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                label8.Text = oku4["toplam4"].ToString();

            }
            baglanti.Close();

            //Elektrik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                lblFaturalar1.Text = oku5["toplam5"].ToString();

            }
            baglanti.Close();

            //Su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                lblFaturalar2.Text = oku6["toplam6"].ToString();

            }
            baglanti.Close();

            //İnternet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(İnternet) as toplam7 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                lblFaturalar3.Text = oku7["toplam7"].ToString();

            }
            baglanti.Close();

            //Personel maaşı hesaplama Asgari ücret için 8500 yazıldı !
            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            lblPersonelMaas.Text = (personel * 8500).ToString();

            //Gelir Gider farkının sonuc'unu buluyoruz
            int sonuc;
            sonuc = Convert.ToInt32(lblKasaToplam.Text) - (Convert.ToInt32(lblPersonelMaas.Text) + Convert.ToInt32(lblAlinanUrunler.Text) + Convert.ToInt32(label7.Text) + Convert.ToInt32(label8.Text) + Convert.ToInt32(lblFaturalar1.Text) + Convert.ToInt32(lblFaturalar2.Text) + Convert.ToInt32(lblFaturalar3.Text));
            lblSonuc.Text = sonuc.ToString();



        }

        private void lblAlinanUrunler_Click(object sender, EventArgs e)
        {

        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
