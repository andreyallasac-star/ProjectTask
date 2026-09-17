using System;
using System.Collections;
using System.Windows.Forms;

namespace ProjectTask
{
    public partial class frmStudentView : Form
    {
        private string connectionString = "Data Source=DESKTOP-TCVIDJV\\SQLEXPRESS01;Initial Catalog=StudentRegDB; Integrated Security=True;" + "TrustServerCertificate=True";
        StudentController studentController;
        ArrayList studentList = new ArrayList();
        public frmStudentView()
        {
            InitializeComponent();
            StudentRepository repo = new StudentRepository(connectionString);
            studentController = new StudentController(repo);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string studentId = row.Cells["StudentId"].Value.ToString();

                Student selectedStudent = studentController.GetStudentById(studentId);

                lblStudNumValue2.Text = selectedStudent.StudentId.ToString();

                lblstname.Text =
                    $"{selectedStudent.LastName}, {selectedStudent.FirstName} {selectedStudent.MiddleName}";

                lblDateOfBirth3.Text = selectedStudent.DateOfBirth.ToShortDateString();
                lblStudentAddress2.Text = selectedStudent.Address;
                lblStudentNumber3.Text = selectedStudent.ContactNumber;
                lblYearLevel3.Text = selectedStudent.YearLevel;

                Guardian guardian = selectedStudent.Guardian;

                lblGuardianName3.Text =
                    $"{guardian.LastName}, {guardian.FirstName} {guardian.MiddleName}";

                lblGuardianAddress3.Text = guardian.Address;
                lblgContactNumber3.Text = guardian.ContactNumber;
                lblgRelationship2.Text = guardian.Relationship;

                ProgramInfo programInfo = selectedStudent.Program;

                lblProgram3.Text = programInfo.ProgramName;
                lblTuition.Text = $"₱ {programInfo.TuitionFee:N2}";

                Requirements requirements = selectedStudent.Requirements;

                lblBirthCertificate2.Text = requirements.BirthCertificate ? "✔ Birth Certificate" : "Birth Certificate";

                lblTranscriptOfRecords.Text = requirements.TOR ? "✔ Transcript of Record" : "Transcript of Record";

                lblGoodMoral2.Text = requirements.GoodMoral ? "✔ Good Moral" : "Good Moral";

                Payment payment = selectedStudent.Payment;

                lblDiscount3.Text = $"{payment.ScholarshipDiscount * 100} %";

                lblDiscountedTuitionFee3.Text = $"₱ {(programInfo.TuitionFee * payment.ScholarshipDiscount):N2}";

                lblAmountToPay3.Text = $"₱ {payment.AmountPaid:N2}";
                lblMethod3.Text = payment.Method;
            }
        }

        private void SetupDatagrid()
        {
            studentList = studentController.GetAllStudents();

            dataGridView1.DataSource = studentList;

            dataGridView1.Columns["Program"].Visible = false;
            dataGridView1.Columns["Guardian"].Visible = false;
            dataGridView1.Columns["Requirements"].Visible = false;
            dataGridView1.Columns["Payment"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridView1.Rows.Count > 0 &&
                dataGridView1.Columns.Count > 0)
            {
                DataGridViewCellEventArgs args =
                    new DataGridViewCellEventArgs(0, 0);

                dataGridView1_CellClick(dataGridView1, args);
            }
        }

        private void frmStudentView_Load(object sender, EventArgs e)
        {
            SetupDatagrid();
        }

        private void frmStudentView_Activated(object sender, EventArgs e)
        {
            SetupDatagrid();
        }
    }
}
