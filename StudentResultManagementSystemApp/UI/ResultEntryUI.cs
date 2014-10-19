using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentResultManagementSystemApp.BLL;
using StudentResultManagementSystemApp.DLL.DAO;

namespace StudentResultManagementSystemApp.UI
{
    public partial class ResultEntryUI : Form
    {
        public ResultEntryUI()
        {
            InitializeComponent();
        }

        CourseBll aCourseBll=new CourseBll();

        StudentBll aStudentBll=new StudentBll();

        private Student aStudent;

        private Student tempStudent;

        private void ResultEntryUI_Load(object sender, EventArgs e)
        {
           ShowAllCourses();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            aStudent = new Student();

             tempStudent = new Student();

            aStudent.Name = nameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;

            tempStudent = aStudentBll.ShowNameEmail(aStudent);

            if (tempStudent==null)
            {
                MessageBox.Show(@"Not Registered");
            }
            else
            {
                nameTextBox.Text=tempStudent.Name;
                emailTextBox.Text = tempStudent.Email;
            }            
        }

        private void viewResultSheetButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        public void ShowAllCourses()
        {
            List<Course> courses = aCourseBll.GetAllCourse();
            foreach (var acourse in courses)
            {
                courseComboBox.Items.Add(acourse);
            }
            courseComboBox.DisplayMember = "CourseName";
            courseComboBox.ValueMember ="Id";

        }

       
    }
}
