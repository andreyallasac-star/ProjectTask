namespace ProjectTask
{
    partial class frmEnrollment
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
            System.Windows.Forms.Label lblTuitionFeeValue;
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.GrpStudent = new System.Windows.Forms.GroupBox();
            this.txtStudentContact = new System.Windows.Forms.MaskedTextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStudentContact = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.grpGuardian = new System.Windows.Forms.GroupBox();
            this.txtGuardianContact = new System.Windows.Forms.MaskedTextBox();
            this.txtGuardianRelationship = new System.Windows.Forms.TextBox();
            this.lblGuardianRelationship = new System.Windows.Forms.Label();
            this.txtGuardianAddress = new System.Windows.Forms.TextBox();
            this.lblGuardianAddress = new System.Windows.Forms.Label();
            this.lblGuardianContact = new System.Windows.Forms.Label();
            this.lblGuardianMiddleName = new System.Windows.Forms.Label();
            this.lblGuardianFirstName = new System.Windows.Forms.Label();
            this.txtGuardianMiddleName = new System.Windows.Forms.TextBox();
            this.txtGuardianFirstName = new System.Windows.Forms.TextBox();
            this.txtGuardianLastName = new System.Windows.Forms.TextBox();
            this.lblGuardianLastName = new System.Windows.Forms.Label();
            this.grpAcademic = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYearLevel = new System.Windows.Forms.ComboBox();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.grpDiscount = new System.Windows.Forms.GroupBox();
            this.rbFullScholar = new System.Windows.Forms.RadioButton();
            this.rb50 = new System.Windows.Forms.RadioButton();
            this.rb25 = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTranscript = new System.Windows.Forms.CheckBox();
            this.chkGoodMoral = new System.Windows.Forms.CheckBox();
            this.chkBirthCertificate = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbInstallment = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDiscountedAmount = new System.Windows.Forms.Label();
            this.lblTuitionFee = new System.Windows.Forms.Label();
            this.lblStudNumValue = new System.Windows.Forms.Label();
            lblTuitionFeeValue = new System.Windows.Forms.Label();
            this.GrpStudent.SuspendLayout();
            this.grpGuardian.SuspendLayout();
            this.grpAcademic.SuspendLayout();
            this.grpDiscount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTuitionFeeValue
            // 
            lblTuitionFeeValue.AutoSize = true;
            lblTuitionFeeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            lblTuitionFeeValue.ForeColor = System.Drawing.Color.White;
            lblTuitionFeeValue.Location = new System.Drawing.Point(7, 76);
            lblTuitionFeeValue.Name = "lblTuitionFeeValue";
            lblTuitionFeeValue.Size = new System.Drawing.Size(151, 13);
            lblTuitionFeeValue.TabIndex = 4;
            lblTuitionFeeValue.Text = "Discounted Tuition Fee:  ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(190, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtLastName.Location = new System.Drawing.Point(20, 39);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // cmbProgram
            // 
            this.cmbProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProgram.FormattingEnabled = true;
            this.cmbProgram.Items.AddRange(new object[] {
            "BSIT",
            "BSTM",
            "BSCE"});
            this.cmbProgram.Location = new System.Drawing.Point(207, 38);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(182, 21);
            this.cmbProgram.TabIndex = 2;
            this.cmbProgram.SelectedIndexChanged += new System.EventHandler(this.cmbProgram_SelectedIndexChanged);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Location = new System.Drawing.Point(192, 86);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(291, 20);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFirstName.Location = new System.Drawing.Point(192, 39);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(137, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(18, 23);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.ForeColor = System.Drawing.Color.White;
            this.lblProgram.Location = new System.Drawing.Point(204, 23);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(53, 13);
            this.lblProgram.TabIndex = 6;
            this.lblProgram.Text = "Program";
            // 
            // GrpStudent
            // 
            this.GrpStudent.BackColor = System.Drawing.Color.Transparent;
            this.GrpStudent.Controls.Add(this.txtStudentContact);
            this.GrpStudent.Controls.Add(this.txtMiddleName);
            this.GrpStudent.Controls.Add(this.lblMiddleName);
            this.GrpStudent.Controls.Add(this.txtAddress);
            this.GrpStudent.Controls.Add(this.lblAddress);
            this.GrpStudent.Controls.Add(this.lblStudentContact);
            this.GrpStudent.Controls.Add(this.lblBirthDate);
            this.GrpStudent.Controls.Add(this.txtLastName);
            this.GrpStudent.Controls.Add(this.dtpBirthDate);
            this.GrpStudent.Controls.Add(this.lblFirstName);
            this.GrpStudent.Controls.Add(this.lblLastName);
            this.GrpStudent.Controls.Add(this.txtFirstName);
            this.GrpStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.GrpStudent.Location = new System.Drawing.Point(12, 34);
            this.GrpStudent.Name = "GrpStudent";
            this.GrpStudent.Size = new System.Drawing.Size(504, 192);
            this.GrpStudent.TabIndex = 7;
            this.GrpStudent.TabStop = false;
            this.GrpStudent.Text = "Student Information";
            // 
            // txtStudentContact
            // 
            this.txtStudentContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentContact.Location = new System.Drawing.Point(20, 86);
            this.txtStudentContact.Name = "txtStudentContact";
            this.txtStudentContact.Size = new System.Drawing.Size(144, 20);
            this.txtStudentContact.TabIndex = 16;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMiddleName.Location = new System.Drawing.Point(355, 39);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(128, 20);
            this.txtMiddleName.TabIndex = 13;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMiddleName.ForeColor = System.Drawing.Color.White;
            this.lblMiddleName.Location = new System.Drawing.Point(352, 22);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(80, 13);
            this.lblMiddleName.TabIndex = 12;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(20, 133);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(463, 47);
            this.txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(19, 112);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // lblStudentContact
            // 
            this.lblStudentContact.AutoSize = true;
            this.lblStudentContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentContact.ForeColor = System.Drawing.Color.White;
            this.lblStudentContact.Location = new System.Drawing.Point(18, 68);
            this.lblStudentContact.Name = "lblStudentContact";
            this.lblStudentContact.Size = new System.Drawing.Size(98, 13);
            this.lblStudentContact.TabIndex = 8;
            this.lblStudentContact.Text = "Contact Number";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBirthDate.ForeColor = System.Drawing.Color.White;
            this.lblBirthDate.Location = new System.Drawing.Point(191, 68);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(79, 13);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Date of Birth";
            // 
            // grpGuardian
            // 
            this.grpGuardian.BackColor = System.Drawing.Color.Transparent;
            this.grpGuardian.Controls.Add(this.txtGuardianContact);
            this.grpGuardian.Controls.Add(this.txtGuardianRelationship);
            this.grpGuardian.Controls.Add(this.lblGuardianRelationship);
            this.grpGuardian.Controls.Add(this.txtGuardianAddress);
            this.grpGuardian.Controls.Add(this.lblGuardianAddress);
            this.grpGuardian.Controls.Add(this.lblGuardianContact);
            this.grpGuardian.Controls.Add(this.lblGuardianMiddleName);
            this.grpGuardian.Controls.Add(this.lblGuardianFirstName);
            this.grpGuardian.Controls.Add(this.txtGuardianMiddleName);
            this.grpGuardian.Controls.Add(this.txtGuardianFirstName);
            this.grpGuardian.Controls.Add(this.txtGuardianLastName);
            this.grpGuardian.Controls.Add(this.lblGuardianLastName);
            this.grpGuardian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpGuardian.Location = new System.Drawing.Point(12, 231);
            this.grpGuardian.Name = "grpGuardian";
            this.grpGuardian.Size = new System.Drawing.Size(504, 174);
            this.grpGuardian.TabIndex = 8;
            this.grpGuardian.TabStop = false;
            this.grpGuardian.Text = "Guardian Information";
            // 
            // txtGuardianContact
            // 
            this.txtGuardianContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianContact.Location = new System.Drawing.Point(22, 82);
            this.txtGuardianContact.Mask = "(999) 000-0000";
            this.txtGuardianContact.Name = "txtGuardianContact";
            this.txtGuardianContact.Size = new System.Drawing.Size(144, 20);
            this.txtGuardianContact.TabIndex = 12;
            // 
            // txtGuardianRelationship
            // 
            this.txtGuardianRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianRelationship.Location = new System.Drawing.Point(22, 126);
            this.txtGuardianRelationship.Name = "txtGuardianRelationship";
            this.txtGuardianRelationship.Size = new System.Drawing.Size(144, 20);
            this.txtGuardianRelationship.TabIndex = 11;
            // 
            // lblGuardianRelationship
            // 
            this.lblGuardianRelationship.AutoSize = true;
            this.lblGuardianRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGuardianRelationship.ForeColor = System.Drawing.Color.White;
            this.lblGuardianRelationship.Location = new System.Drawing.Point(24, 110);
            this.lblGuardianRelationship.Name = "lblGuardianRelationship";
            this.lblGuardianRelationship.Size = new System.Drawing.Size(77, 13);
            this.lblGuardianRelationship.TabIndex = 10;
            this.lblGuardianRelationship.Text = "Relationship";
            // 
            // txtGuardianAddress
            // 
            this.txtGuardianAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianAddress.Location = new System.Drawing.Point(192, 82);
            this.txtGuardianAddress.Multiline = true;
            this.txtGuardianAddress.Name = "txtGuardianAddress";
            this.txtGuardianAddress.Size = new System.Drawing.Size(291, 54);
            this.txtGuardianAddress.TabIndex = 9;
            // 
            // lblGuardianAddress
            // 
            this.lblGuardianAddress.AutoSize = true;
            this.lblGuardianAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGuardianAddress.ForeColor = System.Drawing.Color.White;
            this.lblGuardianAddress.Location = new System.Drawing.Point(191, 66);
            this.lblGuardianAddress.Name = "lblGuardianAddress";
            this.lblGuardianAddress.Size = new System.Drawing.Size(52, 13);
            this.lblGuardianAddress.TabIndex = 8;
            this.lblGuardianAddress.Text = "Address";
            // 
            // lblGuardianContact
            // 
            this.lblGuardianContact.AutoSize = true;
            this.lblGuardianContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGuardianContact.ForeColor = System.Drawing.Color.White;
            this.lblGuardianContact.Location = new System.Drawing.Point(23, 66);
            this.lblGuardianContact.Name = "lblGuardianContact";
            this.lblGuardianContact.Size = new System.Drawing.Size(98, 13);
            this.lblGuardianContact.TabIndex = 6;
            this.lblGuardianContact.Text = "Contact Number";
            // 
            // lblGuardianMiddleName
            // 
            this.lblGuardianMiddleName.AutoSize = true;
            this.lblGuardianMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGuardianMiddleName.ForeColor = System.Drawing.Color.White;
            this.lblGuardianMiddleName.Location = new System.Drawing.Point(353, 18);
            this.lblGuardianMiddleName.Name = "lblGuardianMiddleName";
            this.lblGuardianMiddleName.Size = new System.Drawing.Size(80, 13);
            this.lblGuardianMiddleName.TabIndex = 5;
            this.lblGuardianMiddleName.Text = "Middle Name";
            // 
            // lblGuardianFirstName
            // 
            this.lblGuardianFirstName.AutoSize = true;
            this.lblGuardianFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianFirstName.ForeColor = System.Drawing.Color.White;
            this.lblGuardianFirstName.Location = new System.Drawing.Point(191, 19);
            this.lblGuardianFirstName.Name = "lblGuardianFirstName";
            this.lblGuardianFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblGuardianFirstName.TabIndex = 4;
            this.lblGuardianFirstName.Text = "First Name";
            // 
            // txtGuardianMiddleName
            // 
            this.txtGuardianMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianMiddleName.Location = new System.Drawing.Point(355, 38);
            this.txtGuardianMiddleName.Name = "txtGuardianMiddleName";
            this.txtGuardianMiddleName.Size = new System.Drawing.Size(128, 20);
            this.txtGuardianMiddleName.TabIndex = 3;
            // 
            // txtGuardianFirstName
            // 
            this.txtGuardianFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianFirstName.Location = new System.Drawing.Point(192, 38);
            this.txtGuardianFirstName.Name = "txtGuardianFirstName";
            this.txtGuardianFirstName.Size = new System.Drawing.Size(137, 20);
            this.txtGuardianFirstName.TabIndex = 2;
            // 
            // txtGuardianLastName
            // 
            this.txtGuardianLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianLastName.Location = new System.Drawing.Point(21, 38);
            this.txtGuardianLastName.Name = "txtGuardianLastName";
            this.txtGuardianLastName.Size = new System.Drawing.Size(145, 20);
            this.txtGuardianLastName.TabIndex = 1;
            // 
            // lblGuardianLastName
            // 
            this.lblGuardianLastName.AutoSize = true;
            this.lblGuardianLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianLastName.ForeColor = System.Drawing.Color.White;
            this.lblGuardianLastName.Location = new System.Drawing.Point(22, 22);
            this.lblGuardianLastName.Name = "lblGuardianLastName";
            this.lblGuardianLastName.Size = new System.Drawing.Size(67, 13);
            this.lblGuardianLastName.TabIndex = 0;
            this.lblGuardianLastName.Text = "Last Name";
            // 
            // grpAcademic
            // 
            this.grpAcademic.BackColor = System.Drawing.Color.Transparent;
            this.grpAcademic.Controls.Add(this.lblTuitionFee);
            this.grpAcademic.Controls.Add(this.label2);
            this.grpAcademic.Controls.Add(this.cmbYearLevel);
            this.grpAcademic.Controls.Add(this.lblYearLevel);
            this.grpAcademic.Controls.Add(this.lblProgram);
            this.grpAcademic.Controls.Add(this.cmbProgram);
            this.grpAcademic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpAcademic.Location = new System.Drawing.Point(522, 34);
            this.grpAcademic.Name = "grpAcademic";
            this.grpAcademic.Size = new System.Drawing.Size(402, 100);
            this.grpAcademic.TabIndex = 9;
            this.grpAcademic.TabStop = false;
            this.grpAcademic.Text = "Academic Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tuition Fee:";
            // 
            // cmbYearLevel
            // 
            this.cmbYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYearLevel.FormattingEnabled = true;
            this.cmbYearLevel.Items.AddRange(new object[] {
            "1st Year",
            "2nd year",
            "3rd Year",
            "4th Year"});
            this.cmbYearLevel.Location = new System.Drawing.Point(9, 38);
            this.cmbYearLevel.Name = "cmbYearLevel";
            this.cmbYearLevel.Size = new System.Drawing.Size(182, 21);
            this.cmbYearLevel.TabIndex = 1;
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblYearLevel.ForeColor = System.Drawing.Color.White;
            this.lblYearLevel.Location = new System.Drawing.Point(6, 22);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(68, 13);
            this.lblYearLevel.TabIndex = 0;
            this.lblYearLevel.Text = "Year Level";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudentNumber.Location = new System.Drawing.Point(18, 9);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(135, 17);
            this.lblStudentNumber.TabIndex = 10;
            this.lblStudentNumber.Text = "Student Number: ";
            // 
            // grpDiscount
            // 
            this.grpDiscount.BackColor = System.Drawing.Color.Transparent;
            this.grpDiscount.Controls.Add(this.rbFullScholar);
            this.grpDiscount.Controls.Add(this.rb50);
            this.grpDiscount.Controls.Add(this.rb25);
            this.grpDiscount.Controls.Add(this.rbNone);
            this.grpDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpDiscount.Location = new System.Drawing.Point(522, 140);
            this.grpDiscount.Name = "grpDiscount";
            this.grpDiscount.Size = new System.Drawing.Size(191, 122);
            this.grpDiscount.TabIndex = 11;
            this.grpDiscount.TabStop = false;
            this.grpDiscount.Text = "Discount Options";
            // 
            // rbFullScholar
            // 
            this.rbFullScholar.AutoSize = true;
            this.rbFullScholar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbFullScholar.ForeColor = System.Drawing.Color.White;
            this.rbFullScholar.Location = new System.Drawing.Point(9, 87);
            this.rbFullScholar.Name = "rbFullScholar";
            this.rbFullScholar.Size = new System.Drawing.Size(92, 17);
            this.rbFullScholar.TabIndex = 3;
            this.rbFullScholar.TabStop = true;
            this.rbFullScholar.Text = "Full Scholar";
            this.rbFullScholar.UseVisualStyleBackColor = true;
            this.rbFullScholar.CheckedChanged += new System.EventHandler(this.rbFullScholar_CheckedChanged);
            // 
            // rb50
            // 
            this.rb50.AutoSize = true;
            this.rb50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rb50.ForeColor = System.Drawing.Color.White;
            this.rb50.Location = new System.Drawing.Point(9, 64);
            this.rb50.Name = "rb50";
            this.rb50.Size = new System.Drawing.Size(102, 17);
            this.rb50.TabIndex = 2;
            this.rb50.TabStop = true;
            this.rb50.Text = "50% Discount";
            this.rb50.UseVisualStyleBackColor = true;
            this.rb50.CheckedChanged += new System.EventHandler(this.rb50_CheckedChanged);
            // 
            // rb25
            // 
            this.rb25.AutoSize = true;
            this.rb25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rb25.ForeColor = System.Drawing.Color.White;
            this.rb25.Location = new System.Drawing.Point(9, 41);
            this.rb25.Name = "rb25";
            this.rb25.Size = new System.Drawing.Size(102, 17);
            this.rb25.TabIndex = 1;
            this.rb25.TabStop = true;
            this.rb25.Text = "25% Discount";
            this.rb25.UseVisualStyleBackColor = true;
            this.rb25.CheckedChanged += new System.EventHandler(this.rb25_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbNone.ForeColor = System.Drawing.Color.White;
            this.rbNone.Location = new System.Drawing.Point(9, 17);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(55, 17);
            this.rbNone.TabIndex = 0;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkTranscript);
            this.groupBox1.Controls.Add(this.chkGoodMoral);
            this.groupBox1.Controls.Add(this.chkBirthCertificate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(724, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requirements";
            // 
            // chkTranscript
            // 
            this.chkTranscript.AutoSize = true;
            this.chkTranscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkTranscript.ForeColor = System.Drawing.Color.White;
            this.chkTranscript.Location = new System.Drawing.Point(10, 64);
            this.chkTranscript.Name = "chkTranscript";
            this.chkTranscript.Size = new System.Drawing.Size(143, 17);
            this.chkTranscript.TabIndex = 2;
            this.chkTranscript.Text = "Transcript of Record";
            this.chkTranscript.UseVisualStyleBackColor = true;
            // 
            // chkGoodMoral
            // 
            this.chkGoodMoral.AutoSize = true;
            this.chkGoodMoral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkGoodMoral.ForeColor = System.Drawing.Color.White;
            this.chkGoodMoral.Location = new System.Drawing.Point(10, 41);
            this.chkGoodMoral.Name = "chkGoodMoral";
            this.chkGoodMoral.Size = new System.Drawing.Size(91, 17);
            this.chkGoodMoral.TabIndex = 1;
            this.chkGoodMoral.Text = "Good Moral";
            this.chkGoodMoral.UseVisualStyleBackColor = true;
            // 
            // chkBirthCertificate
            // 
            this.chkBirthCertificate.AutoSize = true;
            this.chkBirthCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkBirthCertificate.ForeColor = System.Drawing.Color.White;
            this.chkBirthCertificate.Location = new System.Drawing.Point(10, 18);
            this.chkBirthCertificate.Name = "chkBirthCertificate";
            this.chkBirthCertificate.Size = new System.Drawing.Size(114, 17);
            this.chkBirthCertificate.TabIndex = 0;
            this.chkBirthCertificate.Text = "Birth Certificate";
            this.chkBirthCertificate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblDiscountedAmount);
            this.groupBox2.Controls.Add(lblTuitionFeeValue);
            this.groupBox2.Controls.Add(this.rbInstallment);
            this.groupBox2.Controls.Add(this.rbCash);
            this.groupBox2.Controls.Add(this.lblAmountToPay);
            this.groupBox2.Controls.Add(this.txtAmountToPay);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(522, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // rbInstallment
            // 
            this.rbInstallment.AutoSize = true;
            this.rbInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbInstallment.ForeColor = System.Drawing.Color.White;
            this.rbInstallment.Location = new System.Drawing.Point(303, 49);
            this.rbInstallment.Name = "rbInstallment";
            this.rbInstallment.Size = new System.Drawing.Size(86, 17);
            this.rbInstallment.TabIndex = 3;
            this.rbInstallment.TabStop = true;
            this.rbInstallment.Text = "Installment";
            this.rbInstallment.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbCash.ForeColor = System.Drawing.Color.White;
            this.rbCash.Location = new System.Drawing.Point(231, 49);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(53, 17);
            this.rbCash.TabIndex = 2;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAmountToPay.ForeColor = System.Drawing.Color.White;
            this.lblAmountToPay.Location = new System.Drawing.Point(6, 30);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(89, 13);
            this.lblAmountToPay.TabIndex = 1;
            this.lblAmountToPay.Text = "Amount to Pay";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountToPay.Location = new System.Drawing.Point(9, 46);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(206, 20);
            this.txtAmountToPay.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(677, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(822, 380);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Register";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDiscountedAmount
            // 
            this.lblDiscountedAmount.AutoSize = true;
            this.lblDiscountedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDiscountedAmount.ForeColor = System.Drawing.Color.White;
            this.lblDiscountedAmount.Location = new System.Drawing.Point(152, 76);
            this.lblDiscountedAmount.Name = "lblDiscountedAmount";
            this.lblDiscountedAmount.Size = new System.Drawing.Size(0, 13);
            this.lblDiscountedAmount.TabIndex = 16;
            // 
            // lblTuitionFee
            // 
            this.lblTuitionFee.AutoSize = true;
            this.lblTuitionFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTuitionFee.ForeColor = System.Drawing.Color.White;
            this.lblTuitionFee.Location = new System.Drawing.Point(209, 68);
            this.lblTuitionFee.Name = "lblTuitionFee";
            this.lblTuitionFee.Size = new System.Drawing.Size(121, 13);
            this.lblTuitionFee.TabIndex = 17;
            this.lblTuitionFee.Text = "<Tuition Fee Value>";
            // 
            // lblStudNumValue
            // 
            this.lblStudNumValue.AutoSize = true;
            this.lblStudNumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNumValue.Location = new System.Drawing.Point(159, 9);
            this.lblStudNumValue.Name = "lblStudNumValue";
            this.lblStudNumValue.Size = new System.Drawing.Size(156, 16);
            this.lblStudNumValue.TabIndex = 16;
            this.lblStudNumValue.Text = "<Stud Number Value>";
            // 
            // frmEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(936, 415);
            this.Controls.Add(this.lblStudNumValue);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDiscount);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.grpAcademic);
            this.Controls.Add(this.grpGuardian);
            this.Controls.Add(this.GrpStudent);
            this.Name = "frmEnrollment";
            this.Text = "Enrollment Form";
            this.Load += new System.EventHandler(this.frmEnrollment_Load);
            this.GrpStudent.ResumeLayout(false);
            this.GrpStudent.PerformLayout();
            this.grpGuardian.ResumeLayout(false);
            this.grpGuardian.PerformLayout();
            this.grpAcademic.ResumeLayout(false);
            this.grpAcademic.PerformLayout();
            this.grpDiscount.ResumeLayout(false);
            this.grpDiscount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbProgram;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.GroupBox GrpStudent;
        private System.Windows.Forms.Label lblStudentContact;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox grpGuardian;
        private System.Windows.Forms.Label lblGuardianLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtGuardianLastName;
        private System.Windows.Forms.Label lblGuardianFirstName;
        private System.Windows.Forms.TextBox txtGuardianMiddleName;
        private System.Windows.Forms.TextBox txtGuardianFirstName;
        private System.Windows.Forms.Label lblGuardianMiddleName;
        private System.Windows.Forms.Label lblGuardianContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.MaskedTextBox txtStudentContact;
        private System.Windows.Forms.TextBox txtGuardianAddress;
        private System.Windows.Forms.Label lblGuardianAddress;
        private System.Windows.Forms.Label lblGuardianRelationship;
        private System.Windows.Forms.MaskedTextBox txtGuardianContact;
        private System.Windows.Forms.TextBox txtGuardianRelationship;
        private System.Windows.Forms.GroupBox grpAcademic;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.ComboBox cmbYearLevel;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDiscount;
        private System.Windows.Forms.RadioButton rb25;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbFullScholar;
        private System.Windows.Forms.RadioButton rb50;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTranscript;
        private System.Windows.Forms.CheckBox chkGoodMoral;
        private System.Windows.Forms.CheckBox chkBirthCertificate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.RadioButton rbInstallment;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDiscountedAmount;
        private System.Windows.Forms.Label lblTuitionFee;
        private System.Windows.Forms.Label lblStudNumValue;
    }
}

