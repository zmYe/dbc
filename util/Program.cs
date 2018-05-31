using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=localhost;database=MvcWeb;user=sa;pwd=1";
            SqlConnection conn = new SqlConnection(connStr);

            //query(conn);
            queryAdapter(conn);

            //Class1 cls1 = new Class1();
            //cls1.test();
           // new Class2();
            Console.Read();

           // new Class3();
        }

        static void query(SqlConnection conn)
        {
            string sql = "select * from aa";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                object[] obj = new object[reader.FieldCount];
                for (int i = 0; i < obj.Length; i++)
                {
                    Console.Write(reader.GetName(i) + "\t");
                }
                Console.WriteLine();
                while (reader.Read())
                {
                    reader.GetValues(obj);

                    Console.Write(reader["id"] + "\t");
                    Console.Write(reader["uname"] + "\t");

                    //foreach (object o in obj)
                    //{
                    //    Console.Write(o.ToString() + "\t\t");

                    //}
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();

            }
        }

        static void queryAdapter(SqlConnection conn)
        {
            string sql = "select * from aa";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();
                //adapter.Fill(ds, "abc");
                //foreach (DataTable dt in ds.Tables)
                //{
                //    Console.WriteLine(dt.TableName);
                //    foreach (DataColumn col in dt.Columns)
                //    {
                //        Console.Write(col.ColumnName + "\t");
                //    }
                //    Console.WriteLine();


                //    foreach (DataRow row in dt.Rows)
                //    {
                //        foreach (DataColumn col in dt.Columns)
                //        {
                //            Console.Write(row[col] + "\t");
                //        }

                //        Console.WriteLine();
                //    }
                //}

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ArrayList list = new ArrayList();
                foreach (DataRow row in dt.Rows)
                {
                    Hashtable ht = new Hashtable();
                    foreach (DataColumn col in dt.Columns)
                    {
                        ht.Add(col.ColumnName, row[col]);
                    }
                    list.Add(ht);
                }
                Console.Write(list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {

                if (conn != null) conn.Close();
            }
           
        }

    }
}
