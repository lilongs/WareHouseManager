using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DALayer
{
    public class DAStoreHouse
    {
        Sqlconn mySqlconn = new Sqlconn();

        /// <summary>
        /// 查询仓库
        /// </summary>
        /// <param name="StoreHouseId"></param>
        /// <returns></returns>
        public DataSet GetStoreHousInfo(string StoreHouseId)
        {
            string Sql = string.Empty;
            Sql = "select * from store_house where  1=1";
            if (StoreHouseId.Length > 0)
            {
                Sql += " and  store_house_id like '%" + StoreHouseId + "%'";
            }
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(Sql);
            return myDs;
        }

        /// <summary>
        /// 新增库存信息
        /// </summary>
        /// <param name="paramStoreHouse_ID"></param>
        /// <param name="paramRemark"></param>
        /// <param name="paramAddress"></param>
        /// <returns></returns>
        public int InsertHouse(string paramStoreHouse_ID, string paramRemark, string paramAddress)
        {
            string Sql = string.Empty;
            string str = string.Empty;
            str = "select * from  store_house where store_house_id='" + paramStoreHouse_ID + "'";
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(str);
            if (myDs.Tables[0].Rows.Count > 0)
            {
                return -1;      //返回-1，store_house表中已存在该store_house_id
            }
            else
            {
                Sql = "insert into store_house (store_house_id,Remark,Address,create_date)values('" + paramStoreHouse_ID + "','" + paramRemark + "','" + paramAddress + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                int i = mySqlconn.ExecuteNonQuery(Sql);
                return i;
            }
        }

        /// <summary>
        /// 删除库房
        /// </summary>
        /// <param name="paramStoreHouse_ID"></param>
        /// <returns></returns>
        public int DeleteHouse(string paramStoreHouse_ID)
        {
            
            string Sql = string.Empty;
            int i=0;
            Sql = "delete from store_house where store_house_id='"+paramStoreHouse_ID+"'";
            i = mySqlconn.ExecuteNonQuery(Sql);
            return i;
           
        }

        /// <summary>
        /// 更新库房信息
        /// </summary>
        /// <param name="paramInventID"></param>
        /// <param name="paramRemark"></param>
        /// <param name="paramAddress"></param>
        /// <returns></returns>
        public int UpdateHouse(string paramStoreHouse_ID, string paramRemark, string paramAddress)
        {
            string Sql = string.Empty;
            Sql = "update store_house set address='" + paramAddress + "',remark='" + paramRemark + "',create_date=getdate() where store_house_id='" + paramStoreHouse_ID + "' ";
            int i = mySqlconn.ExecuteNonQuery(Sql);
            return i;
        }

        public DataTable GetLocationByHouseId(string StoreHouseId)
        {
            StringBuilder str = new StringBuilder();
            str.Append("select * from store_house_location where 1=1");
            if (String.IsNullOrEmpty(StoreHouseId))
            {
                str.Append(" and store_house_id='"+StoreHouseId+"'");
            }
            return mySqlconn.Query(str.ToString()).Tables[0];
        }

        public DataTable GetLocationNOInfo(string StoreHouseID)
        {
            string sql = @"select * from store_house_location
                        where store_house_id like '%"+StoreHouseID+"%'";
            return mySqlconn.Query(sql).Tables[0];
        }

        public bool IsExistsLocationNO(string StoreHouseID,string LocationNo)
        {
            string sql = "select count(id) from store_house_location where store_house_id='"+StoreHouseID+"' and location_no='"+LocationNo+"'";
            return mySqlconn.Exists(sql);
        }

        public bool InsertLocationNo(string StoreHouseID, string LocationNo)
        {
            string sql = @"insert into store_house_location(location_no, store_house_id)
                        values('"+ LocationNo + "', '"+ StoreHouseID + "')";
            return mySqlconn.ExeNonQuery(sql) > 0 ? true : false;
        }

        public bool UpdateLocationNo(string ID,string StoreHouseID, string LocationNo)
        {
            string sql = @"update store_house_location set location_no='"+ LocationNo + "', store_house_id='"+ StoreHouseID + @"'
                        where id='" + ID + "'";
            return mySqlconn.ExeNonQuery(sql) > 0 ? true : false;
        }

        public bool DeleteLocationNo(string ID)
        {
            string sql = @"delete from store_house_location where id='" + ID + "'";
            return mySqlconn.ExeNonQuery(sql) > 0 ? true : false;
        }
    }
}
