﻿// Generated 13 Mar 2023 15:47 - Singular Systems Object Generator Version 3.0.000
//<auto-generated/>
using System;
using Csla;
using Csla.Serialization;
using Csla.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Singular;
using Singular.DataAnnotations;
using System.Data;
using System.Data.SqlClient;


namespace MELib.Products
{
    [Serializable]
    public class Product
     : SingularBusinessBase<Product>
    {
        #region " Properties and Methods "

        #region " Properties "

        public static PropertyInfo<int> ProductIDProperty = RegisterProperty<int>(c => c.ProductID, "ID", 0);
        /// <summary>
        /// Gets the ID value
        /// </summary>
        [Display(AutoGenerateField = false), Key]
        public int ProductID
        {
            get { return GetProperty(ProductIDProperty); }
        }

        public static PropertyInfo<int> CategoryIDProperty = RegisterProperty<int>(c => c.CategoryID, "Category", 0);
        /// <summary>
        /// Gets and sets the Category value
        /// </summary>
        [Display(Name = "Category", Description = ""),
        Required(ErrorMessage = "Category required"),
        Singular.DataAnnotations.DropDownWeb(typeof(MELib.Categories.CategoryList), ValueMember = "CategoryID", DisplayMember = "CategoryName")]
        public int CategoryID
        {
            get { return GetProperty(CategoryIDProperty); }
            set { SetProperty(CategoryIDProperty, value); }
        }

        public static PropertyInfo<string> ProductNameProperty = RegisterProperty<string>(c => c.ProductName, "Product Name", "");
        /// <summary>
        /// Gets and sets the Product Name value
        /// </summary>
        [Display(Name = "Product Name", Description = ""),
        StringLength(50, ErrorMessage = "Product Name cannot be more than 50 characters")]
        public string ProductName
        {
            get { return GetProperty(ProductNameProperty); }
            set { SetProperty(ProductNameProperty, value); }
        }

        public static PropertyInfo<string> ProductDescriptionProperty = RegisterProperty<string>(c => c.ProductDescription, "Product Description", "");
        /// <summary>
        /// Gets and sets the Product Description value
        /// </summary>
        [Display(Name = "Product Description", Description = "")]
        public string ProductDescription
        {
            get { return GetProperty(ProductDescriptionProperty); }
            set { SetProperty(ProductDescriptionProperty, value); }

        }


        public static PropertyInfo<string> URLProperty = RegisterProperty<string>(c => c.URL, "ImageURL", "");
        /// <summary>
        /// Gets and sets the url value
        /// </summary>
        [Display(Name = "ImageURL", Description = ""),
        StringLength(50, ErrorMessage = "Product Name cannot be more than 50 characters")]
        public string URL
        {
            get { return GetProperty(URLProperty); }
            set { SetProperty(URLProperty, value); }
        }


        public static PropertyInfo<int> QuantityProperty = RegisterProperty<int>(c => c.Quantity, "Quantity", 0);
        /// <summary>
        /// Gets and sets the Quantity value
        /// </summary>
        [Display(Name = "Quantity", Description = ""),
        Required(ErrorMessage = "Quantity required")]
        public int Quantity
        {
            get { return GetProperty(QuantityProperty); }
            set { SetProperty(QuantityProperty, value); }
        }

        public static PropertyInfo<bool> IsActiveProperty = RegisterProperty<bool>(c => c.IsActive, "Is Active", false);
        /// <summary>
        /// Gets and sets the Is Active value
        /// </summary>
        [Display(Name = "Is Active", Description = ""),
        Required(ErrorMessage = "Is Active required")]
        public Boolean IsActive
        {
            get
            {
                return GetProperty(IsActiveProperty);
            }
            set
            {
                SetProperty(IsActiveProperty, value);
            }
        }

        public static PropertyInfo<decimal> PriceProperty = RegisterProperty<decimal>(c => c.Price, "Price", (decimal)0);
        /// <summary>
        /// Gets and sets the Price value
        /// </summary>
        [Display(Name = "Price", Description = ""),
        Required(ErrorMessage = "Price required")]
        // Singular.DataAnnotations.NumberField("R #,##0.#;(R #,##0.#)")]
        public decimal Price
        {
            get { return GetProperty(PriceProperty); }
            set { SetProperty(PriceProperty, value); }
        }

        //public static PropertyInfo<string> ProductAvailabilityProperty = RegisterProperty<string>(c => c.ProductAvailability, "Product Availability", "");
        ///// <summary>
        ///// Gets and sets the Product Name value
        ///// </summary>

        //// [Display(Name = "Product Availability", Description = ""),
       
        //[Display(AutoGenerateField = false)]
        //public string ProductAvailability
        //{
        //    get { return GetProperty(ProductAvailabilityProperty); }
        //    set { SetProperty(ProductAvailabilityProperty, value); }
        //}
        #endregion

        #region " Methods "

        protected override object GetIdValue()
        {
            return GetProperty(ProductIDProperty);
        }

        public override string ToString()
        {
            if (this.ProductName.Length == 0)
            {
                if (this.IsNew)
                {
                    return String.Format("New {0}", "Product");
                }
                else
                {
                    return String.Format("Blank {0}", "Product");
                }
            }
            else
            {
                return this.ProductName;
            }
        }

        #endregion

        #endregion

        #region " Validation Rules "

        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
        }

