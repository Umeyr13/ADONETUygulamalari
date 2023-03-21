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

namespace ADONET_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //"server= DESKTOP-TUMHS1A;Northwind;user=kullanıcıadı;password=1234 ";
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "server= DESKTOP-TUMHS1A\\NA;database=Northwind;Integrated Security= true ";
            SqlCommand komut = new SqlCommand();
            komut.CommandText ="select * from Urunler";
            komut.Connection = baglanti;
            baglanti.Open();
           SqlDataReader veri = komut.ExecuteReader();
            while(veri.Read())
            {
               string urun_adi =  veri["UrunAdi"].ToString();   
               string fiyat= veri["BirimFiyati"].ToString();
                string stok = veri["HedefStokDuzeyi"].ToString();
                lst_Urunler.Items.Add(urun_adi+" "+ fiyat+ " "+ stok);

            }
            baglanti.Close();
           // lst_Urunler.DataSource = veri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategori_Form kf;
            if (Application.OpenForms["Kategori_Form"]==null)
            {
                kf= new Kategori_Form();
                kf.Show();
            }
            else
            {
                kf = (Kategori_Form)Application.OpenForms["Kategori_Form"];
                kf.Focus();
            }
            
        }
    }
}
