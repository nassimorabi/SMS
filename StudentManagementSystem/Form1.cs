using Microsoft.EntityFrameworkCore;
using SMS.Domain;
using SMS.Infrastructure.Data;

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
            using (var dbContext = new AppDbContext())
            {
                var program = dbContext.Programs.FirstOrDefault(); // creates a variable to fetch the first data in database
                createProgram(program.ProgramId, program.ProgramName, program.Description);
            }

            //var program = dbContext.Programs.Where(p => p.ProgramName == "EE") || creates a variable to fetch a searched data
            
            //createStudent(1, "Test", "test@test.com");
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            createStudent(2, "Don Pollo", "lingangguli@guliwacha.com");
        }

        private void createStudent(int id, string name, string email)
        {
            var student = new Student // create variables || 
            {
                StudentId = id,
                StudentName = name,
                StudentEmail = email,
                DateAdded = DateTime.Now,
                AddedBy = "Admin"
            };

            textBoxId.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;
            textBoxEmail.Text = student.StudentEmail;

            //labelAddedInformation.Text = "Added by: " + student.AddedBy + " " + student.DateAdded;
            labelAddedInformation.Text = $"Added by: {student.AddedBy} {student.DateAdded}"; //proper outputting

        }

        private void createProgram(int id, string name, string description)
        {
            var program = new Programs // create variables || 
            {
                ProgramId = id,
                ProgramName = name,
                Description = description,
                //DateAdded = DateTime.Now,
                //AddedBy = "Admin"
            };

            textBoxId.Text = program.ProgramId.ToString();
            textBoxName.Text = program.ProgramName;
            textBoxEmail.Text = program.Description;

            //labelAddedInformation.Text = "Added by: " + student.AddedBy + " " + student.DateAdded;
            //labelAddedInformation.Text = $"Added by: {student.AddedBy} {student.DateAdded}"; //proper outputting

        }
    }
}
