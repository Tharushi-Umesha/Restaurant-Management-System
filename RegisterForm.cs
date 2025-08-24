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
    public partial class RegisterForm : Form
    {

        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\tharushi umesha\OneDrive - Edith Cowan University\Documents\RestaurantManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30";
        public RegisterForm()
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

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void register_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPassword.Checked ? '\0' : '*';
            register_confirmPassword.PasswordChar = register_showPassword.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string checkUsernameQuery = "SELECT * FROM users WHERE username = @username";

                using (SqlCommand checkUsername = new SqlCommand(checkUsernameQuery, conn))
                {
                    checkUsername.Parameters.AddWithValue("@username", register_username.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if(table.Rows.Count != 0)
                    {
                        MessageBox.Show($"{register_username.Text.Trim()} was already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }else if(register_password.Text.Trim().Length < 8)
                    {
                        MessageBox.Show("Invalid Password, at least 8 characters needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }else if(register_password.Text.Trim() != register_confirmPassword.Text.Trim())
                    {
                        MessageBox.Show("Passwords are not matching", "Error Message",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertData = "INSERT INTO users (username, password, status, date_created) VALUES (@username, @password, @status, @date)";

                        using(SqlCommand cmd = new SqlCommand(insertData, conn))
                        {
                            cmd.Parameters.AddWithValue ("@username", register_username.Text.Trim());
                            cmd.Parameters.AddWithValue ("@password", register_password.Text.Trim());
                            cmd.Parameters.AddWithValue ("@status", "Active");

                            DateTime today = DateTime.Now;
                            cmd.Parameters.AddWithValue ("@date", today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Register User Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
