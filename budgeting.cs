using System;
using System.Collections.Generic;
using System.Text;

namespace Big_Project_practice
{
    class Budgeting

    {

        public double Calculated_savings(double income, double tax, double rent, double food, double transport)
        {

            double calc_savings = income - tax - rent - food - transport;

            return calc_savings;
        }

        public string Time_To_Save(double calc_savings, double init_savings, double cost)
        {
            double time = 0;

            cost = cost - init_savings;
            time= cost/calc_savings;

            return Convert.ToString(time);
        }

    }
}
