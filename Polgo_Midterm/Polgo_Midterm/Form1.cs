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
            con = new SqlConnection(@"Data Source = RETARDLUL\SQLEXPRESS;
                Initial Catalog = POLGO_MIDTERM195_DB;
                Integrated security = true;");
        }

        private void LoadCustomers()
        {
            dataCustomers.Rows.Clear();
            dataEnrollCust.Rows.Clear();
            dataCustInfo.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT custID, custLName, custFName, custMName, custAddress FROM CUSTOMERS;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataCustomers.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
                dataEnrollCust.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
                dataCustInfo.Rows.Add(rdr[0].ToString(), rdr[1].ToString());
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
            dataEnroll.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT enrollmentID, custLName, className, lengthEnrollment, enrollmentDateTime FROM ENROLLMENT INNER JOIN CUSTOMERS ON ENROLLMENT.custID = CUSTOMERS.custID INNER JOIN GYMCLASS ON ENROLLMENT.classID = GYMCLASS.classID;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataEnroll.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
            }
            con.Close();

        }

        private void LoadClassesInformation()
        {
            string classid = "";
            con.Open();
            cmd = new SqlCommand(@"SELECT classID FROM ENROLLMENT WHERE custID = '"+txtClassCustID.Text+"';", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                classid = rdr[0].ToString();
            }
            con.Close();

            con.Open();
            cmd = new SqlCommand(@"SELECT className FROM GYMCLASS WHERE classID = '"+classid+"' ", con);
            rdr = cmd.ExecuteReader() ;
            while (rdr.Read())
            {
                dataCLassInfo.Rows.Add(rdr[0].ToString());
            }
            con.Close() ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetConnection();
            LoadCustomers();
            LoadGymClass();
            LoadEnrollment();
            LoadClassesInformation();

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

            txtEnrollCustID.Clear();
            txtEnrollClassName.Clear();
            txtEnrollClassID.Clear();
            txtEnrollCustName.Clear();
            txtEnrollLength.Clear();

            txtCustNameInfo.Clear();
            txtClassCustID.Clear();


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
            MessageBox.Show("Customer Added", "Success");
            LoadCustomers();
            ClearAll();

        }

        private void btnCustSave_Click(object sender, EventArgs e)
        {
            if (dataCustomers.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new SqlCommand(@"UPDATE CUSTOMERS SET custLName = '" + txtCustLName.Text
                    + "', custFName = '" + txtCustFName.Text
                    + "', custMName = '" + txtCustMName.Text
                    + "', custAddress = '" + txtCustAddress.Text
                    + "' WHERE custID = '" + txtCustID.Text + "';", con);
                con.Close();
                MessageBox.Show("Successfully Updated", "Success");
                LoadCustomers();
                ClearAll();
            }
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
            LoadGymClass();
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
            LoadGymClass();
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
                    VALUES ('" + txtEnrollCustID.Text
                    + "', '" + txtEnrollClassID.Text 
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

        private void btnShowClass_Click(object sender, EventArgs e)
        {
            LoadClassesInformation();
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

        private void dataEnroll_SelectionChanged(object sender, EventArgs e)
        {
            if (dataEnroll.SelectedRows.Count > 0)
            {
                txtEnrollLength.Text = dataEnroll.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void dataCustInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataCustInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow cell = dataCustInfo.SelectedRows[0];
                txtClassCustID.Text = cell.Cells[0].Value.ToString();
                txtCustNameInfo.Text = cell.Cells[1].Value.ToString();
            }
        }

        private void dataCLassInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataCLassInfo.SelectedRows.Count > 0)
            {
                
            }
        }

        private void btnClearClass_Click(object sender, EventArgs e)
        {
            ClearAll();
            dataCLassInfo.Rows.Clear();
        }
    }
    }
