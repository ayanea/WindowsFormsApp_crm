using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectionbase()
        {
            string connectionString = @"Data Source=PLTXDEVPC01_MAE\SQLEXPRESS;Initial Catalog=CRM_DB;Integrated Security=True";
            string sql = "SELECT * FROM job";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);

        }

        private void select_job()
        {
            string connectionString = @"Data Source=PLTXDEVPC01_MAE\SQLEXPRESS;Initial Catalog=CRM_DB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("spSel_Jobs", connection);
            dataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataadapter.SelectCommand.Parameters.Add("@idjob", SqlDbType.Int).Value = null;
            dataadapter.SelectCommand.Parameters.Add("@isAvailable", SqlDbType.Bit).Value = true;
            connection.Close();

            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "jobs_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "jobs_table";
        }

     
        private void spSetJob(int id=0)
        {
            string connectionString = @"Data Source=PLTXDEVPC01_MAE\SQLEXPRESS;Initial Catalog=CRM_DB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("spSet_Jobs",connection);
            dataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataadapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            dataadapter.SelectCommand.Parameters.Add("@job", SqlDbType.VarChar, (32)).Value = txtB_JobName.Text;
            dataadapter.SelectCommand.Parameters.Add("@note", SqlDbType.VarChar, (256)).Value = txtB_Note.Text;
            dataadapter.SelectCommand.Parameters.Add("@desactivation_date", SqlDbType.DateTime).Value = dtDesactivationJob.Value;
            dataadapter.SelectCommand.ExecuteNonQuery();
            connection.Close();
            
        }

        private void spDelJob()
        {
            string connectionString = @"Data Source=PLTXDEVPC01_MAE\SQLEXPRESS;Initial Catalog=CRM_DB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("spDel_Jobs", connection);
            dataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataadapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(BntDeleteJob.Tag);
            dataadapter.SelectCommand.ExecuteNonQuery();
            connection.Close();
        }
        private void bntAfficherJob_Click(object sender, EventArgs e)
        {
            select_job();

        }

        private void bntQuit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntUpdJob_Click_1(object sender, EventArgs e)
        {
            spSetJob(Convert.ToInt32(bntUpdJob.Tag));
            MessageBox.Show("Modification réussie");
        }

        private void BntAddJob_Click(object sender, EventArgs e)
        {
            spSetJob();
            MessageBox.Show("Insertion réussie");
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow item = dataGridView1.Rows[e.RowIndex];

            txtB_JobName.Text= dataGridView1["JOB", e.RowIndex].Value.ToString();

            txtB_Note.Text = dataGridView1["NOTE", e.RowIndex].Value.ToString();
            dtDesactivationJob.Value =Convert.ToDateTime(dataGridView1["DEACTIVATION_DATE", e.RowIndex].Value.ToString());

            bntUpdJob.Tag= dataGridView1["IDJOB", e.RowIndex].Value.ToString();
            BntDeleteJob.Tag = dataGridView1["IDJOB", e.RowIndex].Value.ToString();


        }

        private void BntDeleteJob_Click(object sender, EventArgs e)
        {
            spDelJob();
            MessageBox.Show("Suppression réussie");
        }

       
    }
}


