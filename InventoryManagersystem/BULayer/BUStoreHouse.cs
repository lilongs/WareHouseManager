using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DALayer;


namespace BULayer
{
    public class BUStoreHouse
    {
        DAStoreHouse dal = new DAStoreHouse();

        /// <summary>
        /// 查询仓库
        /// </summary>
        /// <param name="paramInventID"></param>
        /// <returns></returns>
        public DataSet GetStoreHousInfo(string StoreHouseId)
        {
            return dal.GetStoreHousInfo(StoreHouseId);
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
            return dal.InsertHouse(paramStoreHouse_ID, paramRemark, paramAddress);
        }

        /// <summary>
        /// 删除库房
        /// </summary>
        /// <param name="paramStoreHouse_ID"></param>
        /// <returns></returns>
        public int DeleteHouse(string paramStoreHouse_ID)
        {
            return dal.DeleteHouse(paramStoreHouse_ID);
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
            return dal.UpdateHouse(paramStoreHouse_ID, paramRemark, paramAddress);
        }


        public DataTable GetLocationByHouseId(string StoreHouseId)
        {
            return dal.GetLocationByHouseId(StoreHouseId);
        }

        public DataTable GetLocationNOInfo(string StoreHouseID)
        {
            return dal.GetLocationNOInfo(StoreHouseID);
        }

        public bool IsExistsLocationNO(string StoreHouseID, string LocationNo)
        {
            return dal.IsExistsLocationNO(StoreHouseID, LocationNo);
        }

        public bool InsertLocationNo(string StoreHouseID, string LocationNo)
        {
            return dal.InsertLocationNo(StoreHouseID, LocationNo);
        }

        public bool UpdateLocationNo(string ID, string StoreHouseID, string LocationNo)
        {
            return dal.UpdateLocationNo(ID, StoreHouseID, LocationNo);
        }

        public bool DeleteLocationNo(string ID)
        {
            return dal.DeleteLocationNo(ID);
        }
    }
}
