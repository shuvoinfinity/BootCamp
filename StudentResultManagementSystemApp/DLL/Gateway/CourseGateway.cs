using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentResultManagementSystemApp.DLL.DAO;

namespace StudentResultManagementSystemApp.DLL.Gateway
{
    public class CourseGateway
    {
        private SqlConnection connection;

        public CourseGateway()
        {
            string conn = @"server=RONOK-PC\SQLEXPRESS; database=StudentResultManagentDB; integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }

        public List<Course> GetAllCourses()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM CoursesTable");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Course> newCourses = new List<Course>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse = new Course();
                    aCourse.Id = (int)aReader[0];
                    aCourse.CourseTitle = aReader[1].ToString();
                    aCourse.CourseName = aReader[2].ToString();
                    newCourses.Add(aCourse);
                }
            }
            connection.Close();
            return newCourses;
        }
    }
}
