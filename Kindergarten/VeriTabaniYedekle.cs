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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Kindergarten
{
    public partial class VeriTabaniYedekle : Form
    {
        public VeriTabaniYedekle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=ALX\\ALXSERVER;Initial Catalog=Kindergarten;Integrated Security=True");

        private void btnSec_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TxtYedekleYol.Text = dlg.SelectedPath;
                BtnBackup.Enabled = true;
            }
        }


        private void BtnBackup_Click(object sender, EventArgs e)
        {

            string database = con.Database;
            if (TxtYedekleYol.Text == string.Empty)
            {
                MessageBox.Show("please enter backup file location");
            }
            else
            {
                string cmd = $"Backup Database {database} TO DISK='{TxtYedekleYol.Text}\\-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.bak'";
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);

                command.ExecuteNonQuery();
                MessageBox.Show("Veritabanı Başarıyla Yedeklendi!");
                con.Close();
                TxtYedekleYol.Enabled = false;
            }
        }

        private void btnYedekSec_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQl server databse backup files|*.bak";

            dlg.Title = "Database restore";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TxtYedekYol.Text = dlg.FileName;
                BtnBackup.Enabled = true;
            }
        }

        private void BtnYedektenYukle_Click(object sender, EventArgs e)
        {

            string database = con.Database.ToString();
            con.Open();

            try
            {

                string stri = string.Format("alter database [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");

                SqlCommand cmd1 = new SqlCommand(stri, con);

                cmd1.ExecuteNonQuery();

                string str2 = "Use Master Restore Database[" + database + "] FROM DISK =  '" + TxtYedekYol.Text + "'WITH REPLACE;";

                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");

                SqlCommand cmd3 = new SqlCommand(str3, con);

                cmd3.ExecuteNonQuery();

                MessageBox.Show("Veritabanı başarıyla yedekten yüklendi");
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
