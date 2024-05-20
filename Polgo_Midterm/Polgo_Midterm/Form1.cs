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

using System.Data.SqlClient;

namespace Polgo_Midterm
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetConnection();
            LoadCustomers();
            LoadGymClass();
            LoadEnrollment();

        }
        
        private void SetConnection()
        {
            con = new SqlConnection(@"Data Source = DESKTOP-PEML9SP\SQLEXPRESS01;
                Initial Catalog = POLGO_MIDTERM195_DB;
                user ID = ken; 
                password = mireille34;");
        }

        private void LoadCustomers()
        {
            dataGridCustomers.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT custID, custLName, custFName, custMName, custAddress FROM CUSTOMERS;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataGridCustomers.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
            }
            con.Close();

        }

        private void LoadGymClass()
        {
            dataGridGymClass.Rows.Clear();  
            con.Open();
            cmd = new SqlCommand(@"SELECT classID, className, instructorName, monthlyFee FROM GYMCLASS;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataGridGymClass.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
            }
        }

        private void ClearAll()
        {
            txtCustID.Clear();
            txtCustLName.Clear();
            txtCustFName.Clear();
            txtCustMName.Clear();
            txtCustAddress.Clear();

            txtGymClassID.Clear();
            txtGymClassName.Clear();
            txtGymInsName.Clear();
            txtGymMFee.Clear();

            txtEnrollCust.Clear();
            txtEnrollClass.Clear();
            txtEnrollLength.Clear();
            txtEnrollDateTime.Clear();

            
        }

        private void btnCustAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"INSERT INTO CUSTOMERS (custLName, custFName, custMName, custAddress)
                VALUES ('" + txtCustLName.Text
                +"', '"+txtCustFName.Text
                +"', '"+txtCustMName.Text
                +"', '"+txtCustAddress.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Class Added", "Success");
            LoadCustomers();
            ClearAll();

        }

        private void btnGymAdd_Click(object sender, EventArgs e)
        {
                con.Open();
                cmd = new SqlCommand(@"INSERT INTO GYMCLASS (className, instructorName, monthlyFee)
                VALUES ('" + txtGymClassName.Text
                    + "', '" + txtGymInsName.Text + "', '" + txtGymMFee.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer Added", "Success");
                LoadGymClass();
                ClearAll();

        }

        public void LoadEnrollment()
        {
            dataEnrollment.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"INSERT INTO ENROLLMENT (customerID, classesId, lengthEnrollment, enrollmentDateTime) 
                VALUES ('', '', '', '');", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataGridCustomers.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
            }
            con.Close();

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (dataGridCustomers.SelectedRows.Count > 0 && dataGridGymClass.SelectedRows.Count > 0) {
                con.Open();
                cmd = new SqlCommand(@"INSERT INTO ENROLLMENT (customerID, classesId, lengthEnrollment, enrollment VALUES ('" + txtCustID.Text
                    + "', '" + txtGymClassID.Text + "', '" + txtEnrollLength.Text + "','" + DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Enrollment Added", "Success");
                LoadEnrollment();
                ClearAll();
        }
            }

        private void btnEnrollCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnCustomerClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnGymClassClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnCustEdit_Click(object sender, EventArgs e)
        {
            select
        }

        private void btnGymEdit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridGymClass_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridGymClass.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGridGymClass.SelectedRows[0];
                txtGymClassID.Text = selected.Cells[0].Value.ToString();
                txtGymClassName.Text = selected.Cells[1].Value.ToString();
                txtGymInsName.Text = selected.Cells[2].Value.ToString();
                txtGymMFee.Text = selected.Cells[3].Value.ToString();
                

            }
            btnGymAdd.Enabled = false;
            btnGymEdit.Enabled = true;
        }

        private void dataGridCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridGymClass.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGridGymClass.SelectedRows[0];
                txtCustID.Text = selected.Cells[0].Value.ToString();
                txtCustLName.Text = selected.Cells[1].Value.ToString();
                txtCustFName.Text = selected.Cells[2].Value.ToString();
                txtCustMName.Text = selected.Cells[3].Value.ToString();
                txtCustAddress.Text = selected.Cells[4].Value.ToString();

            }
            btnGymAdd.Enabled = false;
            btnGymEdit.Enabled = true;
        }

        private void dataEnrollGymClass_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridGymClass.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGridGymClass.SelectedRows[0];
                txtCustID.Text = selected.Cells[0].Value.ToString();
                txtCustLName.Text = selected.Cells[1].Value.ToString();
                txtCustFName.Text = selected.Cells[2].Value.ToString();
                txtCustMName.Text = selected.Cells[3].Value.ToString();
                txtCustAddress.Text = selected.Cells[4].Value.ToString();

            }
            btnGymAdd.Enabled = false;
            btnGymEdit.Enabled = true;
        }

        private void dataEnrollCust_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
    }