        #endregion

        #region " Data Access & Factory Methods "

        protected override void OnCreate()
        {
            // This is called when a new object is created
            // Set any variables here, not in the constructor or NewProduct() method.
        }

        public static Product NewProduct()
        {
            return DataPortal.CreateChild<Product>();
        }

        public Product()
        {
            MarkAsChild();
        }

        internal static Product GetProduct(SafeDataReader dr)
        {
            var p = new Product();
            p.Fetch(dr);
            return p;
        }

        protected void Fetch(SafeDataReader sdr)
        {
            using (BypassPropertyChecks)
            {
                int i = 0;
                LoadProperty(ProductIDProperty, sdr.GetInt32(i++));
                LoadProperty(CategoryIDProperty, sdr.GetInt32(i++));             
                LoadProperty(ProductNameProperty, sdr.GetString(i++));
                LoadProperty(ProductDescriptionProperty, sdr.GetString(i++));
                LoadProperty(URLProperty, sdr.GetString(i++));
                LoadProperty(QuantityProperty, sdr.GetInt32(i++));
                LoadProperty(IsActiveProperty, sdr.GetBoolean(i++));
                LoadProperty(PriceProperty, sdr.GetDecimal(i++));
              // LoadProperty(ProductAvailabilityProperty, sdr.GetString(i++));
            }

            MarkAsChild();
            MarkOld();
            BusinessRules.CheckRules();
        }

        protected override Action<SqlCommand> SetupSaveCommand(SqlCommand cm)
        {
            AddPrimaryKeyParam(cm, ProductIDProperty);

            cm.Parameters.AddWithValue("@CategoryID", GetProperty(CategoryIDProperty));
            cm.Parameters.AddWithValue("@ProductName", GetProperty(ProductNameProperty));
            cm.Parameters.AddWithValue("@ProductDescription", GetProperty(ProductDescriptionProperty));
            cm.Parameters.AddWithValue("@URL", GetProperty(URLProperty));
            cm.Parameters.AddWithValue("@Quantity", GetProperty(QuantityProperty));
            cm.Parameters.AddWithValue("@IsActive", GetProperty(IsActiveProperty));
            cm.Parameters.AddWithValue("@Price", GetProperty(PriceProperty));
           // cm.Parameters.AddWithValue("@ProductAvailability",GetProperty(ProductAvailabilityProperty));

            return (scm) =>
            {
    // Post Save
    if (this.IsNew)
                {
                    LoadProperty(ProductIDProperty, scm.Parameters["@ProductID"].Value);
                }
            };
        }

        protected override void SaveChildren()
        {
            // No Children
        }

        protected override void SetupDeleteCommand(SqlCommand cm)
        {
            cm.Parameters.AddWithValue("@ProductID", GetProperty(ProductIDProperty));
        }

        #endregion

    }

}