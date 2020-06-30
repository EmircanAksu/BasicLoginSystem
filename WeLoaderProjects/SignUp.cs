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
using System.IO;

namespace WeLoaderProjects
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source");

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
            
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into users (Username,Password,Email,UserPhoto)values (@p1,@p2,@p3,@p4)", conn);
            cmd.Parameters.AddWithValue("@p1", txtUsername_Sign.Text);
            cmd.Parameters.AddWithValue("@p2", txtPassword_Sign.Text);
            cmd.Parameters.AddWithValue("@p3", txtMail_Sign.Text);
            cmd.Parameters.AddWithValue("@p4", txtResim.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login frmL = new frm_Login();
            frmL.Show();


        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
