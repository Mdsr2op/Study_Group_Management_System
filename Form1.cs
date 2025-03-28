using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _36515_SDT_Mid
{
    public partial class frmGroupManagement : Form
    {
        public frmGroupManagement()
        {
            InitializeComponent();
            LoadUsers();
            fillDG();
        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGroups.Rows[e.RowIndex];
                txtGroupName.Text = row.Cells["GroupName"].Value.ToString();
                txtGroupDescription.Text = row.Cells["GroupDescription"].Value.ToString();
                cmbCreatedBy.SelectedValue = Convert.ToInt32(row.Cells["CreatedBy"].Value);
            }
        }

        protected void fillDG()
        {
            String conStr = @"Data Source=.\sqlexpress;
                      Initial Catalog=Mid;
                      Integrated Security=true;TrustServerCertificate=True;";

            SqlConnection myDbCon = new SqlConnection(conStr);
            myDbCon.Open();

            string sqlSelect = "Select * from Groups";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, myDbCon);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvGroups.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillDG();
        }

        private void LoadUsers()
        {
            string connectionString = @"Server=DESKTOP-5T33D00\SQLEXPRESS;Database=Mid;Integrated Security=True;TrustServerCertificate=True;";

            SqlConnection myDbConfig = new SqlConnection(connectionString);
            myDbConfig.Open();

            string sqlSelect = "SELECT userId, username FROM Users";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, myDbConfig);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbCreatedBy.DataSource = dt;
            cmbCreatedBy.DisplayMember = "username";
            cmbCreatedBy.ValueMember = "userId";

            myDbConfig.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-5T33D00\SQLEXPRESS;Database=Mid;Integrated Security=True;TrustServerCertificate=True;";

            SqlConnection myDbConfig = new SqlConnection(connectionString);
            myDbConfig.Open();

            int createdBy = Convert.ToInt32(cmbCreatedBy.SelectedValue);

            string sqlInsert = "INSERT INTO Groups (GroupName, GroupDescription, CreatedBy) VALUES ('" + txtGroupName.Text + "', '" + txtGroupDescription.Text + "', '" + createdBy + "')";

            SqlCommand myCommand = new SqlCommand(sqlInsert, myDbConfig);

            if (myCommand.ExecuteNonQuery() > 0)
                MessageBox.Show("Group has been added to the database successfully...");
            else
                MessageBox.Show("Failed to add group");

            myDbConfig.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-5T33D00\SQLEXPRESS;Database=Mid;Integrated Security=True;TrustServerCertificate=True;";

            SqlConnection myDbConfig = new SqlConnection(connectionString);
            myDbConfig.Open();

            if (dgvGroups.SelectedRows.Count > 0)
            {
                int groupId = Convert.ToInt32(dgvGroups.SelectedRows[0].Cells["GroupId"].Value);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this group?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDelete = "DELETE FROM Groups WHERE GroupId = " + groupId;
                    SqlCommand myCommand = new SqlCommand(sqlDelete, myDbConfig);

                    if (myCommand.ExecuteNonQuery() > 0)
                        MessageBox.Show("Group has been deleted successfully...");
                    else
                        MessageBox.Show("Failed to delete group");
                }
            }
            else
            {
                MessageBox.Show("Please select a group to delete.");
            }

            myDbConfig.Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-5T33D00\SQLEXPRESS;Database=Mid;Integrated Security=True;TrustServerCertificate=True;";

            SqlConnection myDbConfig = new SqlConnection(connectionString);
            myDbConfig.Open();

            if (dgvGroups.SelectedRows.Count > 0)
            {
                int groupId = Convert.ToInt32(dgvGroups.SelectedRows[0].Cells["GroupId"].Value);
                int createdBy = Convert.ToInt32(cmbCreatedBy.SelectedValue);

                string sqlUpdate = "UPDATE Groups SET GroupName = '" + txtGroupName.Text + "', GroupDescription = '" + txtGroupDescription.Text + "', CreatedBy = '" + createdBy + "' WHERE GroupId = " + groupId;
                SqlCommand myCommand = new SqlCommand(sqlUpdate, myDbConfig);

                if (myCommand.ExecuteNonQuery() > 0)
                    MessageBox.Show("Group has been updated successfully...");
                else
                    MessageBox.Show("Failed to update group");
            }
            else
            {
                MessageBox.Show("Please select a group to update.");
            }

            myDbConfig.Close();
        }
    }
}
