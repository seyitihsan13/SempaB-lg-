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
namespace BilgiMİllyoner
{
    public partial class SkorTablo : Form
    {
        public SkorTablo()
        {
            InitializeComponent();
        }
        public string kullaniciAdi, KazandigiPara, YarismayaVerdigiAd;

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void SkorTablo_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From SkorTablosu where KullaniciAdi,KazandigiPara,YarismayaVerdigiAd=" + kullaniciAdi + KazandigiPara + YarismayaVerdigiAd, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
               
        }
    }
}
