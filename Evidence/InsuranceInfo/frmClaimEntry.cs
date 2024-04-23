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

namespace InsuranceInfo
{
    public partial class frmClaimEntry : Form
    {
        SqlConnection con = new SqlConnection(@"Data source=DESKTOP-EUHQK2O;initial Catalog=Insuranceinfodb;Integrated Security=True");
        public frmClaimEntry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into claimtype(claimid,claimname) values (@i,@n)";
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            cmd.Parameters.AddWithValue("@n", txtClaimName.Text);
            cmd.ExecuteNonQuery();
            LoadGrid();
            txtId.Text = "";
            txtClaimName.Text = "";
            lblMsg.Text = "Data Saved Successfully...";
            con.Close();

        }
        private void LoadGrid()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from claimtype", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmClaimEntry_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
           con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select claimid,claimname from claimtype where claimid=" + id + " ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtId.Text = dt.Rows[0][0].ToString();
                txtClaimName.Text = dt.Rows[0][1].ToString();
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update claimtype set claimname=@n where claimid=@i";
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            cmd.Parameters.AddWithValue("@n", txtClaimName.Text);
            cmd.ExecuteNonQuery();
            LoadGrid();
            txtId.Text = "";
            txtClaimName.Text = "";
            lblMsg.Text = "Data Updated Successfully...";
            con.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from claimtype where claimid=@i";
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            cmd.Parameters.AddWithValue("@n", txtClaimName.Text);
            cmd.ExecuteNonQuery();
            LoadGrid();
            txtId.Text = "";
            txtClaimName.Text = "";
            lblMsg.Text = "Data Deleted Successfully...";
            con.Close();

        }
    }
}
