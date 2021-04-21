using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryApp{
    // https://www.youtube.com/watch?v=4h1eGlB8u_A&list=PL480DYS-b_keHacwHfXhHmHpWSI1n3Ff9&index=16
    // Ebrahim Adams 
    // 2 April 2021
    // Guru Videos
    // Youtube 

    class Home_Loan : Expenses
    {// the declarations from the abstract class 
        public Home_Loan(double grosaries, double waterNLight, double travelCost, double cellphone, double otherExpenses,double rent, double  PurchasePrice, double TotalDeposit, double InterestRate, double MonthNum) 
            : base(grosaries, waterNLight, travelCost, cellphone, otherExpenses, rent)// base for the values for the abstract class
        {
            this.PurchasePrice = PurchasePrice;
            this.TotalDeposit = TotalDeposit;
            this.InterestRate = InterestRate;
            this.MonthNum = MonthNum;
            this.Monthly_Amount = installment();
        }

        //getters and setters of the property purchase and loan
        public double  PurchasePrice { get; set; }
        public double  TotalDeposit { get; set; }
        public double  InterestRate { get; set; }
        public double  MonthNum { get; set; }
        public double Monthly_Amount { get; }

        private double installment() //method for calculating the monthly installment for the loan
        {
            // https://www.siyavula.com/read/maths/grade-10/finance-and-growth/09-finance-and-growth-03
            //Siyavula: TECHNOLOGY POERED LEARNING
            //Calculations using simple and compound interest
           
            double i = InterestRate / 100; // making calculation for a decimal percantage
            double p1 = PurchasePrice * i;// finding the tax amount 
            double P = PurchasePrice - p1; // subtracting the tax amount from the gross income 
            double n = MonthNum / 12;
            double A = P * (1 + (i * n)); // A = P(1 + in)

            double Monthly_Amount = A / MonthNum;
            return Monthly_Amount; //returning the amount which will be paid per month for the loan 
        }


    }


} 

