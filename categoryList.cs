using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    class categoryList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tharushi umesha\OneDrive - Edith Cowan University\Documents\RestaurantManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }

        public string category { set; get; }
        public string status {  set; get; }
        public string DateInsert { set; get; }

        public List<categoryList> categoryListData()
        {
            List<categoryList> listData = new List<categoryList>();

            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string selectData = "SELECT * FROM category";

                using(SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        categoryList cData = new categoryList();
                        cData.ID = (int)reader["ID"];
                        cData.category = reader["Category"].ToString();
                        cData.status = reader["status"].ToString();
                        cData.DateInsert = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);
                    }
                }
            }

            return listData;
        }
    }
}
