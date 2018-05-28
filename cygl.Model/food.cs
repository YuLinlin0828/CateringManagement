using System;
using System.Collections.Generic;
using System.Text;

namespace cygl.Model
{
     public class food
    {
        public string id;//食物id
        public string foodtype;//食物类型
        public string foodnum;//食物数量
        public string foodname;//食物名称
        public string foodprice;//食物价格
        //get读属性代码 set写属性代码
        //以下属性读写都是允许的
        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Foodtype
        {
            set { foodtype = value; }
            get { return foodtype; }

        }
        public string Foodnum
        {
            set { foodnum = value; }
            get { return foodnum; }
        }
        public string Foodname
        {
            set { foodname = value; }
            get { return foodname; }

        }
        public string Foodprice
        {
            set { foodprice = value; }
            get { return foodprice; }
        }
    }
}
