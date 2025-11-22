using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Transactions;
using Microsoft.Extensions.Configuration;
using StudentManagement.Domain.Models;
using System.ComponentModel.Design;
using Microsoft.Data.SqlClient;
using static System.Formats.Asn1.AsnWriter;



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
                using (IDbConnection conn = new SqlConnection(_configuration.GetConnectionString("StudentDB")))
                {
                    DynamicParameters Params = new();
                    Params.Add("@ID", id, DbType.Int32, ParameterDirection.Input);
                    var student = conn.Query<Student>("Select " +
                        "[ID]," +
                        "[FirstName]," +
                        "[LastName]," +
                        "[DOB]," +
                        "[Email]," +
                        "[PhoneNumber]," +
                        "[EnrollmentDate]," +
                        "[Status]," +
                        "[CreatedDate]," +
                        "[ModifiedDate]" +
                        " FROM [Student] WHERE ID=@ID", Params, commandType: CommandType.Text);

                    response = student.FirstOrDefault();

                }


                response.IsSuccess = true;
                response.ErrorMessage = "Success";
            }
            catch (Exception )
            {
                response.IsSuccess = false;
                response.ErrorMessage = "Error while getting student data";
            }

            return response;
        }

        public List<Student> GetStudents()
        {
            List<Student> response = new List<Student>();
            try
            {
                using (IDbConnection conn = new SqlConnection(_configuration.GetConnectionString("StudentDB")))
                {
                    DynamicParameters Params = new();

                    var student = conn.Query<Student>("Select " +
                        "[ID]," +
                        "[FirstName]," +
                        "[LastName]," +
                        "[DOB]," +
                        "[Email]," +
                        "[PhoneNumber]," +
                        "[EnrollmentDate]," +
                        "[Status]," +
                        "[CreatedDate]," +
                        "[ModifiedDate]" +
                        " FROM [Student] ", Params, commandType: CommandType.Text);

                    response = student.ToList();

                }

            }
            catch (Exception )
            {
                throw;
            }

            return response;
        }

        public List<Student> GetStudentByFirstName(string name)
        {
            List<Student> response = new List<Student>();
            try
            {
                using (IDbConnection conn = new SqlConnection(_configuration.GetConnectionString("StudentDB")))
                {
                    DynamicParameters Params = new();
                    Params.Add("@FirstName", name, DbType.String, ParameterDirection.Input);
                    var student = conn.Query<Student>("Select " +
                        "[ID]," +
                        "[FirstName]," +
                        "[LastName]," +
                        "[DOB]," +
                        "[Email]," +
                        "[PhoneNumber]," +
                        "[EnrollmentDate]," +
                        "[Status]," +
                        "[CreatedDate]," +
                        "[ModifiedDate]" +
                        " FROM [Student] WHERE FirstName=@FirstName", Params, commandType: CommandType.Text);

                    response = student.ToList();

                }



            }
            catch (Exception ex)
            {
                throw;
            }

            return response;
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
