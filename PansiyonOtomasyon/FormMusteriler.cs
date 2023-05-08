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
    public partial class BtnVerileriGoster : Form
    {
        public BtnVerileriGoster()
        {
            InitializeComponent();
        }
        // SQL baglantisi için başına @ ' de koyabiliriz.
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5U8T0LG\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");

        private void verileriGoster() //Verileri Göstermek için kurulan fonksiyon
        {
            listView1.Items.Clear(); // Her listeleme işleminde önceki işlemi temizleme komutu !
           
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOdaNo_TextChanged(object sender, EventArgs e)
        {

        }

        // verileri göster listesinden --id-- sine çift tıklama ile müşteri özellikleri doldurma
        int id = 0; 
        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text); // KÖK DÜĞÜM için. id=id sağlamasını yaptık.
            textBoxAd.Text=(listView1.SelectedItems[0].SubItems[1].Text);
            textBoxSoyad.Text = (listView1.SelectedItems[0].SubItems[2].Text);
            textBoxCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskdTxtBoxTlfn.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBoxMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBoxTcNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBoxOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBoxUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimeGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dateCikisTarih.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum. !!!!!!!!!!!! tek tırnak ile aç çift tırnak ile kapa !!!!!! 
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi = '" +textBoxAd.Text+ "', Soyadi = '"+textBoxSoyad.Text+"', Cinsiyet = '"+textBoxCinsiyet.Text+"', Telefon = '"+mskdTxtBoxTlfn.Text+"', Mail='"+textBoxMail.Text+"', TC= '"+textBoxTcNo.Text+"', OdaNo= '"+textBoxOdaNo.Text+"', Ucret='"+textBoxUcret.Text+ "', GirisTarihi= '"+dateTimeGiris.Value.ToString("yyyy - MM - dd")+"', CikisTarihi = '"+ dateCikisTarih.Value.ToString("yyyy-MM-dd")+"' where Musteriid= " +id+"", baglanti);
            komut.ExecuteNonQuery(); // yaptığım komutu kaydettim.
            baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
            verileriGoster();

            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // -------- ODA 101 -------------
            if (textBoxOdaNo.Text == "101") 
            {

                baglanti.Open(); // veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum.
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti); // SQL sorgum silme işlemi
                komut.ExecuteNonQuery();// yaptığım komutu kaydettim
                baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
                verileriGoster();
            }

            // -------- ODA 102 -------------
            if (textBoxOdaNo.Text == "102") 
            {

                baglanti.Open(); // veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum.
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti); // SQL sorgum silme işlemi
                komut.ExecuteNonQuery();// yaptığım komutu kaydettim
                baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
                verileriGoster();
            }
            // -------- ODA 103 -------------
            if (textBoxOdaNo.Text == "103") 
            {

                baglanti.Open(); // veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum.
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti); // SQL sorgum silme işlemi
                komut.ExecuteNonQuery();// yaptığım komutu kaydettim
                baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
                verileriGoster();
            }
            // -------- ODA 104 -------------
            if (textBoxOdaNo.Text == "104") 
            {

                baglanti.Open(); // veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum.
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti); // SQL sorgum silme işlemi
                komut.ExecuteNonQuery();// yaptığım komutu kaydettim
                baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
                verileriGoster();
            }
            // -------- ODA 105 -------------
            if (textBoxOdaNo.Text == "105")
            {

                baglanti.Open(); // veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum.
                SqlCommand komut = new SqlCommand("delete from Oda105", baglanti); // SQL sorgum silme işlemi
                komut.ExecuteNonQuery();// yaptığım komutu kaydettim
                baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
                verileriGoster();
            }
            // -------- ODA 106 -------------
            if (textBoxOdaNo.Text == "106") 
            {

                baglanti.Open(); // veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum.
                SqlCommand komut = new SqlCommand("delete from Oda106", baglanti); // SQL sorgum silme işlemi
                komut.ExecuteNonQuery();// yaptığım komutu kaydettim
                baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
                verileriGoster();
            }
            // -------- ODA 107 -------------
            if (textBoxOdaNo.Text == "107")
            {

                baglanti.Open(); // veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum.
                SqlCommand komut = new SqlCommand("delete from Oda107", baglanti); // SQL sorgum silme işlemi
                komut.ExecuteNonQuery();// yaptığım komutu kaydettim
                baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
                verileriGoster();
            }
            // -------- ODA 108 -------------
            if (textBoxOdaNo.Text == "108")
            {

                baglanti.Open(); // veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum.
                SqlCommand komut = new SqlCommand("delete from Oda108", baglanti); // SQL sorgum silme işlemi
                komut.ExecuteNonQuery();// yaptığım komutu kaydettim
                baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
                verileriGoster();
            }
            // -------- ODA 109 -------------
            if (textBoxOdaNo.Text == "109")
            {

                baglanti.Open(); // veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum.
                SqlCommand komut = new SqlCommand("delete from Oda109", baglanti); // SQL sorgum silme işlemi
                komut.ExecuteNonQuery();// yaptığım komutu kaydettim
                baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
                verileriGoster();
            }




        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxCinsiyet.Text = "";
            textBoxMail.Clear();
            textBoxOdaNo.Clear();
            textBoxTcNo.Clear();
            textBoxUcret.Clear();
            dateTimeGiris.Text = "";
            dateCikisTarih.Text = "";




        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear(); // Her listeleme işleminde önceki işlemi temizleme komutu !

            baglanti.Open(); // verileri göstermek için öncellikle baglantiyi açtım 
            SqlCommand komut = new SqlCommand("select*from MusteriEkle where Adi like '%" + textBox1.Text + "'", baglanti);

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

    }
    }


//Data Source=DESKTOP-5U8T0LG\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True baglantiSQL
//SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti); // SQL sorgum silme işlemi