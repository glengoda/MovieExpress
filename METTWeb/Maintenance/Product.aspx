<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="MEWeb.Maintenance.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
      <!-- Add page specific styles and JavaScript classes below -->
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
                              var HomeContainerTab = AssessmentsTab.AddTab("Product Table");
                              {
                                  var Row = HomeContainerTab.Helpers.DivC("row margin0");
                                  {
                                      var RowCol = Row.Helpers.DivC("col-md-12");
                                      {



                                          var MovieList = RowCol.Helpers.TableFor<MELib.Products.Product>((c) => c.Products, true, true);
                                          {
                                              MovieList.AddClass("table table-striped table-bordered table-hover");
                                              var MovieListRow = MovieList.FirstRow;
                                              {
                                                  var MovieTitle = MovieListRow.AddColumn(c => c.CategoryID);
                                                  {
                                                      MovieTitle.Style.Width = "300px";
                                                  }
                                                  var MovieGenreID = MovieListRow.AddColumn(c => c.ProductName);
                                                  {
                                                      MovieGenreID.Style.Width = "300px";
                                                  }
                                                  var MovieDescription = MovieListRow.AddColumn(c => c.ProductDescription);
                                                  {
                                                      MovieDescription.Style.Width = "300px";
                                                  }
                                                  var movieUrl = MovieListRow.AddColumn(c => c.URL);
                                                    {
                                                      movieUrl.Style.Width = "300px";
                                                    }
                                                  var MovieReleaseDate = MovieListRow.AddColumn(c => c.Quantity);
                                                  {
                                                      MovieReleaseDate.Style.Width = "300px";
                                                  }
                                                  var MoviesTime = MovieListRow.AddColumn(c => c.IsActive);
                                                  {
                                                      MoviesTime.Style.Width = "300px";
                                                  }
                                                  var MovieReleasePrice = MovieListRow.AddColumn(c => c.Price);
                                                  {
                                                      MovieReleasePrice.Style.Width = "300px";
                                                  }
                                              }
                                          }

                                          var SaveList = RowCol.Helpers.DivC("col-md-12 text-right");
                                          {
                                              var SaveBtn = SaveList.Helpers.Button("Save", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                              {
                                                  SaveBtn.AddClass("btn-primary btn btn btn-primary");
                                                  SaveBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "SaveMovies($data)");
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

    <script type="text/javascript">
    Singular.OnPageLoad(function () {
      $("#menuItem5").addClass("active");
      $("#menuItem5 > ul").addClass("in");
    });

    var SaveMovies = function (obj) {
        ViewModel.CallServerMethod('SaveProductList', { productList: ViewModel.MovieList.Serialise(), ShowLoadingBar: true }, function (result) {
        if (result.Success) {
          MEHelpers.Notification("Successfully Saved", 'center', 'success', 3000);
        }
        else {
          MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
        }
      });
    }

    </script>
</asp:Content>
