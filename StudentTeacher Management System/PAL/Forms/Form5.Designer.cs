﻿
namespace StudentTeacher_Management_System.PAL.Forms
{
    partial class Form5
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
            this.tbsched = new System.Windows.Forms.ComboBox();
            this.tsched = new System.Windows.Forms.Label();
            this.tclassDelete = new System.Windows.Forms.Button();
            this.tclassSave = new System.Windows.Forms.Button();
            this.tbcode = new System.Windows.Forms.TextBox();
            this.tcode = new System.Windows.Forms.Label();
            this.tbunit = new System.Windows.Forms.TextBox();
            this.tunit = new System.Windows.Forms.Label();
            this.tcdesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbclass = new System.Windows.Forms.TextBox();
            this.tclass = new System.Windows.Forms.Label();
            this.tbsub = new System.Windows.Forms.TextBox();
            this.tsub = new System.Windows.Forms.Label();
            this.tclassview = new System.Windows.Forms.DataGridView();
            this.tdclassPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tclassview)).BeginInit();
            this.SuspendLayout();
            // 
            // tbsched
            // 
            this.tbsched.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsched.FormattingEnabled = true;
            this.tbsched.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.tbsched.Location = new System.Drawing.Point(567, 219);
            this.tbsched.Name = "tbsched";
            this.tbsched.Size = new System.Drawing.Size(649, 35);
            this.tbsched.TabIndex = 86;
            // 
            // tsched
            // 
            this.tsched.AutoSize = true;
            this.tsched.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsched.Location = new System.Drawing.Point(462, 224);
            this.tsched.Name = "tsched";
            this.tsched.Size = new System.Drawing.Size(99, 26);
            this.tsched.TabIndex = 85;
            this.tsched.Text = "Schedule:";
            // 
            // tclassDelete
            // 
            this.tclassDelete.BackColor = System.Drawing.Color.White;
            this.tclassDelete.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclassDelete.Location = new System.Drawing.Point(1114, 621);
            this.tclassDelete.Name = "tclassDelete";
            this.tclassDelete.Size = new System.Drawing.Size(102, 36);
            this.tclassDelete.TabIndex = 84;
            this.tclassDelete.Text = "Delete";
            this.tclassDelete.UseVisualStyleBackColor = false;
            this.tclassDelete.Click += new System.EventHandler(this.tclassDelete_Click);
            // 
            // tclassSave
            // 
            this.tclassSave.BackColor = System.Drawing.Color.White;
            this.tclassSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclassSave.Location = new System.Drawing.Point(997, 621);
            this.tclassSave.Name = "tclassSave";
            this.tclassSave.Size = new System.Drawing.Size(102, 36);
            this.tclassSave.TabIndex = 83;
            this.tclassSave.Text = "Save";
            this.tclassSave.UseVisualStyleBackColor = false;
            this.tclassSave.Click += new System.EventHandler(this.tclassSave_Click);
            // 
            // tbcode
            // 
            this.tbcode.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcode.Location = new System.Drawing.Point(913, 131);
            this.tbcode.Name = "tbcode";
            this.tbcode.Size = new System.Drawing.Size(303, 35);
            this.tbcode.TabIndex = 82;
            // 
            // tcode
            // 
            this.tcode.AutoSize = true;
            this.tcode.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcode.Location = new System.Drawing.Point(844, 140);
            this.tcode.Name = "tcode";
            this.tcode.Size = new System.Drawing.Size(63, 26);
            this.tcode.TabIndex = 81;
            this.tcode.Text = "Code:";
            // 
            // tbunit
            // 
            this.tbunit.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbunit.Location = new System.Drawing.Point(567, 131);
            this.tbunit.Name = "tbunit";
            this.tbunit.Size = new System.Drawing.Size(227, 35);
            this.tbunit.TabIndex = 80;
            // 
            // tunit
            // 
            this.tunit.AutoSize = true;
            this.tunit.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tunit.Location = new System.Drawing.Point(462, 140);
            this.tunit.Name = "tunit";
            this.tunit.Size = new System.Drawing.Size(64, 26);
            this.tunit.TabIndex = 79;
            this.tunit.Text = "Units:";
            // 
            // tcdesc
            // 
            this.tcdesc.BackColor = System.Drawing.SystemColors.Window;
            this.tcdesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tcdesc.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcdesc.Location = new System.Drawing.Point(467, 296);
            this.tcdesc.Name = "tcdesc";
            this.tcdesc.Size = new System.Drawing.Size(749, 319);
            this.tcdesc.TabIndex = 78;
            this.tcdesc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 77;
            this.label2.Text = "Course Description:";
            // 
            // tbclass
            // 
            this.tbclass.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbclass.Location = new System.Drawing.Point(567, 178);
            this.tbclass.Name = "tbclass";
            this.tbclass.Size = new System.Drawing.Size(649, 35);
            this.tbclass.TabIndex = 76;
            // 
            // tclass
            // 
            this.tclass.AutoSize = true;
            this.tclass.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclass.Location = new System.Drawing.Point(463, 187);
            this.tclass.Name = "tclass";
            this.tclass.Size = new System.Drawing.Size(63, 26);
            this.tclass.TabIndex = 75;
            this.tclass.Text = "Class:";
            // 
            // tbsub
            // 
            this.tbsub.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsub.Location = new System.Drawing.Point(567, 90);
            this.tbsub.Name = "tbsub";
            this.tbsub.Size = new System.Drawing.Size(649, 35);
            this.tbsub.TabIndex = 74;
            // 
            // tsub
            // 
            this.tsub.AutoSize = true;
            this.tsub.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsub.Location = new System.Drawing.Point(463, 95);
            this.tsub.Name = "tsub";
            this.tsub.Size = new System.Drawing.Size(83, 26);
            this.tsub.TabIndex = 73;
            this.tsub.Text = "Subject:";
            // 
            // tclassview
            // 
            this.tclassview.AllowUserToOrderColumns = true;
            this.tclassview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tclassview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tclassview.Location = new System.Drawing.Point(16, 39);
            this.tclassview.Name = "tclassview";
            this.tclassview.ReadOnly = true;
            this.tclassview.RowHeadersWidth = 51;
            this.tclassview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tclassview.RowTemplate.Height = 24;
            this.tclassview.Size = new System.Drawing.Size(411, 618);
            this.tclassview.TabIndex = 72;
            this.tclassview.DoubleClick += new System.EventHandler(this.tclassview_DoubleClick);
            // 
            // tdclassPanel
            // 
            this.tdclassPanel.BackColor = System.Drawing.Color.White;
            this.tdclassPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tdclassPanel.Location = new System.Drawing.Point(1256, 39);
            this.tdclassPanel.Name = "tdclassPanel";
            this.tdclassPanel.Size = new System.Drawing.Size(200, 618);
            this.tdclassPanel.TabIndex = 71;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 697);
            this.Controls.Add(this.tbsched);
            this.Controls.Add(this.tsched);
            this.Controls.Add(this.tclassDelete);
            this.Controls.Add(this.tclassSave);
            this.Controls.Add(this.tbcode);
            this.Controls.Add(this.tcode);
            this.Controls.Add(this.tbunit);
            this.Controls.Add(this.tunit);
            this.Controls.Add(this.tcdesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbclass);
            this.Controls.Add(this.tclass);
            this.Controls.Add(this.tbsub);
            this.Controls.Add(this.tsub);
            this.Controls.Add(this.tclassview);
            this.Controls.Add(this.tdclassPanel);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tclassview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tbsched;
        private System.Windows.Forms.Label tsched;
        private System.Windows.Forms.Button tclassDelete;
        private System.Windows.Forms.Button tclassSave;
        private System.Windows.Forms.TextBox tbcode;
        private System.Windows.Forms.Label tcode;
        private System.Windows.Forms.TextBox tbunit;
        private System.Windows.Forms.Label tunit;
        private System.Windows.Forms.RichTextBox tcdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbclass;
        private System.Windows.Forms.Label tclass;
        private System.Windows.Forms.TextBox tbsub;
        private System.Windows.Forms.Label tsub;
        private System.Windows.Forms.DataGridView tclassview;
        private System.Windows.Forms.Panel tdclassPanel;
    }
}