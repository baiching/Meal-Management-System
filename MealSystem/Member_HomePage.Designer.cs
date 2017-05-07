namespace MealSystem
{
    partial class Member_HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_HomePage));
            this.user_panel = new System.Windows.Forms.Panel();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_panel
            // 
            this.user_panel.BackColor = System.Drawing.Color.DarkGray;
            this.user_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_panel.BackgroundImage")));
            this.user_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_panel.Location = new System.Drawing.Point(93, 12);
            this.user_panel.Name = "user_panel";
            this.user_panel.Size = new System.Drawing.Size(747, 504);
            this.user_panel.TabIndex = 16;
            this.user_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.user_panel_Paint);
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExpense.Location = new System.Drawing.Point(12, 238);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(75, 40);
            this.btnExpense.TabIndex = 11;
            this.btnExpense.Text = "Meal";
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeposit.Location = new System.Drawing.Point(12, 156);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 40);
            this.btnDeposit.TabIndex = 10;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDashBoard.Location = new System.Drawing.Point(12, 47);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(75, 43);
            this.btnDashBoard.TabIndex = 9;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(12, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Member_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(852, 528);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.user_panel);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnDashBoard);
            this.Name = "Member_HomePage";
            this.Text = "Member HomePage";
            this.Load += new System.EventHandler(this.Manager_HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel user_panel;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button button2;
    }
}