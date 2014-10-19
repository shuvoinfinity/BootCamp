using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using StudentResultManagementSystemApp.DLL.DAO;
using StudentResultManagementSystemApp.DLL.Gateway;

namespace StudentResultManagementSystemApp.BLL
{

    public class StudentBll
    {
        private StudentGateway aStudentGateway;

        public StudentBll()
        {
            aStudentGateway = new StudentGateway();
        }
        public Student ShowNameEmail(Student aStudent)
        {
             if (HasThisRegNo(aStudent.RegNo))
                {
                    return aStudentGateway.ShowNameEmail(aStudent.RegNo);
                }
              return null;      
        }

        public bool HasThisRegNo(string RegNo)
        {
            return aStudentGateway.HasThisRegNo(RegNo);

        }
        
    }
}
