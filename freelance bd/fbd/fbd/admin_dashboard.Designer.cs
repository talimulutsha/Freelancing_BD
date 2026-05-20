namespace fbd
{
    partial class admin_dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoadFreelancer = new System.Windows.Forms.Button();
            this.btnLoadClient = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // btnLoadFreelancer
            this.btnLoadFreelancer.Location = new System.Drawing.Point(612, 177);
            this.btnLoadFreelancer.Name = "btnLoadFreelancer";
            this.btnLoadFreelancer.Size = new System.Drawing.Size(176, 23);
            this.btnLoadFreelancer.TabIndex = 1;
            this.btnLoadFreelancer.Text = "Load freelancer data";
            this.btnLoadFreelancer.UseVisualStyleBackColor = true;
            this.btnLoadFreelancer.Click += new System.EventHandler(this.btnLoadFreelancer_Click);

            // btnLoadClient
            this.btnLoadClient.Location = new System.Drawing.Point(612, 222);
            this.btnLoadClient.Name = "btnLoadClient";
            this.btnLoadClient.Size = new System.Drawing.Size(176, 23);
            this.btnLoadClient.TabIndex = 2;
            this.btnLoadClient.Text = "Load client data";
            this.btnLoadClient.UseVisualStyleBackColor = true;
            this.btnLoadClient.Click += new System.EventHandler(this.btnLoadClient_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(612, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(612, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 360);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            // admin_dashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoadClient);
            this.Controls.Add(this.btnLoadFreelancer);
            this.Name = "admin_dashboard";
            this.Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnLoadFreelancer;
        private System.Windows.Forms.Button btnLoadClient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}