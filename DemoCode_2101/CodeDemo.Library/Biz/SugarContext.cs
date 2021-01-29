using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;


namespace CodeDemo.Library.Biz
{
    public class SugarContext
    {

        public SqlSugarClient Db;
        public SugarContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "MyConnctionString",
                DbType = DbType.SqlServer, 
                IsAutoCloseConnection = true, 
                InitKeyType = InitKeyType.Attribute//Code First
            });


            Db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" + Db.Utilities.SerializeObject
                    (pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
        }
        public void CreateTable(bool Backup = false, int StringDefaultLength = 50, params Type[] types)
        {
            Db.CodeFirst.SetStringDefaultLength(StringDefaultLength);
            Db.DbMaintenance.CreateDatabase();
            if (Backup)
            {
                Db.CodeFirst.BackupTable().InitTables(types);
            }
            else
            {
                Db.CodeFirst.InitTables(types);
            }
        }

        public SimpleClient<Students> studentDb { get { return new SimpleClient<Students>(Db); } }
        public SimpleClient<Schools> schoolDb { get { return new SimpleClient<Schools>(Db); } }
    }
}
