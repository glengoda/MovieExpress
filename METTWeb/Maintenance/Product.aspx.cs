using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Singular.Web.Data;
using MELib.RO;
using MELib.Security;
using Singular;
using Singular.Web;
using MELib;

namespace MEWeb.Maintenance
{
    public partial class Product : MEPageBase<ProductVM>
    {

    }

	public class ProductVM : MEStatelessViewModel<ProductVM>
	{
		public MELib.Products.ProductList ProductList { get; set; }

		public MELib.Products.ProductList Products { get; set; }

		//public bool IsActive { get; set; } = true;
		public ProductVM()
		{

		}

		protected override void Setup()
		{
			base.Setup();
			ProductList = MELib.Products.ProductList.GetProductList(null);
		//Products = MELib.Products.ProductList.GetProductList();
		}


		[WebCallable]
		public Result SaveProductList(MELib.Products.ProductList productList)
		{
			Result sr = new Result();
			if (productList.IsValid)
			{
				var SaveResult = productList.TrySave();
				if (SaveResult.Success)
				{
					sr.Data = SaveResult.SavedObject;
					sr.Success = true;
				}
				else
				{
					sr.ErrorText = SaveResult.ErrorText;
					sr.Success = false;
				}
				return sr;
			}
			else
			{
				sr.ErrorText = productList.GetErrorsAsHTMLString();
				return sr;
			}
		}

	}
}