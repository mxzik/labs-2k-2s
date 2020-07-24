using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Data.SQLite;
using System.Data.Common;

namespace DAL.Operations
{
    public static class GeneralOperations
    {
        private static SQLiteConnection connection;
        private static Parser _parser = new Parser();
        private static string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static void CreateTeachersTable()
        {
            string path = @"D:\лабы\2 sem\oop\Lab11\DAL\Database\Scripts\CreateTeachersTable.sql";
            string query = _parser.ParseScript(path);
            if (!string.IsNullOrWhiteSpace(query))
            {
                using (connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    connection.Clone();
                }
            }
            return;
        }

        public static void DropTable()
        {
            string path = @"D:\лабы\2 sem\oop\Lab11\DAL\Database\Scripts\DropTeachersTable.sql";
            string query = _parser.ParseScript(path);
            if (!string.IsNullOrWhiteSpace(query))
            {
                using (connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Clone();
                }
            }
            return;
        }

        public static void CreateDb()
        {
            String dbName = @"Teachers.db";
            String pathToDb2 = @"D:\лабы\2 sem\oop\Lab11\Lab11\bin\Debug" + $"\\{dbName}";
            if (!File.Exists(pathToDb2))
            {
                SQLiteConnection.CreateFile(dbName);
            }
        }

        public static List<string> GetAllTables()
        {
            List<string> tableList = new List<string>();
            using (connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;", connection);
                SQLiteDataReader readerd = command.ExecuteReader();
                foreach (DbDataRecord record in readerd)
                    tableList.Add(record["name"].ToString());
                connection.Close();
            }
            return tableList;
        }

        public static bool HasTable(string tableName)
        {
            bool result = false;
            using (connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;", connection);
                SQLiteDataReader readerd = command.ExecuteReader();
                foreach (DbDataRecord record in readerd)
                    if (record["name"].ToString() == tableName)
                    {
                        result = true;
                    } 
                connection.Close();
            }
            return result;
        }
    }
}
