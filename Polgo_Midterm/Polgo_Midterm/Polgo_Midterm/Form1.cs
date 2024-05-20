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
using System.CodeDom;

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

        private void SetConnection()
        {
            con = new SqlConnection(@"Data Source = DESKTOP-PEML9SP\SQLEXPRESS01;
                Initial Catalog = POLGO_FINALS;
                user ID = ken; 
                password = mireille34;");
        }

        private void LoadCustomers()
        {
            dataCustomers.Rows.Clear();
            dataEnrollCust.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT custID, custLName, custFName, custMName, custAddress FROM CUSTOMERS;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataCustomers.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
                dataEnrollCust.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
            }
            con.Close();

        }

        private void LoadGymClass()
        {
            dataGymClass.Rows.Clear();
            dataEnrollGym.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT classID, className, instructorName, monthlyFee FROM GYMCLASS;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataGymClass.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
                dataEnrollGym.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
            }
            con.Close();
        }

        private void LoadEnrollment()
        {
            dataEnrollment.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT enrollmentID, custLName, custFName, className, lengthEnrollment, enrollmentDateTime FROM ENROLLMENT INNER JOIN CUSTOMERS ON ENROLLMENT.custID = CUSTOMERS.custID INNER JOIN GYMCLASS ON ENROLLMENT.classID = GYMCLASS.classID;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataCustomers.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
            }
            con.Close();

        }

        private void ClassesInformation()
        {
            dataCustInfo.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT custID, custLName, custFname, custMName", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataCustInfo.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetConnection();
            LoadCustomers();
            LoadGymClass();
            LoadEnrollment();

            btnCustAdd.Enabled = true;
            btnGymAdd.Enabled = true;
            btnCustSave.Enabled = false;
            btnGymSave.Enabled = false;

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

            txtEnrollCustName.Clear();
            txtEnrollClassName.Clear();
            txtEnrollLength.Clear();
            
            btnCustAdd.Enabled = true;
            btnGymAdd.Enabled = true;

            btnCustSave.Enabled = false;
            btnGymSave.Enabled = false;

        }

        private void btnCustAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"INSERT INTO CUSTOMERS (custLName, custFName, custMName, custAddress)
                VALUES ('" + txtCustLName.Text
                + "', '" + txtCustFName.Text
                + "', '" + txtCustMName.Text
                + "', '" + txtCustAddress.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Class Added", "Success");
            LoadGymClass();
            ClearAll();

        }

        private void btnCustSave_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"UPDATE CUSTOMERS SET custLName = '" + txtCustLName.Text 
                + "', custFName = '" + txtCustFName.Text 
                + "', custMName = '" + txtCustMName.Text 
                + "', custAddress = '" + txtCustAddress.Text 
                + "' WHERE custID = '" + txtCustID.Text + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated", "Success");
            LoadCustomers();
            ClearAll();

        }

        private void btnCustomerClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnGymAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"INSERT INTO GYMCLASS (className, instructorName, monthlyFee) 
                VALUES ('" + txtGymClassName.Text
                + "', '" + txtGymInsName.Text 
                + "', '" + txtGymMFee.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Customer Added", "Success");
            LoadCustomers();
            ClearAll();

        }

        private void btnGymSave_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"UPDATE GYMCLASS SET className = '" + txtGymClassName.Text 
                + "', instructorName = '" + txtGymInsName.Text 
                + "', monthlyFee = '" + txtGymMFee.Text 
                + "' WHERE custID = '" + txtGymClassID.Text + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated", "Success");
            LoadCustomers();
            ClearAll();
        }

        private void btnGymClassClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }



        private void btnEnroll_Click(object sender, EventArgs e)
        {
                con.Open();
                cmd = new SqlCommand(@"INSERT INTO ENROLLMENT (custID, classID, lengthEnrollment, enrollmentDateTime)  
                    VALUES ('" + txtCustID.Text
                    + "', '" + txtGymClassID.Text 
                    + "', '" + txtEnrollLength.Text 
                    + "','" + DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Enrollment Added", "Success");
                LoadEnrollment();
                ClearAll();
        }

        private void btnEnrollCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }



        private void dataGridGymClass_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGymClass.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGymClass.SelectedRows[0];
                txtGymClassID.Text = selected.Cells[0].Value.ToString();
                txtGymClassName.Text = selected.Cells[1].Value.ToString();
                txtGymInsName.Text = selected.Cells[2].Value.ToString();
                txtGymMFee.Text = selected.Cells[3].Value.ToString();

                btnGymAdd.Enabled = false;
                btnGymSave.Enabled = true;
            }
        }

        private void dataCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataCustomers.SelectedRows[0];
                txtCustID.Text = selected.Cells[0].Value.ToString();
                txtCustLName.Text = selected.Cells[1].Value.ToString();
                txtCustFName.Text = selected.Cells[2].Value.ToString();
                txtCustMName.Text = selected.Cells[3].Value.ToString();
                txtCustAddress.Text = selected.Cells[4].Value.ToString();

                btnCustAdd.Enabled = false;
                btnCustSave.Enabled = true;
            }
        }

        private void dataEnrollment_SelectionChanged(object sender, EventArgs e)
        {
            if (dataEnrollment.SelectedRows.Count > 0)
            {
                txtEnrollLength.Text = dataEnrollment.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void dataEnrollCust_SelectionChanged(object sender, EventArgs e)
        {
            if (dataEnrollCust.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataEnrollCust.SelectedRows[0];
                txtEnrollCustID.Text = selected.Cells[0].Value.ToString();
                txtEnrollCustName.Text = selected.Cells[1].Value.ToString();
            }
        }

        private void dataEnrollGym_SelectionChanged(object sender, EventArgs e)
        {
            if (dataEnrollGym.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataEnrollGym.SelectedRows[0];
                txtEnrollClassID.Text = selected.Cells[0].Value.ToString();
                txtEnrollClassName.Text = selected.Cells[1].Value.ToString();
            }
        }

    }
    }
