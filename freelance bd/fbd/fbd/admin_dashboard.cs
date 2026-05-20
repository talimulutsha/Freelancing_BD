using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fbd
{
    public partial class admin_dashboard : Form
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=fbd;Integrated Security=True";

        public admin_dashboard()
        {
            InitializeComponent();
        }

        private void btnLoadFreelancer_Click(object sender, EventArgs e)
        {
            LoadTable("profilef");
        }

        private void btnLoadClient_Click(object sender, EventArgs e)
        {
            LoadTable("table_2");
        }

        private void LoadTable(string tableName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM " + tableName;
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Select a row first.");
                    return;
                }

                string tableName = "";
                if (dataGridView1.Columns.Contains("gmail"))
                    tableName = "profilef";
                else
                    tableName = "table_2";

                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM " + tableName + " WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!");
                    LoadTable(tableName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit directly in DataGridView then reload table.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}