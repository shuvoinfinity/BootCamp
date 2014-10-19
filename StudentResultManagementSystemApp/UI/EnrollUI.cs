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
    public partial class EnrollUI : Form
    {
        public EnrollUI()
        {
            InitializeComponent();
        }
        CourseBll aCourseBll = new CourseBll();
        StudentBll aStudentBll = new StudentBll();
        private Student aStudent;

        private void EnrollUI_Load(object sender, EventArgs e)
        {
            ShowCoursesComboBox();
        }

        private void findButton_Click(object sender, EventArgs e)
        {

           aStudent = new Student(regNoTextBox.Text, nameTextBox.Text, emailTextBox.Text);
           
            



        }

        private void ShowCoursesComboBox()
        {
          
            List<Course> courses = aCourseBll.GetAllCourse();
            foreach (Course aCourse in courses)
            {
                courseComboBox.Items.Add(aCourse);
            }
            courseComboBox.DisplayMember = "CourseName";
            courseComboBox.ValueMember = "Id";

        }

        

    }
}
