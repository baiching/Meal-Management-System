namespace MealSystem
{
    partial class UcMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMeal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboLunch = new System.Windows.Forms.ComboBox();
            this.comboBreakFast = new System.Windows.Forms.ComboBox();
            this.comboDinner = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 62);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lunch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dinner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Breakfast";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboLunch
            // 
            this.comboLunch.FormattingEnabled = true;
            this.comboLunch.Location = new System.Drawing.Point(541, 62);
            this.comboLunch.Name = "comboLunch";
            this.comboLunch.Size = new System.Drawing.Size(121, 21);
            this.comboLunch.TabIndex = 3;
            this.comboLunch.SelectedIndexChanged += new System.EventHandler(this.comboLunch_SelectedIndexChanged);
            // 
            // comboBreakFast
            // 
            this.comboBreakFast.FormattingEnabled = true;
            this.comboBreakFast.Location = new System.Drawing.Point(239, 62);
            this.comboBreakFast.Name = "comboBreakFast";
            this.comboBreakFast.Size = new System.Drawing.Size(121, 21);
            this.comboBreakFast.TabIndex = 4;
            this.comboBreakFast.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboDinner
            // 
            this.comboDinner.FormattingEnabled = true;
            this.comboDinner.Location = new System.Drawing.Point(239, 229);
            this.comboDinner.Name = "comboDinner";
            this.comboDinner.Size = new System.Drawing.Size(121, 21);
            this.comboDinner.TabIndex = 5;
            this.comboDinner.SelectedIndexChanged += new System.EventHandler(this.comboDinner_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(418, 227);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // UcMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.comboDinner);
            this.Controls.Add(this.comboBreakFast);
            this.Controls.Add(this.comboLunch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcMeal";
            this.Size = new System.Drawing.Size(747, 504);
            this.Load += new System.EventHandler(this.UcMeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboLunch;
        private System.Windows.Forms.ComboBox comboBreakFast;
        private System.Windows.Forms.ComboBox comboDinner;
        private System.Windows.Forms.Button btnConfirm;
    }
}
