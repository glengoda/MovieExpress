﻿// Generated 05 Jan 2021 09:47 - Singular Systems Object Generator Version 2.2.694
//<auto-generated/>
using System;
using Csla;
using Csla.Serialization;
using Csla.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Singular;
using System.Data;
using System.Data.SqlClient;


namespace MELib.Movies
{
  [Serializable]
  public class Movie
   : MEBusinessBase<Movie>
  {
    #region " Properties and Methods "

    #region " Properties "

    public static PropertyInfo<int> MovieIDProperty = RegisterProperty<int>(c => c.MovieID, "ID", 0);
    /// <summary>
    /// Gets the ID value
    /// </summary>
    [Display(AutoGenerateField = false), Key]
    public int MovieID
    {
      get { return GetProperty(MovieIDProperty); }
    }

    public static PropertyInfo<int> MovieGenreIDProperty = RegisterProperty<int>(c => c.MovieGenreID, "Movie Genre", 0);
    /// <summary>
    /// Gets and sets the Movie Genre value
    /// </summary>
    [Display(Name = "Movie Genre", Description = "Movie Genre ID"),
    Required(ErrorMessage = "Movie Genre required"),
    Singular.DataAnnotations.DropDownWeb(typeof(MELib.RO.ROMovieGenreList), ValueMember = "MovieGenreID", DisplayMember = "Genre")]
  
        public int MovieGenreID
    {
      get { return GetProperty(MovieGenreIDProperty); }
      set { SetProperty(MovieGenreIDProperty, value); }
    }

    public static PropertyInfo<String> MovieTitleProperty = RegisterProperty<String>(c => c.MovieTitle, "Movie Title", "");
    /// <summary>
    /// Gets and sets the Movie Title value
    /// </summary>
    [Display(Name = "Movie Title", Description = "Title of the Movie"),
    StringLength(200, ErrorMessage = "Movie Title cannot be more than 200 characters")]
    public String MovieTitle
    {
      get { return GetProperty(MovieTitleProperty); }
      set { SetProperty(MovieTitleProperty, value); }
    }

    public static PropertyInfo<String> MovieDescriptionProperty = RegisterProperty<String>(c => c.MovieDescription, "Movie Description", "");
    /// <summary>
    /// Gets and sets the Movie Description value
    /// </summary>
    [Display(Name = "Movie Description", Description = "Short Description of the Movie")]
    public String MovieDescription
    {
      get { return GetProperty(MovieDescriptionProperty); }
      set { SetProperty(MovieDescriptionProperty, value); }
    }

    public static PropertyInfo<String> MovieImageURLProperty = RegisterProperty<String>(c => c.MovieImageURL, "Movie Image URL", "");
    /// <summary>
    /// Gets and sets the Movie Title value
    /// </summary>
    [Display(Name = "Movie Image URL", Description = "Title of the Movie"),
    StringLength(2000, ErrorMessage = "Movie Image URL cannot be more than 2000 characters")]
    public String MovieImageURL
    {
      get { return GetProperty(MovieImageURLProperty); }
      set { SetProperty(MovieImageURLProperty, value); }
    }

    public static PropertyInfo<Decimal> PriceProperty = RegisterProperty<decimal>(c => c.Price, "Price");
    /// <summary>
    /// Gets and sets the Release Date value
    /// </summary>
    [Display(Name = "Price", Description = "Price"),
    Required(ErrorMessage = "Price required"),
    Singular.DataAnnotations.NumberField("R #,##0.#;(R #,##0.#)")]
    public decimal Price
    {
      get
      {
        return GetProperty(PriceProperty);
      }
      set
      {
        SetProperty(PriceProperty, value);
      }
    }

    public static PropertyInfo<DateTime> ReleaseDateProperty = RegisterProperty<DateTime>(c => c.ReleaseDate, "Release Date");
    /// <summary>
    /// Gets and sets the Release Date value
    /// </summary>
    [Display(Name = "Release Date", Description = "Date of Release"),
    Required(ErrorMessage = "Release Date required")]
    public DateTime ReleaseDate
    {
      get
      {
        return GetProperty(ReleaseDateProperty);
      }
      set
      {
        SetProperty(ReleaseDateProperty, value);
      }
    }

    public static PropertyInfo<Boolean> IsActiveIndProperty = RegisterProperty<Boolean>(c => c.IsActiveInd, "Is Active", true);
    /// <summary>
    /// Gets and sets the Is Active value
    /// </summary>
    [Display(Name = "Is Active", Description = "Indicator showing if the Movie is Active"),
    Required(ErrorMessage = "Is Active required")]
        public Boolean IsActiveInd
        {
            get
            {
                return GetProperty(IsActiveIndProperty);
            }
            set
            {
                SetProperty(IsActiveIndProperty, value);
            }
        }
        public static PropertyInfo<DateTime?> DeletedDateProperty = RegisterProperty<DateTime?>(c => c.DeletedDate, "Deleted Date");
    /// <summary>
    /// Gets and sets the Deleted Date value
    /// </summary>
    [Display(Name = "Deleted Date", Description = "When this record was deleted")]
    public DateTime? DeletedDate
    {
      get
      {
        return GetProperty(DeletedDateProperty);
      }
      set
      {
        SetProperty(DeletedDateProperty, value);
      }
    }

    public static PropertyInfo<int> DeletedByProperty = RegisterProperty<int>(c => c.DeletedBy, "Deleted By", 0);
    /// <summary>
    /// Gets and sets the Deleted By value
    /// </summary>
    [Display(Name = "Deleted By", Description = "User that deleted the record")]
    public int DeletedBy
    {
      get { return GetProperty(DeletedByProperty); }
      set { SetProperty(DeletedByProperty, value); }
    }

    public static PropertyInfo<SmartDate> CreatedDateProperty = RegisterProperty<SmartDate>(c => c.CreatedDate, "Created Date", new SmartDate(DateTime.Now));
    /// <summary>
    /// Gets the Created Date value
    /// </summary>
    [Display(AutoGenerateField = false)]
    public SmartDate CreatedDate
    {
      get { return GetProperty(CreatedDateProperty); }
    }

    public static PropertyInfo<int> CreatedByProperty = RegisterProperty<int>(c => c.CreatedBy, "Created By", 0);
    /// <summary>
    /// Gets the Created By value
    /// </summary>
    [Display(AutoGenerateField = false)]
    public int CreatedBy
    {
      get { return GetProperty(CreatedByProperty); }
    }

    public static PropertyInfo<SmartDate> ModifiedDateProperty = RegisterProperty<SmartDate>(c => c.ModifiedDate, "Modified Date", new SmartDate(DateTime.Now));
    /// <summary>
    /// Gets the Modified Date value
    /// </summary>
    [Display(AutoGenerateField = false)]
    public SmartDate ModifiedDate
    {
      get { return GetProperty(ModifiedDateProperty); }
    }

    public static PropertyInfo<int> ModifiedByProperty = RegisterProperty<int>(c => c.ModifiedBy, "Modified By", 0);
    /// <summary>
    /// Gets the Modified By value
    /// </summary>
    [Display(AutoGenerateField = false)]
    public int ModifiedBy
    {
      get { return GetProperty(ModifiedByProperty); }
    }

    #endregion

    #region " Methods "

    protected override object GetIdValue()
    {
      return GetProperty(MovieIDProperty);
    }

    public override string ToString()
    {
      if (this.MovieTitle.Length == 0)
      {
        if (this.IsNew)
        {
          return String.Format("New {0}", "Movie");
        }
        else
        {
          return String.Format("Blank {0}", "Movie");
        }
      }
      else
      {
        return this.MovieTitle;
      }
    }

    #endregion

    #endregion

    #region " Validation Rules "

    protected override void AddBusinessRules()
    {
      base.AddBusinessRules();

      // Add your custome business rules / validation here, examples below
      var displayNamewebRule = AddWebRule(MovieTitleProperty, c => ((c.MovieTitle.Length < 3)), c => "Movie Title cannot be more less than 3 characters.");

    }

    #endregion

    #region " Data Access & Factory Methods "

    protected override void OnCreate()
    {
      // This is called when a new object is created
      // Set any variables here, not in the constructor or NewMovie() method.
    }

    public static Movie NewMovie()
    {
      return DataPortal.CreateChild<Movie>();
    }

    public Movie()
    {
      MarkAsChild();
    }

    internal static Movie GetMovie(SafeDataReader dr)
    {
      var m = new Movie();
      m.Fetch(dr);
      return m;
    }

    protected void Fetch(SafeDataReader sdr)
    {
      using (BypassPropertyChecks)
      {
        int i = 0;
        LoadProperty(MovieIDProperty, sdr.GetInt32(i++));
        LoadProperty(MovieGenreIDProperty, sdr.GetInt32(i++));
        LoadProperty(MovieTitleProperty, sdr.GetString(i++));
        LoadProperty(MovieDescriptionProperty, sdr.GetString(i++));
        LoadProperty(MovieImageURLProperty, sdr.GetString(i++));
        LoadProperty(PriceProperty, sdr.GetValue(i++));
        LoadProperty(ReleaseDateProperty, sdr.GetValue(i++));
        LoadProperty(IsActiveIndProperty, sdr.GetBoolean(i++));
        LoadProperty(DeletedDateProperty, sdr.GetSmartDate(i++));
        LoadProperty(DeletedByProperty, sdr.GetInt32(i++));
        LoadProperty(CreatedDateProperty, sdr.GetSmartDate(i++));
        LoadProperty(CreatedByProperty, sdr.GetInt32(i++));
        LoadProperty(ModifiedDateProperty, sdr.GetSmartDate(i++));
        LoadProperty(ModifiedByProperty, sdr.GetInt32(i++));
      }

      MarkAsChild();
      MarkOld();
      BusinessRules.CheckRules();
    }

    protected override Action<SqlCommand> SetupSaveCommand(SqlCommand cm)
    {
      LoadProperty(ModifiedByProperty, Settings.CurrentUser.UserID);

      AddPrimaryKeyParam(cm, MovieIDProperty);

      cm.Parameters.AddWithValue("@MovieGenreID", GetProperty(MovieGenreIDProperty));
      cm.Parameters.AddWithValue("@MovieTitle", GetProperty(MovieTitleProperty));
      cm.Parameters.AddWithValue("@MovieDescription", GetProperty(MovieDescriptionProperty));
      cm.Parameters.AddWithValue("@MovieImageURL", GetProperty(MovieImageURLProperty));
      cm.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
      cm.Parameters.AddWithValue("@IsActiveInd", GetProperty(IsActiveIndProperty));
      cm.Parameters.AddWithValue("@DeletedDate", Singular.Misc.NothingDBNull(DeletedDate));
      cm.Parameters.AddWithValue("@DeletedBy", GetProperty(DeletedByProperty));
      cm.Parameters.AddWithValue("@ModifiedBy", GetProperty(ModifiedByProperty));

      return (scm) =>
      {
  // Post Save
  if (this.IsNew)
        {
          LoadProperty(MovieIDProperty, scm.Parameters["@MovieID"].Value);
        }
      };
    }

    protected override void SaveChildren()
    {
      // No Children
    }

    protected override void SetupDeleteCommand(SqlCommand cm)
    {
      cm.Parameters.AddWithValue("@MovieID", GetProperty(MovieIDProperty));
    }

    #endregion

  }

}