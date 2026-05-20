using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fbd
{
    public partial class Form2 : Form
    {
        private string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=fbd;Integrated Security=True";

        // Store selected image path
        private string picturePath = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        // ESC button closes form
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                OnKeyDown(new KeyEventArgs(keyData));
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Upload Image
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd1 = new OpenFileDialog();

            openfd1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openfd1.ShowDialog() == DialogResult.OK)
            {
                picturePath = openfd1.FileName;

                pictureBox1.Image = Image.FromFile(picturePath);

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        // Limit skill selection to 5
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (checkedListBox1.CheckedItems.Count >= 5)
                {
                    MessageBox.Show("You can select only 5 skills.");
                    e.NewValue = CheckState.Unchecked;
                }
            }
        }

        // INSERT PROFILE
        private void button3_Click(object sender, EventArgs e)
        {
            // SQL insert uses dbo.profilef to match database table naming
            string query = @"INSERT INTO dbo.profilef
            (
                name,
                email,
                phone,
                skills,
                picture
            ) VALUES (
                @name,
                @email,
                @phone,
                @skills,
                @picture
            )";
        }

        // UPDATE PROFILE
        private void button4_Click(object sender, EventArgs e)
        {
            // SQL update uses dbo.profilef to match database table naming
            string query = @"UPDATE dbo.profilef SET
                name = @name,
                email = @email,
                phone = @phone,
                skills = @skills,
                picture = @picture
            WHERE id = @id";
        }

        // Get checked skills
        private string GetCheckedItems()
        {
            StringBuilder skills = new StringBuilder();

            foreach (object item in checkedListBox1.CheckedItems)
            {
                if (skills.Length > 0)
                {
                    skills.Append(", ");
                }

                skills.Append(item.ToString());
            }

            return skills.ToString();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFormInput())
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"INSERT INTO dbo.profilef
                        (
                            firstname,
                            lastname,
                            username,
                            phone,
                            dob,
                            gender,
                            country,
                            address,
                            language,
                            title,
                            skills,
                            experience,
                            rate,
                            portfolio,
                            github,
                            linkedin,
                            university,
                            degree,
                            department,
                            graduationyear,
                            image
                        )
                        VALUES
                        (
                            @firstname,
                            @lastname,
                            @username,
                            @phone,
                            @dob,
                            @gender,
                            @country,
                            @address,
                            @language,
                            @title,
                            @skills,
                            @experience,
                            @rate,
                            @portfolio,
                            @github,
                            @linkedin,
                            @university,
                            @degree,
                            @department,
                            @graduationyear,
                            @image
                        )";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@firstname", firstname.Text);
                            command.Parameters.AddWithValue("@lastname", lastname.Text);
                            command.Parameters.AddWithValue("@username", textBox21.Text);
                            command.Parameters.AddWithValue("@phone", phone.Text);
                            command.Parameters.AddWithValue("@dob", dob.Text);
                            command.Parameters.AddWithValue("@gender", gender.Text);
                            command.Parameters.AddWithValue("@country", country.Text);
                            command.Parameters.AddWithValue("@address", address.Text);
                            command.Parameters.AddWithValue("@language", language.Text);
                            command.Parameters.AddWithValue("@title", title.Text);
                            command.Parameters.AddWithValue("@skills", GetCheckedItems());
                            command.Parameters.AddWithValue("@experience", experience.Text);
                            command.Parameters.AddWithValue("@rate", Convert.ToDecimal(rate.Value));
                            command.Parameters.AddWithValue("@portfolio", portfolio.Text);
                            command.Parameters.AddWithValue("@github", github.Text);
                            command.Parameters.AddWithValue("@linkedin", linkedin.Text);
                            command.Parameters.AddWithValue("@university", university.Text);
                            command.Parameters.AddWithValue("@degree", degree.Text);
                            command.Parameters.AddWithValue("@department", department.Text);
                            command.Parameters.AddWithValue("@graduationyear", Convert.ToInt32(graduationyear.Text));
                            command.Parameters.AddWithValue("@image", picturePath);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Profile inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format. Please check graduation year and hourly rate.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFormInput()
        {
            if (string.IsNullOrWhiteSpace(firstname.Text))
            {
                MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(lastname.Text))
            {
                MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox21.Text))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(phone.Text))
            {
                MessageBox.Show("Phone is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(gender.Text))
            {
                MessageBox.Show("Gender is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(country.Text))
            {
                MessageBox.Show("Country is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(address.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (skills.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select at least one skill.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            firstname.Clear();
            lastname.Clear();
            textBox21.Clear();
            phone.Clear();
            dob.Clear();
            address.Clear();
            language.Clear();
            title.Clear();
            experience.Clear();
            portfolio.Clear();
            github.Clear();
            linkedin.Clear();
            university.Clear();
            degree.Clear();
            department.Clear();
            graduationyear.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox24.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox18.Clear();
            gender.SelectedIndex = -1;
            country.SelectedIndex = -1;
            rate.Value = 0;
            foreach (int i in Enumerable.Range(0, skills.Items.Count))
            {
                skills.SetItemChecked(i, false);
            }
            photo.Image = null;
            picturePath = "";
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openfd.ShowDialog() == DialogResult.OK)
            {

                string selectedFilePath = openfd.FileName;
                PictureBox pb = new PictureBox();
                pb.Image = Image.FromFile(selectedFilePath);
            }
        }

        private void photo_Click(object sender, EventArgs e)
        {

        }
    }
}