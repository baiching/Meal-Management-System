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
    public partial class UcMemberInfo : UserControl
    {
        private static UcMemberInfo m_settings;
        MessDBDataContext DB = new MessDBDataContext();
        public static UcMemberInfo Settings
        {
            get
            {
                if (m_settings == null)
                {
                    m_settings = new UcMemberInfo();
                }
                return m_settings;
            }
        }

        public UcMemberInfo()
        {
            InitializeComponent();
        }

        private void UcSettings_Load(object sender, EventArgs e)
        {
            try
            {
                int pID = Form1.ID;
                MemberInformation mi = DB.MemberInformations.SingleOrDefault(x => x.Id == pID);
                txtName.Text = mi.First_Name + mi.Last_Name;
                txtEmail.Text = mi.Email;
                txt_phn_num.Text = mi.Phone;
                txt_user_name.Text = mi.UserName;
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
