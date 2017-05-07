namespace MealSystem
{
    partial class UcMemberInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMemberInfo));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.txt_phn_num = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.PicBoxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(20, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number(+880)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(17, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(20, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 125);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(183, 175);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.ReadOnly = true;
            this.txt_user_name.Size = new System.Drawing.Size(185, 20);
            this.txt_user_name.TabIndex = 14;
            // 
            // txt_phn_num
            // 
            this.txt_phn_num.Location = new System.Drawing.Point(183, 220);
            this.txt_phn_num.Name = "txt_phn_num";
            this.txt_phn_num.ReadOnly = true;
            this.txt_phn_num.Size = new System.Drawing.Size(185, 20);
            this.txt_phn_num.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(183, 259);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // PicBoxUser
            // 
            this.PicBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxUser.Image")));
            this.PicBoxUser.Location = new System.Drawing.Point(20, 3);
            this.PicBoxUser.Name = "PicBoxUser";
            this.PicBoxUser.Size = new System.Drawing.Size(129, 109);
            this.PicBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxUser.TabIndex = 18;
            this.PicBoxUser.TabStop = false;
            // 
            // UcMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.PicBoxUser);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txt_phn_num);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Name = "UcMemberInfo";
            this.Size = new System.Drawing.Size(747, 504);
            this.Load += new System.EventHandler(this.UcSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.TextBox txt_phn_num;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox PicBoxUser;
    }
}
