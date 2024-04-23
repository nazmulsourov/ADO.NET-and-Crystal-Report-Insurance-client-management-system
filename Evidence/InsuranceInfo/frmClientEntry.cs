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
using System.IO;
using System.Drawing.Imaging;
namespace InsuranceInfo
{
    public partial class frmClientEntry : Form
    {
        SqlConnection con= new SqlConnection(@"Data source=DESKTOP-EUHQK2O;initial Catalog=Insuranceinfodb;Integrated Security=True");
        SqlTransaction st;
        public frmClientEntry()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from newclient", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                Image img=Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtImage.Text = openFileDialog1.FileName;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(txtImage.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);

                con.Open();
                st = con.BeginTransaction();

                SqlCommand cmd = new SqlCommand("insert into newclient(clientid,clientname,dateofbirth,contactno,clientemail,clientaddress,policyid,durationid,picture) values(@i,@n,@b,@c,@e,@a,@pi,@di,@p)",con,st);
               
                cmd.Parameters.AddWithValue("@i", txtId.Text);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@b", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@c", txtContact.Text);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                cmd.Parameters.AddWithValue("@a", txtAddress.Text);
                cmd.Parameters.AddWithValue("@pi", comPolicy.SelectedValue);
                cmd.Parameters.AddWithValue("@di", comDuration.SelectedValue);
                cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.ExecuteNonQuery();
                st.Commit();
                MessageBox.Show("Data Saved Successfully...", "Saved Message");
                LoadGrid();
                Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                st.Rollback();
                MessageBox.Show("Input Data Not Valid!!" + ex.Message);
                con.Close();
            }
        }

        private void frmClientEntry_Load(object sender, EventArgs e)
        {
            LoadDuration();
            LoadPolicy();
            LoadGrid();
        }
        private void LoadPolicy()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from policies", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            comPolicy.DataSource = ds.Tables[0];
            comPolicy.DisplayMember = "name";
            comPolicy.ValueMember = "id";
            con.Close();
        }
        private void LoadDuration()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from duration",con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            comDuration.DataSource = ds.Tables[0];
            comDuration.DisplayMember = "period";
            comDuration.ValueMember = "id";
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtId.Clear();
            txtName.Clear();
            this.dateTimePicker1.Value = DateTime.Now;
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            comPolicy.SelectedIndex = -1;
            comDuration.SelectedIndex = -1;
            txtImage.Clear();
            pictureBox1.Image = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select clientid,clientname,dateofbirth,contactno,clientemail,clientaddress,policyid,durationid,picture from newclient where clientid="+id+"", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtId.Text = dt.Rows[0][0].ToString();
                txtName.Text = dt.Rows[0][1].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                txtContact.Text = dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                txtAddress.Text = dt.Rows[0][5].ToString();
                comPolicy.SelectedValue = dt.Rows[0][6].ToString();
                comDuration.SelectedValue = dt.Rows[0][7].ToString();
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][8]);
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                st = con.BeginTransaction();
                if (txtImage.Text != "")
                {
                    Image img = Image.FromFile(txtImage.Text);
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, ImageFormat.Bmp);
                    SqlCommand cmd = new SqlCommand(@"update newclient set clientname=@n,dateofbirth=@b,contactno=@c,clientemail=@e,clientaddress=@a,policyid=@p,durationid=@d,picture=@pc where clientid=@i", con, st);

                    cmd.Parameters.AddWithValue("@i", txtId.Text);
                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@b", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@c", txtContact.Text);
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@a", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@p", comPolicy.SelectedValue);
                    cmd.Parameters.AddWithValue("@d", comDuration.SelectedValue);
                    cmd.Parameters.Add(new SqlParameter("@pc", SqlDbType.VarBinary) { Value = ms.ToArray() });
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(@"update newclient set clientname=@n,dateofbirth=@b,contactno=@c,clientemail=@e,clientaddress=@a,policyid=@p,durationid=@d where clientid=@i", con, st);

                    cmd.Parameters.AddWithValue("@i", txtId.Text);
                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@b", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@c", txtContact.Text);
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@a", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@p", comPolicy.SelectedValue);
                    cmd.Parameters.AddWithValue("@d", comDuration.SelectedValue);


                    cmd.ExecuteNonQuery();
                }
                st.Commit();
                MessageBox.Show("Data Updated Successfully...", "Saved Message");
                LoadGrid();
                Clear();

                con.Close();

            }
            catch (Exception ex)
            {
                st.Rollback();
                MessageBox.Show("Input Data Not Valid!!" + ex.Message);
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                st = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand(@"delete from newclient where clientid="+Convert.ToInt32(txtId.Text)+"", con, st);
                cmd.ExecuteNonQuery();
                st.Commit();
                MessageBox.Show("Data Deleted Successfully...", "Saved Message");
                LoadGrid();
                Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                st.Rollback();
                MessageBox.Show("Input Data Not Valid!!" + ex.Message);
                con.Close();
            }
        }
    }
}
