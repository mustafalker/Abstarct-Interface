using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_vs_Interface
{
    public class BaseDb //bu classın amacı diğer classlara hizmet etmektir ortak amaçla çalışan kodları tek tek yazmak yerine bu classa bir iş yükleyerek çalışmasını sağlamak 
    {
        public DataTable ExecuteSql(string sql)
        {
            return new DataTable();
        }
    }

    public class SqlServerDb : BaseDb  //ardından bunları basedbden türettik 
    {
        public string GetDbVersion() => "SqlServer 2023";

        public string GenerateSql(int id)
        {
            return $"Select * From USERS Where Id = {id}";
        }
    }

    public class MySqlDb : BaseDb
    {
        public string GetDbVersion() => "MySqlDb";

        public string GenerateSql(int id)
        {
            return $"Select * From USERS Where User_Name = {id}";
        }
    }

    public class PgDb : BaseDb
    {
        public string GetDbVersion() => "PgDb 2023";

        public string GenerateSql(int id)
        {
            return $"Select * From USERS Where User_Id = {id}";
        }

        //public DataTable ExecuteSql(string sql) //Abstract Class Tarafı Bize Ortak Olabilicek Yönleri Bulmamızı Kolaylaştırıcak
        //{
        //    return new DataTable(); //Bunlar Yukardaki BaseDb classının içerisine taşıdık .
        //}
    }
}
