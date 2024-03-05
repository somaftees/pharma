namespace ph
{
    partial class Adminstrator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dashbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uc_view1 = new ph.uc_view();
            this.uc_adduser = new ph.uc.uc_adduser();
            this.uc_addmed1 = new ph.ph_uc.uc_addmed();
            this.uc_dashboard2 = new ph.uc.uc_dashboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(210)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.dashbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 1000);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(11, 494);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add medicine";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(408, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1383, 678);
            this.panel2.TabIndex = 1;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logoutbtn.BackgroundImage = global::ph.Properties.Resources.log_out;
            this.logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoutbtn.Location = new System.Drawing.Point(11, 562);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(339, 64);
            this.logoutbtn.TabIndex = 5;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(11, 432);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(339, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Profile";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.BackgroundImage = global::ph.Properties.Resources.view;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(11, 366);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(339, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "View User";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddUser.BackgroundImage = global::ph.Properties.Resources.add_user1;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddUser.Location = new System.Drawing.Point(11, 297);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(339, 54);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dashbtn
            // 
            this.dashbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashbtn.BackgroundImage = global::ph.Properties.Resources.dashboard;
            this.dashbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.dashbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbtn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashbtn.Location = new System.Drawing.Point(11, 225);
            this.dashbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashbtn.Name = "dashbtn";
            this.dashbtn.Size = new System.Drawing.Size(339, 54);
            this.dashbtn.TabIndex = 1;
            this.dashbtn.Text = "Dashboard";
            this.dashbtn.UseVisualStyleBackColor = false;
            this.dashbtn.Click += new System.EventHandler(this.dashbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // uc_view1
            // 
            this.uc_view1.Location = new System.Drawing.Point(346, 0);
            this.uc_view1.Margin = new System.Windows.Forms.Padding(5);
            this.uc_view1.Name = "uc_view1";
            this.uc_view1.Size = new System.Drawing.Size(1559, 1000);
            this.uc_view1.TabIndex = 2;
            this.uc_view1.Load += new System.EventHandler(this.uc_view1_Load);
            // 
            // uc_adduser
            // 
            this.uc_adduser.BackColor = System.Drawing.Color.White;
            this.uc_adduser.Location = new System.Drawing.Point(346, 0);
            this.uc_adduser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uc_adduser.Name = "uc_adduser";
            this.uc_adduser.Size = new System.Drawing.Size(1235, 693);
            this.uc_adduser.TabIndex = 1;
            this.uc_adduser.Load += new System.EventHandler(this.uc_adduser1_Load);
            // 
            // uc_addmed1
            // 
            this.uc_addmed1.BackColor = System.Drawing.SystemColors.Window;
            this.uc_addmed1.BackgroundImage = global::ph.Properties.Resources.WhatsApp_Image_2024_03_02_at_23_46_53_2584d47f;
            this.uc_addmed1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc_addmed1.Location = new System.Drawing.Point(346, -1);
            this.uc_addmed1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_addmed1.Name = "uc_addmed1";
            this.uc_addmed1.Size = new System.Drawing.Size(1235, 1000);
            this.uc_addmed1.TabIndex = 3;
            this.uc_addmed1.Load += new System.EventHandler(this.uc_addmed1_Load);
            // 
            // uc_dashboard2
            // 
            this.uc_dashboard2.BackColor = System.Drawing.Color.White;
            this.uc_dashboard2.Location = new System.Drawing.Point(335, -2);
            this.uc_dashboard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_dashboard2.Name = "uc_dashboard2";
            this.uc_dashboard2.Size = new System.Drawing.Size(1234, 1000);
            this.uc_dashboard2.TabIndex = 4;
            this.uc_dashboard2.Load += new System.EventHandler(this.uc_dashboard2_Load);
            // 
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1567, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uc_dashboard2);
            this.Controls.Add(this.uc_addmed1);
            this.Controls.Add(this.uc_view1);
            this.Controls.Add(this.uc_adduser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1364, 651);
            this.Name = "Adminstrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminstrator";
            this.Load += new System.EventHandler(this.Adminstrator_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private uc.uc_adduser uc_adduser;
    private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    private uc_view uc_view1;
    private System.Windows.Forms.Button button1;
    private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    private ph_uc.uc_addmed uc_addmed1;
        private uc.uc_dashboard uc_dashboard2;
    }
}