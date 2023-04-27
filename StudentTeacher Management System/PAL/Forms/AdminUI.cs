using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;


namespace StudentTeacher_Management_System.PAL.Forms
{
    public partial class AdminForm : Form
    {
        string SconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int StudentAc = 1310000;
        string TconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int TeacherAc = 1210000;
        string AconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int AdminAc = 1110000;
       
        //comment change ni 
        //comment change 2
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Admin_An_Click(object sender, EventArgs e)
        {
            
        }

        private void About_Ad_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wala rani
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //wala rani
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            AGridFill();
            AClear();
            TGridFill();
            TClear();
            SGridFill();
            Slear();

        }

        private void ATMA_Click(object sender, EventArgs e) //For Teachers Account Management
        {
            Tpanel.Visible = true;
            SPanel.Visible = false;
            Apanel.Visible = false;
            annForm1.Visible = false;
        }

        private void ASMAbtn_Click(object sender, EventArgs e)//For Students Account Management
        {

            SPanel.Visible = true;
            Tpanel.Visible = false;
            Apanel.Visible = false;
            annForm1.Visible = false;
        }

        private void AMAbtn_Click(object sender, EventArgs e) //For Admin Account Management
        {
            Apanel.Visible = true;
            SPanel.Visible = false;
            Tpanel.Visible = false;
            annForm1.Visible = false;


        }

        private void AAnbtn_Click(object sender, EventArgs e)
        {
            annForm1.Visible = true;
            SPanel.Visible = false;
            Tpanel.Visible = false;
            Apanel.Visible = false;
        }

        private void ACbttn_Click(object sender, EventArgs e)
        {

            SPanel.Visible = false;
            Tpanel.Visible = false;
            Apanel.Visible = false;
            annForm1.Visible = false;
        }

        private void AAbtn_Click(object sender, EventArgs e)
        {

            SPanel.Visible = false;
            Tpanel.Visible = false;
            Apanel.Visible = false;
            annForm1.Visible = false;
        }

        private void APbtn_Click(object sender, EventArgs e)
        {
            Tpanel.Visible = false;
            SPanel.Visible = false;
            Apanel.Visible = false;
            annForm1.Visible = false;

        }

