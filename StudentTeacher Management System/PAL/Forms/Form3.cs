using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentTeacher_Management_System.PAL.Forms
{
    public partial class Form3 : Form
    {
        private MySqlConnection connection;
        private const string connectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd=karmakun_2002";
        string CconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int idclass = 0;
        public Form3()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string subject = subtxt.Text;
            string schedule = cmbDay.Text;
            string section = sectxt.Text;
            string timeRange = timetxt.Text;

            // Save the data to the database
            SaveData(subject, schedule, section, timeRange);

            // Create a panel to display the data
            Panel panel = CreatePanel(subject, timeRange);

            // Add the panel to the appropriate column
            int columnIndex = GetColumnIndex(schedule); // Pass the day of the week
            AddPanelToColumn(panel, columnIndex);
        }

        private void SaveData(string subject, string day, string section, string timeRange)
        {
            // Create the SQL command to insert the data into the database
            using (MySqlConnection cmysqlCon = new MySqlConnection(CconnectionString))
            {
                cmysqlCon.Open();
                MySqlCommand command = new MySqlCommand("classAddOrEdit", cmysqlCon);
                command.Parameters.AddWithValue("_idclass", idclass);
                command.Parameters.AddWithValue("_subject", subtxt.Text.Trim());
                command.Parameters.AddWithValue("_unit", "");
                command.Parameters.AddWithValue("_code", "");
                command.Parameters.AddWithValue("_schedule", Schedule);
                command.Parameters.AddWithValue("_section", section);
                command.Parameters.AddWithValue("_description", "");


                // Execute the command
                command.ExecuteNonQuery();
                cmysqlCon.Close();
            }
        }
            private Panel CreatePanel(string subject, string timeRange)
            {
                Panel panel = new Panel();
                panel.BackColor = GetColorForTimeRange(timeRange);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

                // Set the height of the panel based on the time range duration
                int panelHeight = CalculatePanelHeight(timeRange);
                panel.Height = panelHeight;

                Label label = new Label();
                label.Text = subject;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(label);

                return panel;
            }

            private int CalculatePanelHeight(string timeRange)
            {
                // Parse the start and end times from the time range
                string[] times = timeRange.Split('-');

                // Check if the time range has two valid time values
                if (times.Length != 2)
                {
                    // Return a default height for invalid time ranges
                    return 30;
                }

                string startTime = times[0].Trim();
                string endTime = times[1].Trim();

                // Create DateTime objects to store the parsed times
                DateTime startDateTime;
                DateTime endDateTime;

                // Try to parse the start and end times
                if (!DateTime.TryParseExact(startTime, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDateTime) ||
                    !DateTime.TryParseExact(endTime, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDateTime))
                {
                    // Return a default height for invalid time formats
                    return 30;
                }

                // Calculate the duration of the time range in minutes
                TimeSpan duration = endDateTime - startDateTime;
                int durationMinutes = (int)duration.TotalMinutes;

                // Calculate the panel height based on the duration
                int panelHeight = durationMinutes * 2;

                return panelHeight;
            }

            private Color GetColorForTimeRange(string timeRange)
            {
                // Parse the start and end times from the time range
                string[] times = timeRange.Split('-');

                // Check if the time range has two valid time values
                if (times.Length != 2)
                {
                    // Return a default color for invalid time ranges
                    return Color.Gray;
                }

                string startTime = times[0].Trim();
                string endTime = times[1].Trim();

                // Create DateTime objects to store the parsed times
                DateTime startDateTime;
                DateTime endDateTime;

                // Try to parse the start and end times
                if (!DateTime.TryParseExact(startTime, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDateTime) ||
                    !DateTime.TryParseExact(endTime, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDateTime))
                {
                    // Return a default color for invalid time formats
                    return Color.Gray;
                }

                // Create DateTime objects representing 7 am and 5 pm
                DateTime morningStartTime = DateTime.Today.AddHours(7);
                DateTime eveningEndTime = DateTime.Today.AddHours(17);

                // Check if the time range falls between 7 am and 5 pm
                if (startDateTime >= morningStartTime && endDateTime <= eveningEndTime)
                {
                    // Determine the color based on the time range
                    if (startDateTime.Minute == 0 && endDateTime.Minute == 30)
                        return Color.Green;
                    else if (startDateTime.Minute == 30 && endDateTime.Minute == 0)
                        return Color.Blue;
                    else
                        return Color.Yellow;
                }
                else
                {
                    // Return a different color for time ranges outside the 7 am - 5 pm range
                    return Color.Gray;
                }
            }


            private void AddPanelToColumn(Panel panel, int columnIndex)
            {
                // Get the corresponding column panel
                Panel columnPanel = GetColumnPanel(columnIndex);

                // Add the panel to the column panel
                columnPanel.Controls.Add(panel);

                // Set the width of the panel based on the column width
                int columnWidth = columnPanel.Width;
                panel.Width = columnWidth;
            }

            private Panel GetColumnPanel(int columnIndex)
            {
                // Implement your logic to get the corresponding column panel based on the columnIndex
                // For example:
                switch (columnIndex)
                {
                    case 0:
                        return MonPanel;
                    case 1:
                        return TuesPanel;
                    case 2:
                        return WedPanel;
                    case 3:
                        return ThurPanel;
                    case 4:
                        return FriPanel;
                    case 5:
                        return SatPanel;
                    case 6:
                        return SunPanel;
                    default:
                        throw new ArgumentException("Invalid column index");
                }
            }

            private int GetColumnIndex(string day)
            {
                // Implement your logic to determine the column index based on the day of the week
                // For example:
                switch (day.ToLower())
                {
                    case "monday":
                        return 0;
                    case "tuesday":
                        return 1;
                    case "wednesday":
                        return 2;
                    case "thursday":
                        return 3;
                    case "friday":
                        return 4;
                    case "saturday":
                        return 5;
                    case "sunday":
                        return 6;
                    default:
                        throw new ArgumentException("Invalid day");
                }
            }

            private void Form3_Load(object sender, EventArgs e)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
        }
    }
