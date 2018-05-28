using System;
using System.Collections.Generic;
using System.Text;
using cygl.DAL;
using cygl.Model;
using System.Data;
using System.Data.SqlClient;

namespace cygl.BLL
{
    public class room
    {
        cygl.DAL.room ro = new cygl.DAL.room();
        public void insert(Model.room myu)
        {
            ro.insert(myu);
        }
        public void update(Model.room myu)
        {
            ro.update(myu);
        }
        public void delete(String Id)
        {
            ro.delete(Id);
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
