using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Singular.Web.Data;
using MELib.RO;
using MELib.Security;
using Singular;
using MELib;
//using MELib.Products;

namespace MEWeb.ROProduct
{
    public partial class ROProducts : MEPageBase<ROProductsVM>
    {

    }
    public class ROProductsVM: MEStatelessViewModel<ROProductsVM>
    {
        public ROProductList ROProductList { get; set; }
        

        public ROProductsVM()
        {

        }
        protected override void Setup()
        {
            base.Setup();
            ROProductList = ROProductList.GetROProductList();
        }
    }
}