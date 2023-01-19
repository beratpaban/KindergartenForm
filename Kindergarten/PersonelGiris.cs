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
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnGiris_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * from personel where tcno=@p1 and sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtTcNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                PersonelEkrani pe = new PersonelEkrani();
                pe.tc = TxtTcNo.Text;
                pe.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc & Şifre Girdiniz");
            }
        }
    }
}
