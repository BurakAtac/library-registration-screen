using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBP104PROJE
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BVS3T9E;Initial Catalog=mbp104;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
             baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into Personeltab (Personel_Ad,Personel_Sifre) values(@p1,@p2)",baglanti); 
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSıfre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
