using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSystem
{
    class Account
    {

        public Account() { }

        public int MealRate(int totalDeposit, int numberOfMeal)
        {
            return totalDeposit / numberOfMeal;
        }

        public int CurrentBalance(int balance, int expense)
        {
            return balance - expense;
        }

        public int ExpenseOfAPerson(int MealRate, int numberOfMeal)
        {
            return MealRate * numberOfMeal;
        }
        
        public int Due(int balance, int expense)
        {
            if(balance < expense)
            {
                return balance - expense;
            }
            else
            {
                return expense - balance;
            }
        }

        public int PayAccount(int balance, int expense)
        {
            if(balance > expense)
            {
                return expense - balance;
            }
            else
            {
                return balance - expense;
            }
        }
        

    }
}
