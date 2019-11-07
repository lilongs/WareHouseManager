using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DALayer
{
    public class DAAboutInfo
    {
        Sqlconn mySqlconn = new Sqlconn();
        public DataSet GetAboutInfo()
        {
            string str = "select System_Name,Version,CopyRight,Company,Description from AboutInfo";
            DataSet ds = new DataSet();
            ds = mySqlconn.Query(str);
            return ds;
        }
    }
}
