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
    public partial class UcShoppingDistribution : UserControl
    {
        private static UcShoppingDistribution m_basicInfo;
        MessDBDataContext DB = new MessDBDataContext();

        public static int totalExpense;

        public static UcShoppingDistribution BasicInfo
        {
            get
            {
                if (m_basicInfo == null)
                {
                    m_basicInfo = new UcShoppingDistribution();
                }
                return m_basicInfo;
            }
        }

        public UcShoppingDistribution()
        {
            InitializeComponent();
        }

        private void UcMemberBasicInfo_Load(object sender, EventArgs e)
        {
            try
            {
                

                var query = DB.MemberInformations.Select(x => x.First_Name);

                comboPerson.DataSource = query.ToList();

                comboPerson.DisplayMember = "Name";
                comboPerson.SelectedValue = "Value";
            }

            catch { }
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalExpense += Convert.ToInt32( txtAddAmount.Text);
        }
    }
}
