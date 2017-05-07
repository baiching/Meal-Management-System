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
    public partial class UcFinalChart : UserControl
    {
        private static UcFinalChart m_perMealCost;
        MessDBDataContext DB = new MessDBDataContext();

        public static UcFinalChart PerMealCost
        {
            get
            {
                if (m_perMealCost == null)
                {
                    m_perMealCost = new UcFinalChart();
                }
                return m_perMealCost;
            }
        }
        public UcFinalChart()
        {
            InitializeComponent();
        }

        private void UcPerMealCost_Load(object sender, EventArgs e)
        {
            try
            {
                int totalBalance = DB.MemberInformations.Select(x => x.Deposit ?? 0).Sum();
                //txtTotalDeposit.Text = Convert.ToString(totalBalance);
                textMeal.Text = Convert.ToString(UcMeal.totalMealForMonth);
                textTotalCost.Text = Convert.ToString(UcShoppingDistribution.totalExpense);
                int mealrate = UcShoppingDistribution.totalExpense / UcMeal.totalMealForMonth;
                textMealRate.Text = Convert.ToString(mealrate);
            }
            catch
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textMealRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
