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
    public partial class UcMemInfo : UserControl
    {
        private static UcMemInfo m_info;
        MessDBDataContext DB = new MessDBDataContext();
        
        public static UcMemInfo info
        {
            get
            {
                if (m_info == null)
                {
                    m_info = new UcMemInfo();
                }
                return m_info;
            }
        }


        public UcMemInfo()
        {
            InitializeComponent();
        }

        private void UcMemInfo_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    

                    var query = DB.MemberInformations.Select(x => x.First_Name);

                    comboSelectMember.DataSource = query.ToList();

                    comboSelectMember.DisplayMember = "Name";
                    comboSelectMember.SelectedValue = "Value";
                }

                catch { }
            }
            catch { }
        }

        private void comboSelectMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = (from c in DB.MemberInformations
                     where comboSelectMember.Text == c.First_Name
                     select c).SingleOrDefault();
            try
            {
                txtName.Text = Convert.ToString(x.First_Name);
                txtUserName.Text = Convert.ToString(x.UserName);
                txtPhoneNumber.Text = Convert.ToString(x.Phone);
                txtEmail.Text = Convert.ToString(x.Email);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var member = (from c in DB.MemberInformations
                     where txtName.Text == c.First_Name
                     select c).SingleOrDefault();

            if(member != null)
            {
                DB.MemberInformations.DeleteOnSubmit(member);
                DB.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }
    }
}