        private string GetStudNameFromDB()
        {
            using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
            {
                smysqlCon.Open();
                MySqlCommand smysqlCmd = new MySqlCommand("SELECT studname FROM studentacc WHERE StudentAc = @StudentAc", smysqlCon);
                smysqlCmd.Parameters.AddWithValue("@StudentAc", StudentAc);
                object result = smysqlCmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return "";
                }
            }
        }
      
        private void ASsave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
            {
                smysqlCon.Open();
                MySqlCommand smysqlCmd = new MySqlCommand("studentAddOrUp", smysqlCon);
                smysqlCmd.CommandType = CommandType.StoredProcedure;
                smysqlCmd.Parameters.AddWithValue("_StudentAc", StudentAc);
                smysqlCmd.Parameters.AddWithValue("_studuname", Sunametxt.Text.Trim());
                smysqlCmd.Parameters.AddWithValue("_studpass", spasstxt.Text.Trim());
                string currentStudName = GetStudNameFromDB(); // Replace with your own method to retrieve the current value of "_studname"
                smysqlCmd.Parameters.AddWithValue("_studname", currentStudName);
                smysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                SGridFill();
                Slear();
            }
        }

        void SGridFill()
        {
            using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
            {
                smysqlCon.Open();
                MySqlDataAdapter ssqlDa = new MySqlDataAdapter("StudentView", smysqlCon);
                ssqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable sdtbl = new DataTable();
                ssqlDa.Fill(sdtbl);
                ASview.DataSource = sdtbl;
                ASview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ASview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ASview.Columns[0].HeaderText = "Student ID";
                ASview.Columns[1].Visible = false;
                ASview.Columns[2].Visible = false;
            }

        }

        void Slear()
        {
            Sunametxt.Text = spasstxt.Text = ssearch.Text = "";
            StudentAc = 0;
            ASsave.Text = "Save";
            ASdelete.Enabled = false;
        }

        private void ASdelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
            {
                smysqlCon.Open();
                MySqlCommand smysqlCmd = new MySqlCommand("StudentDelete", smysqlCon);
                smysqlCmd.CommandType = CommandType.StoredProcedure;
                smysqlCmd.Parameters.AddWithValue("_StudentAc", StudentAc);
                smysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                SGridFill();
                Slear();
            }
        }
        
        private void ASsearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
            {
                smysqlCon.Open();
                MySqlDataAdapter ssqlDa = new MySqlDataAdapter(" StudentSearch", smysqlCon);
                ssqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                ssqlDa.SelectCommand.Parameters.AddWithValue("_ StudentSearch", ssearch.Text);
                DataTable sdtbl = new DataTable();
                ssqlDa.Fill(sdtbl);
                ASview.DataSource = sdtbl;
                ASview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ASview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ASview.Columns[0].HeaderText = "Student ID";
                ASview.Columns[1].Visible = false;
                ASview.Columns[2].Visible = false;
            }
        }
       
        private void ASview_DoubleClick(object sender, EventArgs e)
        {
            if (ASview.CurrentRow.Index != -1)
            {
                Sunametxt.Text = ASview.CurrentRow.Cells[1].Value.ToString();
                StudentAc = Convert.ToInt32(ASview.CurrentRow.Cells[0].Value.ToString());
                ASsave.Text = "Update";
                ASdelete.Enabled = true;
            }
        }
     
        private string GetTeacherNameFromDB()
        {
            using (MySqlConnection tmysqlCon = new MySqlConnection(TconnectionString))
            {
                tmysqlCon.Open();
                MySqlCommand tmysqlCmd = new MySqlCommand("SELECT  teachername FROM teacheracc WHERE   TeacherAc = @TeacherAc", tmysqlCon);
                tmysqlCmd.Parameters.AddWithValue("@StudentAc", StudentAc);
                object result = tmysqlCmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return "";
                }
            }
        }

        private void ATsave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection tmysqlCon = new MySqlConnection(TconnectionString))
            {
                tmysqlCon.Open();
                MySqlCommand tmysqlCmd = new MySqlCommand("teacherAddOrUp", tmysqlCon);
                tmysqlCmd.CommandType = CommandType.StoredProcedure;
                tmysqlCmd.Parameters.AddWithValue("_TeacherAc", TeacherAc);
                tmysqlCmd.Parameters.AddWithValue("_teachername", tuname.Text.Trim());
                tmysqlCmd.Parameters.AddWithValue("_teacherpassword", tpass.Text.Trim());
                tmysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                TGridFill();
                TClear();
            }
        }

        void TGridFill()
        {
            using (MySqlConnection tmysqlCon = new MySqlConnection(AconnectionString))
            {
                tmysqlCon.Open();
                MySqlDataAdapter tsqlDa = new MySqlDataAdapter("TeacherView", tmysqlCon);
                tsqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tdtbl = new DataTable();
                tsqlDa.Fill(tdtbl);
                ATview.DataSource = tdtbl;
                ATview.DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleCenter;
                ATview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ATview.Columns[0].HeaderText = "Teacher Id";
                ATview.Columns[1].Visible = false;
                ATview.Columns[2].Visible = false;
            }

        }

        void TClear()
        {
            tuname.Text = tpass.Text = tsearch.Text = "";
            TeacherAc = 0;
            ATsave.Text = "Save";
            ATdelete.Enabled = false;
        }

        private void ATview_DoubleClick(object sender, EventArgs e)
        {
            if (ATview.CurrentRow.Index != -1)
            {
                tuname.Text = ATview.CurrentRow.Cells[1].Value.ToString();
                TeacherAc = Convert.ToInt32(ATview.CurrentRow.Cells[0].Value.ToString());
                ATsave.Text = "Update";
                ATdelete.Enabled = true;
            }
        }

        private void ATsearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection tmysqlCon = new MySqlConnection(TconnectionString))
            {
                tmysqlCon.Open();
                MySqlDataAdapter tsqlDa = new MySqlDataAdapter("TeacherSearch", tmysqlCon);
                tsqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                tsqlDa.SelectCommand.Parameters.AddWithValue("_TeacherSearch", tsearch.Text);
                DataTable adtbl = new DataTable();
                tsqlDa.Fill(adtbl);
                ATview.DataSource = adtbl;
                ATview.Columns[1].Visible = false;
                ATview.Columns[2].Visible = false;
            }
        }

        private void ATdelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection tmysqlCon = new MySqlConnection(TconnectionString))
            {
                tmysqlCon.Open();
                MySqlCommand tmysqlCmd = new MySqlCommand("TeacherDelete", tmysqlCon);
                tmysqlCmd.CommandType = CommandType.StoredProcedure;
                tmysqlCmd.Parameters.AddWithValue("_TeacherAc", TeacherAc);
                tmysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                TGridFill();
                TClear();
            }
        }
    
        private string GetAdNameFromDB()
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
            {
                amysqlCon.Open();
                MySqlCommand amysqlCmd = new MySqlCommand("SELECT name FROM adminacc WHERE AdminAc = @AdminAc", amysqlCon);
                amysqlCmd.Parameters.AddWithValue("@AdminAc", AdminAc);
                object result = amysqlCmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return "";
                }
            }
        }

        private void AAsave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
            {
                amysqlCon.Open();
                MySqlCommand amysqlCmd = new MySqlCommand("adminAddOrUp", amysqlCon);
                amysqlCmd.CommandType = CommandType.StoredProcedure;
                amysqlCmd.Parameters.AddWithValue("_AdminAc", AdminAc);
                amysqlCmd.Parameters.AddWithValue("_uname", auname.Text.Trim());
                amysqlCmd.Parameters.AddWithValue("_pass", apass.Text.Trim());
                string currentAdName = GetAdNameFromDB(); // Replace with your own method to retrieve the current value of "_name"
                amysqlCmd.Parameters.AddWithValue("_name", currentAdName);
                amysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                AGridFill();
                AClear();
            }
        }

        void AGridFill()
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
            {
                amysqlCon.Open();
                MySqlDataAdapter asqlDa = new MySqlDataAdapter("AdminView", amysqlCon);
                asqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable adtbl = new DataTable();
                asqlDa.Fill(adtbl);
                AAview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                AAview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                AAview.DataSource = adtbl;
                AAview.Columns[0].HeaderText = "Admin ID";
                AAview.Columns[1].Visible = false;
                AAview.Columns[2].Visible = false;
               
            }

        }

        void AClear()
        {
            auname.Text = apass.Text = asearch.Text = "";
            AdminAc = 0;
            AAsave.Text = "Save";
            AAdelete.Enabled = false;
        }

        private void AAview_DoubleClick(object sender, EventArgs e)
        {
            if (AAview.CurrentRow.Index != -1)
            {
                auname.Text = AAview.CurrentRow.Cells[1].Value.ToString();
                AdminAc = Convert.ToInt32(AAview.CurrentRow.Cells[0].Value.ToString());
                AAsave.Text = "Update";
                AAdelete.Enabled = true;
            }
        }

       

        private void AAsearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
            {
                amysqlCon.Open();
                MySqlDataAdapter asqlDa = new MySqlDataAdapter("AdminSearch", amysqlCon);
                asqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                asqlDa.SelectCommand.Parameters.AddWithValue("_AdminSearch", asearch.Text);
                DataTable adtbl = new DataTable();
                asqlDa.Fill(adtbl);
                AAview.DataSource = adtbl;
                AAview.Columns[1].Visible = false;
                AAview.Columns[2].Visible = false;
            }
        }

        private void AAdelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
            {
                amysqlCon.Open();
                MySqlCommand amysqlCmd = new MySqlCommand("AdminDelete", amysqlCon);
                amysqlCmd.CommandType = CommandType.StoredProcedure;
                amysqlCmd.Parameters.AddWithValue("_AdminAc", AdminAc);
                amysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                AGridFill();
                AClear();
            }
        }

       
    }
}