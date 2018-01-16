namespace Morning_Planning
{
    partial class WeeklyPlanning
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
            this.label_WeeklyPlan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckBox_WeekProject = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_WeeklyPlan
            // 
            this.label_WeeklyPlan.AutoSize = true;
            this.label_WeeklyPlan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label_WeeklyPlan.ForeColor = System.Drawing.Color.Black;
            this.label_WeeklyPlan.Location = new System.Drawing.Point(79, 9);
            this.label_WeeklyPlan.Name = "label_WeeklyPlan";
            this.label_WeeklyPlan.Size = new System.Drawing.Size(168, 22);
            this.label_WeeklyPlan.TabIndex = 1;
            this.label_WeeklyPlan.Text = "This Weekly Plan";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(108, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // CheckBox_WeekProject
            // 
            this.CheckBox_WeekProject.AutoSize = true;
            this.CheckBox_WeekProject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBox_WeekProject.Location = new System.Drawing.Point(108, 45);
            this.CheckBox_WeekProject.Name = "CheckBox_WeekProject";
            this.CheckBox_WeekProject.Size = new System.Drawing.Size(82, 23);
            this.CheckBox_WeekProject.TabIndex = 4;
            this.CheckBox_WeekProject.Text = "Project";
            this.CheckBox_WeekProject.UseVisualStyleBackColor = true;
            this.CheckBox_WeekProject.Click += new System.EventHandler(this.CheckBox_WeekProject_Click);
            // 
            // WeeklyPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 522);
            this.Controls.Add(this.CheckBox_WeekProject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_WeeklyPlan);
            this.Name = "WeeklyPlanning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weekly Planning";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WeekAndDayPlanning_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_WeeklyPlan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CheckBox_WeekProject;
    }
}