using System;
using System.Collections.Generic;
using System.Text;
using cygl.DAL;
using cygl.Model;
using System.Data;
using System.Data.SqlClient;

namespace cygl.BLL
{
    public class waiter
    {
        cygl.DAL.waiter ro = new cygl.DAL.waiter();
        public void insert(Model.waiter myu)
        {
            ro.insert(myu);
        }
        public void update(Model.waiter myu)
        {
            ro.update(myu);
        }
        public void delete(string waitername)
        {
            ro.delete(waitername);
        }
        public DataSet select(string strWhere)
        {
            return ro.select(strWhere);
        }
        public DataTable getlist(string strWhere)
        {
            return ro.getlist(strWhere);
        }
    }
}
