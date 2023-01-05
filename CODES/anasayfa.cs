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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        //oluşturduğumuz sql bağlantı sınıfından nesne türetiyoruz
        sqlbaglantisi bgl = new sqlbaglantisi();

        //bütün dersleri tabloya çeken fonksiyonumuzu yazdık
        void ButunDersler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_DERSLER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //bütün sınıfları tabloya çeken fonksiyonumuzu yazdık
        void ButunSiniflar()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_SINIFLAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        //bütün öğretmenleri tabloya çeken fonksiyonumuzu yazdık
        void ButunOgretmenler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OGRETMENID,ADSOYAD,TELEFON,MAIL,DERSADI From TBL_OGRETMEN inner join TBL_DERSLER on TBL_OGRETMEN.BRANS = TBL_DERSLER.DERSID", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        //bütün öğrencileri tabloya çeken fonksiyonumuzu yazdık
        void ButunOgrenciler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OGRENCIID,ADSOYAD,TELEFON,MAIL,SINIFADI From TBL_OGRENCI inner join TBL_SINIFLAR on TBL_OGRENCI.SINIFID = TBL_SINIFLAR.SINIFID", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
        }

        //son eklenen 5 ürünü gösteren tabloyu yazdık
        void SonEklenenEtutler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Top 5 TBL_OGRETMEN.ADSOYAD as 'Öğretmen Adı',TBL_OGRENCI.ADSOYAD as 'Öğrenci Adı' From TBL_ETUT inner join TBL_OGRETMEN on TBL_ETUT.OGRETMENID = TBL_OGRETMEN.OGRETMENID inner join TBL_OGRENCI on TBL_ETUT.OGRENCIID = TBL_OGRENCI.OGRENCIID  order by ID desc", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt;
        }

        /* ISTATISTIKLER */
        //öğrenci sayisini çeken sql kodunu yazdık ardından bunu lbltoplamogrenci ye aktardık.
        void ToplamOgrenciSayisi()
        {
            SqlCommand komut = new SqlCommand("Select Count(OGRENCIID) From TBL_OGRENCI", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamOgrenci.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        //öğretmen sayisini çeken sql kodunu yazdık ardından bunu LblToplamOgretmen ye aktardık.
        void ToplamOgretmenSayisi()
        {
            SqlCommand komut = new SqlCommand("Select Count(OGRETMENID) From TBL_OGRETMEN", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamOgretmen.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        //sınıf sayisini çeken sql kodunu yazdık ardından bunu LblToplamSinif ye aktardık.
        void ToplamSinifSayisi()
        {
            SqlCommand komut = new SqlCommand("Select Count(SINIFID) From TBL_SINIFLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamSinif.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        //etüt sayisini çeken sql kodunu yazdık ardından bunu LblToplamEtut ye aktardık.
        void ToplamEtutSayisi()
        {
            SqlCommand komut = new SqlCommand("Select Count(ID) From TBL_ETUT", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamEtut.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            //yazdiğimiz tüm fonksiyonları çalışmaları için anasayfamızın load özelliğine yazarak çağırdık.
            ButunDersler();
            ButunSiniflar();
            ButunOgretmenler();
            ButunOgrenciler();
            SonEklenenEtutler();

            ToplamOgrenciSayisi();
            ToplamOgretmenSayisi();
            ToplamSinifSayisi();
            ToplamEtutSayisi();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timerimiz güncel olarak tarih saat tutması için timer içine datetime verilerini koyduk.
            //ve bunları textlere aktardık.
            LblTarih.Text = DateTime.Now.ToShortDateString();
            LblSaat.Text = DateTime.Now.ToLongTimeString();
           
        }
    }
}
