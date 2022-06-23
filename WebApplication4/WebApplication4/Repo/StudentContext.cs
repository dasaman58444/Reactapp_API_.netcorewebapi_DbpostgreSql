using Npgsql;
using WebApplication4.Data;
using System.Collections.Generic;
using Dapper;
using System.Linq;
using System;

namespace WebApplication4.Repo
{
    public class StudentContext
    {
       
        

        public List<StudentData> GetStudentDatasFromDB(int id)
        {

            List<StudentData> Data = new List<StudentData>();


            using (var connection = CreateConnection())
            {
                if (id == 0)
                    Data = connection.Query<StudentData>("select * from student").ToList();
                else
                    Data = connection.Query<StudentData>("select * from student where id=@something", new
                    {
                        something = id
                    }).ToList();
            }

            return Data;
        }

        internal object LoadAllData()
        {
            throw new NotImplementedException();
        }

        public void InsertIntoStudent(StudentData data)
        {
            using (var connection = CreateConnection())
            {
                connection.Execute(@"
INSERT INTO public.student(
	id, name)
	VALUES (@id, @name);
", data);
            }
        }

        public void UpdateStudent(StudentData data)
        {
            using (var connection = CreateConnection())
            {
                connection.Execute(@"
UPDATE public.student
	SET  name=@name
	WHERE id=@id;
", data);
            }
        }

        public NpgsqlConnection CreateConnection()
        {
            var conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=sdc;User Id=postgres;Password=Aman2056;");
            conn.Open();
            return conn;
        }
    }
}