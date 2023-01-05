using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sql işlemleri için kütüphanemizi ekliyoruz
using System.Data.SqlClient;

namespace Birebir_Etut_Programi
{
    public partial class Form1 : Form
    {
        //sql bağlantı nesnemizi türettik
        sqlbaglantisi bag = new sqlbaglantisi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                //adminlistesi tablosunda girilen kullanıcı adı ve şifreden kullanıcı var mı diye kontrol ettik

                SqlCommand komut = new SqlCommand("select * from TBL_ADMINLISTESI where K_ADI='" + textBox1.Text + "'and SIFRE='" + textBox2.Text + "' ", bag.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())//eğer okuma işlemi başarılıysa onu menüye yönlendirdik
                {
                    MessageBox.Show("Başarılı Giriş Yapıldı");
                    menu menugigris = new menu();
                    menugigris.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("hatalı giriş yapdınız");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }
    }
}
