using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryApp
// https://www.youtube.com/watch?v=4h1eGlB8u_A&list=PL480DYS-b_keHacwHfXhHmHpWSI1n3Ff9&index=16
// Ebrahim Adams 
// 2 April 2021
// Guru Videos
// You tube 
{
    class GrossTax : Expenses
    {// contrutor with declarations from the abstract class
        public GrossTax(double grosaries, double waterNLight, double travelCost, double cellphone, double otherExpenses, double rent, double grossIncome, double taxDeduction)
            : base(grosaries, waterNLight, travelCost, cellphone, otherExpenses, rent)// base with the values from the abstract class which is the Expenses class
        {
            this.grossIncome = grossIncome;
            this.taxDeduction = taxDeduction;
            this.total_Expenses = AllExpenses();
            this.deductedIncomeTax = IncomeAfterTax();
        }
        // getters and setters for the Expenses
        public double grossIncome { get; set; }
        public double taxDeduction { get; set; }
        public double total_Expenses { get; }
        public double deductedIncomeTax { get; }

        private double AllExpenses() //method for calculating the total expenses
        {

            double total_Expenses = Grosaries + WaterNLight1 + TravelCost1 + Cellphone1 + OtherExpenses1 + Rent1; //adding all the expenses
            return total_Expenses;// return the value of the expenses
        }

        private double IncomeAfterTax()// method for taxing the gross income 
        {
            double tax = taxDeduction / 100; // dividing the tax amount so that i will have a decimal fraction for tax amount eg 0,15
            double Tax_Amount = grossIncome * tax; // multplying the gross income with the tax so that i will have the tax amount of the grosss income 
            double deductedIncomeTax = grossIncome - Tax_Amount; // subtracting the tax amount from the groos income, which will give us the gross income after tax

            return deductedIncomeTax; // return the gross amount which has been tax deducted
            
        }

       
    }
}
