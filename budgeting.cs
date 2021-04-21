using System;
using System.Collections.Generic;
using System.Text;

//CB Start
namespace Big_Project_practice
{
    class Budgeting

    {
        //takes multiple user, or preset, inputs to calculate total annual savings
        public double Calculated_savings(double income, double tax, double rent, double food, double transport)
        {

            double calc_savings = income - tax - rent - food - transport;

            return calc_savings;
        }

        //uses calculated annual savings and current savings, and compares it to users input cost, to calculate time required to save to that cost
        public string Time_To_Save(double calc_savings, double init_savings, double cost)
        {
            double time = 0;

            cost = cost - init_savings;
            if(cost <= 0)
            {
                return "Already Saved";
            }
            time= cost/calc_savings;

            return Convert.ToString(time);
        }

    }
}
//CB end