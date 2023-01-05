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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        //sql bağlantı nesnemizi türettik
        sqlbaglantisi bag = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = colorDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {

             menu.anasayfaarkaplanrengi = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = fontDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {

                menu.anasayfafont = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //adminlistesi tablosunda girilen kullanıcı adı ve şifreden kullanıcı var mı diye kontrol ettik

                SqlCommand komut = new SqlCommand("insert into TBL_ADMINLISTESI(K_ADI,SIFRE)   values('"+textBox1.Text+"','"+textBox2.Text+"') ", bag.baglanti());
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarılı Admin Ekleme İşlemi !");
                textBox1.Text = "sefa";
                textBox2.Text = "ali";
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //adminlistesi tablosunda girilen kullanıcı adı ve şifreden kullanıcı var mı diye kontrol ettik

                SqlCommand komut = new SqlCommand("delete from TBL_ADMINLISTESI where K_ADI='"+textBox4.Text+"'and SIFRE='"+textBox3.Text+"'  ", bag.baglanti());
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarılı Admin Silme İşlemi !");
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }
    }
}
