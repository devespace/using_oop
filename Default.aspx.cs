using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //BankAccount EmadAccount = new BankAccount();
        //EmadAccount.Name = "Emad";
        //EmadAccount.AccountNo = "001122";
        ////EmadAccount.Balance = 1000;
        //Response.Write(EmadAccount.Name + " Has " + EmadAccount.GetBalance() + " in his/her account with number : " + EmadAccount.AccountNo);

        //BankAccount HaniAccount = new BankAccount("Hani", "334455", 2000);
        //Settings.SetActive();
        //HaniAccount.Deposit(500);
        ////HaniAccount.Withdraw(2300);
        //Response.Write(HaniAccount.Name + " Has " + HaniAccount.GetBalance() + " in his/her account with number : " + HaniAccount.AccountNo);

        var accounts = new List<BankAccount>();

        accounts.Add(new BankAccount("Hani", "334455", 2000));
        accounts.Add(new BankAccount("Emad", "001122", 1000));

        foreach (BankAccount item in accounts)
        {
           Response.Write(item.Name + " Has " + item.GetBalance() + " in his/her account with number : " + item.AccountNo);
           Response.Write("<br>");
        }

    }
}