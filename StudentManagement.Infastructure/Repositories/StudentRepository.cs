using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using StudentManagement.Domain.Models;



namespace StudentManagement.Infastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IConfiguration _configuration;

        public StudentRepository(IConfiguration configuration)
        {
            this._configuration = configuration;

        }

        public Student GetStudentById(int id)
        {
            Student response = new Student();
            try
            {


                response.IsSuccess = true;
                response.ErrorMessage = "Success";
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessage = "Error while getting student data";
            }

            return response;
        }

        public List<Student> GetStudents()
        {
            return new List<Student>();
        }

        public Student GetStudentByName(string name)
        {
            return new Student();
        }
        public Student UpdateStudent(Student student)
        {
            return new Student();
        }
        public Student DeleteStudentById(int id)
        {
            return new Student();
        }
    }
}
