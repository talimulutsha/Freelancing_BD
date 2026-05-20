using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fbd
{
    public partial class admin : Form
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=fbd;Integrated Security=True";

        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adminId = textBox3.Text;
            string adminPass = textBox4.Text;

            if (string.IsNullOrWhiteSpace(adminId) ||
                string.IsNullOrWhiteSpace(adminPass))
            {
                MessageBox.Show("Please enter ID and Password.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM dbo.admin WHERE id = @id AND [password] = @password", con);

                    cmd.Parameters.AddWithValue("@id", adminId);
                    cmd.Parameters.AddWithValue("@password", adminPass);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Admin Login Successful!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        admin_dashboard dashboard = new admin_dashboard();
                        this.Hide();
                        dashboard.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or Password.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}