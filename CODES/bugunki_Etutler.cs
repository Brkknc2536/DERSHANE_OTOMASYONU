using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sql işlemleri için kütüphanemizi içeri aktarırız
using System.Data.SqlClient;
namespace Birebir_Etut_Programi
{
    public partial class bugunki_Etutler : Form
    {  //oluşturduğumuz sql bağlantı sınıfından nesne türetiyoruz
        sqlbaglantisi bgl = new sqlbaglantisi();

        public bugunki_Etutler()
        {
            InitializeComponent();
        }
        //bugünkü etütleri bulmak için sql kodu hazırladık  bunun içni inner join nesnesini kullanarak birden fazla tabloyu birleştirme işlemine tabi tuttuk
        void BugunEtut()
        {
            try
            {
             

                SqlDataAdapter da = new SqlDataAdapter("Select ID,DERSADI as 'Ders Adı',TBL_OGRETMEN.ADSOYAD as 'Öğretmen Adı',TBL_OGRENCI.ADSOYAD as 'Öğrenci Adı',TARIH,SAAT From TBL_ETUT inner join TBL_DERSLER on TBL_ETUT.DERSID = TBL_DERSLER.DERSID inner join TBL_OGRETMEN on TBL_ETUT.OGRETMENID = TBL_OGRETMEN.OGRETMENID inner join TBL_OGRENCI on TBL_ETUT.OGRENCIID = TBL_OGRENCI.OGRENCIID where TARIH='"+ LblTarih.Text + "' order by ID desc", bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu..."+hata.Message, "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bugunki_Etutler_Load(object sender, EventArgs e)
        {//yazdiğimiz fonksiyonumuzu çağırdık
            BugunEtut();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  //timerimiz güncel olarak tarih saat tutması için timer içine datetime verilerini koyduk.
            //ve bunları textlere aktardık.
            LblTarih.Text = DateTime.Now.ToShortDateString();
            LblSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
