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
    public partial class Kategori_Form : Form
    {
        public Kategori_Form()
        {
            InitializeComponent();
        }

        private void Kategori_Form_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server= DESKTOP-TUMHS1A\\NA;database=Northwind;Integrated Security= true ");
            SqlCommand komut = new SqlCommand("select * from kategoriler",baglanti);
            baglanti.Open();
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                string katAd = rdr["KategoriAdi"].ToString();
                string tanim = rdr["Tanimi"].ToString();
                listBox1.Items.Add(string.Format("{0}-{1}",katAd,tanim));
            }
            baglanti.Close();
        }
    }
}
