using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Configuration;
using DAL.Models;
using System.Data.SqlClient;

namespace DAL.Operations
{
    public class TeacherRepository : IRepository<Teacher>
    {
        public TeacherRepository()
        {

        }

        private static SQLiteConnection connection;
        private static String _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Boolean Create(Teacher item)
        {
            SQLiteTransaction transaction = connection.BeginTransaction();

            try
            {
                Boolean flag = false;
                String query = $"INSERT INTO 'Teachers'('TeacherName', 'TeacherAge', 'WorkExperience', 'TeacherPhoto') VALUES('{item.TeacherName}', {item.TeacherAge}, {item.WorkExperience}, @img)";
                String query1 = $"INSERT INTO 'TeachersInfo'('TeacherName', 'TeacherAge', 'WorkExperience', 'TeacherPhoto') VALUES('{item.TeacherName}', {item.TeacherAge}, {item.WorkExperience}, @img)";

                using (connection = new SQLiteConnection(_connectionString))

                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.Add("@img", DbType.Binary).Value = item.TeacherPhoto;
                    int i = command.ExecuteNonQuery();
                    flag = i == 1 ? true : false;
                    transaction.Commit();
                    connection.Close();
                }
                return flag;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }

        public Boolean Delete(Teacher item)
        {
            Boolean flag = false;
            String query = $"DELETE FROM Teachers WHERE TeacherId = {item.TeacherId}";

            using (connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                flag = command.ExecuteNonQuery() == 1
                    ? true
                    : false;

                connection.Close();
            }
            return flag;
        }

        public IEnumerable<Teacher> GetAll()
        {
            List<Teacher> results = new List<Teacher>();
            String query = @"SELECT * FROM 'Teachers';";
            using (connection = new SQLiteConnection(_connectionString, true))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    foreach (DbDataRecord record in reader)
                    {
                        results.Add(new Teacher()
                        {
                            TeacherId = Convert.ToInt32(record["TeacherId"]),
                            TeacherName = record["TeacherName"].ToString(),
                            WorkExperience = Convert.ToInt32(record["WorkExperience"]),
                            TeacherAge = Convert.ToInt32(record["TeacherAge"]),
                            TeacherPhoto = record["TeacherPhoto"] == DBNull.Value ? null : (byte[])record["TeacherPhoto"]
                        });
                    }
                }
                
                connection.Close();
            }
            return results;
        }
        //TODO
        public IEnumerable<Teacher> GetByQuery(Func<Teacher, bool> predicate)
        {
            string query = string.Empty;
            using (connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                connection.Close();
            }
            return null;
        }
        //TODO
        public bool Update(Teacher item)
        {
            string query = string.Empty;
            using (connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                connection.Close();
            }
            return true;
        }
    }
}
