using System;
using System.Collections.Generic;
using System.Text;

namespace Big_Project_practice
{
	class CheckingSavings
	{
		double savings, checking, transferAmount;

		bool transferToo;

		private string amount;
		public string Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		private string account;
		public string Account
		{
			get { return account; }
			set { account = value; }
		}

		private string cTotal;
		public string CTotal
		{
			get { return cTotal; }
			set { cTotal = value; }
		}

		private string sTotal;
		public string STotal
		{
			get { return sTotal; }
			set { sTotal = value; }
		}

		public string Withdraw()
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
						tempSTotal -= tempAmount;
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
		public string Deposit()
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
		public string[] Transfer()
		{
			double tempAmount;
			double tempSTotal;
			double tempCTotal;

			bool result1 = double.TryParse(Amount, out tempAmount);
			bool result2 = double.TryParse(STotal, out tempSTotal);
			bool result3 = double.TryParse(CTotal, out tempCTotal);

			if (result1 && result2)
			{
				if (Account.Contains("From Savings To Checking"))
				{
					tempSTotal -= tempAmount;
					tempCTotal += tempAmount;

					string tempString1 = Convert.ToString(tempCTotal);
					string tempString2 = Convert.ToString(tempSTotal);

					return new string[] { tempString1, tempString2 };
				}
				else if (Account.Contains("From Checking To Savings"))
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
