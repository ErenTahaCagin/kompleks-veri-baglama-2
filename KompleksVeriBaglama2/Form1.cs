using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KompleksVeriBaglama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Sehirler> listSehirler = new List<Sehirler>();

        class Sehirler
        {
            public string Plaka { get; set; }
            public string SehirAdi { get; set; }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sehirler sehir = new Sehirler();
            sehir.Plaka = txtPlaka.Text;
            sehir.SehirAdi = txtSehir.Text;
            listSehirler.Add(sehir);
            Bagla();
        }

        private void Bagla()
        {
            cbSehirler.DataSource = null;
            cbSehirler.DataSource = listSehirler;
            cbSehirler.DisplayMember = "SehirAdi";
            cbSehirler.ValueMember = "Plaka";
        }
    }
}
