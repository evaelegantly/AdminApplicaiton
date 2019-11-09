using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Web1
{
    public class Storevalue
    {
        public static  SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static string connString = @"Data Source=DESKTOP-J12F5GP\sqlexpress;Initial Catalog=16ThingsDB;Integrated Security=True";
        public static SqlCommand com = new SqlCommand();
        public static int pos;

        public void load()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                    string sqlSelectQuery = "select * from students";  
                    adapter = new SqlDataAdapter(sqlSelectQuery, con);
                    adapter.Fill(dt);
            }
        }

        public void adapt(SqlDataAdapter adt)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                adapter = adt;
                adapter.Fill(dt);
            }
        }

        public void increamental()
        {
            pos++;
        }

        public void decrease()
        {
          pos--;
         }
        public void Pos()
        {
            pos = 0;
        }

        public void posLess()
        {
            pos = dt.Rows.Count - 1;
        }
        
    }
}
