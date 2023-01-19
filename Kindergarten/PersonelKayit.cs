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
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
        {
            InitializeComponent();
        }



        SqlBaglantisi bgl=new SqlBaglantisi();
        int maas = 10000;
        

        public void cmbEtkID()
        {
            bgl.baglanti();
            string komut = "select etkinlikid from etkinlik";
            SqlCommand cmd = new SqlCommand(komut, bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbTxtEtk.Items.Add(dr["etkinlikid"].ToString());
                CmbTxtEtk.DisplayMember = (dr["etkinlikid"].ToString());
                CmbTxtEtk.ValueMember = (dr["etkinlikid"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand personelTablo = new SqlCommand("insert into personel (ad,soyad,tcno,sifre,unvan,dogumtarihi,maas,etkinlikid,cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            personelTablo.Parameters.AddWithValue("@p1", TxtPerAd.Text);
            personelTablo.Parameters.AddWithValue("@p2", TxtPerSoyad.Text);
            personelTablo.Parameters.AddWithValue("@p3", MskTxtTc.Text);
            personelTablo.Parameters.AddWithValue("@p4", TxtSifre.Text);
            personelTablo.Parameters.AddWithValue("@p5", CmbPerUnvan.Text);
            personelTablo.Parameters.AddWithValue("@p6", MskTxtDogum.Text);
            personelTablo.Parameters.AddWithValue("@p7", maas);
            personelTablo.Parameters.AddWithValue("@p8", CmbTxtEtk.Text);
            personelTablo.Parameters.AddWithValue("@p9", CmbPerCinsiyet.Text);
            personelTablo.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void PersonelKayit_Load(object sender, EventArgs e)
        { 
            cmbEtkID();
        }
    }
}
