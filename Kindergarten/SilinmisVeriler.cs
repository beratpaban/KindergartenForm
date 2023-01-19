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
    public partial class SilinmisVeriler : Form
    {
        public SilinmisVeriler()
        {
            InitializeComponent();
        }

        private void SilinmisVeriler_Load(object sender, EventArgs e)
        {
            
            this.silinmisTableAdapter.Fill(this.kindergartenDataSet8.silinmis);

        }
    }
}
