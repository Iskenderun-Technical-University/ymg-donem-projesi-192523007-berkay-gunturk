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
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }
        // SQL baglantisi için başına @ ' de koyabiliriz.
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5U8T0LG\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");

        private void verileriGoster() //Verileri Göstermek için kurulan fonksiyon
        {
            baglanti.Open(); // verileri göstermek için öncellikle baglantiyi açtım 
            SqlCommand komut = new SqlCommand("select*from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) // tüm verileri okutuyoruz..
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close(); // SQL baglantisini kapattık.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }
    }
}

//Data Source=DESKTOP-5U8T0LG\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True baglantiSQL