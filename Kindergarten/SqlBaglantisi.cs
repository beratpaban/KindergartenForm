using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kindergarten
{
    public class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ALX\\ALXSERVER;Initial Catalog=Kindergarten;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
