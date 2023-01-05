﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace Birebir_Etut_Programi
{
    public partial class tum_Etutler : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public tum_Etutler()
        {
            InitializeComponent();
        }
        void Etut()
        {
            try
            {


                SqlDataAdapter da = new SqlDataAdapter("Select ID,DERSADI as 'Ders Adı',TBL_OGRETMEN.ADSOYAD as 'Öğretmen Adı',TBL_OGRENCI.ADSOYAD as 'Öğrenci Adı',TARIH,SAAT From TBL_ETUT inner join TBL_DERSLER on TBL_ETUT.DERSID = TBL_DERSLER.DERSID inner join TBL_OGRETMEN on TBL_ETUT.OGRETMENID = TBL_OGRETMEN.OGRETMENID inner join TBL_OGRENCI on TBL_ETUT.OGRENCIID = TBL_OGRENCI.OGRENCIID  order by ID desc", bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu..." + hata.Message, "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tum_Etutler_Load(object sender, EventArgs e)
        {
            Etut();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            LblTarih.Text = DateTime.Now.ToShortDateString();
            LblSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
