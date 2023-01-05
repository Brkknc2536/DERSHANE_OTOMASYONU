using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//sql kütüphanemizi projemize dahil ettik
namespace Birebir_Etut_Programi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=GÜRBÜZ\SQLEXPRESS01;Initial Catalog=etut_db;Integrated Security=True");//sql bağlantı cümlemizi oluşturduk
            baglanti.Open();//bağlantıyı açtık
            SqlConnection.ClearPool(baglanti);
            SqlConnection.ClearAllPools();//açık kalan vs bağlantıları temizledik
            return (baglanti);//bağlantıyı gönderdik
        }

    }
}
