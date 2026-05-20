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
    public partial class client_signup : Form
    {
        public client_signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(cid.Text) ||
                    string.IsNullOrWhiteSpace(cname.Text) ||
                    string.IsNullOrWhiteSpace(cpassword.Text))
                {
                    MessageBox.Show(
                        "Please fill all fields.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Connection String
                string connectionString =
                    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=fbd;Integrated Security=True";

                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO table_2
            (
                id,
                companyname,
                cpassword
            )
            VALUES
            (
                @id,
                @companyname,
                @cpassword
            )";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", cid.Text);

                        command.Parameters.AddWithValue("@companyname", cname.Text);

                        command.Parameters.AddWithValue("@cpassword", cpassword.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show(
                            "Client signup successful!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // Clear textboxes
                        cid.Clear();
                        cname.Clear();
                        cpassword.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            client_login clilog = new client_login();
            this.Hide();
            clilog.ShowDialog();
            this.Show();
        }
    }
}
