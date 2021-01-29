using CodeDemo.Library.Biz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using CodeDemo.Library;

namespace CodeDemo.FunctionTest
{
    [TestClass]
    public class SugarGeneratorTest
    {
        [TestMethod]
        public void ShouldClassGenerator_GenerateTables()
        {
            SugarContext context = new SugarContext();
            context.CreateTable(false, 255, typeof(Students), typeof(Schools));
        }
        
        
        [TestMethod]
        public void ShouldClassGenerator_GenerateClassFile()
        {

            var path = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;

            List<string> tableList = new List<string>() { "MySEI_KeywordResearchRequest_List_SERPTask", "MySEI_RankingTask_DataForSEO_Result" };
            Dictionary<string, string> ingoreColumns = new Dictionary<string, string>() {  { "MySEI_KeywordResearchRequest_List_SERPTask", "Status,AssignedTimes" } };
            SugarClassGenerator.GenerateModel(string.Join(",", tableList), path, ingoreColumns, "DM.MyModels");
            foreach (var table in tableList)
            {
                Assert.IsTrue(File.Exists($@"{path}\{table}.cs"));
            }
        }

        
       

    }
}
