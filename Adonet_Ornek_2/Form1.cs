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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            SqlConnection baglanti = new SqlConnection("server= DESKTOP-TUMHS1A\\NA;database=Northwind;Integrated Security= true ");
        public void UrunListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Urunler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt; // sadece select sorgularında kullanılır.
            dataGridView1.Columns["UrunID"].Visible = false;
            dataGridView1.Columns["TedarikciID"].Visible = false;
            dataGridView1.Columns["KategoriID"].Visible = false;


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListele();
      
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            string uruad = textBoxurunad.Text;
            decimal fiyat = numericUpDownfiyat.Value;
            decimal stok = numericUpDownstok.Value;
            if (uruad =="" || fiyat == 0 || stok>0)
            {

            }
            SqlCommand komut = new SqlCommand();
            komut.CommandText =string.Format("INSERT INTO Urunler(UrunAdi, BirimFiyati,HedefStokDuzeyi) values ('{0}', '{1}', '{2}')",uruad,fiyat,stok);
            komut.Connection = baglanti;
            baglanti.Open();
           int sonuc =  komut.ExecuteNonQuery();
            if (sonuc>0)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else 
                MessageBox.Show("kaydedilemedi");
            UrunListele();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategoriler k;
            if (Application.OpenForms["Kategoriler"] == null)
            {
                k = new Kategoriler();
                k.Show();
            }
            else
            {
                k = (Kategoriler)Application.OpenForms["Kategoriler"];
                k.Focus();
            }
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            string fiyat = numericUpDownfiyat.Value.ToString().Replace(',','.');
            SqlCommand komut = new SqlCommand();
            komut.CommandText =String.Format("UPDATE Urunler SET UrunAdi='{0}', BirimFiyati='{1}', HedefStokDuzeyi= '{2}' WHERE UrunID= '{3}' ",textBoxurunad.Text,fiyat,numericUpDownstok.Value,textBoxurunad.Tag);
            
            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxurunad.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            numericUpDownfiyat.Value = (decimal)dataGridView1.CurrentRow.Cells["BirimFiyati"].Value;//cast
            numericUpDownstok.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HedefStokDuzeyi"].Value);
            textBoxurunad.Tag=dataGridView1.CurrentRow.Cells["UrunID"].Value;//textbox un tag i ne id yi attık. Tag object türünden veri taşıyabilir.
                
        }
    }
}
