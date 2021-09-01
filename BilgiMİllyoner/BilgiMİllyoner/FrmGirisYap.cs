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
    public partial class FrmGirisYap : Form
    {
        public FrmGirisYap()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void LnkKayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayıtOl fr = new FrmKayıtOl();
            fr.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Kayit Where KullaniciAdi=@p1 and Sifre=@p2 and YarismaAdi=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p3", TxtYarismaAd.Text);

            //staticclass.staticattribute = TxtYarismaAd.Text;
            jfbss.UserID = TxtYarismaAd.Text;


            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı,Şifre veya Yarışma Adı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            bgl.baglanti().Close();
        }

        private void FrmGirisYap_Load(object sender, EventArgs e)
        {

        }

        private void TxtYarismaAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
