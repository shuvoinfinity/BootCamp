using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentResultManagementSystemApp.BLL;
using StudentResultManagementSystemApp.DLL.DAO;

namespace StudentResultManagementSystemApp.DLL.Gateway
{
    public class StudentGateway
    {
        private SqlConnection connection;
        public StudentGateway()
        {
            string conn = @"server=RONOK-PC\SQLEXPRESS; database=StudentResultManagentDB; integrated security=true";
            connection = new SqlConnection(conn);
           
           
        }


        public Student ShowNameEmail(string regNo)
        {
            
             connection.Open();
            string queryString = string.Format("Select * from StudentsTable Where RegNo='{0}'", regNo);
            SqlCommand command = new SqlCommand(queryString, connection);
            
            SqlDataReader aReader = command.ExecuteReader();
            Student aStudent = new Student();
            while (aReader.Read())
            {
                aStudent.Name = aReader[1].ToString();
                aStudent.RegNo = aReader[0].ToString();
                aStudent.Email = aReader[2].ToString();
            }
            connection.Close();
            return aStudent;

        }

        public bool HasThisRegNo(string RegNo)
        {
            connection.Open();
            string queryString = string.Format("Select * from StudentsTable Where RegNo='{0}'", RegNo);
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader aReader = command.ExecuteReader();
           
            if (aReader.HasRows)
            {
                return true;
            }
            connection.Close();
            return false;
            
        }
    }
}
