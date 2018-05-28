using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using cygl.Helper;
using cygl.Model;

namespace cygl.DAL
{
    public class user
    {
        Helper.DBHelper co = new DBHelper();
        //查询用户是否存在
        public int ExistsUsers(Model.user users)
        {
            string sqlTest = "select count(*) from users where name=@name and pwd=@pwd";
            SqlParameter[] par = new SqlParameter[2]
            {
                new SqlParameter("@name",users .Name),
                new SqlParameter ("@pwd",users .Pwd)
            };

            object obj = DBHelper.ExecuteScalar(sqlTest, par);
            return int.Parse(obj.ToString());//返回类型的完整名称并转化为32进制整型数
        }
        //查询用户ID
        public object QueryAdminID(Model.user user)
        {
            string sqlTest =
                    @"select id from users where name=@name and pwd=@pwd";
            SqlParameter[] par =
            {
                new SqlParameter ("@name",user .Name),
                new SqlParameter ("@pwd",user .Pwd)
            };
            return DBHelper.ExecuteScalar(sqlTest, par);
        }
        //添加用户
        public void insert(Model.user my)
        {
            String sql = "insert into users(name,pwd)values(@name,@pwd)";
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@name", my.Name));
            sqlParams.Add(new SqlParameter("@pwd", my.Pwd));
            co.ExecuteSql(sql, sqlParams);
        }
        //更新用户信息
        public void update(Model.user my)
        {
            String sql = "update users set name=@name,pwd=@pwd where name=@name";
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@name", my.Name));
            sqlParams.Add(new SqlParameter("@pwd", my.Pwd));
            co.ExecuteSql(sql, sqlParams);
        }
        //删除用户信息
        public void delete(Model.user my)
        {
            String sql = "delete from users where name=@name";
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@name",my.Name));
            co.ExecuteSql(sql, sqlParams);
        }
        //获取用户列表
        public DataTable getlist(string strWhere)
        {
            string sql = "select * from users";

            if (strWhere != "")
            {
                sql += "where" + strWhere;


            }
            return co.query(sql);
        }
        public DataSet select(string strwhere)
        {
            string sql = "select * from users ";
            if (strwhere != "")
                sql += " where " + strwhere;
            return co.getds(sql);
        }
    }
}
