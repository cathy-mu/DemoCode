using System;
using SqlSugar;

namespace CodeDemo.Library
{
    [SugarTable("AStudents")]
    public class Students
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        [SugarColumn(ColumnDataType="nvarchar",Length = 50)]
        public string StudentName { get; set; }
        [SugarColumn(IsNullable = true)]  
        public string Class{ get; set; }
        [SugarColumn(IsNullable = true)]
        public int? Age { get; set; }
        public DateTime CreatedDate { get; set; }
        [SugarColumn(DecimalDigits = 2, Length = 4)]
        public Decimal Score { get; set; }
        public bool IsActive { get; set; }
        [SugarColumn(IsIgnore = true)]
        public String Remark { get; set; }
    }

    [SugarTable("ASchools")]
    public class Schools
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)] 
        public int SId { get; set; }
        public string SchoolName { get; set; }
    }
}
