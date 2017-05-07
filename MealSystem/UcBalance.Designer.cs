namespace MealSystem
{
    partial class UcBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBalance));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMember = new System.Windows.Forms.ComboBox();
            this.txtDepositedAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalDeposit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deposited amount";
            // 
            // comboBoxMember
            // 
            this.comboBoxMember.FormattingEnabled = true;
            this.comboBoxMember.Location = new System.Drawing.Point(507, 192);
            this.comboBoxMember.Name = "comboBoxMember";
            this.comboBoxMember.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMember.TabIndex = 2;
            this.comboBoxMember.SelectedIndexChanged += new System.EventHandler(this.comboBoxMember_SelectedIndexChanged);
            // 
            // txtDepositedAmount
            // 
            this.txtDepositedAmount.Location = new System.Drawing.Point(507, 306);
            this.txtDepositedAmount.Name = "txtDepositedAmount";
            this.txtDepositedAmount.Size = new System.Drawing.Size(121, 20);
            this.txtDepositedAmount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Deposited amount till now is\r\n";
            // 
            // txtTotalDeposit
            // 
            this.txtTotalDeposit.Location = new System.Drawing.Point(507, 73);
            this.txtTotalDeposit.Name = "txtTotalDeposit";
            this.txtTotalDeposit.Size = new System.Drawing.Size(121, 20);
            this.txtTotalDeposit.TabIndex = 5;
            // 
            // UcBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.txtTotalDeposit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepositedAmount);
            this.Controls.Add(this.comboBoxMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcBalance";
            this.Size = new System.Drawing.Size(747, 504);
            this.Load += new System.EventHandler(this.UcExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMember;
        private System.Windows.Forms.TextBox txtDepositedAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalDeposit;
    }
}
