using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using cygl.Model;
using cygl.Helper;

namespace cygl.DAL
{
    public class waiter
    {
        Helper.DBHelper co = new DBHelper();
        //插入服务生信息
        public void insert(Model.waiter my)
        {
            String sql = "insert into waiter(id,waitername,idcard,sex,age,tel)values(@id,@waitername,@idcard,@sex,@age,@tel)";
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@id", my.Id));
            sqlParams.Add(new SqlParameter("@waitername", my.Waitername));
            sqlParams.Add(new SqlParameter("@idcard", my.Idcard));
            sqlParams.Add(new SqlParameter("@sex", my.Sex));
            sqlParams.Add(new SqlParameter("@age", my.Age));
            sqlParams.Add(new SqlParameter("@tel", my.Tel));
            co.ExecuteSql(sql, sqlParams);
        }
        //更新服务生信息
        public void update(Model.waiter my)
        {
            String sql = "update waiter set waitername=@waitername,sex=@sex,age=@age,idcard=@idcard,tel=@tel,id=@id where id=@id";
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@waitername", my.Waitername));
            sqlParams.Add(new SqlParameter("@age", my.Age));
            sqlParams.Add(new SqlParameter("@idcard", my.Idcard));
            sqlParams.Add(new SqlParameter("@tel", my.Tel));
            sqlParams.Add(new SqlParameter("@sex", my.Sex));
            sqlParams.Add(new SqlParameter("@id", my.Id));
            co.ExecuteSql(sql, sqlParams);
        }
        //删除服务生信息
        public void delete(string waitername)
        {
            String sql = "delete from waiter where waitername=@waitername";
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@waitername", waitername));
            co.ExecuteSql(sql, sqlParams);
        }
        //显示服务生信息列表
        public DataTable getlist(string strWhere)
        {
            string sql = "select * from waiter";

            if (strWhere != "")
            {
                sql += "where" + strWhere;


            }
            return co.query(sql);
        }
        public DataSet select(string strwhere)
        {
            string sql = "select * from waiter";
            if (strwhere != "")
                sql += " where " + strwhere;
            return co.getds(sql);
        }
    }
}
