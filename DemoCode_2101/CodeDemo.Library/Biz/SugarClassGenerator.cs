using SqlSugar;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace CodeDemo.Library.Biz
{
    public static class SugarClassGenerator
    {
        private static string _conn = "MyConnctionString";
        private static string _namespaceDesc = "using System.ComponentModel;\r\nusing System.Data;\r\n";
        private static string _propertyDesc = @"/// <summary>
   /// Desc:{PropertyDescription}
   /// Default:{DefaultValue}
   /// Nullable:{IsNullable}
   /// </summary>
   [Description(" + string.Format("\"{0}\"", "{PropertyDescription}") + ")]";


        public static SqlSugarClient GetInstance(string conn)
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = conn,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                IsShardSameThread = true
            });
            db.Ado.IsEnableLogEvent = true;

            return db;
        }


        public static void GenerateModel(String tableNames, string path, Dictionary<string,string> ignoreColumns, string nameSpace="Models")
        {
            try
            {
                var tableLists = tableNames.ToLower().Split(',').ToList();
                var instance = GetInstance(_conn).DbFirst.SettingNamespaceTemplate(old =>
                {
                    return old + _namespaceDesc;//set namespace
                }).SettingPropertyDescriptionTemplate(old =>
                {
                    return _propertyDesc;
                });

                var sugar = instance.Where(it => tableLists.Contains(it.ToLower()));


                //Filter fields
                if (ignoreColumns != null)
                {
                    var list = new List<SqlSugar.IgnoreColumn>();
                    //var tables = sugar.ToClassStringList().Keys;
                    foreach (var columnList in ignoreColumns)
                    {
                        var columnNames = columnList.Value.Split(",");
                        foreach (var column in columnNames)
                        {
                            list.Add(new SqlSugar.IgnoreColumn() { EntityName = columnList.Key, PropertyName = column });
                        }
                    }
                    sugar.Context.IgnoreColumns.AddRange(list);
                }    
                sugar.CreateClassFile(path, nameSpace);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
