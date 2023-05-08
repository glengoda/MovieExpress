using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Singular;
using Singular.Web;

namespace MEWeb.Profile
{
  public partial class DepositFunds : MEPageBase<DepositFundsVM>
  {
  }
  public class DepositFundsVM : MEStatelessViewModel<DepositFundsVM>
  {
     //   public MELib.Accounts.Account EditBalance { get; set; } // editBalance property to get data from database
     public MELib.Accounts.Account EditBalance { get; set; }
    public DepositFundsVM()
    {

    }
    protected override void Setup() //pageload 
    {
      base.Setup();

          EditBalance = MELib.Accounts.AccountList.GetAccountListById(Settings.CurrentUserID).FirstOrDefault(); // getting the currentUser on the page
          
            
    }
        [WebCallable]
        public static Result Deposit(decimal Amount)
        {
            Result sr = new Result();
            try
            {
                
                var currentUserAmount = MELib.Accounts.AccountList.GetAccountListById(Settings.CurrentUserID);  // Getting the current amount after a user/Super just logged in.
                var accountList = MELib.Accounts.AccountList.GetAccountList();
            //    var newBalance = MELib.Accounts.Account.NewAccount(); //initialize newBalance to Account table inorder for us to add a new balance with the old balance 

                foreach (var item in currentUserAmount) // due to printing a list 
                {
                    item.Balance += Amount;
                    accountList.Add(item);
                    accountList.Save();
                    accountList.Clear();
                    //newBalance.TrySave();
                }
                sr.Success = true;
            }
            catch (Exception e)
            {
                sr.Data = e.InnerException;
                sr.Success = false;
            }
            return sr;
        }
        }
}

