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
    public partial class VeliSayfasi : Form
    {
        public VeliSayfasi()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();

        

        private void VeliSayfasi_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;
            SqlCommand komut =new SqlCommand("Select ad,telno,adres from veli where tcno=@p1",bgl.baglanti());
            
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblVeliAd.Text = dr[0].ToString();
                LblTelNo.Text = dr[1].ToString();
                LblAdres.Text = dr[2].ToString();

            }
            


            SqlCommand komut2 = new SqlCommand("Select veliid from veli where tcno=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                int veliID = (int)dr2[0];
                SqlCommand komut3 = new SqlCommand("Select ad,soyad from ogrenci where veliid=@p1", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p1", veliID);
                
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    LblAdSoyad.Text = dr3[0] + " " + dr3[1];
                }
                SqlCommand komut4 = new SqlCommand("Select sinifid from ogrenci where veliid=@p1", bgl.baglanti());
                komut4.Parameters.AddWithValue("@p1", veliID);
                SqlDataReader dr4 = komut4.ExecuteReader();
                while (dr4.Read())
                {
                    int sinifid = (int)dr4[0];
                    SqlCommand komut5 = new SqlCommand("Select persid,ad from sinif where sinifid=@p1",bgl.baglanti());
                    komut5.Parameters.AddWithValue("@p1", sinifid);
                    SqlDataReader dr5 = komut5.ExecuteReader();
                    while (dr5.Read())
                    {
                        int persid=(int)dr5[0];
                        LblSinif.Text = dr5[1].ToString();
                        SqlCommand komut6 = new SqlCommand("Select ad,soyad from personel where persid=@p1",bgl.baglanti());
                        komut6.Parameters.AddWithValue("@p1", persid);
                        SqlDataReader dr6 = komut6.ExecuteReader();
                        while (dr6.Read())
                        {
                            LblOgretmen.Text = dr6[0] + " " + dr6[1];
                        }
                    }
                }
            }
            
        }

        private void BilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OgrBilgiDuzenle obd = new OgrBilgiDuzenle();
            obd.TcNo=LblTc.Text;
            obd.Show();
            this.Hide();
        }
    }
}
