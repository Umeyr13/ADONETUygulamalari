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

            //komut.CommandText = String.Format("INSERT INTO Kategoriler (KategoriAdi, Tanimi) values ('{0}','{1}')",textkategori.Text,texttanim.Text);

              /***************   PARAMETRE KULLANIMI        ******************/

            SqlCommand komut = new SqlCommand("KateoriEkle", baglanti);
          //komut.CommandText = "INSERT INTO Kategoriler (KategoriAdi, Tanimi) values (@kulAd,@tanim)";
          //  komut.Connection = baglanti;
          //  komut.Parameters.AddWithValue("@kulAd",textkategori.Text);
          //  komut.Parameters.AddWithValue("@tanim",texttanim.Text);

           komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kategori", textkategori.Text);
            komut.Parameters.AddWithValue("@tanim",texttanim.Text);
            baglanti.Open();

            try
            {
                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();
                if (sonuc > 0)
                {
                    MessageBox.Show("Başarılı");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Hatalı");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            
        }
        public void Listele()
        {
           // SqlDataAdapter adp = new SqlDataAdapter("select * from Kategoriler", baglanti);
           SqlDataAdapter adp = new SqlDataAdapter("KategoriListesi",baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;           
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id =Convert.ToInt32(dataGridView1.CurrentRow.Cells["KategoriID"].Value);//seçilen id
               // SqlCommand komut = new SqlCommand();
               // komut.CommandText = String.Format("DELETE Kategoriler WHERE KategoriID={0}",id);
                //komut.Connection = baglanti;
                SqlCommand komut = new SqlCommand("KategoriSil",baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@kId",id);
                baglanti.Open();
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc>0)
                {
                    MessageBox.Show ("başarılı");
                    Listele();
                    
                }
                else
                {

                }
                baglanti.Close();


            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {//hücrenin değeri her değiştiğinde update oluyor
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KategoriID"].Value);
            string kad = dataGridView1.CurrentRow.Cells["KategoriAdi"].Value.ToString();
            string tanim = dataGridView1.CurrentRow.Cells["Tanimi"].Value.ToString();
            SqlCommand komut = new  SqlCommand ("KategoriGuncelle",baglanti);
            komut.CommandType = CommandType.StoredProcedure ;
            komut.Parameters.AddWithValue("@kId",id);
            komut.Parameters.AddWithValue("@kAd",kad);
            komut.Parameters.AddWithValue("@kTanim",tanim);
            baglanti.Open ();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
