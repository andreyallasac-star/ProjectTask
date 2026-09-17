using System;
using System.Collections;

using System.Windows.Forms;

namespace ProjectTask
{
    public partial class frmEnrollment : Form
    {
        private string connectionString = "Data Source=DESKTOP-TCVIDJV\\SQLEXPRESS01;Initial Catalog=StudentRegDB; Integrated Security=True;" + "TrustServerCertificate=True";
        StudentController studentController;
        ArrayList programList = new ArrayList();
        public frmEnrollment()
        {
            InitializeComponent();
            StudentRepository repo = new StudentRepository(connectionString);
            studentController = new StudentController(repo);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtMiddleName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Please fill the student's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGuardianFirstName.Text) || string.IsNullOrWhiteSpace(txtGuardianMiddleName.Text) || string.IsNullOrWhiteSpace(txtGuardianLastName.Text))
                {
                    MessageBox.Show("Please fill the guardian's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!chkBirthCertificate.Checked)
                {
                    MessageBox.Show("Birth Certificate is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!chkGoodMoral.Checked)
                {
                    MessageBox.Show("Good Moral Certificate is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!chkTranscript.Checked)
                {
                    MessageBox.Show("Transcript of Records is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbProgram.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a program.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbYearLevel.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a year level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!rbCash.Checked && !rbInstallment.Checked)
                {
                    MessageBox.Show("Please select a mode of payment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!rbFullScholar.Checked && !rbNone.Checked && !rb25.Checked && !rb50.Checked)
                {
                    MessageBox.Show("Please select a discount option.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAmountToPay.Text))
                {
                    MessageBox.Show("Please input the amount to pay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGuardianRelationship.Text))
                {
                    MessageBox.Show("Please fill the guardian's relationship.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtStudentContact.Text) || string.IsNullOrWhiteSpace(txtGuardianContact.Text))
                {
                    MessageBox.Show("Please fill the contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtGuardianAddress.Text))
                {
                    MessageBox.Show("Please fill the address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Guardian guardian = new Guardian(0, txtGuardianFirstName.Text, txtGuardianMiddleName.Text, txtGuardianLastName.Text, txtGuardianRelationship.Text, txtGuardianAddress.Text, txtGuardianContact.Text);
                Requirements requirements = new Requirements();
                requirements.BirthCertificate = chkBirthCertificate.Checked;
                requirements.TOR = chkTranscript.Checked;
                requirements.GoodMoral = chkGoodMoral.Checked;

                ProgramInfo programInfo = new ProgramInfo(0, cmbProgram.Text, (decimal)cmbProgram.SelectedValue);

                string modeOfPayment = rbCash.Checked ? rbCash.Text : rbInstallment.Text;
                Payment payment = new Payment(0, decimal.Parse(txtAmountToPay.Text), modeOfPayment, GetDiscount());

                Student student = new Student(lblStudNumValue.Text, txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, dtpBirthDate.Value, programInfo, guardian, requirements, payment, txtStudentContact.Text, txtAddress.Text, cmbYearLevel.Text);

                studentController.SaveStudentRegistration(student);
                MessageBox.Show("StudentSaved", "Student Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllInputs(this);
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Student Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

            private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllInputs(this);
            lblStudentNumber.Text = IDGenerator.GenerateStudentID();
        }

        private decimal GetDiscount()
        {
            decimal discount = 0;
            if (rb25.Checked)
            {
                discount = .25m;
            }
            else if (rb50.Checked)
            {
                discount = .5m;
            }
            else if (rbFullScholar.Checked)
            {
                discount = 1m;
            }
            return discount;
        }

        private void ClearAllInputs(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                    tb.Clear();
                else if (ctrl is ComboBox cb)
                    cb.SelectedIndex = -1;
                else if (ctrl is CheckBox chk)
                    chk.Checked = false;
                else if (ctrl is DateTimePicker dtp)
                {
                    int currentYear = DateTime.Now.Year;
                    dtp.MaxDate = DateTime.Now.AddYears(-15);
                    dtp.MinDate = DateTime.Now.AddYears(-100);

                    dtp.Value = dtp.MaxDate;
                }

                if (ctrl.HasChildren)
                    ClearAllInputs(ctrl);
            }

            lblDiscountedAmount.Text = lblTuitionFee.Text = "₱0.00";
            lblStudNumValue.Text = studentController.GenerateNewStudentId();
        }

        private void ShowDiscountAmount()
        {
            decimal discount = GetDiscount();
            decimal tuitionFee = (decimal)cmbProgram.SelectedValue;
            decimal discountedTuition = tuitionFee * discount;
            lblDiscountedAmount.Text = $"₱{tuitionFee-discountedTuition:N2}";
        }

        private void frmEnrollment_Load(object sender, EventArgs e)
        {
            programList = studentController.GetAllPrograms();

            cmbProgram.DisplayMember = "ProgramName";
            cmbProgram.ValueMember = "TuitionFee";
            cmbProgram.DataSource = null;
            cmbProgram.DataSource = programList;

            ClearAllInputs(this);
        }

        private void cmbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProgram.SelectedIndex != -1)
            {
                decimal tuition = (decimal)cmbProgram.SelectedValue;
                lblTuitionFee.Text = $"₱{tuition:N2}";
            }
        }

        private void rb25_CheckedChanged(object sender, EventArgs e)
        {
            ShowDiscountAmount();
        }

        private void rb50_CheckedChanged(object sender, EventArgs e)
        {
            ShowDiscountAmount();
        }

        private void rbFullScholar_CheckedChanged(object sender, EventArgs e)
        {
            ShowDiscountAmount();
        }
    }
}
