namespace Morning_Planning
{
    partial class DayPlanning
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CheckBox_TodayProject = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_WeeklyPlan
            // 
            this.label_WeeklyPlan.AutoSize = true;
            this.label_WeeklyPlan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label_WeeklyPlan.ForeColor = System.Drawing.Color.Black;
            this.label_WeeklyPlan.Location = new System.Drawing.Point(127, 9);
            this.label_WeeklyPlan.Name = "label_WeeklyPlan";
            this.label_WeeklyPlan.Size = new System.Drawing.Size(114, 22);
            this.label_WeeklyPlan.TabIndex = 2;
            this.label_WeeklyPlan.Text = "Today Plan";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox1.Location = new System.Drawing.Point(150, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Project";
            // 
            // CheckBox_TodayProject
            // 
            this.CheckBox_TodayProject.AutoSize = true;
            this.CheckBox_TodayProject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBox_TodayProject.Location = new System.Drawing.Point(129, 54);
            this.CheckBox_TodayProject.Name = "CheckBox_TodayProject";
            this.CheckBox_TodayProject.Size = new System.Drawing.Size(15, 14);
            this.CheckBox_TodayProject.TabIndex = 6;
            this.CheckBox_TodayProject.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(129, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // DayPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CheckBox_TodayProject);
            this.Controls.Add(this.label_WeeklyPlan);
            this.Name = "DayPlanning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayPlanning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_WeeklyPlan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox CheckBox_TodayProject;
        private System.Windows.Forms.Button button1;
    }
}