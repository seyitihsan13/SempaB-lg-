using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BilgiMİllyoner
{
    class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=PC-160130;Initial Catalog=soru;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
