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
    public partial class VeliGiris : Form
    {
        public VeliGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnVeliGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select * from veli where tcno=@p1 and sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTcNo.Text);
            komut.Parameters.AddWithValue("@p2", MskSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                VeliSayfasi vs = new VeliSayfasi();
                vs.tc=MskTcNo.Text;
                vs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc & Şifre Girdiniz");
            }
        }
    }
}
