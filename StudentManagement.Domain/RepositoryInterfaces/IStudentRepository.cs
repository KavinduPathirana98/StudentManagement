using StudentManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infastructure.Repositories
{
    public interface IStudentRepository
    {

        public Student GetStudentById(int id);
        public List<Student> GetStudents();
        public Student GetStudentByName(string name);
        public Student UpdateStudent(Student student);
        public Student DeleteStudentById(int id);

    }
}
