namespace MealSystem
{
    partial class UcFinalChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFinalChart));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTotalCost = new System.Windows.Forms.TextBox();
            this.textMealRate = new System.Windows.Forms.TextBox();
            this.textMeal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Cost";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Meal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Per Meal Cost";
            // 
            // textTotalCost
            // 
            this.textTotalCost.Location = new System.Drawing.Point(305, 87);
            this.textTotalCost.Name = "textTotalCost";
            this.textTotalCost.Size = new System.Drawing.Size(110, 20);
            this.textTotalCost.TabIndex = 5;
            // 
            // textMealRate
            // 
            this.textMealRate.Location = new System.Drawing.Point(305, 249);
            this.textMealRate.Name = "textMealRate";
            this.textMealRate.Size = new System.Drawing.Size(110, 20);
            this.textMealRate.TabIndex = 6;
            this.textMealRate.TextChanged += new System.EventHandler(this.textMealRate_TextChanged);
            // 
            // textMeal
            // 
            this.textMeal.Location = new System.Drawing.Point(305, 160);
            this.textMeal.Name = "textMeal";
            this.textMeal.Size = new System.Drawing.Size(110, 20);
            this.textMeal.TabIndex = 7;
            // 
            // UcFinalChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.textMeal);
            this.Controls.Add(this.textMealRate);
            this.Controls.Add(this.textTotalCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcFinalChart";
            this.Size = new System.Drawing.Size(747, 504);
            this.Load += new System.EventHandler(this.UcPerMealCost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTotalCost;
        private System.Windows.Forms.TextBox textMealRate;
        private System.Windows.Forms.TextBox textMeal;
    }
}
