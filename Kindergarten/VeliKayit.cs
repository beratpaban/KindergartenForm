using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten
{
    public partial class VeliKayit : Form
    {
        public VeliKayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand veliTablo = new SqlCommand("insert into veli (ad,soyad,tcno,cinsiyet,telno,adres,sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            veliTablo.Parameters.AddWithValue("@p1", TxtVeliAd.Text);
            veliTablo.Parameters.AddWithValue("@p2", TxtVeliSoyad.Text);
            veliTablo.Parameters.AddWithValue("@p3", TxtVeliTcNo.Text);
            veliTablo.Parameters.AddWithValue("@p4", CmbVeliCinsiyet.Text);
            veliTablo.Parameters.AddWithValue("@p5", TxtVeliTelNo.Text);
            veliTablo.Parameters.AddWithValue("@p6", TxtAdres.Text);
            veliTablo.Parameters.AddWithValue("@p7", TxtVeliSifre.Text);
            veliTablo.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OgrKayit ogrKayit = new OgrKayit();
            ogrKayit.Show();
            this.Hide();
        }
    }
}
