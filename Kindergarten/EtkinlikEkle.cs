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
    public partial class EtkinlikEkle : Form
    {
        public EtkinlikEkle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnEtkEkle_Click(object sender, EventArgs e)
        {
            SqlCommand etkinlikTablo=new SqlCommand("insert into etkinlik (ad,kazanım) values (@p1,@p2)",bgl.baglanti());
            etkinlikTablo.Parameters.AddWithValue("@p1", TxtEtkAd.Text);
            etkinlikTablo.Parameters.AddWithValue("@p2", TxtEtkKaz.Text);
            etkinlikTablo.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
