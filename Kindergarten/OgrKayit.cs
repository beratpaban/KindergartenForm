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
    public partial class OgrKayit : Form
    {
        public OgrKayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        int ogrNo = 191000001;

        private void OgrKayit_Load(object sender, EventArgs e)
        {
            this.veliTableAdapter1.Fill(this.kindergartenDataSet3.veli);
            this.ogrenciTableAdapter.Fill(this.kindergartenDataSet2.ogrenci);
            cmbVeliID();
            cmbSinifID();
            cmbEtkID();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.veliTableAdapter1.Fill(this.kindergartenDataSet3.veli);
            this.ogrenciTableAdapter.Fill(this.kindergartenDataSet2.ogrenci);
        }

        private void BtnOgrKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand OgrKaydet = new SqlCommand("insert into ogrenci " +
                "(ad,soyad,dogumtarihi,cinsiyet,tcno,ogrno,veliid,sinifid,etkinlikid,alerji,hastalik)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            OgrKaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
            OgrKaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
            OgrKaydet.Parameters.AddWithValue("@p3", TxtOgrDogum.Text);
            OgrKaydet.Parameters.AddWithValue("@p4", CmbOgrCinsiyet.Text);
            OgrKaydet.Parameters.AddWithValue("@p5", TxtOgrTc.Text);
            OgrKaydet.Parameters.AddWithValue("@p6", ogrNo);
            OgrKaydet.Parameters.AddWithValue("@p7", CmbVeliID.Text);
            OgrKaydet.Parameters.AddWithValue("@p8", CmbSinifID.Text);
            OgrKaydet.Parameters.AddWithValue("@p9", CmbEtkID.Text);
            OgrKaydet.Parameters.AddWithValue("@p10", CmbOgrAlerji.Text);
            OgrKaydet.Parameters.AddWithValue("@p11", TxtOgrHastalik.Text);
            OgrKaydet.ExecuteNonQuery();
            ogrNo++;
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Başarıyla eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.ogrenciTableAdapter.Fill(this.kindergartenDataSet2.ogrenci);

        }

        public void cmbVeliID()
        {
            bgl.baglanti();
            string komut = "select veliid from veli";
            SqlCommand cmd = new SqlCommand(komut, bgl.baglanti());
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbVeliID.Items.Add(dr["veliid"].ToString());
                CmbVeliID.DisplayMember=(dr["veliid"].ToString());
                CmbVeliID.ValueMember=(dr["veliid"].ToString());
            }
            bgl.baglanti().Close();
        }
        public void cmbSinifID()
        {
            bgl.baglanti();
            string komut = "select sinifid from sinif";
            SqlCommand cmd = new SqlCommand(komut, bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbSinifID.Items.Add(dr["sinifid"].ToString());
                CmbSinifID.DisplayMember = (dr["sinifid"].ToString());
                CmbSinifID.ValueMember = (dr["sinifid"].ToString());
            }
            bgl.baglanti().Close();
        }
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

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            int secim = dataGridView2.SelectedCells[0].RowIndex;
            TxtOgrID.Text = dataGridView2.Rows[secim].Cells[0].Value.ToString();
            TxtOgrAd.Text = dataGridView2.Rows[secim].Cells[1].Value.ToString();
            TxtOgrSoyad.Text = dataGridView2.Rows[secim].Cells[2].Value.ToString();
            TxtOgrDogum.Text = dataGridView2.Rows[secim].Cells[3].Value.ToString();
            CmbOgrCinsiyet.Text = dataGridView2.Rows[secim].Cells[4].Value.ToString();
            TxtOgrTc.Text = dataGridView2.Rows[secim].Cells[5].Value.ToString();
            CmbVeliID.Text = dataGridView2.Rows[secim].Cells[7].Value.ToString();
            CmbSinifID.Text = dataGridView2.Rows[secim].Cells[8].Value.ToString();
            CmbEtkID.Text = dataGridView2.Rows[secim].Cells[9].Value.ToString();
            CmbOgrAlerji.Text = dataGridView2.Rows[secim].Cells[10].Value.ToString();
            TxtOgrHastalik.Text = dataGridView2.Rows[secim].Cells[11].Value.ToString();

        }

        private void BtnOgrSil_Click(object sender, EventArgs e)
        {
            string tabloturu = "ogrenci";
            bgl.baglanti();
            SqlCommand silinmisekle = new SqlCommand("Insert into silinmis (ad,soyad,tcno,tabloturu) values(@p1,@p2,@p3,@p4) ", bgl.baglanti());
            silinmisekle.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
            silinmisekle.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
            silinmisekle.Parameters.AddWithValue("@p3", TxtOgrTc.Text);
            silinmisekle.Parameters.AddWithValue("@p4", tabloturu.ToString());
            silinmisekle.ExecuteNonQuery();
            SqlCommand sil = new SqlCommand("Delete from ogrenci where tcno=@p1",bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", TxtOgrTc.Text);
            sil.ExecuteNonQuery();
            
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ogrenciTableAdapter.Fill(this.kindergartenDataSet2.ogrenci);

        }
        void Temizle()
        {
            TxtOgrID.Text = "";
            TxtOgrAd.Text = "";
            TxtOgrSoyad.Text = "";
            TxtOgrDogum.Text = "";
            CmbOgrCinsiyet.Text = "";
            TxtOgrTc.Text = "";
            CmbVeliID.Text = "";
            CmbSinifID.Text = "";
            CmbEtkID.Text = "";
            CmbOgrAlerji.Text = "";
            TxtOgrHastalik.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand guncelle = new SqlCommand("Update ogrenci Set ad=@p1,soyad=@p2,cinsiyet=@p3,dogumtarihi=@p4,tcno=@p5,ogrno=@p6,veliid=@p7,sinifid=@p8,etkinlikid=@p9,alerji=@p10,hastalik=@p11 where ogrid=@p12", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
            guncelle.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", CmbOgrCinsiyet.Text);
            guncelle.Parameters.AddWithValue("@p4", TxtOgrDogum.Text);
            guncelle.Parameters.AddWithValue("@p5", TxtOgrTc.Text);
            guncelle.Parameters.AddWithValue("@p6", ogrNo);
            guncelle.Parameters.AddWithValue("@p7", CmbVeliID.Text);
            guncelle.Parameters.AddWithValue("@p8", CmbSinifID.Text);
            guncelle.Parameters.AddWithValue("@p9", CmbEtkID.Text);
            guncelle.Parameters.AddWithValue("@p10", CmbOgrAlerji.Text);
            guncelle.Parameters.AddWithValue("@p11", TxtOgrHastalik.Text);
            guncelle.Parameters.AddWithValue("@p12", TxtOgrID.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
