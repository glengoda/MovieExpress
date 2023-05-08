using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Singular.Web;


namespace MEWeb.ViewAvailableProduct
{
    public partial class ViewAvailableProduct : MEPageBase<ViewAvailableProductVM>
    {
    }
    public class ViewAvailableProductVM : MEStatelessViewModel<ViewAvailableProductVM>
    {
        public MELib.Products.ProductList ProductList { get; set; }
   //     public MELib.Products.ProductList Products { get; set; }

        public bool IsActive { get; set; } = true;
        public ViewAvailableProductVM()
        {

        }
        protected override void Setup()
        {
            base.Setup();
            ProductList = MELib.Products.ProductList.GetProductList(IsActive);
            //Products = MELib.Products.ProductList.GetProductList();
            //int num = 0;
        }
        
    }
 }