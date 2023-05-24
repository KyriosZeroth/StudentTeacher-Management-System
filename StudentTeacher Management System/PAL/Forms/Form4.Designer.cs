
namespace StudentTeacher_Management_System.PAL.Forms
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mondayDataGridView = new System.Windows.Forms.DataGridView();
            this.startTimeMaskedTextBox = new System.Windows.Forms.TextBox();
            this.endTimeMaskedTextBox = new System.Windows.Forms.TextBox();
            this.tuesdayDataGridView = new System.Windows.Forms.DataGridView();
            this.wednesdayDataGridView = new System.Windows.Forms.DataGridView();
            this.thursdayDataGridView = new System.Windows.Forms.DataGridView();
            this.fridayDataGridView = new System.Windows.Forms.DataGridView();
            this.saturdayDataGridView = new System.Windows.Forms.DataGridView();
            this.sundayDataGridView = new System.Windows.Forms.DataGridView();
            this.monday = new System.Windows.Forms.Label();
            this.tuesday = new System.Windows.Forms.Label();
            this.wednesday = new System.Windows.Forms.Label();
            this.thursday = new System.Windows.Forms.Label();
            this.friday = new System.Windows.Forms.Label();
            this.Saturday = new System.Windows.Forms.Label();
            this.Sunday = new System.Windows.Forms.Label();
            this.mondayButton = new System.Windows.Forms.Button();
            this.tuesdayButton = new System.Windows.Forms.Button();
            this.wednesdayButton = new System.Windows.Forms.Button();
            this.saturdayButton = new System.Windows.Forms.Button();
            this.fridayButton = new System.Windows.Forms.Button();
            this.thursdayButton = new System.Windows.Forms.Button();
            this.sundayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mondayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuesdayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wednesdayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thursdayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fridayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturdayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sundayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Time";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(121, 53);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(100, 22);
            this.subjectTextBox.TabIndex = 5;
            // 
            // roomTextBox
            // 
            this.roomTextBox.Location = new System.Drawing.Point(121, 100);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(100, 22);
            this.roomTextBox.TabIndex = 6;
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.dayComboBox.Location = new System.Drawing.Point(121, 142);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(100, 24);
            this.dayComboBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // mondayDataGridView
            // 
            this.mondayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mondayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mondayDataGridView.Location = new System.Drawing.Point(270, 73);
            this.mondayDataGridView.Name = "mondayDataGridView";
            this.mondayDataGridView.RowHeadersWidth = 51;
            this.mondayDataGridView.RowTemplate.Height = 24;
            this.mondayDataGridView.Size = new System.Drawing.Size(833, 611);
            this.mondayDataGridView.TabIndex = 24;
            // 
            // startTimeMaskedTextBox
            // 
            this.startTimeMaskedTextBox.Location = new System.Drawing.Point(123, 179);
            this.startTimeMaskedTextBox.Name = "startTimeMaskedTextBox";
            this.startTimeMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.startTimeMaskedTextBox.TabIndex = 25;
            // 
            // endTimeMaskedTextBox
            // 
            this.endTimeMaskedTextBox.Location = new System.Drawing.Point(123, 221);
            this.endTimeMaskedTextBox.Name = "endTimeMaskedTextBox";
            this.endTimeMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.endTimeMaskedTextBox.TabIndex = 26;
            // 
            // tuesdayDataGridView
            // 
            this.tuesdayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tuesdayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tuesdayDataGridView.Location = new System.Drawing.Point(270, 73);
            this.tuesdayDataGridView.Name = "tuesdayDataGridView";
            this.tuesdayDataGridView.RowHeadersWidth = 51;
            this.tuesdayDataGridView.RowTemplate.Height = 24;
            this.tuesdayDataGridView.Size = new System.Drawing.Size(833, 611);
            this.tuesdayDataGridView.TabIndex = 27;
            // 
            // wednesdayDataGridView
            // 
            this.wednesdayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.wednesdayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wednesdayDataGridView.Location = new System.Drawing.Point(270, 73);
            this.wednesdayDataGridView.Name = "wednesdayDataGridView";
            this.wednesdayDataGridView.RowHeadersWidth = 51;
            this.wednesdayDataGridView.RowTemplate.Height = 24;
            this.wednesdayDataGridView.Size = new System.Drawing.Size(833, 611);
            this.wednesdayDataGridView.TabIndex = 28;
            // 
            // thursdayDataGridView
            // 
            this.thursdayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.thursdayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thursdayDataGridView.Location = new System.Drawing.Point(270, 73);
            this.thursdayDataGridView.Name = "thursdayDataGridView";
            this.thursdayDataGridView.RowHeadersWidth = 51;
            this.thursdayDataGridView.RowTemplate.Height = 24;
            this.thursdayDataGridView.Size = new System.Drawing.Size(833, 611);
            this.thursdayDataGridView.TabIndex = 29;
            // 
            // fridayDataGridView
            // 
            this.fridayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fridayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fridayDataGridView.Location = new System.Drawing.Point(270, 73);
            this.fridayDataGridView.Name = "fridayDataGridView";
            this.fridayDataGridView.RowHeadersWidth = 51;
            this.fridayDataGridView.RowTemplate.Height = 24;
            this.fridayDataGridView.Size = new System.Drawing.Size(833, 611);
            this.fridayDataGridView.TabIndex = 30;
            // 
            // saturdayDataGridView
            // 
            this.saturdayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saturdayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saturdayDataGridView.Location = new System.Drawing.Point(270, 73);
            this.saturdayDataGridView.Name = "saturdayDataGridView";
            this.saturdayDataGridView.RowHeadersWidth = 51;
            this.saturdayDataGridView.RowTemplate.Height = 24;
            this.saturdayDataGridView.Size = new System.Drawing.Size(833, 611);
            this.saturdayDataGridView.TabIndex = 31;
            // 
            // sundayDataGridView
            // 
            this.sundayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sundayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sundayDataGridView.Location = new System.Drawing.Point(270, 73);
            this.sundayDataGridView.Name = "sundayDataGridView";
            this.sundayDataGridView.RowHeadersWidth = 51;
            this.sundayDataGridView.RowTemplate.Height = 24;
            this.sundayDataGridView.Size = new System.Drawing.Size(833, 611);
            this.sundayDataGridView.TabIndex = 32;
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.Location = new System.Drawing.Point(625, 37);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(68, 17);
            this.monday.TabIndex = 33;
            this.monday.Text = "MONDAY";
            // 
            // tuesday
            // 
            this.tuesday.AutoSize = true;
            this.tuesday.Location = new System.Drawing.Point(620, 37);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(73, 17);
            this.tuesday.TabIndex = 34;
            this.tuesday.Text = "TUESDAY";
            // 
            // wednesday
            // 
            this.wednesday.AutoSize = true;
            this.wednesday.Location = new System.Drawing.Point(597, 37);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(96, 17);
            this.wednesday.TabIndex = 35;
            this.wednesday.Text = "WEDNESDAY";
            // 
            // thursday
            // 
            this.thursday.AutoSize = true;
            this.thursday.Location = new System.Drawing.Point(597, 37);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(84, 17);
            this.thursday.TabIndex = 36;
            this.thursday.Text = "THURSDAY";
            // 
            // friday
            // 
            this.friday.AutoSize = true;
            this.friday.Location = new System.Drawing.Point(620, 37);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(57, 17);
            this.friday.TabIndex = 37;
            this.friday.Text = "FRIDAY";
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Location = new System.Drawing.Point(610, 37);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(83, 17);
            this.Saturday.TabIndex = 38;
            this.Saturday.Text = "SATURDAY";
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Location = new System.Drawing.Point(616, 37);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(65, 17);
            this.Sunday.TabIndex = 39;
            this.Sunday.Text = "SUNDAY";
            // 
            // mondayButton
            // 
            this.mondayButton.Location = new System.Drawing.Point(42, 379);
            this.mondayButton.Name = "mondayButton";
            this.mondayButton.Size = new System.Drawing.Size(75, 23);
            this.mondayButton.TabIndex = 40;
            this.mondayButton.Text = "button2";
            this.mondayButton.UseVisualStyleBackColor = true;
            this.mondayButton.Click += new System.EventHandler(this.mondayButton_Click);
            // 
            // tuesdayButton
            // 
            this.tuesdayButton.Location = new System.Drawing.Point(42, 421);
            this.tuesdayButton.Name = "tuesdayButton";
            this.tuesdayButton.Size = new System.Drawing.Size(75, 23);
            this.tuesdayButton.TabIndex = 41;
            this.tuesdayButton.Text = "button3";
            this.tuesdayButton.UseVisualStyleBackColor = true;
            this.tuesdayButton.Click += new System.EventHandler(this.tuesdayButton_Click);
            // 
            // wednesdayButton
            // 
            this.wednesdayButton.Location = new System.Drawing.Point(42, 457);
            this.wednesdayButton.Name = "wednesdayButton";
            this.wednesdayButton.Size = new System.Drawing.Size(75, 23);
            this.wednesdayButton.TabIndex = 42;
            this.wednesdayButton.Text = "button4";
            this.wednesdayButton.UseVisualStyleBackColor = true;
            this.wednesdayButton.Click += new System.EventHandler(this.wednesdayButton_Click);
            // 
            // saturdayButton
            // 
            this.saturdayButton.Location = new System.Drawing.Point(47, 579);
            this.saturdayButton.Name = "saturdayButton";
            this.saturdayButton.Size = new System.Drawing.Size(75, 23);
            this.saturdayButton.TabIndex = 45;
            this.saturdayButton.Text = "button5";
            this.saturdayButton.UseVisualStyleBackColor = true;
            this.saturdayButton.Click += new System.EventHandler(this.saturdayButton_Click);
            // 
            // fridayButton
            // 
            this.fridayButton.Location = new System.Drawing.Point(47, 543);
            this.fridayButton.Name = "fridayButton";
            this.fridayButton.Size = new System.Drawing.Size(75, 23);
            this.fridayButton.TabIndex = 44;
            this.fridayButton.Text = "button6";
            this.fridayButton.UseVisualStyleBackColor = true;
            this.fridayButton.Click += new System.EventHandler(this.fridayButton_Click);
            // 
            // thursdayButton
            // 
            this.thursdayButton.Location = new System.Drawing.Point(47, 501);
            this.thursdayButton.Name = "thursdayButton";
            this.thursdayButton.Size = new System.Drawing.Size(75, 23);
            this.thursdayButton.TabIndex = 43;
            this.thursdayButton.Text = "button7";
            this.thursdayButton.UseVisualStyleBackColor = true;
            this.thursdayButton.Click += new System.EventHandler(this.thursdayButton_Click);
            // 
            // sundayButton
            // 
            this.sundayButton.Location = new System.Drawing.Point(47, 622);
            this.sundayButton.Name = "sundayButton";
            this.sundayButton.Size = new System.Drawing.Size(75, 23);
            this.sundayButton.TabIndex = 46;
            this.sundayButton.Text = "button8";
            this.sundayButton.UseVisualStyleBackColor = true;
            this.sundayButton.Click += new System.EventHandler(this.sundayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 713);
            this.Controls.Add(this.sundayButton);
            this.Controls.Add(this.saturdayButton);
            this.Controls.Add(this.fridayButton);
            this.Controls.Add(this.thursdayButton);
            this.Controls.Add(this.wednesdayButton);
            this.Controls.Add(this.tuesdayButton);
            this.Controls.Add(this.mondayButton);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.friday);
            this.Controls.Add(this.thursday);
            this.Controls.Add(this.wednesday);
            this.Controls.Add(this.tuesday);
            this.Controls.Add(this.monday);
            this.Controls.Add(this.sundayDataGridView);
            this.Controls.Add(this.saturdayDataGridView);
            this.Controls.Add(this.fridayDataGridView);
            this.Controls.Add(this.thursdayDataGridView);
            this.Controls.Add(this.wednesdayDataGridView);
            this.Controls.Add(this.tuesdayDataGridView);
            this.Controls.Add(this.endTimeMaskedTextBox);
            this.Controls.Add(this.startTimeMaskedTextBox);
            this.Controls.Add(this.mondayDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "TUESDAY";
            ((System.ComponentModel.ISupportInitialize)(this.mondayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuesdayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wednesdayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thursdayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fridayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturdayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sundayDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView mondayDataGridView;
        private System.Windows.Forms.TextBox startTimeMaskedTextBox;
        private System.Windows.Forms.TextBox endTimeMaskedTextBox;
        private System.Windows.Forms.DataGridView tuesdayDataGridView;
        private System.Windows.Forms.DataGridView wednesdayDataGridView;
        private System.Windows.Forms.DataGridView thursdayDataGridView;
        private System.Windows.Forms.DataGridView fridayDataGridView;
        private System.Windows.Forms.DataGridView saturdayDataGridView;
        private System.Windows.Forms.DataGridView sundayDataGridView;
        private System.Windows.Forms.Label monday;
        private System.Windows.Forms.Label tuesday;
        private System.Windows.Forms.Label wednesday;
        private System.Windows.Forms.Label thursday;
        private System.Windows.Forms.Label friday;
        private System.Windows.Forms.Label Saturday;
        private System.Windows.Forms.Label Sunday;
        private System.Windows.Forms.Button mondayButton;
        private System.Windows.Forms.Button tuesdayButton;
        private System.Windows.Forms.Button wednesdayButton;
        private System.Windows.Forms.Button saturdayButton;
        private System.Windows.Forms.Button fridayButton;
        private System.Windows.Forms.Button thursdayButton;
        private System.Windows.Forms.Button sundayButton;
    }
}