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
    public partial class FormSifreGuncelle : Form
    {
        public FormSifreGuncelle()
        {
            InitializeComponent();
        }

        //SQL BAGLANTIM
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5U8T0LG\\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True"); // çift slaş ekledim bağlantı için

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //veritabanından işlem yapmak için öncellikle bağlantıyı açıyorum. !!!!!!!!!!!! tek tırnak ile aç çift tırnak ile kapa !!!!!! 
            SqlCommand komut = new SqlCommand("update AdminGiris set KullaniciAdi = '" + textBoxKullaniciAdi.Text + "', Sifre = '" + textBoxSifre.Text +"'", baglanti);
            komut.ExecuteNonQuery(); // yaptığım komutu kaydettim.
            baglanti.Close(); // veritabanında komutumu yazdıktan sonra baglantimi kestim.
            

        }
    }
}
