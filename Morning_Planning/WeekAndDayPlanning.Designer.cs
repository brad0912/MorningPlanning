namespace Morning_Planning
{
    partial class WeekAndDayPlanning
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
            this.label_DayPlan = new System.Windows.Forms.Label();
            this.label_WeeklyPlan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_DayPlan
            // 
            this.label_DayPlan.AutoSize = true;
            this.label_DayPlan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label_DayPlan.ForeColor = System.Drawing.Color.Black;
            this.label_DayPlan.Location = new System.Drawing.Point(53, 49);
            this.label_DayPlan.Name = "label_DayPlan";
            this.label_DayPlan.Size = new System.Drawing.Size(130, 22);
            this.label_DayPlan.TabIndex = 0;
            this.label_DayPlan.Text = "Today\'s Plan";
            // 
            // label_WeeklyPlan
            // 
            this.label_WeeklyPlan.AutoSize = true;
            this.label_WeeklyPlan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label_WeeklyPlan.ForeColor = System.Drawing.Color.Black;
            this.label_WeeklyPlan.Location = new System.Drawing.Point(425, 49);
            this.label_WeeklyPlan.Name = "label_WeeklyPlan";
            this.label_WeeklyPlan.Size = new System.Drawing.Size(168, 22);
            this.label_WeeklyPlan.TabIndex = 1;
            this.label_WeeklyPlan.Text = "This Weekly Plan";
            // 
            // WeekAndDayPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 603);
            this.Controls.Add(this.label_WeeklyPlan);
            this.Controls.Add(this.label_DayPlan);
            this.Name = "WeekAndDayPlanning";
            this.Text = "Week&Day Planning";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WeekAndDayPlanning_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DayPlan;
        private System.Windows.Forms.Label label_WeeklyPlan;
    }
}