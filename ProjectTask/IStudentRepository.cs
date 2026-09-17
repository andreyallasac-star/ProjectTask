using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask
{
    internal interface IStudentRepository
    {
        void SaveStudentRegistration(Student student);
        void UpdateStudentRegistration(Student student);
        void DeleteStudent(string Id);
        Student GetStudentById(string Id);
        ArrayList GetAllStudents();
        ArrayList GetAllPrograms();
        string GenerateNewStudentId();  
    }
}
