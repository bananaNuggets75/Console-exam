namespace Polgo_Midterm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCustomerClear = new System.Windows.Forms.Button();
            this.btnCustEdit = new System.Windows.Forms.Button();
            this.btnCustAdd = new System.Windows.Forms.Button();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.lblCustMname = new System.Windows.Forms.Label();
            this.lblCustFname = new System.Windows.Forms.Label();
            this.lblCustLname = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustMName = new System.Windows.Forms.TextBox();
            this.txtCustFName = new System.Windows.Forms.TextBox();
            this.txtCustLName = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.custID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGymClassClear = new System.Windows.Forms.Button();
            this.btnGymEdit = new System.Windows.Forms.Button();
            this.btnGymAdd = new System.Windows.Forms.Button();
            this.txtGymMFee = new System.Windows.Forms.TextBox();
            this.txtGymInsName = new System.Windows.Forms.TextBox();
            this.txtGymClassName = new System.Windows.Forms.TextBox();
            this.txtGymClassID = new System.Windows.Forms.TextBox();
            this.lblGymMFee = new System.Windows.Forms.Label();
            this.lblGymInsName = new System.Windows.Forms.Label();
            this.lblGymClassName = new System.Windows.Forms.Label();
            this.lblGymClassID = new System.Windows.Forms.Label();
            this.dataGridGymClass = new System.Windows.Forms.DataGridView();
            this.classID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataEnrollGymClass = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEnrollCust = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.txtEnrollCust = new System.Windows.Forms.TextBox();
            this.lblEnrollCust = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnrollClass = new System.Windows.Forms.Label();
            this.txtEnrollLength = new System.Windows.Forms.TextBox();
            this.txtEnrollClass = new System.Windows.Forms.TextBox();
            this.txtEnrollDateTime = new System.Windows.Forms.TextBox();
            this.lblEnrollDateTime = new System.Windows.Forms.Label();
            this.btnEnrollCancel = new System.Windows.Forms.Button();
            this.dataEnrollment = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthEnrollment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGymClass)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnrollGymClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnrollCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnrollment)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 567);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCustomerClear);
            this.tabPage1.Controls.Add(this.btnCustEdit);
            this.tabPage1.Controls.Add(this.btnCustAdd);
            this.tabPage1.Controls.Add(this.lblCustAddress);
            this.tabPage1.Controls.Add(this.lblCustMname);
            this.tabPage1.Controls.Add(this.lblCustFname);
            this.tabPage1.Controls.Add(this.lblCustLname);
            this.tabPage1.Controls.Add(this.lblCustID);
            this.tabPage1.Controls.Add(this.txtCustAddress);
            this.tabPage1.Controls.Add(this.txtCustMName);
            this.tabPage1.Controls.Add(this.txtCustFName);
            this.tabPage1.Controls.Add(this.txtCustLName);
            this.tabPage1.Controls.Add(this.txtCustID);
            this.tabPage1.Controls.Add(this.dataGridCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1115, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCustomerClear
            // 
            this.btnCustomerClear.Location = new System.Drawing.Point(40, 328);
            this.btnCustomerClear.Name = "btnCustomerClear";
            this.btnCustomerClear.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerClear.TabIndex = 13;
            this.btnCustomerClear.Text = "CLEAR";
            this.btnCustomerClear.UseVisualStyleBackColor = true;
            this.btnCustomerClear.Click += new System.EventHandler(this.btnCustomerClear_Click);
            // 
            // btnCustEdit
            // 
            this.btnCustEdit.Location = new System.Drawing.Point(40, 289);
            this.btnCustEdit.Name = "btnCustEdit";
            this.btnCustEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCustEdit.TabIndex = 12;
            this.btnCustEdit.Text = "EDIT";
            this.btnCustEdit.UseVisualStyleBackColor = true;
            this.btnCustEdit.Click += new System.EventHandler(this.btnCustEdit_Click);
            // 
            // btnCustAdd
            // 
            this.btnCustAdd.Location = new System.Drawing.Point(40, 260);
            this.btnCustAdd.Name = "btnCustAdd";
            this.btnCustAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCustAdd.TabIndex = 11;
            this.btnCustAdd.Text = "ADD";
            this.btnCustAdd.UseVisualStyleBackColor = true;
            this.btnCustAdd.Click += new System.EventHandler(this.btnCustAdd_Click);
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.Location = new System.Drawing.Point(7, 209);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(48, 13);
            this.lblCustAddress.TabIndex = 10;
            this.lblCustAddress.Text = "Address:";
            // 
            // lblCustMname
            // 
            this.lblCustMname.AutoSize = true;
            this.lblCustMname.Location = new System.Drawing.Point(7, 162);
            this.lblCustMname.Name = "lblCustMname";
            this.lblCustMname.Size = new System.Drawing.Size(72, 13);
            this.lblCustMname.TabIndex = 9;
            this.lblCustMname.Text = "Middle Name:";
            // 
            // lblCustFname
            // 
            this.lblCustFname.AutoSize = true;
            this.lblCustFname.Location = new System.Drawing.Point(7, 120);
            this.lblCustFname.Name = "lblCustFname";
            this.lblCustFname.Size = new System.Drawing.Size(60, 13);
            this.lblCustFname.TabIndex = 8;
            this.lblCustFname.Text = "First Name:";
            // 
            // lblCustLname
            // 
            this.lblCustLname.AutoSize = true;
            this.lblCustLname.Location = new System.Drawing.Point(6, 79);
            this.lblCustLname.Name = "lblCustLname";
            this.lblCustLname.Size = new System.Drawing.Size(61, 13);
            this.lblCustLname.TabIndex = 7;
            this.lblCustLname.Text = "Last Name:";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(6, 37);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(68, 13);
            this.lblCustID.TabIndex = 6;
            this.lblCustID.Text = "Customer ID:";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(79, 209);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(100, 20);
            this.txtCustAddress.TabIndex = 5;
            // 
            // txtCustMName
            // 
            this.txtCustMName.Location = new System.Drawing.Point(79, 162);
            this.txtCustMName.Name = "txtCustMName";
            this.txtCustMName.Size = new System.Drawing.Size(100, 20);
            this.txtCustMName.TabIndex = 4;
            // 
            // txtCustFName
            // 
            this.txtCustFName.Location = new System.Drawing.Point(79, 120);
            this.txtCustFName.Name = "txtCustFName";
            this.txtCustFName.Size = new System.Drawing.Size(100, 20);
            this.txtCustFName.TabIndex = 3;
            // 
            // txtCustLName
            // 
            this.txtCustLName.Location = new System.Drawing.Point(79, 76);
            this.txtCustLName.Name = "txtCustLName";
            this.txtCustLName.Size = new System.Drawing.Size(100, 20);
            this.txtCustLName.TabIndex = 2;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(79, 37);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(100, 20);
            this.txtCustID.TabIndex = 1;
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custID,
            this.custLastName,
            this.custFirstName,
            this.custMiddleName,
            this.custAddress});
            this.dataGridCustomers.Location = new System.Drawing.Point(194, 6);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.Size = new System.Drawing.Size(535, 354);
            this.dataGridCustomers.TabIndex = 0;
            this.dataGridCustomers.SelectionChanged += new System.EventHandler(this.dataGridCustomers_SelectionChanged);
            // 
            // custID
            // 
            this.custID.HeaderText = "Customer ID";
            this.custID.Name = "custID";
            this.custID.ReadOnly = true;
            // 
            // custLastName
            // 
            this.custLastName.HeaderText = "Last Name";
            this.custLastName.Name = "custLastName";
            this.custLastName.ReadOnly = true;
            // 
            // custFirstName
            // 
            this.custFirstName.HeaderText = "First Name";
            this.custFirstName.Name = "custFirstName";
            this.custFirstName.ReadOnly = true;
            // 
            // custMiddleName
            // 
            this.custMiddleName.HeaderText = "Middle Name";
            this.custMiddleName.Name = "custMiddleName";
            this.custMiddleName.ReadOnly = true;
            // 
            // custAddress
            // 
            this.custAddress.HeaderText = "Address";
            this.custAddress.Name = "custAddress";
            this.custAddress.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGymClassClear);
            this.tabPage2.Controls.Add(this.btnGymEdit);
            this.tabPage2.Controls.Add(this.btnGymAdd);
            this.tabPage2.Controls.Add(this.txtGymMFee);
            this.tabPage2.Controls.Add(this.txtGymInsName);
            this.tabPage2.Controls.Add(this.txtGymClassName);
            this.tabPage2.Controls.Add(this.txtGymClassID);
            this.tabPage2.Controls.Add(this.lblGymMFee);
            this.tabPage2.Controls.Add(this.lblGymInsName);
            this.tabPage2.Controls.Add(this.lblGymClassName);
            this.tabPage2.Controls.Add(this.lblGymClassID);
            this.tabPage2.Controls.Add(this.dataGridGymClass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1115, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gym Class";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGymClassClear
            // 
            this.btnGymClassClear.Location = new System.Drawing.Point(48, 309);
            this.btnGymClassClear.Name = "btnGymClassClear";
            this.btnGymClassClear.Size = new System.Drawing.Size(75, 23);
            this.btnGymClassClear.TabIndex = 11;
            this.btnGymClassClear.Text = "CLEAR";
            this.btnGymClassClear.UseVisualStyleBackColor = true;
            this.btnGymClassClear.Click += new System.EventHandler(this.btnGymClassClear_Click);
            // 
            // btnGymEdit
            // 
            this.btnGymEdit.Location = new System.Drawing.Point(48, 251);
            this.btnGymEdit.Name = "btnGymEdit";
            this.btnGymEdit.Size = new System.Drawing.Size(75, 23);
            this.btnGymEdit.TabIndex = 10;
            this.btnGymEdit.Text = "EDIT";
            this.btnGymEdit.UseVisualStyleBackColor = true;
            this.btnGymEdit.Click += new System.EventHandler(this.btnGymEdit_Click);
            // 
            // btnGymAdd
            // 
            this.btnGymAdd.Location = new System.Drawing.Point(48, 280);
            this.btnGymAdd.Name = "btnGymAdd";
            this.btnGymAdd.Size = new System.Drawing.Size(75, 23);
            this.btnGymAdd.TabIndex = 9;
            this.btnGymAdd.Text = "ADD";
            this.btnGymAdd.UseVisualStyleBackColor = true;
            this.btnGymAdd.Click += new System.EventHandler(this.btnGymAdd_Click);
            // 
            // txtGymMFee
            // 
            this.txtGymMFee.Location = new System.Drawing.Point(86, 162);
            this.txtGymMFee.Name = "txtGymMFee";
            this.txtGymMFee.Size = new System.Drawing.Size(100, 20);
            this.txtGymMFee.TabIndex = 8;
            // 
            // txtGymInsName
            // 
            this.txtGymInsName.Location = new System.Drawing.Point(86, 125);
            this.txtGymInsName.Name = "txtGymInsName";
            this.txtGymInsName.Size = new System.Drawing.Size(100, 20);
            this.txtGymInsName.TabIndex = 7;
            // 
            // txtGymClassName
            // 
            this.txtGymClassName.Location = new System.Drawing.Point(86, 93);
            this.txtGymClassName.Name = "txtGymClassName";
            this.txtGymClassName.Size = new System.Drawing.Size(100, 20);
            this.txtGymClassName.TabIndex = 6;
            // 
            // txtGymClassID
            // 
            this.txtGymClassID.Location = new System.Drawing.Point(86, 64);
            this.txtGymClassID.Name = "txtGymClassID";
            this.txtGymClassID.Size = new System.Drawing.Size(100, 20);
            this.txtGymClassID.TabIndex = 5;
            // 
            // lblGymMFee
            // 
            this.lblGymMFee.AutoSize = true;
            this.lblGymMFee.Location = new System.Drawing.Point(6, 165);
            this.lblGymMFee.Name = "lblGymMFee";
            this.lblGymMFee.Size = new System.Drawing.Size(68, 13);
            this.lblGymMFee.TabIndex = 4;
            this.lblGymMFee.Text = "Monthly Fee:";
            // 
            // lblGymInsName
            // 
            this.lblGymInsName.AutoSize = true;
            this.lblGymInsName.Location = new System.Drawing.Point(3, 128);
            this.lblGymInsName.Name = "lblGymInsName";
            this.lblGymInsName.Size = new System.Drawing.Size(85, 13);
            this.lblGymInsName.TabIndex = 3;
            this.lblGymInsName.Text = "Instructor Name:";
            // 
            // lblGymClassName
            // 
            this.lblGymClassName.AutoSize = true;
            this.lblGymClassName.Location = new System.Drawing.Point(3, 96);
            this.lblGymClassName.Name = "lblGymClassName";
            this.lblGymClassName.Size = new System.Drawing.Size(66, 13);
            this.lblGymClassName.TabIndex = 2;
            this.lblGymClassName.Text = "Class Name:";
            // 
            // lblGymClassID
            // 
            this.lblGymClassID.AutoSize = true;
            this.lblGymClassID.Location = new System.Drawing.Point(6, 64);
            this.lblGymClassID.Name = "lblGymClassID";
            this.lblGymClassID.Size = new System.Drawing.Size(49, 13);
            this.lblGymClassID.TabIndex = 1;
            this.lblGymClassID.Text = "Class ID:";
            // 
            // dataGridGymClass
            // 
            this.dataGridGymClass.AllowUserToAddRows = false;
            this.dataGridGymClass.AllowUserToDeleteRows = false;
            this.dataGridGymClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGymClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classID,
            this.className,
            this.instructorName,
            this.monthlyFee});
            this.dataGridGymClass.Location = new System.Drawing.Point(190, 19);
            this.dataGridGymClass.Name = "dataGridGymClass";
            this.dataGridGymClass.ReadOnly = true;
            this.dataGridGymClass.Size = new System.Drawing.Size(536, 338);
            this.dataGridGymClass.TabIndex = 0;
            this.dataGridGymClass.SelectionChanged += new System.EventHandler(this.dataGridGymClass_SelectionChanged);
            // 
            // classID
            // 
            this.classID.HeaderText = "Class ID";
            this.classID.Name = "classID";
            this.classID.ReadOnly = true;
            // 
            // className
            // 
            this.className.HeaderText = "Class Name";
            this.className.Name = "className";
            this.className.ReadOnly = true;
            // 
            // instructorName
            // 
            this.instructorName.HeaderText = "Instructor Name";
            this.instructorName.Name = "instructorName";
            this.instructorName.ReadOnly = true;
            this.instructorName.Width = 150;
            // 
            // monthlyFee
            // 
            this.monthlyFee.HeaderText = "Monthly Fee";
            this.monthlyFee.Name = "monthlyFee";
            this.monthlyFee.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataEnrollGymClass);
            this.tabPage3.Controls.Add(this.dataEnrollCust);
            this.tabPage3.Controls.Add(this.btnEnroll);
            this.tabPage3.Controls.Add(this.txtEnrollCust);
            this.tabPage3.Controls.Add(this.lblEnrollCust);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.lblEnrollClass);
            this.tabPage3.Controls.Add(this.txtEnrollLength);
            this.tabPage3.Controls.Add(this.txtEnrollClass);
            this.tabPage3.Controls.Add(this.txtEnrollDateTime);
            this.tabPage3.Controls.Add(this.lblEnrollDateTime);
            this.tabPage3.Controls.Add(this.btnEnrollCancel);
            this.tabPage3.Controls.Add(this.dataEnrollment);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1115, 541);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cutomer Enrollment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataEnrollGymClass
            // 
            this.dataEnrollGymClass.AllowUserToAddRows = false;
            this.dataEnrollGymClass.AllowUserToDeleteRows = false;
            this.dataEnrollGymClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEnrollGymClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataEnrollGymClass.Location = new System.Drawing.Point(520, 198);
            this.dataEnrollGymClass.Name = "dataEnrollGymClass";
            this.dataEnrollGymClass.ReadOnly = true;
            this.dataEnrollGymClass.Size = new System.Drawing.Size(578, 169);
            this.dataEnrollGymClass.TabIndex = 12;
            this.dataEnrollGymClass.SelectionChanged += new System.EventHandler(this.dataEnrollGymClass_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Class ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Class Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Instructor Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Monthly Fee";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataEnrollCust
            // 
            this.dataEnrollCust.AllowUserToAddRows = false;
            this.dataEnrollCust.AllowUserToDeleteRows = false;
            this.dataEnrollCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEnrollCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataEnrollCust.Location = new System.Drawing.Point(520, 11);
            this.dataEnrollCust.Name = "dataEnrollCust";
            this.dataEnrollCust.ReadOnly = true;
            this.dataEnrollCust.Size = new System.Drawing.Size(578, 159);
            this.dataEnrollCust.TabIndex = 11;
            this.dataEnrollCust.SelectionChanged += new System.EventHandler(this.dataEnrollCust_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Middle Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(22, 267);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(84, 39);
            this.btnEnroll.TabIndex = 10;
            this.btnEnroll.Text = "ENROLL";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // txtEnrollCust
            // 
            this.txtEnrollCust.Location = new System.Drawing.Point(22, 24);
            this.txtEnrollCust.Name = "txtEnrollCust";
            this.txtEnrollCust.Size = new System.Drawing.Size(100, 20);
            this.txtEnrollCust.TabIndex = 9;
            // 
            // lblEnrollCust
            // 
            this.lblEnrollCust.AutoSize = true;
            this.lblEnrollCust.Location = new System.Drawing.Point(28, 7);
            this.lblEnrollCust.Name = "lblEnrollCust";
            this.lblEnrollCust.Size = new System.Drawing.Size(68, 13);
            this.lblEnrollCust.TabIndex = 8;
            this.lblEnrollCust.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enrollment Length:";
            // 
            // lblEnrollClass
            // 
            this.lblEnrollClass.AutoSize = true;
            this.lblEnrollClass.Location = new System.Drawing.Point(26, 50);
            this.lblEnrollClass.Name = "lblEnrollClass";
            this.lblEnrollClass.Size = new System.Drawing.Size(35, 13);
            this.lblEnrollClass.TabIndex = 6;
            this.lblEnrollClass.Text = "Class:";
            // 
            // txtEnrollLength
            // 
            this.txtEnrollLength.Location = new System.Drawing.Point(22, 116);
            this.txtEnrollLength.Name = "txtEnrollLength";
            this.txtEnrollLength.Size = new System.Drawing.Size(100, 20);
            this.txtEnrollLength.TabIndex = 5;
            // 
            // txtEnrollClass
            // 
            this.txtEnrollClass.Location = new System.Drawing.Point(22, 73);
            this.txtEnrollClass.Name = "txtEnrollClass";
            this.txtEnrollClass.Size = new System.Drawing.Size(100, 20);
            this.txtEnrollClass.TabIndex = 4;
            // 
            // txtEnrollDateTime
            // 
            this.txtEnrollDateTime.Location = new System.Drawing.Point(22, 172);
            this.txtEnrollDateTime.Name = "txtEnrollDateTime";
            this.txtEnrollDateTime.Size = new System.Drawing.Size(100, 20);
            this.txtEnrollDateTime.TabIndex = 3;
            // 
            // lblEnrollDateTime
            // 
            this.lblEnrollDateTime.AutoSize = true;
            this.lblEnrollDateTime.Location = new System.Drawing.Point(19, 145);
            this.lblEnrollDateTime.Name = "lblEnrollDateTime";
            this.lblEnrollDateTime.Size = new System.Drawing.Size(77, 13);
            this.lblEnrollDateTime.TabIndex = 2;
            this.lblEnrollDateTime.Text = "Date and Time";
            // 
            // btnEnrollCancel
            // 
            this.btnEnrollCancel.Location = new System.Drawing.Point(22, 230);
            this.btnEnrollCancel.Name = "btnEnrollCancel";
            this.btnEnrollCancel.Size = new System.Drawing.Size(84, 31);
            this.btnEnrollCancel.TabIndex = 1;
            this.btnEnrollCancel.Text = "CANCEL";
            this.btnEnrollCancel.UseVisualStyleBackColor = true;
            this.btnEnrollCancel.Click += new System.EventHandler(this.btnEnrollCancel_Click);
            // 
            // dataEnrollment
            // 
            this.dataEnrollment.AllowUserToAddRows = false;
            this.dataEnrollment.AllowUserToDeleteRows = false;
            this.dataEnrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEnrollment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.classesId,
            this.lengthEnrollment,
            this.enrollment});
            this.dataEnrollment.Location = new System.Drawing.Point(520, 389);
            this.dataEnrollment.Name = "dataEnrollment";
            this.dataEnrollment.ReadOnly = true;
            this.dataEnrollment.Size = new System.Drawing.Size(578, 146);
            this.dataEnrollment.TabIndex = 0;
            // 
            // customerID
            // 
            this.customerID.HeaderText = "Customer ID";
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            // 
            // classesId
            // 
            this.classesId.HeaderText = "Class";
            this.classesId.Name = "classesId";
            this.classesId.ReadOnly = true;
            // 
            // lengthEnrollment
            // 
            this.lengthEnrollment.HeaderText = "Enrollment Length";
            this.lengthEnrollment.Name = "lengthEnrollment";
            this.lengthEnrollment.ReadOnly = true;
            this.lengthEnrollment.Width = 130;
            // 
            // enrollment
            // 
            this.enrollment.HeaderText = "Enrollment Date and Time";
            this.enrollment.Name = "enrollment";
            this.enrollment.ReadOnly = true;
            this.enrollment.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 639);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGymClass)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnrollGymClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnrollCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnrollment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.DataGridView dataGridGymClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn custID;
        private System.Windows.Forms.DataGridViewTextBoxColumn custLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn custMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn classID;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyFee;
        private System.Windows.Forms.Label lblCustAddress;
        private System.Windows.Forms.Label lblCustMname;
        private System.Windows.Forms.Label lblCustFname;
        private System.Windows.Forms.Label lblCustLname;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustMName;
        private System.Windows.Forms.TextBox txtCustFName;
        private System.Windows.Forms.TextBox txtCustLName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtGymMFee;
        private System.Windows.Forms.TextBox txtGymInsName;
        private System.Windows.Forms.TextBox txtGymClassName;
        private System.Windows.Forms.TextBox txtGymClassID;
        private System.Windows.Forms.Label lblGymMFee;
        private System.Windows.Forms.Label lblGymInsName;
        private System.Windows.Forms.Label lblGymClassName;
        private System.Windows.Forms.Label lblGymClassID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEnrollCancel;
        private System.Windows.Forms.DataGridView dataEnrollment;
        private System.Windows.Forms.Button btnCustAdd;
        private System.Windows.Forms.Button btnGymAdd;
        private System.Windows.Forms.TextBox txtEnrollDateTime;
        private System.Windows.Forms.Label lblEnrollDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnrollClass;
        private System.Windows.Forms.TextBox txtEnrollLength;
        private System.Windows.Forms.TextBox txtEnrollClass;
        private System.Windows.Forms.TextBox txtEnrollCust;
        private System.Windows.Forms.Label lblEnrollCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn classesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthEnrollment;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollment;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnCustEdit;
        private System.Windows.Forms.Button btnGymEdit;
        private System.Windows.Forms.Button btnCustomerClear;
        private System.Windows.Forms.Button btnGymClassClear;
        private System.Windows.Forms.DataGridView dataEnrollGymClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView dataEnrollCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

