using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BankAccount
/// </summary>
public class BankAccount
{
    public string Name { get; set; }
    public string AccountNo { get; set; }
    private double Balance { get; set; }
    public bool Active { get; set; }

    public BankAccount()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public BankAccount(string name,string accountNo ,double balance,bool active=true)
    {
        Name = name;
        AccountNo = accountNo;
        Balance = balance;
        Active = active; 
    }

    public void Deposit(double amount)
    {
        if (Settings.GetStatus()==Transaction.Active)
        {
            Balance += amount;
        }
    }

    public double GetBalance()
    {
        return Balance;
    }

    public void Withdraw(double amount)
    {
        if (amount < Balance)
        {
            Balance -= amount;
        }
    }

}