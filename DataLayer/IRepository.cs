using DBStudentApp_1218645.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStudentApp_1218645.DataLayer
{
    internal interface IRepository
    {
        List<Course> GetAllCourses();
        List<Enrollment> GetEnrollment(string courseNum);
    }
}
