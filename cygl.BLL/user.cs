using System;
using System.Collections.Generic;
using System.Text;
using cygl.DAL;
using cygl.Model;
using System.Data;
using System.Data.SqlClient;

namespace cygl.BLL
{
    public class user
    {
        cygl.DAL.user us = new cygl.DAL.user();
        public string QueryAdminID(Model.user user)
        {
            object obj = us.QueryAdminID(user);
            return obj.ToString();
        }
        public bool ExistsUsers(Model.user users)
        {
            int n = us.ExistsUsers(users);
            if (n > 0)
            {
                return true;
            }
            return false;

        }
        public void insert(Model.user myu)
        {
            us.insert(myu);
        }
        public void update(Model.user myu)
        {
            us.update(myu);
        }
        public void delete(Model.user myu)
        {
            us.delete(myu);
        }
        public DataSet select(string strWhere)
        {
            return us.select(strWhere);
        }
        public DataTable getlist(string strWhere)
        {
            return us.getlist(strWhere);
        }
    }
}
