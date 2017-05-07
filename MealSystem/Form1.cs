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
    public partial class Form1 : Form
    {
        MessDBDataContext DB = new MessDBDataContext();
        public static int ID { set; get; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm r = new RegistrationForm();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member_HomePage h = new Member_HomePage();
            MemberInformation mi = new MemberInformation();
            var log = from x in DB.MemberInformations
                      where txtUserName.Text == x.UserName && txtPassword.Text == x.Password                     
                      select x;
            var result = DB.MemberInformations.SingleOrDefault(x => x.UserName == txtUserName.Text)?.Id ?? 0;
            ID = result;
            
                if (log.Any())
                {
                    this.Hide();
                    h.Show();
                }           
                else
                {
                    this.Hide();
                    LoginError le = new LoginError();
                    le.Show();
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoginAsManager_Click(object sender, EventArgs e)
        {
            ManagerHomepage mhp = new ManagerHomepage();
            Manager m = new Manager();

            var query = from n in DB.Managers
                        where txtUserName.Text == n.username && txtPassword.Text == n.password
                        select n;
            if (query.Any())
            {
                this.Hide();
                mhp.Show();
            }
            else
            {
                this.Hide();
                LoginError le = new LoginError();
                le.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
