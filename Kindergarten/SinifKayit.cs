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
    public partial class SinifKayit : Form
    {
        public SinifKayit()
        {
            InitializeComponent();
        }
        
        SqlBaglantisi bgl =new SqlBaglantisi();

        public void cmbEtkID()
        {
            bgl.baglanti();
            string komut = "select etkinlikid from etkinlik";
            SqlCommand cmd = new SqlCommand(komut, bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbEtkID.Items.Add(dr["etkinlikid"].ToString());
                CmbEtkID.DisplayMember = (dr["etkinlikid"].ToString());
                CmbEtkID.ValueMember = (dr["etkinlikid"].ToString());
            }
            bgl.baglanti().Close();
        }

        public void cmbPerID()
        {
            bgl.baglanti();
            string komut = "select persid from personel";
            SqlCommand cmd = new SqlCommand(komut, bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbPerID.Items.Add(dr["persid"].ToString());
                CmbPerID.DisplayMember = (dr["persid"].ToString());
                CmbPerID.ValueMember = (dr["persid"].ToString());
            }
            bgl.baglanti().Close();
        }



        private void SinifKayit_Load(object sender, EventArgs e)
        {

            TxtID.Text = "";
            cmbEtkID();
            cmbPerID();
            this.sinifTableAdapter.Fill(this.kindergartenDataSet6.sinif);
            this.personelTableAdapter.Fill(this.kindergartenDataSet5.personel);
            this.etkinlikTableAdapter.Fill(this.kindergartenDataSet4.etkinlik);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.sinifTableAdapter.Fill(this.kindergartenDataSet6.sinif);
            this.personelTableAdapter.Fill(this.kindergartenDataSet5.personel);
            this.etkinlikTableAdapter.Fill(this.kindergartenDataSet4.etkinlik);
        }

        private void BtnSinifKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand SinifKaydet = new SqlCommand("insert into sinif (ad,etkinlikid,persid) values (@p1,@p2,@p3)", bgl.baglanti());
            SinifKaydet.Parameters.AddWithValue("@p1", TxtSinifAd.Text);
            SinifKaydet.Parameters.AddWithValue("@p2", CmbEtkID.Text);
            SinifKaydet.Parameters.AddWithValue("@p3", CmbPerID.Text);
            SinifKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sınıf Başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSinifSil_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand sil = new SqlCommand("Delete from sinif where sinifid=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", TxtID.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sınıf Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand guncelle = new SqlCommand("Update sinif Set ad=@p1,etkinlikid=@p2,persid=@p3 where sinifid=@p4", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", TxtSinifAd.Text);
            guncelle.Parameters.AddWithValue("@p2", CmbEtkID.Text);
            guncelle.Parameters.AddWithValue("@p3", CmbPerID.Text);
            guncelle.Parameters.AddWithValue("@p4", TxtID.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sınıf Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            int secim = dataGridView3.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView3.Rows[secim].Cells[0].Value.ToString();
            TxtSinifAd.Text = dataGridView3.Rows[secim].Cells[1].Value.ToString();
            CmbEtkID.Text = dataGridView3.Rows[secim].Cells[2].Value.ToString();
            CmbPerID.Text = dataGridView3.Rows[secim].Cells[3].Value.ToString();
        }
    }
}
