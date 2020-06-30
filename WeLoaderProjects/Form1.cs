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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }


      
        private void frm_Login_Load(object sender, EventArgs e)
        {
           

        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sgn = new SignUp();
            sgn.Show();

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            
            SqlConnection conn = new SqlConnection("Data Source");
            string sorgu = "select * from users where username= '" + txtBox_Username.Text.Trim() + "' and Password = '" + txtBox_Password.Text.Trim() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                HomePage dashboard = new HomePage();
                this.Hide();
                dashboard.Show();

            }
            else
                MessageBox.Show("Kullanıcı adı veya şifreniz yanlış!");

        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
         
                this.BackColor = Color.Black;
                lbl_Username.BackColor = Color.Black;
                lbl_Username.ForeColor = Color.White;
                txtBox_Username.BackColor = Color.White;
                lbl_Password.BackColor = Color.Black;
                lbl_Password.ForeColor = Color.White;
                txtBox_Password.BackColor = Color.White;
                label1.ForeColor = Color.White;
                
        }
           

        }
    }
    
    

        
        
    


