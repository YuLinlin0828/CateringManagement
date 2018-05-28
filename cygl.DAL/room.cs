using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using cygl.Model;
using cygl.Helper;

namespace cygl.DAL
{
    public class room
    {
        Helper.DBHelper co = new DBHelper();
        //插入房间信息
        public void insert(Model.room my)
        {
            string sql = "insert into room(id,roomname,roomabb,roomfee,roomwz)values(@id,@roomname,@roomabb,@roomfee,@roomlocation)";
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@id", my.Id));
            sqlParams.Add(new SqlParameter("@roomname", my.Roomname));
            sqlParams.Add(new SqlParameter("@roomabb", my.Roomabb));
            sqlParams.Add(new SqlParameter("@roomfee", my.Roomfee));
            sqlParams.Add(new SqlParameter("@roomlocation", my.Roomlocation));
            co.ExecuteSql(sql, sqlParams);
            

        }
        //更新房间信息
        public void update(Model.room my)
        {
            string sql = "update room set roomabb=@roomabb,roomfee=@roomfee,roomlocation=@roomlocation Where roomname=@roomname ";
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@roomname", my.Roomname));
            sqlParams.Add(new SqlParameter("@roomabb", my.Roomabb));
            sqlParams.Add(new SqlParameter("@roomfee", my.Roomfee));
            sqlParams.Add(new SqlParameter("@roomlocation", my.Roomlocation));
            co.ExecuteSql(sql, sqlParams);
        }
        //删除房间
        public void delete(string Roomname)
        {
            String sql = "delete from room where roomname=@roomname";
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@roomname", Roomname));
            co.ExecuteSql(sql, sqlParams);
        }
        //显示房间列表
        public DataTable getlist(string strWhere)
        {
            string sql = "select id,roomname,roomjc,roombjf,roomwz from Room";
            if (strWhere != "")
            {
                sql += "where" + strWhere;

            }
            return co.query(sql);
        }
        public DataSet select(string strwhere)
        {
            string sql = "select * from Room ";
            if (strwhere != "")
                sql += " where " + strwhere;
            return co.getds(sql);
        }
    }
}
