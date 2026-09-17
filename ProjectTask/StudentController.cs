using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask
{
    internal class StudentController
    {
        IStudentRepository studentRepository;
        public StudentController(IStudentRepository repo)
        {

            studentRepository = repo;
        }
        public void SaveStudentRegistration(Student student)
        {
            try
            {
                studentRepository.SaveStudentRegistration(student);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateStudentRegistration(Student student)
        {
            try
            {
                studentRepository.UpdateStudentRegistration(student);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteStudent(string id)
        {
            try
            {
                studentRepository.DeleteStudent(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Student GetStudentById(string id)
        {
            try
            {
                return studentRepository.GetStudentById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ArrayList GetAllStudents()
        {
            try
            {
                return studentRepository.GetAllStudents();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ArrayList GetAllPrograms()
        {
            try
            {
                return studentRepository.GetAllPrograms();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GenerateNewStudentId()
        {
            try
            {
                return studentRepository.GenerateNewStudentId();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
