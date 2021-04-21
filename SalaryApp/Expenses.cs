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
    abstract class Expenses // declaring the abstract class as a ABSTRACT 
    { 
        // declarations of the abstract class
        private double grosaries;
        private double WaterNLight;
        private double TravelCost;
        private double Cellphone;
        private double OtherExpenses;
        private double Rent;

        //constructor fpr the abstract class fields 
        protected Expenses(double grosaries, double waterNLight, double travelCost, double cellphone, double otherExpenses, double rent)
        {
            this.grosaries = grosaries;
            WaterNLight = waterNLight;
            TravelCost = travelCost;
            Cellphone = cellphone;
            OtherExpenses = otherExpenses;
            Rent = rent;
        }
         // getters ans setters for the fields of the abstract class 
        public double Grosaries { get => grosaries; set => grosaries = value; }
        public double WaterNLight1 { get => WaterNLight; set => WaterNLight = value; }
        public double TravelCost1 { get => TravelCost; set => TravelCost = value; }
        public double Cellphone1 { get => Cellphone; set => Cellphone = value; }
        public double OtherExpenses1 { get => OtherExpenses; set => OtherExpenses = value; }
        public double Rent1 { get => Rent; set => Rent = value; }
    }


    
    
}
