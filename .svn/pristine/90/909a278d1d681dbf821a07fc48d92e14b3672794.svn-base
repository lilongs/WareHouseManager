using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using DALayer;

namespace BULayer
{
    public class KSRCommonUtils
    {
        public static string GetServerTimeString()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select GetDate() as serverdate  ");
            Sqlconn theTestDb = new Sqlconn();
            
            DataSet theDs = theTestDb.Query(strSql.ToString());
            return theDs != null ? theDs.Tables[0].Rows[0][0].ToString() : null;
        }

        public static DateTime GetServerTime()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select GetDate() as serverdate  ");
            Sqlconn theTestDb = new Sqlconn();

            DataSet theDs = theTestDb.Query(strSql.ToString());
            if(theDs != null && theDs.Tables.Count != 0)
                return DateTime.Parse(theDs.Tables[0].Rows[0][0].ToString());
            else
                return DateTime.Now;
        }

        public static DataSet GetExcelData(string aFileName, string aSheetName)
        {
            if(!File.Exists(aFileName))
                return null;

            string theSheet = string.Format("[{0}$]", aSheetName);
            string theExcelConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + aFileName + ";Extended Properties='Excel 12.0 Xml;HDR=YES'";
            System.Data.OleDb.OleDbConnection theConn = null;
            try
            {
                theConn = new System.Data.OleDb.OleDbConnection(theExcelConn);
                string strCom = "SELECT * FROM  " + theSheet + "";
                theConn.Open();
                System.Data.OleDb.OleDbDataAdapter myCommand = new System.Data.OleDb.OleDbDataAdapter(strCom, theConn);
                DataSet theDs = new DataSet();
                myCommand.Fill(theDs, theSheet);
                return theDs;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(theConn != null)
                    theConn.Close();
            }
        }

        public static int GetColumnIndex(DataColumnCollection aColumns, string aColumnTag)
        {
            for(int it = 0, itCount = aColumns.Count; it < itCount; it++)
            {
                if(string.Compare(aColumns[it].ColumnName.Trim(), aColumnTag, true) == 0)
                    return it;
            }
            return -1;
        }
    }
}
