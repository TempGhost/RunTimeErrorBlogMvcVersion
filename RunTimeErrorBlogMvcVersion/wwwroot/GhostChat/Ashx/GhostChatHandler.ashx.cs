using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Text;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;


namespace WebSiteHandler.Ashx
{
    /// <summary>
    /// GhostChatHandler 的摘要说明
    /// </summary>
    public class GhostChatHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        { 
            
            context.Response.ContentType = "text/plain";
            string result = "Error!";
            if (context.Request["Action"] != null && context.Request["Action"] != "")
            {
                
                OracleConnection OracleConn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=Yellow)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=GhostChatDb)));;User ID=System;Password=nimadepo;"); 
                OracleConn.Open();
                OracleCommand Ocb = new OracleCommand();
                OracleCommand OComm = new OracleCommand("select * from c_user", OracleConn);
                OracleDataReader Odr = OComm.ExecuteReader();
                DataTable Dt = new DataTable();
                Dt.Load(Odr);
                StringBuilder Sb = new StringBuilder();
                Sb.Append("{");
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    Sb.Append("'User':"+"'"+Dt.Rows[i]["Name"]+"'");
                }
                Sb.Remove(Sb.Length - 1, 1);
                Sb.Append("}");
                result = Sb.ToString();
            }
            context.Response.Write(result);
         }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}