namespace WeLoaderProjects
{
    partial class frm_Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_SignUp = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Username = new ns1.BunifuMaterialTextbox();
            this.txtBox_Password = new ns1.BunifuMaterialTextbox();
            this.lbl_Password = new ns1.BunifuCustomLabel();
            this.btn_Login = new MetroFramework.Controls.MetroButton();
            this.bunifuiOSSwitch1 = new ns1.BunifuiOSSwitch();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(12, 81);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(90, 29);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.Orange;
            this.btn_SignUp.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_SignUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SignUp.Location = new System.Drawing.Point(48, 362);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(282, 49);
            this.btn_SignUp.TabIndex = 6;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseCustomBackColor = true;
            this.btn_SignUp.UseSelectable = true;
            this.btn_SignUp.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "WeLoader";
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBox_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_Username.HintForeColor = System.Drawing.Color.Empty;
            this.txtBox_Username.HintText = "";
            this.txtBox_Username.isPassword = false;
            this.txtBox_Username.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txtBox_Username.LineIdleColor = System.Drawing.Color.Black;
            this.txtBox_Username.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txtBox_Username.LineThickness = 3;
            this.txtBox_Username.Location = new System.Drawing.Point(48, 114);
            this.txtBox_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(282, 44);
            this.txtBox_Username.TabIndex = 8;
            this.txtBox_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_Password.HintForeColor = System.Drawing.Color.Empty;
            this.txtBox_Password.HintText = "";
            this.txtBox_Password.isPassword = true;
            this.txtBox_Password.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.txtBox_Password.LineIdleColor = System.Drawing.Color.Black;
            this.txtBox_Password.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.txtBox_Password.LineThickness = 3;
            this.txtBox_Password.Location = new System.Drawing.Point(48, 221);
            this.txtBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(282, 44);
            this.txtBox_Password.TabIndex = 9;
            this.txtBox_Password.Text = "bunifuPassword";
            this.txtBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(12, 177);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(85, 29);
            this.lbl_Password.TabIndex = 11;
            this.lbl_Password.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Login.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Login.Location = new System.Drawing.Point(48, 292);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(282, 49);
            this.btn_Login.TabIndex = 12;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseCustomBackColor = true;
            this.btn_Login.UseSelectable = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(309, 12);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 13;
            this.bunifuiOSSwitch1.Value = true;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(364, 434);
            this.Controls.Add(this.bunifuiOSSwitch1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.lbl_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeLoader Login ";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Username;
        private MetroFramework.Controls.MetroButton btn_SignUp;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox txtBox_Username;
        private ns1.BunifuMaterialTextbox txtBox_Password;
        private ns1.BunifuCustomLabel lbl_Password;
        private MetroFramework.Controls.MetroButton btn_Login;
        private ns1.BunifuiOSSwitch bunifuiOSSwitch1;
    }
}

