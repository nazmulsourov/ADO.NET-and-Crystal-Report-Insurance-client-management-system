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
namespace InsuranceInfo
{
    public partial class frmPolicy : Form
    {
        SqlConnection con = new SqlConnection(@"Data source=DESKTOP-EUHQK2O;initial Catalog=Insuranceinfodb;Integrated Security=True");
        SqlTransaction st;
        public frmPolicy()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            try
            {
                con.Open();
                st = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand("insert into policies(id,name) values (@i,@n)",con,st);
               
                cmd.Parameters.AddWithValue("@i", txtId.Text);
                cmd.Parameters.AddWithValue("@n", txtPolicyName.Text);
                cmd.ExecuteNonQuery();
                
                st.Commit();
                MessageBox.Show("Data Saved Successfully...", "Saved Message");
                txtId.Text = "";
                txtPolicyName.Text = "";
                LoadGrid();
                con.Close();
            }
            catch (Exception ex)
            {
                st.Rollback();
                MessageBox.Show("Input Data Not Valid!!"+ex.Message);
                con.Close();
            }
           
        }
        private void LoadGrid()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from policies", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       
       

        private void frmPolicy_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select id,name from policies where id=" + id + " ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtId.Text = dt.Rows[0][0].ToString();
                txtPolicyName.Text = dt.Rows[0][1].ToString();
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update policies set name=@n where id=@i";
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            cmd.Parameters.AddWithValue("@n", txtPolicyName.Text);
            cmd.ExecuteNonQuery();
            LoadGrid();
            txtId.Text = "";
            txtPolicyName.Text = "";
            lblMsg.Text = "Data Updated Successfully...";
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from policies where id=@i";
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            cmd.Parameters.AddWithValue("@n", txtPolicyName.Text);
            cmd.ExecuteNonQuery();
            LoadGrid();
            txtId.Text = "";
            txtPolicyName.Text = "";
            lblMsg.Text = "Data Deleted Successfully...";
            con.Close();

        }
    }
}
