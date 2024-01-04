using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MBP104PROJE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BVS3T9E;Initial Catalog=mbp104;Integrated Security=True");
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'mbp104DataSet6.kayıttab' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayıttabTableAdapter2.Fill(this.mbp104DataSet6.kayıttab);
            // TODO: Bu kod satırı 'mbp104DataSet5.kayıttab' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayıttabTableAdapter1.Fill(this.mbp104DataSet5.kayıttab);
            // TODO: Bu kod satırı 'mbp104DataSet2.kayıttab' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.kayıttabTableAdapter2.Fill(this.mbp104DataSet6.kayıttab);
        }

        private void button7_Click(object sender, EventArgs e)
        {
           baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into kayıttab (Ad,Soyad,Kitap_Ad,Kitap_Yazar,Yayın_Evi,Süre_Gün) values (@k1,@k2,@k3,@k4,@k5,@k6)", baglanti);
            komut.Parameters.AddWithValue("@k1", textBox1.Text);
            komut.Parameters.AddWithValue("@k2", textBox2.Text);
            komut.Parameters.AddWithValue("@k3", textBox3.Text);
            komut.Parameters.AddWithValue("@k4", textBox4.Text);
            komut.Parameters.AddWithValue("@k5", textBox5.Text);
            komut.Parameters.AddWithValue("@k6", textBox6.Text);
            komut.ExecuteNonQuery();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();



            baglanti.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sil = new SqlCommand("delete from kayıttab where ID=@d1 ", baglanti);
            sil.Parameters.AddWithValue("@d1", textBox7.Text);
            sil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Başarıyla silindi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int secilen= dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncel = new SqlCommand("update kayıttab set Ad=@g1 ,Soyad=@g2, Kitap_Ad=@g3, Kitap_Yazar=@g4, Yayın_Evi=@g5 , Süre_gün=@g6   where ID=@g7", baglanti);
            guncel.Parameters.AddWithValue("g1", textBox1.Text);
            guncel.Parameters.AddWithValue("g2", textBox2.Text);
            guncel.Parameters.AddWithValue("g3", textBox3.Text);
            guncel.Parameters.AddWithValue("g4", textBox4.Text);
            guncel.Parameters.AddWithValue("g5", textBox5.Text);
            guncel.Parameters.AddWithValue("g6", textBox6.Text);
            guncel.Parameters.AddWithValue("g7", textBox7.Text);


            guncel.ExecuteNonQuery();


            baglanti.Close();

            MessageBox.Show("Başarıyla Güncellendi");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void c(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            textBox7.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
