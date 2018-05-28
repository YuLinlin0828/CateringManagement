using System;
using System.Collections.Generic;
using System.Text;

namespace cygl.Model
{
    public class room
    {
        public string id;//房间标号
        public string roomname;//房间名称
        public string roomabb;//房间简称
        public string roomfee;//房间包间费
        public string roomlocation;//房间位置
        public string roomstate;//房间状态

        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Roomname
        {
            set { roomname = value; }
            get { return roomname; }
        }
        public string Roomabb
        {
            set { roomabb = value; }
            get { return roomabb; }
        }
        public string Roomfee
        {
            set { roomfee = value; }
            get { return roomfee; }
        }
        public string Roomlocation
        {
            set { roomlocation = value; }
            get { return roomlocation; }
        }
        public string Roomstate
        {
            set { roomstate = value; }
            get { return roomstate; }
        }
        
    }
}
