using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeLoaderProjects
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }


        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
            string baglanti = "Data Source";
            SqlConnection con = new SqlConnection(baglanti);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("select UserPhoto from Users" + con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string dosyaYolu = "filePATH";
            Stream stream = dr.GetStream(5); //Resim kolonunun sorgunuzdaki sıra numarası gelmeli.
            pictureBox1.Image = Image.FromStream(stream);
            cmd.Parameters.AddWithValue("@UserPhoto", File.ReadAllBytes(dosyaYolu));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
        bool AdminMi; // Kullanmak İstersen diye çok (Opsiyonel)
        private object txtBox_Username;

        private void GirisYapanKullanici_Load(object sender, EventArgs e)
        {
            









        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
