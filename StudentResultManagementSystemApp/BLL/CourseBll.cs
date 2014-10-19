using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentResultManagementSystemApp.DLL.DAO;
using StudentResultManagementSystemApp.DLL.Gateway;

namespace StudentResultManagementSystemApp.BLL
{
    public class CourseBll
    {
        private CourseGateway aCourseGateway;

        public CourseBll()
        {
            aCourseGateway = new CourseGateway();
            
        }
        public List<Course> GetAllCourse()
        {
            return aCourseGateway.GetAllCourses();
        }

       
    }
    }
