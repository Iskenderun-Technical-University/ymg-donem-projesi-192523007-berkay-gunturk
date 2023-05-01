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
            FormMusteriler fr = new FormMusteriler();
            fr.Show();

        }
    }
}
