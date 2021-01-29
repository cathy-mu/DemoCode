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
    public partial class MySEI_RankingTask_DataForSEO_Result
    {
           public MySEI_RankingTask_DataForSEO_Result(){


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
           public int TaskId {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public int KeywordId {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public int SearchEngineId {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public int LanguageId {get;set;}

/// <summary>
   /// Desc:
   /// Default:O
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public string Status {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public DateTime TaskDate {get;set;}

/// <summary>
   /// Desc:
   /// Default:2018-01-01 00:00:00.000
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public DateTime? LastAssignedTime {get;set;}

/// <summary>
   /// Desc:
   /// Default:DateTime.Now
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public DateTime CreatedDate {get;set;}

/// <summary>
   /// Desc:
   /// Default:0
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public int Priority {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public int RankingPositions {get;set;}

/// <summary>
   /// Desc:
   /// Default:0
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public bool LogHtml {get;set;}

/// <summary>
   /// Desc:
   /// Default:0
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public bool LogData {get;set;}

/// <summary>
   /// Desc:
   /// Default:
   /// Nullable:True
   /// </summary>
   [Description("")]           
           public string DFSTaskId {get;set;}

/// <summary>
   /// Desc:
   /// Default:DateTime.Now
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public DateTime LastUpdated {get;set;}

/// <summary>
   /// Desc:
   /// Default:0
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public byte DataType {get;set;}

/// <summary>
   /// Desc:
   /// Default:0
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public bool IsWhiteListKeyword {get;set;}

/// <summary>
   /// Desc:
   /// Default:0
   /// Nullable:False
   /// </summary>
   [Description("")]           
           public string RedoTag {get;set;}

    }
}
