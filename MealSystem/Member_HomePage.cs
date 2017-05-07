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
    public partial class Member_HomePage : Form
    {
        MessDBDataContext DB = new MessDBDataContext();
        public Member_HomePage()
        {
            InitializeComponent();
        }

        private void Manager_HomePage_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            UcDeposit u = new UcDeposit();
            this.user_panel.Controls.Clear();
            this.user_panel.Controls.Add(u);
                                                                                                                                          
            
        }

        private void btnFinalChart_Click(object sender, EventArgs e)
        {
            UcFinalChart u = new UcFinalChart();
            this.user_panel.Controls.Clear();
            this.user_panel.Controls.Add(u);
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {

        }

        private void btnDistribution_Click(object sender, EventArgs e)
        {
            UcShoppingDistribution u = new UcShoppingDistribution();
            this.user_panel.Controls.Clear();
            this.user_panel.Controls.Add(u);
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            UcMeal u = new UcMeal();
            this.user_panel.Controls.Clear();
            this.user_panel.Controls.Add(u);
        }

        private void btnMemberInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            UcMemberInfo u = new UcMemberInfo();
            this.user_panel.Controls.Clear();
            this.user_panel.Controls.Add(u);
        }

        private void user_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginPage = new Form1();
            loginPage.Show();
        }
    }
}
