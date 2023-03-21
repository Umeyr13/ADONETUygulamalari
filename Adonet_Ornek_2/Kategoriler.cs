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

namespace Adonet_Ornek_2
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server= DESKTOP-TUMHS1A\\NA;database=Northwind;Integrated Security= true ");
        private void button1_Click(object sender, EventArgs e)
        {
          SqlCommand komut = new SqlCommand();
          komut.CommandText = String.Format("INSERT INTO Kategoriler (KategoriAdi, Tanimi) values ('{0}','{1}')",textkategori.Text,texttanim.Text);
            komut.Connection = baglanti;
            baglanti.Open();
            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();
            if (sonuc >0)
            {
                MessageBox.Show( "Başarılı");
            }
            else
            {
                MessageBox.Show("Hatalı");
            }
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Kategoriler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }
    }
}
