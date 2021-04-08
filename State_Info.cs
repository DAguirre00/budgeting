using System;
using System.Collections.Generic;
using System.Text;

namespace Big_Project_practice
{
    class State_Info
    {
        public struct CT
        {
            public const string rent_CT = "15924";
            public const string food_CT = "4949";
            public const string trans_CT = "10120";

        }

        public string CT_tax(string income)
        {
            double tax_CT = 0;
            double temp_income = Convert.ToDouble(income);

            if (temp_income <= 10000)
            {
                tax_CT = temp_income * 0.03;
                return Convert.ToString(tax_CT);
            }
            
            else if((temp_income > 10000) && (temp_income <=50000))
            {
                tax_CT = (10000 * 0.03)+((temp_income-10000)*.05);
                return Convert.ToString(tax_CT);
            }

            else if ((temp_income > 50000) && (temp_income <= 100000))
            {
                tax_CT = (10000 * 0.03) + (40000 * 0.05) + ((temp_income - 50000) * 0.055);
                return Convert.ToString(tax_CT);
            }

            else if ((temp_income > 100000) && (temp_income <= 200000))
            {
                tax_CT = (10000 * 0.03) + (40000 * 0.05) + ((50000) * 0.055) + ((temp_income - 100000) * 0.06);
                return Convert.ToString(tax_CT);
            }

            else if ((temp_income > 200000) && (temp_income <= 250000))
            {
                tax_CT = (10000 * 0.03) + (40000 * 0.05) + ((50000) * 0.055) + ((100000) * 0.06) + ((temp_income - 200000) * 0.065);
                return Convert.ToString(tax_CT);
            }

            else if ((temp_income > 250000) && (temp_income <= 500000))
            {
                tax_CT = (10000 * 0.03) + (40000 * 0.05) + ((50000) * 0.055) + ((100000) * 0.06) + ((50000) * 0.065) + ((temp_income - 250000) * 0.069);
                return Convert.ToString(tax_CT);
            }

            else if ((temp_income > 500000))
            {
                tax_CT = (10000 * 0.03) + (40000 * 0.05) + ((50000) * 0.055) + ((100000) * 0.06) + ((50000) * 0.065) + ((250000) * 0.069) + ((temp_income - 500000) * 0.0699);
                return Convert.ToString(tax_CT);
            }

            else
            {
                return Convert.ToString(tax_CT);
            }
        }

        public struct ME
        {
            public const string rent_ME = "17592";
            public const string food_ME = "4972";
            public const string trans_ME = "7131";

        }

        public string ME_tax(string income)
        {
            double tax_ME = 0;
            double temp_income = Convert.ToDouble(income);

            if (temp_income <= 22000)
            {
                tax_ME = temp_income * 0.058;
                return Convert.ToString(tax_ME);
            }

            else if ((temp_income > 22000) && (temp_income <= 52600))
            {
                tax_ME = (22000 * 0.058) + ((temp_income - 22000) * .0675);
                return Convert.ToString(tax_ME);
            }

            else if ((temp_income > 52600))
            {
                tax_ME = (22000 * 0.058) + (30600 * 0.0675) + ((temp_income - 52600) * 0.0715);
                return Convert.ToString(tax_ME);
            }

            else
            {
                return Convert.ToString(tax_ME);
            }
        }

        public struct MA
        {
            public const string rent_MA = "27024";
            public const string food_MA = "5056";
            public const string trans_MA = "9706";
        }

        public string MA_tax(string income)
        {
            double tax_MA = 0;
            double temp_income = Convert.ToDouble(income);

            if (temp_income >= 0)
            {
                tax_MA = temp_income * 0.05;
                return Convert.ToString(tax_MA);
            }

            else
            {
                return Convert.ToString(tax_MA);
            }
        }

        public struct NH
        {
            public const string tax_NH = "0";
            public const string rent_NH = "20976";
            public const string food_NH = "4968";
            public const string trans_NH = "7889";

        }

        public struct RI
        {
            public const string rent_RI = "20700";
            public const string food_RI = "4944";
            public const string trans_RI = "9553";

        }

        public string RI_tax(string income)
        {
            double tax_RI = 0;
            double temp_income = Convert.ToDouble(income);

            if (temp_income <= 65250)
            {
                tax_RI = temp_income * 0.0375;
                return Convert.ToString(tax_RI);
            }

            else if ((temp_income > 65250) && (temp_income <= 148350))
            {
                tax_RI = (65250 * 0.0375) + ((temp_income - 65250) * 0.0475);
                return Convert.ToString(tax_RI);
            }

            else if ((temp_income > 148350))
            {
                tax_RI = (65250 * 0.0375) + (83100 * 0.0475) + ((temp_income - 14830) * 0.0599);
                return Convert.ToString(tax_RI);
            }

            else
            {
                return Convert.ToString(tax_RI);
            }
        }

        public struct VT
        {
            
            public const string rent_VT = "19188";
            public const string food_VT = "4954";
            public const string trans_VT = "7014";

        }

        public string VT_tax(string income)
        {
            double tax_VT = 0;
            double temp_income = Convert.ToDouble(income);

            if (temp_income <= 40350)
            {
                tax_VT = temp_income * 0.035;
                return Convert.ToString(tax_VT);
            }

            else if ((temp_income > 40350) && (temp_income <= 97800))
            {
                tax_VT = (40350 * 0.035) + ((temp_income - 40350) * 0.066);
                return Convert.ToString(tax_VT);
            }

            else if ((temp_income > 97800) && (temp_income <= 204000))
            {
                tax_VT = (40350 * 0.035) + (57450 * 0.066) + ((temp_income - 97800) * 0.076);
                return Convert.ToString(tax_VT);
            }

            else if ((temp_income > 204000))
            {
                tax_VT = (40350 * 0.035) + (57450 * 0.066) + ((106200) * 0.076) + ((temp_income - 204000) * 0.0875);
                return Convert.ToString(tax_VT);
            }

            else
            {
                return Convert.ToString(tax_VT);
            }
        }

    }
}
