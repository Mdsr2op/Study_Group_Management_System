namespace _36515_SDT_Mid
{
    partial class frmGroupManagement
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblGroupID;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblGroupDescription;
        private System.Windows.Forms.TextBox txtGroupDescription;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.ComboBox cmbCreatedBy;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLinkPages;

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
            pnlHeader = new Panel();
            lblTitle = new Label();
            dgvGroups = new DataGridView();
            pnlForm = new Panel();
            lblGroupID = new Label();
            txtGroupID = new TextBox();
            lblGroupName = new Label();
            txtGroupName = new TextBox();
            lblGroupDescription = new Label();
            txtGroupDescription = new TextBox();
            lblCreatedBy = new Label();
            cmbCreatedBy = new ComboBox();
            pnlActions = new Panel();
            button1 = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLinkPages = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).BeginInit();
            pnlForm.SuspendLayout();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(45, 45, 48);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Study Group Management";
            // 
            // dgvGroups
            // 
            dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroups.BackgroundColor = Color.White;
            dgvGroups.ColumnHeadersHeight = 29;
            dgvGroups.Location = new Point(20, 80);
            dgvGroups.MultiSelect = false;
            dgvGroups.Name = "dgvGroups";
            dgvGroups.ReadOnly = true;
            dgvGroups.RowHeadersWidth = 51;
            dgvGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGroups.Size = new Size(760, 200);
            dgvGroups.TabIndex = 1;
            dgvGroups.CellContentClick += dgvGroups_CellContentClick;
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(lblGroupID);
            pnlForm.Controls.Add(txtGroupID);
            pnlForm.Controls.Add(lblGroupName);
            pnlForm.Controls.Add(txtGroupName);
            pnlForm.Controls.Add(lblGroupDescription);
            pnlForm.Controls.Add(txtGroupDescription);
            pnlForm.Controls.Add(lblCreatedBy);
            pnlForm.Controls.Add(cmbCreatedBy);
            pnlForm.Location = new Point(20, 300);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(760, 150);
            pnlForm.TabIndex = 2;
            // 
            // lblGroupID
            // 
            lblGroupID.Location = new Point(10, 10);
            lblGroupID.Name = "lblGroupID";
            lblGroupID.Size = new Size(100, 23);
            lblGroupID.TabIndex = 0;
            lblGroupID.Text = "Group ID:";
            // 
            // txtGroupID
            // 
            txtGroupID.Enabled = false;
            txtGroupID.Location = new Point(150, 10);
            txtGroupID.Name = "txtGroupID";
            txtGroupID.Size = new Size(200, 27);
            txtGroupID.TabIndex = 1;
            // 
            // lblGroupName
            // 
            lblGroupName.Location = new Point(10, 40);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new Size(100, 23);
            lblGroupName.TabIndex = 2;
            lblGroupName.Text = "Group Name:";
            // 
            // txtGroupName
            // 
            txtGroupName.Location = new Point(150, 40);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(200, 27);
            txtGroupName.TabIndex = 3;
            // 
            // lblGroupDescription
            // 
            lblGroupDescription.Location = new Point(10, 70);
            lblGroupDescription.Name = "lblGroupDescription";
            lblGroupDescription.Size = new Size(100, 23);
            lblGroupDescription.TabIndex = 4;
            lblGroupDescription.Text = "Description:";
            // 
            // txtGroupDescription
            // 
            txtGroupDescription.Location = new Point(150, 70);
            txtGroupDescription.Multiline = true;
            txtGroupDescription.Name = "txtGroupDescription";
            txtGroupDescription.Size = new Size(400, 50);
            txtGroupDescription.TabIndex = 5;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.Location = new Point(10, 130);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(100, 23);
            lblCreatedBy.TabIndex = 6;
            lblCreatedBy.Text = "Created By:";
            // 
            // cmbCreatedBy
            // 
            cmbCreatedBy.Location = new Point(150, 130);
            cmbCreatedBy.Name = "cmbCreatedBy";
            cmbCreatedBy.Size = new Size(200, 28);
            cmbCreatedBy.TabIndex = 7;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(button1);
            pnlActions.Controls.Add(btnCreate);
            pnlActions.Controls.Add(btnUpdate);
            pnlActions.Controls.Add(btnDelete);
            pnlActions.Controls.Add(btnLinkPages);
            pnlActions.Location = new Point(20, 470);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(760, 60);
            pnlActions.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 120, 215);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(608, 10);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 4;
            button1.Text = "Populate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(0, 120, 215);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(0, 10);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 40);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 120, 215);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(120, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(232, 17, 35);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(240, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLinkPages
            // 
            btnLinkPages.BackColor = Color.Gray;
            btnLinkPages.FlatStyle = FlatStyle.Flat;
            btnLinkPages.ForeColor = Color.White;
            btnLinkPages.Location = new Point(360, 10);
            btnLinkPages.Name = "btnLinkPages";
            btnLinkPages.Size = new Size(120, 40);
            btnLinkPages.TabIndex = 3;
            btnLinkPages.Text = "Other Pages";
            btnLinkPages.UseVisualStyleBackColor = false;
            // 
            // frmGroupManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(pnlHeader);
            Controls.Add(dgvGroups);
            Controls.Add(pnlForm);
            Controls.Add(pnlActions);
            Name = "frmGroupManagement";
            Text = "Study Group Management";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlActions.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Button button1;
    }
}
