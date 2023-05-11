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
    public partial class FormGazeteler : Form
    {
        public FormGazeteler()
        {
            InitializeComponent();
        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
        }

        private void btnHaberTurk_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void btnSozcu_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
        }

        private void btnPosta_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.posta.com.tr/");
        }

        private void btnSabah_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sabah.com.tr/");
        }
    }
}
