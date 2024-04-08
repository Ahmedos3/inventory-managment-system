namespace inventory_managment_system
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            btnClose = new Button();
            btnSignup = new Button();
            txtlname = new TextBox();
            txtfname = new TextBox();
            label4 = new Label();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            txtcpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            l_username = new Label();
            txtusername = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 96, 129);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 419);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(36, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 91);
            label5.Name = "label5";
            label5.Size = new Size(186, 14);
            label5.TabIndex = 18;
            label5.Text = "inventory mangment system";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(75, 53);
            label3.Name = "label3";
            label3.Size = new Size(77, 38);
            label3.TabIndex = 16;
            label3.Text = "iMs";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(2, 96, 129);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(590, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 23);
            btnClose.TabIndex = 15;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(2, 96, 129);
            btnSignup.Cursor = Cursors.Hand;
            btnSignup.FlatStyle = FlatStyle.Popup;
            btnSignup.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(323, 351);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(231, 36);
            btnSignup.TabIndex = 10;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnsignup_Click;
            // 
            // txtlname
            // 
            txtlname.AcceptsReturn = true;
            txtlname.BackColor = Color.White;
            txtlname.BorderStyle = BorderStyle.FixedSingle;
            txtlname.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlname.Location = new Point(462, 99);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(156, 26);
            txtlname.TabIndex = 14;
            // 
            // txtfname
            // 
            txtfname.AccessibleDescription = "";
            txtfname.BackColor = Color.White;
            txtfname.BorderStyle = BorderStyle.FixedSingle;
            txtfname.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfname.Location = new Point(282, 99);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(153, 26);
            txtfname.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(2, 96, 129);
            label4.Location = new Point(371, 34);
            label4.Name = "label4";
            label4.Size = new Size(155, 38);
            label4.TabIndex = 17;
            label4.Text = "Sign Up";
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.White;
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(282, 206);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(336, 26);
            txtemail.TabIndex = 18;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(282, 260);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(336, 26);
            txtpassword.TabIndex = 19;
            txtpassword.Tag = "";
            // 
            // txtcpassword
            // 
            txtcpassword.BackColor = Color.White;
            txtcpassword.BorderStyle = BorderStyle.FixedSingle;
            txtcpassword.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcpassword.Location = new Point(282, 314);
            txtcpassword.Name = "txtcpassword";
            txtcpassword.Size = new Size(336, 26);
            txtcpassword.TabIndex = 20;
            txtcpassword.Tag = "";
            txtcpassword.TextChanged += txtcpassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 83);
            label1.Name = "label1";
            label1.Size = new Size(68, 13);
            label1.TabIndex = 21;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 83);
            label2.Name = "label2";
            label2.Size = new Size(67, 13);
            label2.TabIndex = 22;
            label2.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(280, 190);
            label6.Name = "label6";
            label6.Size = new Size(38, 13);
            label6.TabIndex = 23;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 244);
            label7.Name = "label7";
            label7.Size = new Size(61, 13);
            label7.TabIndex = 24;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(280, 298);
            label8.Name = "label8";
            label8.Size = new Size(111, 13);
            label8.TabIndex = 25;
            label8.Text = "Password Confirm";
            // 
            // l_username
            // 
            l_username.AutoSize = true;
            l_username.Location = new Point(280, 133);
            l_username.Name = "l_username";
            l_username.Size = new Size(64, 13);
            l_username.TabIndex = 27;
            l_username.Text = "username";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.White;
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(282, 149);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(336, 26);
            txtusername.TabIndex = 26;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 419);
            Controls.Add(l_username);
            Controls.Add(txtusername);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtcpassword);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnSignup);
            Controls.Add(txtlname);
            Controls.Add(txtfname);
            Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signUP";
            Load += signup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtcpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l_username;
        private System.Windows.Forms.TextBox txtusername;
    }
}