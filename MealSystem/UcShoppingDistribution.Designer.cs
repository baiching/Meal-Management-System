namespace MealSystem
{
    partial class UcShoppingDistribution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcShoppingDistribution));
            this.labelFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboPerson = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(54, 39);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 25);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Person";
            this.labelFirstName.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Amount";
            // 
            // txtAddAmount
            // 
            this.txtAddAmount.Location = new System.Drawing.Point(199, 181);
            this.txtAddAmount.Name = "txtAddAmount";
            this.txtAddAmount.Size = new System.Drawing.Size(149, 20);
            this.txtAddAmount.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboPerson
            // 
            this.comboPerson.FormattingEnabled = true;
            this.comboPerson.Location = new System.Drawing.Point(199, 39);
            this.comboPerson.Name = "comboPerson";
            this.comboPerson.Size = new System.Drawing.Size(149, 21);
            this.comboPerson.TabIndex = 5;
            this.comboPerson.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UcShoppingDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.comboPerson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAddAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFirstName);
            this.Name = "UcShoppingDistribution";
            this.Size = new System.Drawing.Size(747, 504);
            this.Load += new System.EventHandler(this.UcMemberBasicInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboPerson;
    }
}
