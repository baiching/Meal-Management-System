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
    public partial class UcDashBoard : UserControl
    {

        private static UcDashBoard m_DashBoard;

        public static UcDashBoard DashBoard
        {
            get
            {
                if (m_DashBoard == null)
                {
                    m_DashBoard = new UcDashBoard();
                }
                return m_DashBoard;
            }
        }
        public UcDashBoard()
        {
            InitializeComponent();
        }

        private void UcDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
