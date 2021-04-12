//All code in this class was written by Dominic A

using System;
using System.Collections.Generic;
using System.Text;

namespace Big_Project_practice
{
	class CheckingSavings
	{
		double savings, checking, transferAmount;

		bool transferToo;

		private string amount;//Gets the changing amount
		public string Amount 
		{
			get { return amount; }
			set { amount = value; }
		}

		private string account;//Gets the account thats being changed
		public string Account
		{
			get { return account; }
			set { account = value; }
		}

		private string cTotal; //Gets the total for the checking account
		public string CTotal
		{
			get { return cTotal; }
			set { cTotal = value; }
		}

		private string sTotal; //Gets the total for the savings account
		public string STotal
		{
			get { return sTotal; }
			set { sTotal = value; }
		}

		public string Withdraw() //This funtion is run when you withdraw
		{
			double tempAmount;
			bool result1 = double.TryParse(Amount, out tempAmount); //Changes the string to a double and at the same time makes sure the value entered is a number
			if (result1)//catches if what was entered is a number and if not sends back an error
			{

				if (Account.Contains("Savings")) //Checks which account is being changed
				{
					double tempSTotal;
					bool result2 = double.TryParse(STotal, out tempSTotal); //Makes the sure the amount is a number and converts it to a double
					if (result2)
					{
						tempSTotal -= tempAmount; //subtracts the amount
						return Convert.ToString(tempSTotal); //returns the value as a string
					}
					else
					{
						return "Error";
					}
				}
				else if (Account.Contains("Checking")) //Same code except for checking account
				{
					double tempCTotal;
					bool result3 = double.TryParse(CTotal, out tempCTotal);
					if (result3)
					{
						tempCTotal -= tempAmount;
						return Convert.ToString(tempCTotal);
					}
					else
					{
						return "Error";
					}
				}
				else
				{
					return "Error";
				}
			}
			else
			{
				return "Error";
			}
		}
		public string Deposit() //This code is run when you deposit, it is same as withdraw except adding the amount instead of subtracting
		{
			double tempAmount;
			bool result1 = double.TryParse(Amount, out tempAmount);
			if (result1)
			{

				if (Account.Contains("Savings"))
				{
					double tempSTotal;
					bool result2 = double.TryParse(STotal, out tempSTotal);
					if (result2)
					{
						tempSTotal += tempAmount;
						return Convert.ToString(tempSTotal);
					}
					else
					{
						return "Error";
					}
				}
				else if (Account.Contains("Checking"))
				{
					double tempCTotal;
					bool result3 = double.TryParse(CTotal, out tempCTotal);
					if (result3)
					{
						tempCTotal += tempAmount;
						return Convert.ToString(tempCTotal);
					}
					else
					{
						return "Error";
					}
				}
				else
				{
					return "Error";
				}
			}
			else
			{
				return "Error";
			}

		}
		public string[] Transfer() //This code is run when transfering its a array because i needed to return two values and this is the easiest way
		{
			double tempAmount;
			double tempSTotal;
			double tempCTotal;

			bool result1 = double.TryParse(Amount, out tempAmount); //Converts all the needed strings to numbers and makes sure they are numbers
			bool result2 = double.TryParse(STotal, out tempSTotal);
			bool result3 = double.TryParse(CTotal, out tempCTotal);

			if (result1 && result2)//if they arent numbers then it returns an error
			{
				if (Account.Contains("From Savings To Checking")) //checks where the money is moving
				{
					tempSTotal -= tempAmount; //subtracts from one and adds to the other
					tempCTotal += tempAmount;

					string tempString1 = Convert.ToString(tempCTotal);//converts doubles back to strings
					string tempString2 = Convert.ToString(tempSTotal);

					return new string[] { tempString1, tempString2 }; //returns the strings as an array
				}
				else if (Account.Contains("From Checking To Savings")) //same as prior code
				{
					tempSTotal += tempAmount;
					tempCTotal -= tempAmount;

					string tempString1 = Convert.ToString(tempCTotal);
					string tempString2 = Convert.ToString(tempSTotal);

					return new string[] { tempString1, tempString2 };
				}
				else
				{
					return new string[] { "Error" };
				}
			}
			else
			{
				return new string[] { "Error" };
			}
		}
    }
}
