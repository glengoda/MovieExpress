<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewAvailableProduct.aspx.cs" Inherits="MEWeb.ViewAvailableProduct.ViewAvailableProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">


    <!-- Add page specific styles and JavaScript classes below -->

  <link href="../Theme/Singular/Custom/home.css" rel="stylesheet" />
  <link href="../Theme/Singular/Custom/customstyles.css" rel="stylesheet" />

    <style>
        .movie-border {
            border-radius: 5px;
            border: 2px solid #DEDEDE;
            padding: 15px;
            margin: 5px;
        }

        .img-size  {
            width: 13rem;
            height: 13rem;
            object-fit: cover;
            padding: 0px;
            object-position: 50% 50%;
        }

        div.item {
            vertical-align: top;
            display: inline-block;
            text-align: center;
            padding-bottom: 25px;
        }

        .caption {
            display: block;
            padding-bottom: 5px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageTitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  <%
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
                          var HomeContainerTab = AssessmentsTab.AddTab("Product");
                          {
                              var Row = HomeContainerTab.Helpers.DivC("row margin0");
                              {
                                  var RowColLeft = Row.Helpers.DivC("col-md-9");
                                  {
                                      var AnotherCardDiv = RowColLeft.Helpers.DivC("ibox float-e-margins paddingBottom");
                                      {
                                          var CardTitleDiv = AnotherCardDiv.Helpers.DivC("ibox-title");
                                          {
                                              CardTitleDiv.Helpers.HTML("<i class='ffa-lg fa-fw pull-left'></i>");
                                              CardTitleDiv.Helpers.HTML().Heading5("Add Cart");
                                          }
                                          var CardTitleToolsDiv = CardTitleDiv.Helpers.DivC("ibox-tools");
                                          {
                                              var aToolsTag = CardTitleToolsDiv.Helpers.HTMLTag("a");
                                              aToolsTag.AddClass("collapse-link");
                                              {
                                                  var iToolsTag = aToolsTag.Helpers.HTMLTag("i");
                                                  iToolsTag.AddClass("fa fa-chevron-up");
                                              }
                                          }
                                          var ContentDiv = AnotherCardDiv.Helpers.DivC("ibox-content");
                                          {
                                              var RowContentDiv = ContentDiv.Helpers.DivC("row");
                                              {
                                                  var ColNoContentDiv = RowContentDiv.Helpers.DivC("col-md-12 text-center");
                                                  {
                                                      ColNoContentDiv.AddBinding(Singular.Web.KnockoutBindingString.visible, c => ViewModel.ProductList.Count() == 0);
                                                      ColNoContentDiv.Helpers.HTML("<p>Could not find any products based on your filter criteria.</p>");
                                                  }
                                                  var ColContentDiv = RowContentDiv.Helpers.DivC("col-md-12");
                                                  {
                                                      var MoviesWatchedDiv = ColContentDiv.Helpers.ForEach<MELib.Products.Product>(c => c.ProductList);
                                                      {

                                                          // Using Knockout Binding
                                                          // <img width="16px" height="16px" data-bind="attr:{src: imagePath}" />
                                                          MoviesWatchedDiv.Helpers.HTML("<div class='item'>");
                                                          MoviesWatchedDiv.Helpers.HTML("<img data-bind=\"attr:{src: $data.URL()} \" class='img-size movie-border'/>");
                                                          MoviesWatchedDiv.Helpers.HTML("<b><span data-bind=\"text: $data.ProductName() \"  class='caption'></span></b>");
                                                          // MoviesWatchedDiv.Helpers.HTML("<span data-bind=\"text: $data.MovieGenreID() \"  class='caption'></span>");
                                                          MoviesWatchedDiv.Helpers.HTML("<span data-bind=\"text: $data.ProductDescription() \"  class='caption'></span>");
                                                          MoviesWatchedDiv.Helpers.HTML("<span data-bind=\"text: $data.Price \"  class='caption'></span>");

                                                      }
                                                      var WatchBtn = MoviesWatchedDiv.Helpers.Button("Add Cart", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                                      {
                                                          //WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.text, c => "Rent @ R " + c.Price);
                                                          //WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "RentMovie($data)");
                                                          //WatchBtn.AddClass("btn btn-primary btn-outline");
                                                      }
                                                      MoviesWatchedDiv.Helpers.HTML("</div>");
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
      }
  %>

</asp:Content>
