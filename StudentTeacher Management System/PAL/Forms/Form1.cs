using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentTeacher_Management_System.PAL.Forms
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002");
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_bttn_Click(object sender, EventArgs e)
        {


            if (Username_txt.Text == "" || Password_txt.Text == "" || roleCB.SelectedIndex == 0)
            {
                MessageBox.Show(" LogIn Failed, Input Correct Information!");
            }
            else if (roleCB.Text == "admin")
            {
                con.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter("select count(*) from adminacc where uname= '" + Username_txt.Text + "' and pass= '" + Password_txt.Text + "'", con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    AdminForm Obj = new AdminForm();
                    Obj.Show();
                    this.Hide();
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Wrong Username and Password");
                    Username_txt.Text = "";
                    Password_txt.Text = "";


                }
                con.Close();
            }
            else if (roleCB.Text == "teacher")
            {
                con.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter("select count(*) from teacheracc where teachername= '" + Username_txt.Text + "' and teacherpassword= '" + Password_txt.Text + "'", con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    AdminForm Obj = new AdminForm();
                    Obj.Show();
                    this.Hide();
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Wrong Username and Password");
                    Username_txt.Text = "";
                    Password_txt.Text = "";


                }
                con.Close();
            }


        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Show Password");
        }


        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Hide Password");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Password_txt.UseSystemPasswordChar = false;
            pictureBox2.Hide();
            pictureBox3.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {


            Password_txt.UseSystemPasswordChar = true;
            pictureBox2.Show();
            pictureBox3.Hide();
        }


    }
}
