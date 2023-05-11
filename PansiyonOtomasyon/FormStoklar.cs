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
    public partial class FormGiderler : Form
    {
        public FormGiderler()
        {
            InitializeComponent();
        }
        //sql baglantim.
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5U8T0LG\\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True"); // çift slaş ekledim bağlantı için

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void VerileriGoster2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Elektrik"].ToString();
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gida,İcecek,Cerezler) values ('" + txtGidalar.Text + "','" + txtboxIcecekler.Text + "','" + txtboxAtistirmaliklar.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }

        private void FormStoklar_Load(object sender, EventArgs e)
        {
            VerileriGoster();
            VerileriGoster2();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar(Elektrik,Su,İnternet) values ('" + textBoxElektrik.Text + "','" + textBoxSu.Text + "','" + textBoxInternet.Text+ "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster2();
        }
    }
}
