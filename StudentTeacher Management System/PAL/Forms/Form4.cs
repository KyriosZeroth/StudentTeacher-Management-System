using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;



namespace StudentTeacher_Management_System.PAL.Forms
{
    public partial class MainForm : Form
    {
        private Dictionary<string, DataGridView> dataGridViews; // Dictionary to store DataGridView controls for each day
        private Dictionary<string, List<string[]>> schedules; // Dictionary to store schedules for each day
        private MySqlConnection connection;
        private const string connectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";

        public MainForm()
        {
            InitializeComponent();
            dataGridViews = new Dictionary<string, DataGridView>
            {
                { "Monday", mondayDataGridView },
                { "Tuesday", tuesdayDataGridView },
                { "Wednesday", wednesdayDataGridView },
                { "Thursday", thursdayDataGridView },
                { "Friday", fridayDataGridView },
                { "Saturday", saturdayDataGridView },
                { "Sunday", sundayDataGridView }
            };
            schedules = new Dictionary<string, List<string[]>>();

            // Define columns for the DataGridView controls
            foreach (var dataGridView in dataGridViews.Values)
            {
                dataGridView.Columns.Add("SubjectNameColumn", "Subject Name");
                dataGridView.Columns.Add("RoomColumn", "Room");
                dataGridView.Columns.Add("StartTimeColumn", "Start Time");
                dataGridView.Columns.Add("EndTimeColumn", "End Time");
            }

            // Initialize the connection to the MySQL database
            connection = new MySqlConnection(connectionString);

            LoadDataFromDatabase();

            // Show the Monday schedule by default
            ShowDataGridView("Monday");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string subjectName = subjectTextBox.Text;
            string room = roomTextBox.Text;
            string day = dayComboBox.SelectedItem.ToString();
            string startTime = startTimeMaskedTextBox.Text;
            string endTime = endTimeMaskedTextBox.Text;

            if (IsScheduleOverlapping(day, startTime, endTime))
            {
                MessageBox.Show("The schedule overlaps with an existing schedule. Please select a different time slot.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the schedule to the database
            SaveScheduleToDatabase(subjectName, room, day, startTime, endTime);

            // Add the schedule to the local dictionary
            if (!schedules.ContainsKey(day))
            {
                schedules[day] = new List<string[]>();
            }

            schedules[day].Add(new string[] { subjectName, room, startTime, endTime });

            // Sort the schedules list by start time
            schedules[day] = schedules[day].OrderBy(s => TimeSpan.Parse(s[2])).ToList();

            // Update the DataGridView
            UpdateDataGridView(day);

            ClearFields();
        }

        private bool IsScheduleOverlapping(string day, string startTime, string endTime)
        {
            if (schedules.ContainsKey(day))
            {
                foreach (var schedule in schedules[day])
                {
                    TimeSpan subjectStartTime = TimeSpan.Parse(schedule[2]);
                    TimeSpan subjectEndTime = TimeSpan.Parse(schedule[3]);
                    TimeSpan newStartTime = TimeSpan.Parse(startTime);
                    TimeSpan newEndTime = TimeSpan.Parse(endTime);

                    if ((newStartTime >= subjectStartTime && newStartTime < subjectEndTime) ||
                        (newEndTime > subjectStartTime && newEndTime <= subjectEndTime) ||
                        (newStartTime <= subjectStartTime && newEndTime >= subjectEndTime))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void UpdateDataGridView(string day)
        {
            var dataGridView = dataGridViews[day];
            dataGridView.Rows.Clear();

            if (schedules.ContainsKey(day))
            {
                foreach (var schedule in schedules[day])
                {
                    dataGridView.Rows.Add(schedule[0], schedule[1], schedule[2], schedule[3]);
                }
            }
        }

        private void ClearFields()
        {
            subjectTextBox.Text = "";
            roomTextBox.Text = "";
            dayComboBox.SelectedIndex = -1;
            startTimeMaskedTextBox.Text = "";
            endTimeMaskedTextBox.Text = "";
        }

        private void ShowDataGridView(string day)
        {
            // Show the selected DataGridView and hide others
            foreach (var dataGridView in dataGridViews.Values)
            {
                dataGridView.Visible = dataGridView == dataGridViews[day];
            }

            // Show the selected day label and hide others
            foreach (var label in new Label[] { monday, tuesday, wednesday, thursday, friday, Saturday, Sunday })
            {
                label.Visible = label.Name.ToLower() == day.ToLower();
            }
        }

        private void LoadDataFromDatabase()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM adminacc";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string subjectName = reader.GetString("subject");
                    string room = reader.GetString("room");
                    string day = reader.GetString("day");
                    string startTime = reader.GetString("startTime");
                    string endTime = reader.GetString("endTime");

                    if (!schedules.ContainsKey(day))
                    {
                        schedules[day] = new List<string[]>();
                    }

                    schedules[day].Add(new string[] { subjectName, room, startTime, endTime });
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error11: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void SaveScheduleToDatabase(string subjectName, string room, string day, string startTime, string endTime)
        {
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("classAddorEdit", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("_idclass", 0); // 0 indicates new schedule
                command.Parameters.AddWithValue("_subject", subjectName);
                command.Parameters.AddWithValue("_code", ""); // Assuming code and section are not used in this context
                command.Parameters.AddWithValue("_section", "");
                command.Parameters.AddWithValue("_schedule", day);
                command.Parameters.AddWithValue("_description", ""); // Assuming description is not used in this context
                command.Parameters.AddWithValue("_unit", 0); // Assuming units are not used in this context

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void mondayButton_Click(object sender, EventArgs e)
        {
            ShowDataGridView("Monday");
        }

        private void tuesdayButton_Click(object sender, EventArgs e)
        {
            ShowDataGridView("Tuesday");
        }

        private void wednesdayButton_Click(object sender, EventArgs e)
        {
            ShowDataGridView("Wednesday");
        }

        private void thursdayButton_Click(object sender, EventArgs e)
        {
            ShowDataGridView("Thursday");
        }

        private void fridayButton_Click(object sender, EventArgs e)
        {
            ShowDataGridView("Friday");
        }

        private void saturdayButton_Click(object sender, EventArgs e)
        {
            ShowDataGridView("Saturday");
        }

        private void sundayButton_Click(object sender, EventArgs e)
        {
            ShowDataGridView("Sunday");
        }
    }
}