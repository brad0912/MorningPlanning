namespace Morning_Planning
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.HomePageTitle = new System.Windows.Forms.Label();
            this.YearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomePageTitle
            // 
            this.HomePageTitle.AutoSize = true;
            this.HomePageTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageTitle.Location = new System.Drawing.Point(116, 105);
            this.HomePageTitle.Name = "HomePageTitle";
            this.HomePageTitle.Size = new System.Drawing.Size(349, 27);
            this.HomePageTitle.TabIndex = 1;
            this.HomePageTitle.Text = "Welecome to Morning Planning";
            this.HomePageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearButton
            // 
            this.YearButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.YearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.YearButton.Location = new System.Drawing.Point(190, 162);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(167, 108);
            this.YearButton.TabIndex = 0;
            this.YearButton.Text = "button1";
            this.YearButton.UseVisualStyleBackColor = false;
            this.YearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(563, 423);
            this.Controls.Add(this.HomePageTitle);
            this.Controls.Add(this.YearButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morning Planning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HomePageTitle;
        private System.Windows.Forms.Button YearButton;
    }
}

