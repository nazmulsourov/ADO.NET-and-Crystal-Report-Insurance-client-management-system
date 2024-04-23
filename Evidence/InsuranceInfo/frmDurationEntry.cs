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
    public partial class frmDurationEntry : Form
    {
        SqlConnection con = new SqlConnection(@"Data source=DESKTOP-EUHQK2O;initial Catalog=Insuranceinfodb;Integrated Security=True");
        public frmDurationEntry()
        {
            InitializeComponent();
        }
       
        private void LoadGrid()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from duration", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select id,period from duration where id=" + id + " ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtId.Text = dt.Rows[0][0].ToString();
                txtDuration.Text = dt.Rows[0][1].ToString();
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update duration set period=@d where id=@i";
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            cmd.Parameters.AddWithValue("@d", txtDuration.Text);
            cmd.ExecuteNonQuery();
            LoadGrid();
            txtId.Text = "";
            txtDuration.Text = "";
            lblMsg.Text = "Data Updated Successfully...";
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from duration where id=@i";
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            cmd.Parameters.AddWithValue("@d", txtDuration.Text);
            cmd.ExecuteNonQuery();
            LoadGrid();
            txtId.Text = "";
            txtDuration.Text = "";
            lblMsg.Text = "Data Deleted Successfully...";
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into duration(id,period) values (@i,@p)";
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            cmd.Parameters.AddWithValue("@p", txtDuration.Text);
            cmd.ExecuteNonQuery();
            LoadGrid();
            lblMsg.Text = "Data Saved Successfully...";
            con.Close();
        }

        private void frmDurationEntry_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
