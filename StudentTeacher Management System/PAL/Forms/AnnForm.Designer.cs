
namespace StudentTeacher_Management_System.PAL.Forms
{
    partial class AnnForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnnPanel = new System.Windows.Forms.Panel();
            this.delbttn = new System.Windows.Forms.Button();
            this.AnnPanel1 = new System.Windows.Forms.Panel();
            this.postbttn = new System.Windows.Forms.Button();
            this.Postrtb = new System.Windows.Forms.RichTextBox();
            this.AnnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnnPanel
            // 
            this.AnnPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AnnPanel.Controls.Add(this.delbttn);
            this.AnnPanel.Controls.Add(this.AnnPanel1);
            this.AnnPanel.Controls.Add(this.postbttn);
            this.AnnPanel.Controls.Add(this.Postrtb);
            this.AnnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnnPanel.Location = new System.Drawing.Point(0, 0);
            this.AnnPanel.Name = "AnnPanel";
            this.AnnPanel.Size = new System.Drawing.Size(1324, 612);
            this.AnnPanel.TabIndex = 33;
            // 
            // delbttn
            // 
            this.delbttn.Location = new System.Drawing.Point(1094, 557);
            this.delbttn.Name = "delbttn";
            this.delbttn.Size = new System.Drawing.Size(171, 40);
            this.delbttn.TabIndex = 5;
            this.delbttn.Text = "DELETE";
            this.delbttn.UseVisualStyleBackColor = true;
            this.delbttn.Click += new System.EventHandler(this.delbttn_Click);
            // 
            // AnnPanel1
            // 
            this.AnnPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AnnPanel1.Location = new System.Drawing.Point(36, 132);
            this.AnnPanel1.Name = "AnnPanel1";
            this.AnnPanel1.Size = new System.Drawing.Size(1256, 419);
            this.AnnPanel1.TabIndex = 4;
            // 
            // postbttn
            // 
            this.postbttn.Location = new System.Drawing.Point(917, 557);
            this.postbttn.Name = "postbttn";
            this.postbttn.Size = new System.Drawing.Size(171, 40);
            this.postbttn.TabIndex = 2;
            this.postbttn.Text = "POST";
            this.postbttn.UseVisualStyleBackColor = true;
            this.postbttn.Click += new System.EventHandler(this.postbttn_Click);
            // 
            // Postrtb
            // 
            this.Postrtb.Location = new System.Drawing.Point(32, 30);
            this.Postrtb.Name = "Postrtb";
            this.Postrtb.Size = new System.Drawing.Size(1260, 74);
            this.Postrtb.TabIndex = 0;
            this.Postrtb.Text = "";
            // 
            // AnnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AnnPanel);
            this.Name = "AnnForm";
            this.Size = new System.Drawing.Size(1324, 612);
            this.AnnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AnnPanel;
        private System.Windows.Forms.Panel AnnPanel1;
        private System.Windows.Forms.Button postbttn;
        private System.Windows.Forms.RichTextBox Postrtb;
        private System.Windows.Forms.Button delbttn;
    }
}
