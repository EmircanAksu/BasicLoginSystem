namespace WeLoaderProjects
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignUp_Browse = new MetroFramework.Controls.MetroButton();
            this.txtResim = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.txtUsername_Sign = new ns1.BunifuMaterialTextbox();
            this.txtPassword_Sign = new ns1.BunifuMaterialTextbox();
            this.txtMail_Sign = new ns1.BunifuMaterialTextbox();
            this.lblUsername_Sign = new ns1.BunifuCustomLabel();
            this.lblPassword_Sign = new ns1.BunifuCustomLabel();
            this.lblMail_Sign = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Orange;
            this.metroButton1.Location = new System.Drawing.Point(63, 387);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(223, 73);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Sign Up";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "WeLoader";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(254, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSignUp_Browse
            // 
            this.btnSignUp_Browse.Location = new System.Drawing.Point(211, 342);
            this.btnSignUp_Browse.Name = "btnSignUp_Browse";
            this.btnSignUp_Browse.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp_Browse.TabIndex = 10;
            this.btnSignUp_Browse.Text = "Browse";
            this.btnSignUp_Browse.UseSelectable = true;
            this.btnSignUp_Browse.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // txtResim
            // 
            // 
            // 
            // 
            this.txtResim.CustomButton.Image = null;
            this.txtResim.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtResim.CustomButton.Name = "";
            this.txtResim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtResim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtResim.CustomButton.TabIndex = 1;
            this.txtResim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtResim.CustomButton.UseSelectable = true;
            this.txtResim.CustomButton.Visible = false;
            this.txtResim.Lines = new string[0];
            this.txtResim.Location = new System.Drawing.Point(63, 341);
            this.txtResim.MaxLength = 32767;
            this.txtResim.Name = "txtResim";
            this.txtResim.PasswordChar = '\0';
            this.txtResim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResim.SelectedText = "";
            this.txtResim.SelectionLength = 0;
            this.txtResim.SelectionStart = 0;
            this.txtResim.ShortcutsEnabled = true;
            this.txtResim.Size = new System.Drawing.Size(133, 23);
            this.txtResim.TabIndex = 11;
            this.txtResim.UseSelectable = true;
            this.txtResim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton3
            // 
            this.metroButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton3.BackgroundImage")));
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton3.Location = new System.Drawing.Point(12, 38);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(41, 36);
            this.metroButton3.TabIndex = 12;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // txtUsername_Sign
            // 
            this.txtUsername_Sign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername_Sign.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername_Sign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername_Sign.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername_Sign.HintText = "";
            this.txtUsername_Sign.isPassword = false;
            this.txtUsername_Sign.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txtUsername_Sign.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername_Sign.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txtUsername_Sign.LineThickness = 3;
            this.txtUsername_Sign.Location = new System.Drawing.Point(63, 113);
            this.txtUsername_Sign.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUsername_Sign.Name = "txtUsername_Sign";
            this.txtUsername_Sign.Size = new System.Drawing.Size(223, 33);
            this.txtUsername_Sign.TabIndex = 13;
            this.txtUsername_Sign.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword_Sign
            // 
            this.txtPassword_Sign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword_Sign.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword_Sign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword_Sign.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword_Sign.HintText = "";
            this.txtPassword_Sign.isPassword = true;
            this.txtPassword_Sign.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txtPassword_Sign.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword_Sign.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txtPassword_Sign.LineThickness = 3;
            this.txtPassword_Sign.Location = new System.Drawing.Point(63, 201);
            this.txtPassword_Sign.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword_Sign.Name = "txtPassword_Sign";
            this.txtPassword_Sign.Size = new System.Drawing.Size(223, 33);
            this.txtPassword_Sign.TabIndex = 14;
            this.txtPassword_Sign.Text = "bunifuMaterialTextbox1";
            this.txtPassword_Sign.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMail_Sign
            // 
            this.txtMail_Sign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail_Sign.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMail_Sign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMail_Sign.HintForeColor = System.Drawing.Color.Empty;
            this.txtMail_Sign.HintText = "";
            this.txtMail_Sign.isPassword = false;
            this.txtMail_Sign.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txtMail_Sign.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMail_Sign.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txtMail_Sign.LineThickness = 3;
            this.txtMail_Sign.Location = new System.Drawing.Point(63, 285);
            this.txtMail_Sign.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail_Sign.Name = "txtMail_Sign";
            this.txtMail_Sign.Size = new System.Drawing.Size(223, 33);
            this.txtMail_Sign.TabIndex = 15;
            this.txtMail_Sign.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblUsername_Sign
            // 
            this.lblUsername_Sign.AutoSize = true;
            this.lblUsername_Sign.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername_Sign.Location = new System.Drawing.Point(12, 89);
            this.lblUsername_Sign.Name = "lblUsername_Sign";
            this.lblUsername_Sign.Size = new System.Drawing.Size(90, 29);
            this.lblUsername_Sign.TabIndex = 16;
            this.lblUsername_Sign.Text = "Username";
            // 
            // lblPassword_Sign
            // 
            this.lblPassword_Sign.AutoSize = true;
            this.lblPassword_Sign.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword_Sign.Location = new System.Drawing.Point(12, 168);
            this.lblPassword_Sign.Name = "lblPassword_Sign";
            this.lblPassword_Sign.Size = new System.Drawing.Size(85, 29);
            this.lblPassword_Sign.TabIndex = 17;
            this.lblPassword_Sign.Text = "Password";
            // 
            // lblMail_Sign
            // 
            this.lblMail_Sign.AutoSize = true;
            this.lblMail_Sign.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail_Sign.Location = new System.Drawing.Point(12, 252);
            this.lblMail_Sign.Name = "lblMail_Sign";
            this.lblMail_Sign.Size = new System.Drawing.Size(116, 29);
            this.lblMail_Sign.TabIndex = 18;
            this.lblMail_Sign.Text = "E-mail Adress";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(353, 484);
            this.Controls.Add(this.lblMail_Sign);
            this.Controls.Add(this.lblPassword_Sign);
            this.Controls.Add(this.lblUsername_Sign);
            this.Controls.Add(this.txtMail_Sign);
            this.Controls.Add(this.txtPassword_Sign);
            this.Controls.Add(this.txtUsername_Sign);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.txtResim);
            this.Controls.Add(this.btnSignUp_Browse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnSignUp_Browse;
        private MetroFramework.Controls.MetroTextBox txtResim;
        private MetroFramework.Controls.MetroButton metroButton3;
        private ns1.BunifuMaterialTextbox txtUsername_Sign;
        private ns1.BunifuMaterialTextbox txtPassword_Sign;
        private ns1.BunifuMaterialTextbox txtMail_Sign;
        private ns1.BunifuCustomLabel lblUsername_Sign;
        private ns1.BunifuCustomLabel lblPassword_Sign;
        private ns1.BunifuCustomLabel lblMail_Sign;
    }
}