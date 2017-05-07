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
    public partial class ManagerHomepage : Form
    {
        public ManagerHomepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            UcDashBoard d = new UcDashBoard();
            this.user_panel.Controls.Clear();
            this.user_panel.Controls.Add(d);

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //UcDeposit u = new UcDeposit();
            //this.user_panel.Controls.Clear();
            //this.user_panel.Controls.Add(u);
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            UcBalance u = new UcBalance();
            this.user_panel.Controls.Clear();
            this.user_panel.Controls.Add(u);
        }

        private void btnDistribution_Click(object sender, EventArgs e)
        {
            UcShoppingDistribution u = new UcShoppingDistribution();
            this.user_panel.Controls.Clear();
            this.user_panel.Controls.Add(u);
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            //if (!user_panel.Controls.Contains(UcMemberInfo.Settings))
            //{
            //    user_panel.Controls.Add(UcMemberInfo.Settings);
            //    UcMemberInfo.Settings.Dock = DockStyle.Fill;
            //    UcMemberInfo.Settings.BringToFront();
            //}
            //else
            //{
            //    UcMemberInfo.Settings.BringToFront();
            //}
        }

        private void btnFinalChart_Click(object sender, EventArgs e)
        {
            UcFinalChart u = new UcFinalChart();
            this.user_panel.Controls.Clear();
            this.user_panel.Controls.Add(u);
        }

        private void btnMemberInfo_Click(object sender, EventArgs e)
        {
            UcMemInfo u = new UcMemInfo();
            this.user_panel.Controls.Clear();
            this.user_panel.Controls.Add(u);
        }

        private void name_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
