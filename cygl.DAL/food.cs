using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using cygl.Model;
using cygl.Helper;

namespace cygl.DAL
{
     public class food
    {
         Helper.DBHelper co = new DBHelper();
        //插入食物信息
         public void insert(Model.food my)
         {
             string sql = "insert into food(id,foodname,foodnum,foodtype,foodprice)values(@id,@foodname,@foodnum,@foodtype,@foodprice)";
             List<SqlParameter> sqlParams = new List<SqlParameter>();
             sqlParams.Add(new SqlParameter("@id", my.Id));
             sqlParams.Add(new SqlParameter("@foodname", my.Foodname));
             sqlParams.Add(new SqlParameter("@foodnum", my.Foodnum));
             sqlParams.Add(new SqlParameter("@foodtype", my.Foodtype));
             sqlParams.Add(new SqlParameter("@foodprice", my.Foodprice));
             co.ExecuteSql(sql, sqlParams);
         }
        //更新重置食物信息
         public void update(Model.food my)
         {
             String sql = "update food set foodname=@foodname,foodnum=@foodnum,foodtype=@foodtype,foodprice=@foodprice Where foodname=@foodname ";
             List<SqlParameter> sqlParams = new List<SqlParameter>();
             sqlParams.Add(new SqlParameter("@foodname", my.Foodname));
             sqlParams.Add(new SqlParameter("@foodtype", my.Foodtype));
             sqlParams.Add(new SqlParameter("@foodnum", my.Foodnum));
             sqlParams.Add(new SqlParameter("@foodprice", my.Foodprice));
             co.ExecuteSql(sql, sqlParams);
         }
        //删除食物信息
         public void delete(string foodname)
         {
             String sql = "delete from food where foodname=@foodname";
             List<SqlParameter> sqlParams = new List<SqlParameter>();
             sqlParams.Add(new SqlParameter("@foodname", foodname));
             co.ExecuteSql(sql, sqlParams);
         }
        //获得食物列表
         public DataTable getlist(string strWhere)
         {
             string sql = "select * from food";
             if (strWhere != "")
             {
                 sql += "where" + strWhere;

             }
             return co.query(sql);
         }
         public DataSet select(string strwhere)
         {
             string sql = "select * from food";
             if (strwhere != "")
                 sql += " where " + strwhere;
             return co.getds(sql);
         }
    }
}
