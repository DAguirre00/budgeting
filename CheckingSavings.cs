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
		set { amount = value;}
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

		//public void withdraw(double savings, double checking, double amount)
		//      {
		//	if (account == 's')
		//	{
		//		if (amount <= savings)
		//		{
		//			savings =- amount;
		//		}
		//		else
		//		{
		//			//cout << "You dont have enough money." << endl;
		//		}
		//	}
		//	else if (account == 'c')
		//	{
		//		if (amount <= checking)
		//		{
		//			checking =- amount;
		//		}
		//		else if (amount <= (checking + savings))
		//		{ // Overdraft protection
		//			//cout << "Not enough money in checking trasfering from savings." << endl;
		//			amount =- checking;
		//			checking = 0;
		//			savings =- amount;
		//		}
		//		else
		//		{
		//			//cout << "You dont have enough money." << endl;
		//		}
		//	}
		//	else
		//	{
		//		//cout << "Enter a proper account." << endl;
		//	}
		//}
		public string Deposit()
        {
			double tempAmount = Convert.ToDouble(Amount);
			
			

			if (Account.Contains("Savings"))
			{
				double tempSTotal = Convert.ToDouble(STotal);
				tempSTotal += tempAmount;
				return Convert.ToString(tempSTotal);
				
			}
			else if (Account.Contains("Checking"))
			{
				double tempCTotal = Convert.ToDouble(CTotal);
				tempCTotal += tempAmount;
				return Convert.ToString(tempCTotal);
			}
            else
            {
				return "Error";
            }
			
		}
  //      public void trasnfer(double savings, double checking,double transferAmount, bool trasnferToo)
  //      {
		//	if (trasnferToo == true)
		//	{
		//		if (transferAmount <= savings)
		//		{
		//			checking = checking + transferAmount;
		//			savings = savings - transferAmount;
		//		}
		//		else
		//		{
		//			//cout << "You dont have enough money" << endl;
		//		}
		//	}
		//	else if (trasnferToo == false)
		//	{
		//		if (transferAmount <= checking)
		//		{
		//			checking = checking - transferAmount;
		//			savings = savings + transferAmount;
		//		}
		//		else
		//		{
		//			//cout << "You dont have enough money." << endl;
		//		}
		//	}
		//	else
		//	{
		//		// << "Enter a valid option." << endl;
		//	}
		//}
  //      public void Check()
  //      {

  //      }

    }
}
