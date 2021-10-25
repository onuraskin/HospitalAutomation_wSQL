using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Sql bağlantı kütüphanesi


namespace Proje_Hastane
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti() {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PJQ3A1C\\KODB;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
