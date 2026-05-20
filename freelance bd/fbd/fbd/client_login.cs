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

namespace fbd
{
    public partial class client_login : Form
    {
        public client_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(cid.Text) ||
                    string.IsNullOrWhiteSpace(cpassword.Text))
                {
                    MessageBox.Show(
                        "Please enter ID and Password.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                string connectionString =
                    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=fbd;Integrated Security=True";

                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT COUNT(*) 
                             FROM table_2
                             WHERE id = @id
                             AND cpassword = @cpassword";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", cid.Text);

                        command.Parameters.AddWithValue("@cpassword", cpassword.Text);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show(
                                "Login Successful!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            job j = new job();
                            this.Hide();
                            j.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid ID or Password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
