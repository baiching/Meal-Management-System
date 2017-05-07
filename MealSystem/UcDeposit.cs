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
    public partial class UcDeposit : UserControl
    {

        MessDBDataContext DB = new MessDBDataContext();
        

        private static UcDeposit m_deposit;

        public static UcDeposit Deposit
        {
            get
            {
                if(m_deposit == null)
                {
                    m_deposit = new UcDeposit();
                }
                return m_deposit;
            }
        }

        public UcDeposit()
        {
            InitializeComponent();
        }

        private void UcDeposit_Load(object sender, EventArgs e)
        {
            try
            {
                int pID = Form1.ID;
                MemberInformation mi = DB.MemberInformations.SingleOrDefault(x => x.Id == pID);
                txtCurrentBalance.Text = Convert.ToString(mi.Deposit);
            }
            catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //Form1 f1;
                int pID = Form1.ID;
                MemberInformation mi = DB.MemberInformations.SingleOrDefault(x => x.Id == pID);
                if(mi.Deposit == null)
                {
                    mi.Deposit = Convert.ToInt32(txtAddAmount.Text);
                }
                else
                {
                    mi.Deposit += Convert.ToInt32(txtAddAmount.Text);
                }
                
                DB.SubmitChanges();
                MessageBox.Show("Done");
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
