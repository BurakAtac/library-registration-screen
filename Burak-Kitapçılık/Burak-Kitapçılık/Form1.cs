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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-BVS3T9E;Initial Catalog=mbp104;Integrated Security=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit frm = new Kayit();
            frm.Show();
             
        }

        private void grsAd_Click(object sender, EventArgs e)
        {
            

             baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From personeltab Where Personel_Ad=@p1 and Personel_Sifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", gırısAd.Text);
            komut.Parameters.AddWithValue("@p2", gırısSıfre.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                Main ans = new Main();  
                ans.Show();
                this.Hide();
                MessageBox.Show(""+""+"Hoşgeldin:"+gırısAd.Text );
               
                
                
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
                gırısAd.Clear();
                gırısSıfre.Clear();
                gırısAd.Focus();
            }
            
            baglanti.Close();

            


        }
    }
}
