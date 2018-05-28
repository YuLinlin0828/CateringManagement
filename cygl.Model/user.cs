using System;
using System.Collections.Generic;
using System.Text;

namespace cygl.Model
{
    public class user
    {
        public int id;
        public string name;
        public string pwd;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
      

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
    }
}
