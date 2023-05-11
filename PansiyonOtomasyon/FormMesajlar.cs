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
    public partial class FormMesajlar : Form
    {
        public FormMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5U8T0LG\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");

        private void verileriGoster() //Verileri Göstermek için kurulan fonksiyon
        {
            listView1.Items.Clear(); // Her listeleme işleminde önceki işlemi temizleme komutu !

            baglanti.Open(); // verileri göstermek için öncellikle baglantiyi açtım 
            SqlCommand komut = new SqlCommand("select*from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) // tüm verileri okutuyoruz..
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["Adsoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                
              

                listView1.Items.Add(ekle);
            }

            baglanti.Close(); // SQL baglantisini kapattık.
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(Adsoyad,Mesaj) values ('" + textBoxAdsoyad.Text + "','" + richTextBoxMesaj.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void FormMesajlar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        // 2 kere tıklandığında verileri kutularda gösterir !
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBoxAdsoyad.Text = (listView1.SelectedItems[0].SubItems[1].Text);
            richTextBoxMesaj.Text = (listView1.SelectedItems[0].SubItems[2].Text);

        }
    }
}
