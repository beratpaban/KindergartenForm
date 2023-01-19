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
    public partial class PersonelEkrani : Form
    {
        public PersonelEkrani()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();

        public void Listele()
        {
            bgl.baglanti();
            SqlDataAdapter dataAdapter=new SqlDataAdapter("Select * from ogrenci",bgl.baglanti());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
        }

        private void PersonelEkrani_Load(object sender, EventArgs e)
        {
            this.ogrenciTableAdapter.Fill(this.kindergartenDataSet7.ogrenci);
            LblTc.Text = tc;
            
            SqlCommand komut = new SqlCommand("Select ad,soyad,unvan from personel where tcno=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
                LblUnvan.Text = dr[2].ToString();

            }
            bgl.baglanti().Close();

            Listele();

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from ogrenci where tcno like '"+ TxtTcNo.Text + "%'", bgl.baglanti());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from ogrenci where ad like '" + TxtAd.Text + "%'", bgl.baglanti());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];

        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from ogrenci where soyad like '" + TxtSoyad.Text + "%'", bgl.baglanti());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from ogrenci where cinsiyet like '" + TxtCinsiyet.Text + "%'", bgl.baglanti());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
        }

        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from ogrenci where ogrno like '" + TxtOgrNo.Text + "%'", bgl.baglanti());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
        }

        private void maskedTextBox5_TextChanged(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from ogrenci where veliid like '" + TxtVeliID.Text + "%'", bgl.baglanti());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
        }

        private void BtnImportCsv_Click(object sender, EventArgs e)
        {
            if (unvan().Equals("Müdür"))
            {
                ExcelVerisiEkle eve = new ExcelVerisiEkle();
                eve.Show();
            }
            else
            {
                MessageBox.Show("Bu İşlem için Yetkiniz Bulunmamakta", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void BtnYedekle_Click(object sender, EventArgs e)
        {
            if (unvan().Equals("Müdür"))
            {
                VeriTabaniYedekle vty = new VeriTabaniYedekle();
                vty.Show();
            }
            else
            {
                MessageBox.Show("Bu İşlem için Yetkiniz Bulunmamakta", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (unvan().Equals("Müdür"))
            {
                OgrKayit ogrKayit = new OgrKayit();
                ogrKayit.Show();
            }
            else
            {
                MessageBox.Show("Bu İşlem için Yetkiniz Bulunmamakta", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (unvan().Equals("Müdür"))
            {
                VeliKayit vg = new VeliKayit();
                vg.Show();
            }
            else
            {
                MessageBox.Show("Bu İşlem için Yetkiniz Bulunmamakta","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public string unvan()
        {
            string strunvan="";
            SqlCommand komut = new SqlCommand("Select unvan from personel where tcno=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                strunvan = dr[0].ToString();
            }
            bgl.baglanti().Close();
            return strunvan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (unvan().Equals("Müdür"))
            {
                EtkinlikEkle etkinlikEkle = new EtkinlikEkle();
                etkinlikEkle.Show();
            }
            else if (unvan().Equals("Müdür Yardımcısı"))
            {
                EtkinlikEkle etkinlikEkle = new EtkinlikEkle();
                etkinlikEkle.Show();
            }
            else
            {
                MessageBox.Show("Bu İşlem için Yetkiniz Bulunmamakta", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (unvan().Equals("Müdür")||unvan().Equals("Müdür Yardımcısı"))
            {
                SinifKayit sk = new SinifKayit();
                sk.Show();
            }
            else
            {
                MessageBox.Show("Bu İşlem için Yetkiniz Bulunmamakta", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            if (unvan().Equals("Müdür"))
            {
                SilinmisVeriler silinmisVeriler = new SilinmisVeriler();
                silinmisVeriler.Show();
            }
            else
            {
                MessageBox.Show("Bu İşlem için Yetkiniz Bulunmamakta", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            GirisEkrani ge = new GirisEkrani();
            ge.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelKayit pk = new PersonelKayit();
            pk.Show();
        }
    }
}
