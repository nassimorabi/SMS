using SMS.Domain;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            createStudent(1, "Test", "test@test.com");

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            createStudent(2, "Don Pollo", "lingangguli@guliwacha.com");

        }

        private void createStudent(int id, string name, string email)
        {
            var student = new Student
            {
                StudentId = id,
                StudentName = name,
                StudentEmail = email
            };

            textBoxId.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;
            textBoxEmail.Text = student.StudentEmail;

        }


    }
}
