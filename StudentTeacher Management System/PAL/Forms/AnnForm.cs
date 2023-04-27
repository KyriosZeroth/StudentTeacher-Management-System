using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentTeacher_Management_System.PAL.Forms
{
    public partial class AnnForm : UserControl
    {
        public AnnForm()
        {
            InitializeComponent();
            // Call this function to load the announcements from the database
            LoadAnnouncements();
        }

        string AnconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int AnID = 0;
        List<string> announcementsList = new List<string>();

        private void postbttn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection anmysqlCon = new MySqlConnection(AnconnectionString))
            {
                anmysqlCon.Open();
                MySqlCommand anmysqlCmd = new MySqlCommand("AnAddorEdit", anmysqlCon);
                anmysqlCmd.CommandType = CommandType.StoredProcedure;
                anmysqlCmd.Parameters.AddWithValue("_AnID", AnID);
                anmysqlCmd.Parameters.AddWithValue("_announcement", Postrtb.Text.Trim());
                anmysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Posted Successfully");

                AnClear();

                // Reload the announcements from the database and display them in the panel
                LoadAnnouncements();
            }

        }

        void AnClear()
        {
            Postrtb.Text = "";
            AnID = 0;
            postbttn.Text = "POST";
        }

        void LoadAnnouncements()
        {
            using (MySqlConnection anmysqlCon = new MySqlConnection(AnconnectionString))
            {
                anmysqlCon.Open();

                // Clear the existing announcements from the panel and the list
                AnnPanel1.Controls.Clear();
                announcementsList.Clear();

                // Retrieve all the announcements from the database
                string query = "SELECT AnID, Announcement FROM announcement";
                MySqlCommand cmd = new MySqlCommand(query, anmysqlCon);
                MySqlDataReader reader = cmd.ExecuteReader();

                int top = 0;
                int tabIndex = 1;
                while (reader.Read())
                {
                    // Add each announcement to the list
                    announcementsList.Add(reader.GetString("Announcement"));

                    // Create a new label for each announcement and add it to the panel
                    Label lbl = new Label();
                    lbl.Top = top;
                    lbl.Left = 0;
                    lbl.Width = AnnPanel1.Width;
                    lbl.ForeColor = Color.Black;
                    lbl.BackColor = Color.LightGray;
                    lbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
                    lbl.Text = announcementsList[announcementsList.Count - 1];
                    lbl.Margin = new Padding(0, 10, 0, 0); // Add margin to separate the labels
                    lbl.AutoSize = false; // Disable auto-sizing to enable paragraph formatting
                    lbl.TextAlign = ContentAlignment.TopLeft; // Set the text alignment to top-left
                    lbl.Height = TextRenderer.MeasureText(lbl.Text, lbl.Font, new Size(lbl.Width, 0), TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl).Height; // Set the label height based on the text content
                    lbl.TabIndex = tabIndex++; // Set the tab index to make the label selectable
                    lbl.Click += Label_Click; // Attach the Click event handler to make the label focused
                    AnnPanel1.Controls.Add(lbl);

                    // Increase the top position for the next label
                    top += lbl.Height + 10;
                }

                // Resize the panel and update the scrollable area
                AnnPanel1.AutoScrollMinSize = new Size(0, top);
            }
        }


        private void Label_Click(object sender, EventArgs e)
        {
            foreach (Label label in AnnPanel1.Controls.OfType<Label>())
            {
                label.BackColor = Color.LightGray; // Set the background color of all labels to LightGray
            }
            Label clickedLabel = (Label)sender;
            clickedLabel.BackColor = Color.WhiteSmoke; // Set the background color of the clicked label to WhiteSmoke
        }

        private void delbttn_Click(object sender, EventArgs e)
        {
            if (AnnPanel1.Controls.Count == 0)
            {
                MessageBox.Show("There are no announcements to delete");
                return;
            }

            // Get the selected label
            Label selectedLabel = AnnPanel1.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.BackColor == Color.WhiteSmoke);

            // Check if a label was selected
            if (selectedLabel == null)
            {
                MessageBox.Show("Please select a label to delete");
                return;
            }

            // Show confirmation dialog before deleting the announcement
            DialogResult result = MessageBox.Show("Are you sure you want to delete this announcement?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Get the ID of the announcement to delete
                int AnID = announcementsList.IndexOf(selectedLabel.Text) + 1;

                // Remove the announcement from the database
                using (MySqlConnection anmysqlCon = new MySqlConnection(AnconnectionString))
                {
                    anmysqlCon.Open();
                    MySqlCommand anmysqlCmd = new MySqlCommand("AnDelete", anmysqlCon);
                    anmysqlCmd.CommandType = CommandType.StoredProcedure;
                    anmysqlCmd.Parameters.AddWithValue("_AnID", AnID);
                    anmysqlCmd.ExecuteNonQuery();
                }

                // Remove the label from the panel and the announcements list
                AnnPanel1.Controls.Remove(selectedLabel);
                announcementsList.RemoveAt(AnID - 1);

                // Re-position the remaining labels
                int top = 0;
                foreach (Control control in AnnPanel1.Controls)
                {
                    control.Top = top;
                    top += control.Height + 10;
                }

                // Resize the panel and update the scrollable area
                AnnPanel1.AutoScrollMinSize = new Size(0, top);
            }

        }
    }
}
