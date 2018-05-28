using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace cygl.Helper
{
    public class DBHelper
    {
        //连接数据库方法
        public static SqlConnection getconn()
        {
            //SqlConnection conn = new SqlConnection("server=.;database=cygl;uid=sa;pwd=sa;integrated security=true");
            //数据库是本机，数据库名称cygl，SSPI(Security Support Provider Interface，安全性支持提供者接口）
            SqlConnection conn = new SqlConnection("server=.;database=cygl;Trusted_Connection=SSPI");
            return conn;
        }
       
        
        //重载ExcuteScalar函数，执行SQL语句，返回结果集中的第一行的第一列的Object类型对象，用于查询操作
        public static object ExecuteScalar(string sqlText, SqlParameter[] pars)
        {
            using (SqlConnection conn = getconn())
            {
                //打开数据库连接
                conn.Open();
                //两个参数，一个是SQL语句、表或存储过程，一个是SqlServer实例连接
                SqlCommand cmd = new SqlCommand(sqlText, conn);
                if (pars != null)
                {
                    //添加多个sql参数
                    cmd.Parameters.AddRange(pars);
                }
                object obj = cmd.ExecuteScalar();
                conn.Close();
                return obj;
            }
        }
        //重载ExcuteNonQuery函数，执行SQL语句，并返回整型的受影响的行数，用于执行增加、删除、修改，无参数
        public void ExecuteSql(string sql)
        {
            SqlConnection conn = getconn();
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        //重载ExcuteNonQuery函数，执行SQL语句，并返回整型的受影响的行数，用于执行增加、删除、修改，有参数
        public void ExecuteSql(string sql, List<SqlParameter> param)
        {
            SqlConnection conn = getconn();
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            for (int i = 0; i < param.Count; i++)
            {
                comm.Parameters.Add(param[i]);
            }
            comm.ExecuteNonQuery();
            conn.Close();
        }
        //获得数据集
        public DataSet getds(string sql)
        {
            SqlConnection conn = getconn();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            //向数据集内添加数据表
            da.Fill(ds);
            return ds;
        }
        //用于查询操作
        public DataTable query(string sql)
        {
            SqlConnection conn = getconn();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];//表集合属性

        }
    }
}
