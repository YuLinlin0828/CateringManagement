using System;
using System.Collections.Generic;
using System.Text;
using cygl.DAL;
using cygl.Model;
using System.Data;
using System.Data.SqlClient;

namespace cygl.BLL
{
    public class food
    {
        DAL.food my = new DAL.food();
        public void insert(Model.food myu)
        {
            my.insert(myu);
        }
        public void update(Model.food myu)
        {
            my.update(myu);
        }
        public void delete(string foodname)
        {
            my.delete(foodname);
        }
        public DataSet select(string strWhere)
        {
            return my.select(strWhere);
        }
        public DataTable getlist(string strWhere)
        {
            return my.getlist(strWhere);
        }
    }
}
