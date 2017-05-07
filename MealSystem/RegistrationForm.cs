using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSystem
{
    public delegate bool RegDel();



    public partial class RegistrationForm : Form
    {
        private Form1 login;
        UcDeposit ud = new UcDeposit();
        public int ID;
        MessDBDataContext DB = new MessDBDataContext();
        public string UserName
        {
            set;
            get;
        }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                RegDel reg = new RegDel(RegCheck);

                if (reg())
                {

                    login = new Form1();
                    //DB = new MessDBDataContext();

                    MemberInformation mi = new MemberInformation()
                    {
                        First_Name = txtFirst_Name.Text,
                        Last_Name = txtLastName.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        Phone = txtPhone.Text,
                        Deposit = 0,
                        Due = 0,
                        Pay_money = 0,
                        Expense = 0,
                        Current_Balance = 0
                    };
                    UserName = txtFirst_Name.Text + Convert.ToString(mi.Id);
                    mi.UserName = UserName;
                    DB.MemberInformations.InsertOnSubmit(mi);
                    DB.SubmitChanges();

                    //ID = mi.Id;

                    MessageBox.Show($"your user name is :{mi.UserName}");
                    this.Hide();

                    login.Show();
                }


                else
                {
                    MessageBox.Show("invalid input");
                }
            }

            catch
            {
                //DB.SubmitChanges();
            }
        }
        

        public static bool NameIsValid(string name)
        {
            int t = 0;
            bool x = false;
            char[] chArr = name.ToCharArray();

            foreach (char ch in chArr)
            {
                if (int.TryParse(ch.ToString(), out t))
                {
                    x = true;
                }
            }

            if (!x)
            {
                return false;
            }
            else
            {
                return true;
            }
            // return x;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

        }

        private void txtReTypePassword_TextChanged(object sender, EventArgs e)
        {
            txtReTypePassword.PasswordChar = '*';
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        
        public bool RegCheck()
        {
            int b;
            
            //checking the fields are null or not
            if (String.IsNullOrEmpty(txtFirst_Name.Text) && !NameIsValid(txtFirst_Name.Text))
            {
                return false;
            }

            if (String.IsNullOrEmpty(txtLastName.Text) && !NameIsValid(txtLastName.Text))
            {
                return false;
            }

            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtPhone.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtReTypePassword.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtFirst_Name.Text))
            {
                return false;
            }

            //inside textfield valid or not
            else if (int.TryParse(txtFirst_Name.Text, out b))
            {
                return false;
            }
            else if (NameIsValid(txtFirst_Name.Text))
            {
                return false;
            }
            else if (int.TryParse(txtEmail.Text, out b))
            {
                return false;
            }
            else if (!int.TryParse(txtPhone.Text, out b))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtFirst_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
