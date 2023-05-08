using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Singular.Web;

namespace MEWeb.Profile
{
  public partial class Transactions : MEPageBase<TransactionsVM>
  {
  }
  public class TransactionsVM : MEStatelessViewModel<TransactionsVM>
  {
    public TransactionsVM()
    {

    }
    protected override void Setup()
    {
      base.Setup();
    }
  }
}

