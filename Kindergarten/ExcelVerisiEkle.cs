using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten
{
    public partial class ExcelVerisiEkle : Form
    {
        public ExcelVerisiEkle()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        private void btnSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd= new OpenFileDialog();
            
            ofd.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası |*.xls";
            ofd.Title = "Ürün Dosyasını Seçiniz";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ofd.FileName+"; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                baglanti.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [Sayfa1$]", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                SqlCommand komut = new SqlCommand("insert into veli (ad,soyad,tcno,cinsiyet,telno,adres,sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", row.Cells["ad"].Value.ToString());
                komut.Parameters.AddWithValue("@p2", row.Cells["soyad"].Value.ToString());
                komut.Parameters.AddWithValue("@p3", row.Cells["tcno"].Value.ToString());
                komut.Parameters.AddWithValue("@p4", row.Cells["cinsiyet"].Value.ToString());
                komut.Parameters.AddWithValue("@p5", row.Cells["telno"].Value.ToString());
                komut.Parameters.AddWithValue("@p6", row.Cells["adres"].Value.ToString());
                komut.Parameters.AddWithValue("@p7", row.Cells["sifre"].Value.ToString());
                komut.ExecuteNonQuery();

                bgl.baglanti().Close();
                
            }
            MessageBox.Show("Kayıt Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        
    }
}
