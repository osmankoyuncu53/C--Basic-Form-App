using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alisveris
{
    class Veritabani
    {
        string adres = "Data Source=(local);Initial Catalog=VT_Alisveris;User ID=sa;Password=123456*-";
        SqlConnection baglan;
        public SqlConnection BaglantiAc()
        {
            baglan = new SqlConnection(adres);

            if(baglan.State == System.Data.ConnectionState.Closed)
            {
                baglan.Open();
                return baglan;
            }
            else
            {
                return null;
            }
        }

        public void BaglantiKapat()
        {
            if(baglan.State == System.Data.ConnectionState.Open)
            {
                baglan.Close();
            }
        }
    }
}
