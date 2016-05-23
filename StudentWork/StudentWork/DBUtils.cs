using System;
using System.Data.SQLite;


namespace StudentWork
{
    class DBUtils
    {
        public const string Path = "StudentBase.db";
        public static SQLiteConnection Con = new SQLiteConnection("Data Source=" + Path + ";Version=3;");
        public static void CreateNewDatabase()
        {
            SQLiteConnection.CreateFile(Path);
        }
        public static void ConnectToDatabase()
        {
            Con.Open();
        }
        public static void DataSource()
        {
            Students.Items.Clear();
            var sql = "SELECT * FROM students";
            var command = new SQLiteCommand(sql, Con);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var std = new Students
                {
                    Name = (string)reader["name"],
                    Group = (string)reader["gr"],
                    Speciality = (string)reader["specialty"],
                    Mark = (string)reader["mark"]
                };
                Students.Items.Add(std);
            }

        }
        public static bool CheckUser(string name)
        {
            Students.Items.Clear();
            var sql = "SELECT * FROM students";
            var command = new SQLiteCommand(sql, Con);
            var namesql = false;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (name == (string) reader["name"])
                {
                    namesql = true;
                }
            }
            return namesql;
        }

        public static void DeleteTable(string querry)
        {
            var command = new SQLiteCommand("DELETE FROM 'students' WHERE name = '" + querry + "';", Con);
             command.ExecuteNonQuery();
        }

        public static void CreateTable()
        {
            var sql = "CREATE TABLE 'students' (name TEXT, gr TEXT, specialty TEXT, mark TEXT);";
            var command = new SQLiteCommand(sql, Con);
            command.ExecuteNonQuery();
        }
        public static void Insert(string querry)
        {
             var command = new SQLiteCommand(querry, Con);
             command.ExecuteNonQuery();

        }
    }
}
