﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class KitapEklefrm : Form
    {
        public KitapEklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PPA31HS\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        private void KitapEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitap(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayıttarihi) values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@turu,@stoksayisi,@rafno,@aciklama,@kayıttarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazari.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("sayfasayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@turu", comboTuru.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            komut.Parameters.AddWithValue("@kayıttarihi",DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı yapıldı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    
                  item.Text = "";
                    
                }
            }
        }
    }
}
