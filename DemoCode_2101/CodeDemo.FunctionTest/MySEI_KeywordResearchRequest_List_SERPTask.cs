using System;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;

namespace DM.MyModels
{
    ///<summary>
    ///
    ///</summary>
    public partial class MySEI_KeywordResearchRequest_List_SERPTask
    {
           public MySEI_KeywordResearchRequest_List_SERPTask(){


           }
/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public int Id {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public Guid ListGuid {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public Guid? RequestGuid {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public string Keyword {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public string ResultsJson {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public int? Rankingposition {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public decimal? OrganicDifficulty {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public decimal? OrganicCTR {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public int? MonthlySearchVolume {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public int? Priority {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public string SERPFeatures {get;set;}

/// <summary>
   /// Desc:
   /// Default:3
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public int Myrating {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public DateTime TaskDate {get;set;}

/// <summary>
   /// Desc:
   /// Default:DateTime.Now
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public DateTime? LastUpdated {get;set;}

/// <summary>
   /// Desc:
   /// Default:0
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public bool IsRedo {get;set;}

/// <summary>
   /// Desc:
   /// Default:0
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public bool Sync {get;set;}

/// <summary>
   /// Desc:
   /// Default:1
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public bool IsActive {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public DateTime? LastAssignedTime {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public string BenchmarkSite {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public string RankingJson {get;set;}

    }
}
