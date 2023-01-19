using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kindergarten
{
    public partial class OgrBilgiDuzenle : Form
    {
        public OgrBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TcNo;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void OgrBilgiDuzenle_Load(object sender, EventArgs e)
        {
            TxtTcNo.Text = TcNo;
            SqlCommand komut = new SqlCommand("Select * from veli where tcno=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                TxtTelNo.Text = dr[4].ToString();
                TxtAdres.Text = dr[5].ToString();
                TxtSifre.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update veli set ad=@p1,soyad=@p2,telno=@p3,adres=@p4,sifre=@p5 where tcno=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", TxtTelNo.Text);
            komut2.Parameters.AddWithValue("@p4", TxtAdres.Text);
            komut2.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p6", TxtTcNo.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            VeliSayfasi vs = new VeliSayfasi();
            vs.Show();
            this.Hide();
            
        }
    }
}
