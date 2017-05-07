namespace MealSystem
{
    partial class ManagerHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerHomepage));
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnDistribution = new System.Windows.Forms.Button();
            this.btnFinalChart = new System.Windows.Forms.Button();
            this.btnMemberInfo = new System.Windows.Forms.Button();
            this.user_panel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDashBoard.Location = new System.Drawing.Point(12, 74);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(75, 43);
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBalance.Location = new System.Drawing.Point(12, 148);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(75, 40);
            this.btnBalance.TabIndex = 3;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = false;
            this.btnBalance.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnDistribution
            // 
            this.btnDistribution.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDistribution.Location = new System.Drawing.Point(12, 215);
            this.btnDistribution.Name = "btnDistribution";
            this.btnDistribution.Size = new System.Drawing.Size(75, 39);
            this.btnDistribution.TabIndex = 4;
            this.btnDistribution.Text = "Shopping Distribution";
            this.btnDistribution.UseVisualStyleBackColor = false;
            this.btnDistribution.Click += new System.EventHandler(this.btnDistribution_Click);
            // 
            // btnFinalChart
            // 
            this.btnFinalChart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFinalChart.Location = new System.Drawing.Point(12, 308);
            this.btnFinalChart.Name = "btnFinalChart";
            this.btnFinalChart.Size = new System.Drawing.Size(75, 42);
            this.btnFinalChart.TabIndex = 6;
            this.btnFinalChart.Text = "Final Chart";
            this.btnFinalChart.UseVisualStyleBackColor = false;
            this.btnFinalChart.Click += new System.EventHandler(this.btnFinalChart_Click);
            // 
            // btnMemberInfo
            // 
            this.btnMemberInfo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMemberInfo.Location = new System.Drawing.Point(12, 366);
            this.btnMemberInfo.Name = "btnMemberInfo";
            this.btnMemberInfo.Size = new System.Drawing.Size(75, 38);
            this.btnMemberInfo.TabIndex = 7;
            this.btnMemberInfo.Text = "Member Information";
            this.btnMemberInfo.UseVisualStyleBackColor = false;
            this.btnMemberInfo.Click += new System.EventHandler(this.btnMemberInfo_Click);
            // 
            // user_panel
            // 
            this.user_panel.BackColor = System.Drawing.Color.DarkGray;
            this.user_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_panel.BackgroundImage")));
            this.user_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_panel.Location = new System.Drawing.Point(93, 12);
            this.user_panel.Name = "user_panel";
            this.user_panel.Size = new System.Drawing.Size(747, 504);
            this.user_panel.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogout.Location = new System.Drawing.Point(12, 422);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 38);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ManagerHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(852, 528);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.user_panel);
            this.Controls.Add(this.btnMemberInfo);
            this.Controls.Add(this.btnFinalChart);
            this.Controls.Add(this.btnDistribution);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnDashBoard);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ManagerHomepage";
            this.Text = "Manager Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnDistribution;
        private System.Windows.Forms.Button btnFinalChart;
        private System.Windows.Forms.Button btnMemberInfo;
        private System.Windows.Forms.Panel user_panel;
        private System.Windows.Forms.Button btnLogout;
    }
}