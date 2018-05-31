using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.util
{

    class Dbutil
    {

        private const string con228 = "server=172.16.10.228;database=ittools;user=sa;pwd=123456";

        public static Dictionary<int, string> dic = new Dictionary<int, string>();

        static Dbutil()
        {
            dic.Add(228, con228);
        }

        public static SqlConnection getSQLServerConnection(int key)
        {
            return ConSqlServer.getConnection(dic[228]);
        }

        public static void closeSQLServer(SqlConnection conn)
        {
            ConSqlServer.close(conn);
        }

        public static ArrayList query(SqlCommand cmd)
        {
            return ConSqlServer.query(cmd);
        }

        private class ConSqlServer
        {
            public static SqlConnection getConnection(string connStr)
            {
                SqlConnection conn = new SqlConnection(connStr);
                return conn;
            }


            public static void close(SqlConnection conn)
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }

            public static ArrayList query(SqlCommand cmd)
            {
                SqlDataAdapter adapter = null;
                DataTable dt = null;
                ArrayList list = new ArrayList();
                try
                {
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        Hashtable ht = new Hashtable();
                        foreach (DataColumn col in dt.Columns)
                        {
                            ht.Add(col.ColumnName, row[col]);
                        }
                        list.Add(ht);
                    }
                    return list;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    if(adapter != null ) adapter.Dispose();
                    if (dt != null)
                    {
                        dt.Clear();
                        dt.Dispose();
                    }
                   
                }
            }
        }
    }

    
}
