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
    public partial class UcMeal : UserControl
    {
        private static UcMeal m_perMeal;
        private int breakfastMeal;
        private int lunchMeal;
        private int dinnerMeal;
        private int totalMealForDay;
        public static int totalMealForMonth;
        public static UcMeal PerMealCost
        {
            get
            {
                if (m_perMeal == null)
                {
                    m_perMeal= new UcMeal();
                }
                return m_perMeal;
            }
        }
        public UcMeal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                breakfastMeal = Convert.ToInt32(comboBreakFast.ValueMember);
            }
            catch
            {

            }
        }

        private void UcMeal_Load(object sender, EventArgs e)
        {
            //
            //for breakfast
            //
            comboBreakFast.DisplayMember = "Text";
            comboBreakFast.ValueMember = "Value";
            //
            //for lunch
            //
            comboLunch.DisplayMember = "Text";
            comboLunch.ValueMember = "Value";
            //
            //for dinner
            //
            comboDinner.DisplayMember = "Text";
            comboDinner.ValueMember = "Value";

            var itemBreakfast = new[]
            {
                new { Text = "1", Value = "1" },
                new { Text = "2", Value = "2" },
                new { Text = "3", Value = "3" },
                new { Text = "4", Value = "4" },
                new { Text = "5", Value = "5" }
            };

            var itemLunch = new[]
            {
                new { Text = "1", Value = "1" },
                new { Text = "2", Value = "2" },
                new { Text = "3", Value = "3" },
                new { Text = "4", Value = "4" },
                new { Text = "5", Value = "5" }
            };

            var itemDinner = new[]
            {
                new { Text = "1", Value = "1" },
                new { Text = "2", Value = "2" },
                new { Text = "3", Value = "3" },
                new { Text = "4", Value = "4" },
                new { Text = "5", Value = "5" }
            };

            comboBreakFast.DataSource = itemBreakfast;
            comboLunch.DataSource = itemLunch;
            comboDinner.DataSource = itemDinner;
        }

        private void comboDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dinnerMeal = Convert.ToInt32(comboDinner.ValueMember);
            }
            catch { }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                totalMealForDay = breakfastMeal + lunchMeal + dinnerMeal;

                totalMealForMonth += totalMealForDay;
            }
            catch { }
        }

        private void comboLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lunchMeal = Convert.ToInt32(comboLunch.ValueMember);
            }
            catch { }

        }
    }
}
