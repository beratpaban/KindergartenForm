using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void BtnVeliGiris_Click(object sender, EventArgs e)
        {
            VeliGiris vg=new VeliGiris();
            vg.Show();
            this.Hide();
        }

        private void BtnPersonelGiris_Click(object sender, EventArgs e)
        {

            PersonelGiris pg=new PersonelGiris();
            pg.Show();
            this.Hide();
        }
    }
}
