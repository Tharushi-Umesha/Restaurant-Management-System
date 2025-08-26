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
            displayCategoryList();
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
                                displayCategoryList();
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

        public void displayCategoryList()
        {
            categoryList cData = new categoryList();
            List<categoryList> listData = cData.categoryListData();

            dataGridView1.DataSource = listData;
        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                category_category.Text = row.Cells[1].Value.ToString();
                category_status.Text = row.Cells[2].Value.ToString();
            }

        }

        private void category_updateBtn_Click(object sender, EventArgs e)
        {
            if(getID == 0)
            {
                MessageBox.Show("Select the item first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show($"Are you sure you want to update this ID : {getID} ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using(SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();

                        string updateData = "UPDATE category SET category =@category, status =@status WHERE id =@id";

                        using(SqlCommand cmd =  new SqlCommand(updateData, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@category", category_category.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", category_status.SelectedItem.ToString());

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show($"{getID} has been updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        conn.Close();
                    }
                }
            }
            displayCategoryList();
        }

        private void category_deleteBtn_Click(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Select the item first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to update this ID : {getID} ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();

                        string updateData = "DELETE FROM category WHERE id =@id";

                        using (SqlCommand cmd = new SqlCommand(updateData, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show($"{getID} has been deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        conn.Close();
                    }
                }
            }
            displayCategoryList();

        }
    }
}
