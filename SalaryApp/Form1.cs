using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace SalaryApp
{       // https://www.youtube.com/watch?v=4h1eGlB8u_A&list=PL480DYS-b_keHacwHfXhHmHpWSI1n3Ff9&index=16
        // Ebrahim Adams 
        // 2 April 2021
        // Guru Videos
        // You tube 
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRental_CheckedChanged(object sender, EventArgs e)
        {
            // This will allow the user to be able to choose between the Rental or Property
            // when the user click on rental the rental group box will appear and the property groupbox will be hidden
            if (rdbRental.Checked) {
                gpbBuyAProperty.Visible = false;
                gpbRental.Visible = true;
            }
        }

        private void rdbBuyingAProperty_CheckedChanged(object sender, EventArgs e)
        {
            // This will allow the user to be able to choose between the Rental or Property
            // when the user click on rental the rental group box will hidden and the property groupbox will be shown
            if (rdbBuyingAProperty.Checked) {
                gpbRental.Visible = false;
                gpbBuyAProperty.Visible = true;
            }
        }

       

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            // declaring the fields and linking the to the form
            double grossIncome = Convert.ToDouble(txbGrossMonthlyIncome.Text);
            double taxDeduction = Convert.ToDouble(txbEstimatedMonthlyTax.Text);
            double groceries = Convert.ToDouble(txbGrossaries.Text);
            double waterNlight = Convert.ToDouble(txbWaterAndLight.Text);
            double travel = Convert.ToDouble(txbTravelCost.Text);
            double cellphone = Convert.ToDouble(txbCellphone.Text);
            double otherExpenses = Convert.ToDouble(txbOtherExpenses.Text);
            double rent = Convert.ToDouble(txbRental.Text);

            //construtor linking the the form with the fields on the GrossTax class
            GrossTax s = new GrossTax(groceries, waterNlight, travel, cellphone, otherExpenses, rent, grossIncome, taxDeduction);

            // ArrayList for the expenses of the user
            ListHandler.expense.Add(s);

            double finalIncome = s.deductedIncomeTax - s.total_Expenses; // after tax, now we subtract the remaiining gross income with the total expenses
             // this is the message which tell the user the total monthly expenses, Gross monthly income after tax and Gross monthly income after tax and expenses
            MessageBox.Show("This is your total monthly expenses: R" + string.Format("{0:0.00}", s.total_Expenses) +
                // https://stackoverflow.com/questions/10749506/two-decimal-places-using-c-sharp
                // Stack Overflow
                //Louis Waweru
                // 25 MayTwo
                // Decimal places using c#
                

                "\n This is your Gross Monthly Income after deductions of tax: R" + s.deductedIncomeTax +
                "\n This is the Gross Income After the expenses and Tax: R" + finalIncome);

            Close();

        }

        private void btnInstallment_Click(object sender, EventArgs e)
        {
            // declaring the fields and linking the to the form
            double groceries = Convert.ToDouble(txbGrossaries.Text);
            double waterNlight = Convert.ToDouble(txbWaterAndLight.Text);
            double travel = Convert.ToDouble(txbTravelCost.Text);
            double cellphone = Convert.ToDouble(txbCellphone.Text);
            double otherExpenses = Convert.ToDouble(txbOtherExpenses.Text);
            double rent = 0; // declaring rent 0 becuase its not needed in this instance 
            double grossIncome = Convert.ToDouble(txbGrossMonthlyIncome.Text);
            double taxDeduction = Convert.ToDouble(txbEstimatedMonthlyTax.Text);
            double PurchasePrice = Convert.ToDouble(txbPurchasePrice.Text);
            double TotalDeposit = Convert.ToDouble(txbTotalDeposit.Text);
            double InterestRate = Convert.ToDouble(txbInterestRate.Text);
            int MonthNum = Convert.ToInt32(txbRepay.Text);
           
            // contructor for linking the form to the home loan class 
            Home_Loan a = new Home_Loan(groceries, waterNlight, travel, cellphone, otherExpenses, rent, PurchasePrice, TotalDeposit, InterestRate, MonthNum);
           // calculation for the third of the Gross Monthly Income 
            double third = grossIncome / 3;
            
            if (a.Monthly_Amount > third) // decision for the loan 
            {

                MessageBox.Show("This your Monthly installment for the loan: R"+ string.Format("{0:0.00}", a.Monthly_Amount) +
                    "\nSorry you will not eligible to get the loan"); // when the instalment is more than the third of the gross monthly salary 
            }
            else // decision for the loan 
            {

                MessageBox.Show("This your Monthly installment for the loan: R" + string.Format("{0:0.00}", a.Monthly_Amount) +
                    "\nCongratulation you are eligible for the loan"); // if the installment is less than the third of the gross monthly salary
            }

            Close();


        }

        private void txbOtherExpenses_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
