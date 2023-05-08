<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ROProducts.aspx.cs" Inherits="MEWeb.ROProduct.ROProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <script type="text/javascript" src="../Scripts/JSLINQ.js"></script>
    <link href="../Theme/Singular/Custom/home.css" rel="stylesheet" />
    <link href="../Theme/Singular/Custom/customstyles.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="PageTitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <%


        using (var h = this.Helpers)
        {
            var MainContent = h.DivC("row pad-top-10");
            {
                var MainContainer = MainContent.Helpers.DivC("col-md-12 p-n-lr");
                {
                    var PageContainer = MainContainer.Helpers.DivC("tabs-container");
                    {
                        var PageTab = PageContainer.Helpers.TabControl();
                        {
                            PageTab.Style.ClearBoth();
                            PageTab.AddClass("nav nav-tabs");
                            var ContainerTab = PageTab.AddTab("Available Movies");
                            {
                                var RowContentDiv = ContainerTab.Helpers.DivC("row");
                                {
                                    var ColContentDiv = RowContentDiv.Helpers.DivC("col-md-9");
                                    {
                                        var MoviesDiv = ColContentDiv.Helpers.BootstrapTableFor<MELib.RO.ROProduct>((c) => c.ROProductList, false, false, "");
                                        {
                                            var FirstRow = MoviesDiv.FirstRow;
                                            {
                                                var MovieTitle = FirstRow.AddColumn("Category");
                                                {
                                                    var MovieTitleText = MovieTitle.Helpers.Span(c => c.CategoryID);
                                                    MovieTitle.Style.Width = "250px";
                                                }
                                                var MovieName = FirstRow.AddColumn("Product Name");
                                                {
                                                    var MovieNameText = MovieName.Helpers.Span(c => c.ProductName);
                                                    MovieName.Style.Width = "250px";
                                                }
                                                var MovieDescription = FirstRow.AddColumn("Product Description");
                                                {
                                                    var MovieDescriptionText = MovieDescription.Helpers.Span(c => c.ProductDescription);
                                                    MovieDescription.Style.Width = "250px";
                                                }
                                                var MovieQuantity = FirstRow.AddColumn("Quantity");
                                                {
                                                    var MovieQuantityText = MovieQuantity.Helpers.Span(c => c.Quantity);
                                                    MovieQuantity.Style.Width = "250px";
                                                }
                                                //  var MovieIsActive = FirstRow.AddColumn("Available Product");
                                                //{
                                                //    var MovieIsActiveText = MovieIsActive.Helpers.Span(c => c.IsActive);
                                                //    MovieIsActive.Style.Width = "250px";
                                                //}
                                                var MoviePrice = FirstRow.AddColumn("Price");
                                                {
                                                    var MoviePriceText = MoviePrice.Helpers.Span(c => c.Price);
                                                    MoviePrice.Style.Width = "250px";
                                                }
                                                   var MovieAvailable = FirstRow.AddColumn("Available Product");
                                                {
                                                    var MovieAvailableText = MovieAvailable.Helpers.Span(c => c.ProductAvailability);
                                                    MovieAvailable.Style.Width = "250px";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }






























        /*
        using (var h = this.Helpers)
        {
            var MainHDiv = h.DivC("row pad-top-10");
            {
                var PanelContainer = MainHDiv.Helpers.DivC("col-md-12 p-n-lr");
                {
                    var HomeContainer = PanelContainer.Helpers.DivC("tabs-container");
                    {
                        var AssessmentsTab = HomeContainer.Helpers.TabControl();
                        {
                            AssessmentsTab.Style.ClearBoth();
                            AssessmentsTab.AddClass("nav nav-tabs");
                            var HomeContainerTab = AssessmentsTab.AddTab("Product View");
                            {
                                var Row = HomeContainerTab.Helpers.DivC("row margin0");
                                {
                                    var RowCol = Row.Helpers.DivC("col-md-12");
                                    {
                                        RowCol.Helpers.HTML().Heading3("Product");
                                        {
                                            var ProductList = RowCol.Helpers.With<MELib.Products.Product>(c => c.ProductList);
                                            {

                                                var test = ProductList.Helpers.DivC("col-md-12");
                                                {
                                                    test.Helpers.BootstrapEditorRowFor(c => c.ProductName);
                                                }


                                                //ProductList.FirstRow.Helpers.EditorRowFor(c => c.ProductName);



                                                //var ProductListRow = ProductList.FirstRow;
                                                //{
                                                //var MovieTitle = ProductListRow.AddColumn("Category");
                                                //{
                                                //var MovieTitleText = ProductListRow.Helpers.Span(c => c.CategoryID);
                                                //}
                                                //var MovieName = ProductListRow.AddColumn("Product Name");
                                                //{
                                                //var MovieNameText = ProductListRow.Helpers.EditorRowFor(c => c.ProductName);
                                                //}
                                                //var MovieDescription = ProductListRow.AddColumn("Product Description");
                                                //{
                                                //var MovieDescriptionText = ProductListRow.Helpers.Span(c => c.ProductDescription);
                                                //}
                                                //var MovieQuantity = ProductListRow.AddColumn("Quantity");
                                                //{
                                                //var MovieQuantityText = ProductListRow.Helpers.Span(c => c.Quantity);
                                                //}
                                                //var MovieIsActive = ProductListRow.AddColumn("Available");
                                                //{
                                                //    var MovieIsActiveText = ProductListRow.Helpers.Span(c => c.IsActive);
                                                //}
                                                //var MoviePrice = ProductListRow.AddColumn("Price");
                                                //{
                                                //    var MovieIsPriceText = ProductListRow.Helpers.Span(c => c.Price);
                                                //}

                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
        */

    %>


    <script type="text/javascript">
        Singular.OnPageLoad(function () {
            $("#menuItem5").addClass("active");
            $("#menuItem5 > ul").addClass("in");
        });
    </script>
</asp:Content>



