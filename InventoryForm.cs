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

namespace RestaurantManagementSystem
{
    public partial class InventoryForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tharushi umesha\OneDrive - Edith Cowan University\Documents\RestaurantManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30";
        public InventoryForm()
        {
            InitializeComponent();
            displayCategoryList();
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
    }
}
