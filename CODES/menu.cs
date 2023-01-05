using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birebir_Etut_Programi
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        public static Color anasayfaarkaplanrengi = anasayfa.DefaultBackColor;
        public static Font anasayfafont = anasayfa.DefaultFont;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
        }

        private void menu_Load(object sender, EventArgs e)
        {

            //tıklandığında anasayfa açılacak
            anasayfa ChildForm = new anasayfa();

            ChildForm.MdiParent = this;
         
            ChildForm.Show();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa ChildForm = new anasayfa();
            ChildForm.BackColor = anasayfaarkaplanrengi;
            ChildForm.Font = anasayfafont;
          //  MessageBox.Show(anasayfaarkaplanrengi.ToString());
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dersİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tıklandığında dersler_Sayfasi açılacak
            dersler_Sayfasi ChildForm = new dersler_Sayfasi();

            ChildForm.MdiParent = this;
            ChildForm.Show();

        }

        private void sınıfİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tıklandığında sinif_Islemleri açılacak
            sinif_Islemleri ChildForm = new sinif_Islemleri();

            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void öğretmenİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        { //tıklandığında ogretmenler_Sayfasi açılacak

            ogretmenler_Sayfasi ChildForm = new ogretmenler_Sayfasi();

            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void öğrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        { //tıklandığında ogrenci_Sayfasi açılacak
            ogrenci_Sayfasi ChildForm = new ogrenci_Sayfasi();

            ChildForm.MdiParent = this;
            ChildForm.Show();

        }

        private void etütOluşturmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {//tıklandığında etut_Sayfasi açılacak
            etut_Sayfasi ChildForm = new etut_Sayfasi();

            ChildForm.MdiParent = this;
            ChildForm.Show();

        }

        private void bugünkiEtütlerToolStripMenuItem_Click(object sender, EventArgs e)
        {//tıklandığında bugunki_Etutler açılacak
            bugunki_Etutler ChildForm = new bugunki_Etutler();

            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void tümEtütlerToolStripMenuItem_Click(object sender, EventArgs e)
        {//tıklandığında tum_Etutler açılacak
            tum_Etutler ChildForm = new tum_Etutler();

            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tıklandığında tum_Etutler açılacak
            Ayarlar ChildForm = new Ayarlar();

            ChildForm.MdiParent = this;
            ChildForm.Show();
        }
    }
}
