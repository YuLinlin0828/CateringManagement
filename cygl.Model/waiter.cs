using System;
using System.Collections.Generic;
using System.Text;

namespace cygl.Model
{
    public class waiter
    {
        public string id;
        public string waitername;
        public string sex;
        public string age;
        public string idcard;
        public string tel;

        public string Id
        {
            set { id = value; }
            get { return id; }

        }
        public string Waitername
        {
            set { waitername = value; }
            get { return waitername; }
        }
        public string Sex
        {
            set { sex = value; }
            get { return sex; }
        }
        public string Age
        {
            set { age = value; }
            get { return age; }
        }
        public string Idcard
        {
            set { idcard = value; }
            get { return idcard; }
        }
        public string Tel
        {
            set { tel = value; }
            get { return tel; }
        }
    }
}
