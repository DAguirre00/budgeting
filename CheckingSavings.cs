using System;
using System.Collections.Generic;
using System.Text;

namespace Big_Project_practice
{
    class CheckingSavings
    {
        double savings, checking, amount, transferAmount,test2;
        char account;
        bool transferToo;

        public void withdraw(double savings, double checking, double amount)
        {
			if (account == 's')
			{
				if (amount <= savings)
				{
					savings =- amount;
				}
				else
				{
					//cout << "You dont have enough money." << endl;
				}
			}
			else if (account == 'c')
			{
				if (amount <= checking)
				{
					checking =- amount;
				}
				else if (amount <= (checking + savings))
				{ // Overdraft protection
					//cout << "Not enough money in checking trasfering from savings." << endl;
					amount =- checking;
					checking = 0;
					savings =- amount;
				}
				else
				{
					//cout << "You dont have enough money." << endl;
				}
			}
			else
			{
				//cout << "Enter a proper account." << endl;
			}
		}
        public void Deposit(double savings, double checking, double amount)
        {
			if (account == 's')
			{
				savings = + amount;
			}
			else if (account == 'c')
			{
				checking = + amount;
			}
			else
			{
				//cout << "Enter a proper account." << endl;
			}
			
		}
        public void trasnfer(double savings, double checking,double transferAmount, bool trasnferToo)
        {
			if (trasnferToo == true)
			{
				if (transferAmount <= savings)
				{
					checking = checking + transferAmount;
					savings = savings - transferAmount;
				}
				else
				{
					//cout << "You dont have enough money" << endl;
				}
			}
			else if (trasnferToo == false)
			{
				if (transferAmount <= checking)
				{
					checking = checking - transferAmount;
					savings = savings + transferAmount;
				}
				else
				{
					//cout << "You dont have enough money." << endl;
				}
			}
			else
			{
				// << "Enter a valid option." << endl;
			}
		}
        public void Check()
        {

        }

    }
}
