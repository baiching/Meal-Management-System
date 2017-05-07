using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSystem
{
    public partial class UcBalance : UserControl
    {
        MessDBDataContext DB = new MessDBDataContext();
        public UcBalance()
        {
            InitializeComponent();
        }

        private void UcExpense_Load(object sender, EventArgs e)
        {
            try
            {
                int totalBalance = DB.MemberInformations.Select(x => x.Deposit ?? 0).Sum();
                txtTotalDeposit.Text = Convert.ToString(totalBalance);

                var query = DB.MemberInformations.Select(x => x.First_Name);
                
                comboBoxMember.DataSource = query.ToList();

                comboBoxMember.DisplayMember = "Name";
                comboBoxMember.SelectedValue = "Value";
            }

            catch { }
        }

        private void comboBoxMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtDepositedAmount.Text = comboBoxMember.ValueMember;
            var x = (from c in DB.MemberInformations
                    where comboBoxMember.Text == c.First_Name
                    select c).SingleOrDefault();
            txtDepositedAmount.Text = Convert.ToString(x.Deposit);
        }
    }
}
