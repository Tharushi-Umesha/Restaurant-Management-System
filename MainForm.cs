using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            shopForm1.Visible = false;
            inventoryForm1.Visible = false;
            categoryForm1.Visible = false;
            customersForm1.Visible = false;
        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = true;
            inventoryForm1.Visible = false;
            categoryForm1.Visible = false;
            customersForm1.Visible = false;
        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventoryForm1.Visible = true;
            categoryForm1.Visible = false;
            customersForm1.Visible = false;
        }

        private void category_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventoryForm1.Visible = false;
            categoryForm1.Visible = true;
            customersForm1.Visible = false;
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventoryForm1.Visible = false;
            categoryForm1.Visible = false;
            customersForm1.Visible = true;
        }
    }
}
