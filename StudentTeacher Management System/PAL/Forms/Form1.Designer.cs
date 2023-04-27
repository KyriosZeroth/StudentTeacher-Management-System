
namespace StudentTeacher_Management_System.PAL.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginBox1 = new System.Windows.Forms.GroupBox();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.valid_lbl = new System.Windows.Forms.Label();
            this.LogIn_bttn = new System.Windows.Forms.Button();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox1
            // 
            this.LoginBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBox1.BackColor = System.Drawing.Color.White;
            this.LoginBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginBox1.Controls.Add(this.roleCB);
            this.LoginBox1.Controls.Add(this.pictureBox3);
            this.LoginBox1.Controls.Add(this.pictureBox2);
            this.LoginBox1.Controls.Add(this.valid_lbl);
            this.LoginBox1.Controls.Add(this.LogIn_bttn);
            this.LoginBox1.Controls.Add(this.Password_txt);
            this.LoginBox1.Controls.Add(this.Password_lbl);
            this.LoginBox1.Controls.Add(this.Username_txt);
            this.LoginBox1.Controls.Add(this.username_lbl);
            this.LoginBox1.Location = new System.Drawing.Point(152, 213);
            this.LoginBox1.Name = "LoginBox1";
            this.LoginBox1.Size = new System.Drawing.Size(626, 346);
            this.LoginBox1.TabIndex = 0;
            this.LoginBox1.TabStop = false;
            this.LoginBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // roleCB
            // 
            this.roleCB.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Items.AddRange(new object[] {
            "student",
            "teacher",
            "admin"});
            this.roleCB.Location = new System.Drawing.Point(423, 269);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(154, 35);
            this.roleCB.TabIndex = 9;
            this.roleCB.Text = "Role";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(538, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 39);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(538, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 39);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // valid_lbl
            // 
            this.valid_lbl.AutoSize = true;
            this.valid_lbl.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid_lbl.ForeColor = System.Drawing.Color.Red;
            this.valid_lbl.Location = new System.Drawing.Point(38, 246);
            this.valid_lbl.Name = "valid_lbl";
            this.valid_lbl.Size = new System.Drawing.Size(58, 19);
            this.valid_lbl.TabIndex = 5;
            this.valid_lbl.Text = "Invalid!";
            this.valid_lbl.Visible = false;
            // 
            // LogIn_bttn
            // 
            this.LogIn_bttn.BackColor = System.Drawing.Color.Goldenrod;
            this.LogIn_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogIn_bttn.FlatAppearance.BorderSize = 0;
            this.LogIn_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn_bttn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_bttn.ForeColor = System.Drawing.Color.Maroon;
            this.LogIn_bttn.Location = new System.Drawing.Point(42, 269);
            this.LogIn_bttn.Name = "LogIn_bttn";
            this.LogIn_bttn.Size = new System.Drawing.Size(113, 36);
            this.LogIn_bttn.TabIndex = 4;
            this.LogIn_bttn.Text = "Log In";
            this.LogIn_bttn.UseVisualStyleBackColor = false;
            this.LogIn_bttn.Click += new System.EventHandler(this.LogIn_bttn_Click);
            // 
            // Password_txt
            // 
            this.Password_txt.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(42, 171);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(536, 39);
            this.Password_txt.TabIndex = 3;
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(36, 135);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(128, 33);
            this.Password_lbl.TabIndex = 2;
            this.Password_lbl.Text = "Password:";
            // 
            // Username_txt
            // 
            this.Username_txt.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txt.Location = new System.Drawing.Point(42, 80);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(536, 39);
            this.Username_txt.TabIndex = 1;
            this.Username_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(36, 43);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(135, 33);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username:";
            this.username_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(968, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 678);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "CEBU TECHNOLOGICAL UNIVERSITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Main Campus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(551, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "M.J. Cuenco Ave., Cor R. Palma Street, 6000 Cebu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1353, 677);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginBox1);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.LoginBox1.ResumeLayout(false);
            this.LoginBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginBox1;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.Label valid_lbl;
        private System.Windows.Forms.Button LogIn_bttn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}