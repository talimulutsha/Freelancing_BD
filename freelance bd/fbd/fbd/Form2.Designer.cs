using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fbd
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFormInput())
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"UPDATE dbo.profilef SET

                    firstname = @firstname,
                    lastname = @lastname,
                    phone = @phone,
                    dob = @dob,
                    gender = @gender,
                    country = @country,
                    address = @address,
                    language = @language,
                    title = @title,
                    skills = @skills,
                    experience = @experience,
                    rate = @rate,
                    portfolio = @portfolio,
                    github = @github,
                    linkedin = @linkedin,
                    university = @university,
                    degree = @degree,
                    department = @department,
                    graduationyear = @graduationyear,
                    image = @image

                    WHERE username = @username";

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

                            int rows = command.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("Profile updated successfully!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Username not found.",
                                    "Update Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid graduation year or rate.",
                    "Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }




        #region Windows Form Designer generated code



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label10 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.language = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.TextBox();
            this.photo = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.phone = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.portfolio = new System.Windows.Forms.TextBox();
            this.github = new System.Windows.Forms.TextBox();
            this.linkedin = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.experience = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.skills = new System.Windows.Forms.CheckedListBox();
            this.label46 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.graduationyear = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.degree = new System.Windows.Forms.TextBox();
            this.university = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rate)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 23);
            this.label22.TabIndex = 0;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(0, 0);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 0;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(0, 0);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(0, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(0, 0);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 23);
            this.label26.TabIndex = 0;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(0, 0);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 22);
            this.textBox17.TabIndex = 0;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(0, 0);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 22);
            this.textBox16.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(0, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 23);
            this.label25.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 23);
            this.label24.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 23);
            this.label23.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 96);
            this.checkedListBox1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(0, 0);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 0;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(0, 0);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 0;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(0, 0);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 0;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(0, 0);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(0, 0);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 23);
            this.label27.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 23);
            this.label28.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 23);
            this.label29.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.language);
            this.panel2.Controls.Add(this.country);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.gender);
            this.panel2.Controls.Add(this.label38);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.address);
            this.panel2.Controls.Add(this.textBox24);
            this.panel2.Controls.Add(this.textBox19);
            this.panel2.Controls.Add(this.dob);
            this.panel2.Controls.Add(this.photo);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Controls.Add(this.phone);
            this.panel2.Controls.Add(this.textBox21);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lastname);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.firstname);
            this.panel2.Location = new System.Drawing.Point(27, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 615);
            this.panel2.TabIndex = 4;
            // 
            // language
            // 
            this.language.Location = new System.Drawing.Point(160, 571);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(216, 24);
            this.language.TabIndex = 27;
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "Bangladesh",
            "India",
            "Canada",
            "USA",
            "UAE",
            "UK",
            "Sweden",
            "Thailand",
            "Pakistan",
            "Ghana",
            "Nigeria",
            "Iraq",
            "Iran",
            "Brasil",
            "Argentina",
            "Other..."});
            this.country.Location = new System.Drawing.Point(160, 487);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(121, 26);
            this.country.TabIndex = 26;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Silver;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(30, 569);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(115, 25);
            this.label31.TabIndex = 25;
            this.label31.Text = "Language:";
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(160, 443);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 26);
            this.gender.TabIndex = 24;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Silver;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(30, 444);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(90, 25);
            this.label38.TabIndex = 23;
            this.label38.Text = "Gender:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Silver;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(30, 488);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(95, 25);
            this.label37.TabIndex = 22;
            this.label37.Text = "Country:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Silver;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(30, 533);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(99, 25);
            this.label36.TabIndex = 21;
            this.label36.Text = "Address:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Silver;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(24, 303);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(126, 25);
            this.username.TabIndex = 19;
            this.username.Text = "User Name:";
            this.username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Silver;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(89, 33);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(210, 25);
            this.label30.TabIndex = 18;
            this.label30.Text = "Personal Information";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(160, 533);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(216, 24);
            this.address.TabIndex = 17;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(160, 686);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(216, 24);
            this.textBox24.TabIndex = 15;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(160, 636);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(216, 24);
            this.textBox19.TabIndex = 14;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(160, 398);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(216, 24);
            this.dob.TabIndex = 13;
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(205, 73);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(141, 120);
            this.photo.TabIndex = 12;
            this.photo.TabStop = false;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(29, 117);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(84, 21);
            this.progressBar2.TabIndex = 11;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(160, 351);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(216, 24);
            this.phone.TabIndex = 10;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(160, 305);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(216, 24);
            this.textBox21.TabIndex = 9;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Silver;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(30, 396);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 25);
            this.label32.TabIndex = 8;
            this.label32.Text = "DOB:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Silver;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(30, 349);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(81, 25);
            this.label33.TabIndex = 7;
            this.label33.Text = "Phone:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(28, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(160, 260);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(216, 24);
            this.lastname.TabIndex = 6;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Silver;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(24, 260);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(122, 25);
            this.label34.TabIndex = 5;
            this.label34.Text = "Last Name:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Silver;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(23, 218);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(123, 25);
            this.label35.TabIndex = 4;
            this.label35.Text = "First Name:";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(160, 218);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(216, 24);
            this.firstname.TabIndex = 3;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(27, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 57);
            this.panel1.TabIndex = 28;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label39.Location = new System.Drawing.Point(1122, 7);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(79, 36);
            this.label39.TabIndex = 4;
            this.label39.Text = "Jobs";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(1228, 11);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(115, 32);
            this.label41.TabIndex = 3;
            this.label41.Text = "Sign Up";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(924, 7);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(153, 32);
            this.label42.TabIndex = 1;
            this.label42.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label50);
            this.panel3.Controls.Add(this.label49);
            this.panel3.Controls.Add(this.portfolio);
            this.panel3.Controls.Add(this.github);
            this.panel3.Controls.Add(this.linkedin);
            this.panel3.Controls.Add(this.label47);
            this.panel3.Controls.Add(this.rate);
            this.panel3.Controls.Add(this.label45);
            this.panel3.Controls.Add(this.experience);
            this.panel3.Controls.Add(this.label44);
            this.panel3.Controls.Add(this.skills);
            this.panel3.Controls.Add(this.label46);
            this.panel3.Controls.Add(this.title);
            this.panel3.Controls.Add(this.label40);
            this.panel3.Controls.Add(this.label48);
            this.panel3.Controls.Add(this.textBox22);
            this.panel3.Controls.Add(this.textBox23);
            this.panel3.Location = new System.Drawing.Point(490, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 615);
            this.panel3.TabIndex = 28;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Silver;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(12, 488);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(82, 25);
            this.label50.TabIndex = 46;
            this.label50.Text = "Github:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Silver;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(12, 531);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(100, 25);
            this.label49.TabIndex = 45;
            this.label49.Text = "Linkedin:";
            // 
            // portfolio
            // 
            this.portfolio.Location = new System.Drawing.Point(160, 441);
            this.portfolio.Name = "portfolio";
            this.portfolio.Size = new System.Drawing.Size(216, 24);
            this.portfolio.TabIndex = 44;
            // 
            // github
            // 
            this.github.Location = new System.Drawing.Point(160, 488);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(216, 24);
            this.github.TabIndex = 43;
            // 
            // linkedin
            // 
            this.linkedin.Location = new System.Drawing.Point(160, 535);
            this.linkedin.Name = "linkedin";
            this.linkedin.Size = new System.Drawing.Size(216, 24);
            this.linkedin.TabIndex = 42;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Silver;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(12, 441);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(98, 25);
            this.label47.TabIndex = 41;
            this.label47.Text = "Portfolio:";
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(160, 396);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(120, 24);
            this.rate.TabIndex = 40;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Silver;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(12, 397);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(63, 25);
            this.label45.TabIndex = 39;
            this.label45.Text = "Rate:";
            // 
            // experience
            // 
            this.experience.Location = new System.Drawing.Point(160, 353);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(216, 24);
            this.experience.TabIndex = 38;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Silver;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(12, 351);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(120, 25);
            this.label44.TabIndex = 37;
            this.label44.Text = "Experience";
            // 
            // skills
            // 
            this.skills.FormattingEnabled = true;
            this.skills.Items.AddRange(new object[] {
            "Python",
            "C#",
            "Java",
            "Machine Learning",
            "Data Science",
            "FastAPI",
            "React",
            "UI/UX Design",
            "Video Editing",
            "Graphic Design",
            "Digital Marketing",
            "Content Writing"});
            this.skills.Location = new System.Drawing.Point(160, 126);
            this.skills.Name = "skills";
            this.skills.Size = new System.Drawing.Size(216, 213);
            this.skills.TabIndex = 36;
            this.skills.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Silver;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(12, 126);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(71, 25);
            this.label46.TabIndex = 35;
            this.label46.Text = "Skills:";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(160, 86);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(216, 24);
            this.title.TabIndex = 28;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Silver;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(12, 86);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(61, 25);
            this.label40.TabIndex = 28;
            this.label40.Text = "Title:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Silver;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(89, 33);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(244, 25);
            this.label48.TabIndex = 18;
            this.label48.Text = "Professional Information";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(160, 686);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(216, 24);
            this.textBox22.TabIndex = 15;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(160, 636);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(216, 24);
            this.textBox23.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.btnupdate);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.graduationyear);
            this.panel4.Controls.Add(this.department);
            this.panel4.Controls.Add(this.degree);
            this.panel4.Controls.Add(this.university);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.label54);
            this.panel4.Controls.Add(this.label53);
            this.panel4.Controls.Add(this.label52);
            this.panel4.Controls.Add(this.label51);
            this.panel4.Controls.Add(this.label43);
            this.panel4.Controls.Add(this.textBox18);
            this.panel4.Controls.Add(this.textBox20);
            this.panel4.Location = new System.Drawing.Point(940, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 615);
            this.panel4.TabIndex = 29;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnupdate.Location = new System.Drawing.Point(170, 344);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(94, 40);
            this.btnupdate.TabIndex = 28;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(33, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 38);
            this.button6.TabIndex = 51;
            this.button6.Text = "Insert Info";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // graduationyear
            // 
            this.graduationyear.Location = new System.Drawing.Point(160, 224);
            this.graduationyear.Name = "graduationyear";
            this.graduationyear.Size = new System.Drawing.Size(216, 24);
            this.graduationyear.TabIndex = 47;
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(160, 170);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(216, 24);
            this.department.TabIndex = 48;
            // 
            // degree
            // 
            this.degree.Location = new System.Drawing.Point(160, 126);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(216, 24);
            this.degree.TabIndex = 49;
            // 
            // university
            // 
            this.university.Location = new System.Drawing.Point(160, 88);
            this.university.Name = "university";
            this.university.Size = new System.Drawing.Size(216, 24);
            this.university.TabIndex = 50;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(33, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 38);
            this.button5.TabIndex = 28;
            this.button5.Text = "Add CV";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Silver;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(30, 168);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(130, 25);
            this.label54.TabIndex = 50;
            this.label54.Text = "Department:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Silver;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(30, 203);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(135, 18);
            this.label53.TabIndex = 49;
            this.label53.Text = "Graduation Year:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Silver;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(30, 126);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(89, 25);
            this.label52.TabIndex = 48;
            this.label52.Text = "Degree:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Silver;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(30, 86);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(114, 25);
            this.label51.TabIndex = 47;
            this.label51.Text = "University:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Silver;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(89, 33);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(238, 25);
            this.label43.TabIndex = 18;
            this.label43.Text = "Educational Information";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(160, 686);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(216, 24);
            this.textBox18.TabIndex = 15;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(160, 636);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(216, 24);
            this.textBox20.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 735);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rate)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox6;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox language;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.CheckedListBox skills;
        private System.Windows.Forms.TextBox experience;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown rate;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox portfolio;
        private System.Windows.Forms.TextBox github;
        private System.Windows.Forms.TextBox linkedin;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox graduationyear;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox degree;
        private System.Windows.Forms.TextBox university;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnupdate;
    }
}