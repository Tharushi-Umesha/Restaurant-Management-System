using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public partial class CategoryForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tharushi umesha\OneDrive - Edith Cowan University\Documents\RestaurantManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30";
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void category_addBtn_Click(object sender, EventArgs e)
        {
            if(category_category.Text == "" || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields", "Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    
                    string selectCategory = "SELECT * FROM category WHERE category = @category";

                    using (SqlCommand checkCategory = new SqlCommand(selectCategory, conn))
                    {
                        checkCategory.Parameters.AddWithValue("@category", category_category.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkCategory);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(category_category.Text.Trim() + "is already existing in the db", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO category (category, status, date_insert) VALUES (@category, @status, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, conn))
                            {
                                cmd.Parameters.AddWithValue("@category", category_category.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", category_status.SelectedItem.ToString());

                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Category Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                    }
                }

            }
                
        }

        void clearFields()
        {
            category_category.Clear();
            category_status.SelectedIndex = -1;
        }

        private void category_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
