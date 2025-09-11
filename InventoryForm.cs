using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace RestaurantManagementSystem
{
    public partial class InventoryForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tharushi umesha\OneDrive - Edith Cowan University\Documents\RestaurantManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30";
        public InventoryForm()
        {
            InitializeComponent();
            displayCategoryList();
            clearFields();
        }

        public void displayCategoryList()
        {
            inventory_category.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string selectCategory = "SELECT * FROM category WHERE status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(selectCategory, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                       
                        inventory_category.Items.Add(reader["category"]);
                    }

                }
            }
        }

        private void inventory_updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void inventory_imgImportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All Files (*.*)|*.*";

                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inventory_addBtn_Click(object sender, EventArgs e)
        {
            if(inventory_productID.Text == "" || inventory_productName.Text == "" || inventory_category.SelectedIndex == -1|| inventory_stock.Text == "" || inventory_price.Text == "" || inventory_status.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string checkProductId = "SELECT * FROM products WHERE product_id = @product_id";

                    using(SqlCommand checkProdId = new SqlCommand(checkProductId, connect))
                    {
                        checkProdId.Parameters.AddWithValue("product_id", inventory_productID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkProdId);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        if(dataTable.Rows.Count != 0)
                        {
                            MessageBox.Show($"{inventory_productID.Text.Trim()} already existing", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string insertData = "INSERT INTO products (product_id, product_name, category, stock, price, status, image, date_inserted)" + "VALUES (@product_id, @product_name, @category, @stock, @price, @status, @image, @date_inserted)";
                            string relativePath = Path.Combine("product_directory", inventory_productID.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);
                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(pictureBox1.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@product_id", inventory_productID.Text.Trim());
                                cmd.Parameters.AddWithValue("@product_name", inventory_productName.Text.Trim());
                                cmd.Parameters.AddWithValue("@category", inventory_category.SelectedIndex.ToString());
                                cmd.Parameters.AddWithValue("@stock", inventory_stock.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", inventory_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", inventory_status.SelectedIndex.ToString());
                                cmd.Parameters.AddWithValue("@image", path);

                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date_inserted", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();


                            }
                        }

                    }

                }
            }

        }

        void clearFields()
        {
            inventory_productID.Clear();
            inventory_productName.Clear();
            inventory_category.SelectedIndex = -1;
            inventory_stock.Clear();
            inventory_price.Clear();
            inventory_status.SelectedIndex = -1;
            pictureBox1.Image = null; 
        }

        private void inventory_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
