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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                lblKasaToplam.Text = oku["toplam"].ToString();

            }
            baglanti.Close();

            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            lblPersonelMaas.Text = (personel * 1500).ToString();
            
        }
    }
}
