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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MessageBox.Show("Bu Bilgi Yarışması toplam 25 sorudan oluşmaktadır. Bu Sorular Rastgele Gelmektedir. 15 saniye içinde cevap vermeniz gerekmektedir. Başarılar :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        SqlConnection baglan = new SqlConnection("Data Source=PC-160130;Initial Catalog=soru;Integrated Security=True");
        int sayaç = 0;
        int puan = 2500;
        int zaman = 16;

        List<Sorular> items;

        static int index = 0;
        private void BtnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 16;

            lblYarismaAdiii.Text = jfbss.UserID;





            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;

            BtnBasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            BtnBasla.Text = "Sonraki";
            sayaç++;
            lblsoru.Text = sayaç.ToString();

            button1.Text = (items[index].a.ToString());
            button2.Text = (items[index].b.ToString());
            button3.Text = (items[index].c.ToString());
            button4.Text = (items[index].d.ToString());
            textBox1.Text = (items[index].soru.ToString());
            lbldogru.Text = (items[index].dogru.ToString());
            lblKategori.Text = (items[index].kategori.ToString());

            index++;

            //if (sayaç == 1)
            //{
            //    sayaç++;
            //    baglan.Open();
            //    SqlCommand komut = new SqlCommand("SELECT TOP 10  FROM soru  ORDER BY NEWID() ", baglan);
            //    SqlDataReader oku = komut.ExecuteReader();

            //    List<Sorular> items = new List<Sorular>();
            //    Sorular item = null;

            //    while (oku.Read())
            //    {
            //        // sayaç++;
            //        item = new Sorular();

            //        item.kategori = (oku["kategori"].ToString());
            //        item.soru = (oku["sorular"].ToString());
            //        item.a = (oku["a"].ToString());
            //        item.b = (oku["b"].ToString());
            //        item.c = (oku["c"].ToString());
            //        item.d = (oku["d"].ToString());
            //        item.dogru = (oku["dogru"].ToString());
            //        //textBox1.Text = (oku["sorular"].ToString());
            //        //lbldogru.Text = (oku["dogru"].ToString());
            //    }

            //    baglan.Close();
            //}


            if (sayaç == 25)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                timer1.Enabled = false;

                MessageBox.Show("Kazanılan Para: " + puan, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT TOP 25 *  FROM Kategori  ORDER BY NEWID() ", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            items = new List<Sorular>();
            Sorular item = null;

            while (oku.Read())
            {
                //sayaç++;
                item = new Sorular();

                

                //item.kategori = (oku["kategori"].ToString());
                item.soru = (oku["sorular"].ToString());
                item.a = (oku["a"].ToString());
                item.b = (oku["b"].ToString());
                item.c = (oku["c"].ToString());
                item.d = (oku["d"].ToString());
                item.kategori = (oku["kategori"].ToString());
                item.dogru = (oku["dogru"].ToString());
                //textBox1.Text = (oku["sorular"].ToString());
                //lbldogru.Text = (oku["dogru"].ToString());
                items.Add(item);

            }

            baglan.Close();




            lblsoru.Text = sayaç.ToString();
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            lbldogru.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == lbldogru.Text)
            {
                puan = puan + 2500;
                lblpuan.Text = puan.ToString();
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == lbldogru.Text)
            {
                puan = puan + 2500;
                lblpuan.Text = puan.ToString(); button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == lbldogru.Text)
            {
                puan = puan + 2500;
                lblpuan.Text = puan.ToString(); button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == lbldogru.Text)
            {
                puan = puan + 2500;
                lblpuan.Text = puan.ToString(); button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblzaman.Text = zaman.ToString();
            if (zaman == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                BtnBasla.Enabled = true;
            }
        }

        private void BtnSkorTablosu_Click(object sender, EventArgs e)
        {
            SkorTablo skt = new SkorTablo();
            skt.Show();
            this.Hide();
        }
        SqlConnection bgl = new SqlConnection();

        private void lblYarismaAdiii_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
