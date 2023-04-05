using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Settings
/// </summary>
public class Settings
{

    private static Transaction BankTransaction = Transaction.UnActive;

    public Settings()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static void SetActive()
    {
        BankTransaction = Transaction.Active;
    }

    public static void SetNotActive()
    {
        BankTransaction = Transaction.UnActive;
    }

    public static Transaction GetStatus()
    {
        return BankTransaction;
    }

}
public enum Transaction
{
    Active,
    UnActive
}