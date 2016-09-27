using System.Data.SQLite;


namespace StudentWork
{
    public class DBUtils
    {
        public static string[] DB = { "StudentBase.db", "Studentmark.db", "Teachers.db" };


        public static SQLiteConnection Studentconn =
            new SQLiteConnection(string.Format("Data Source={0};Version=3;", DB[0]));
        public static SQLiteConnection Markconn =
            new SQLiteConnection(string.Format("Data Source={0};Version=3;", DB[1]));
        public static SQLiteConnection Teacherconn =
            new SQLiteConnection(string.Format("Data Source={0};Version=3;", DB[2]));

        public static readonly string QuerryStudent = @"CREATE TABLE 'students'(
            login TEXT,
            passwd TEXT,
            name TEXT,
            gr TEXT,
            specialty TEXT,
            mark TEXT);";

        public static readonly string QuerryMarks = @"CREATE TABLE 'studentmark'(
            name TEXT,
            subject TEXT,
            part TEXT,
            mark TEXT);";
        public static readonly string QuerryTeachers = @"CREATE TABLE 'teacher'(
            name TEXT,
            login TEXT,
            passwd TEXT);";
        public static void CreateNewDatabase(string path)
        {
            SQLiteConnection.CreateFile(path);
        }
        public static void ConnectToDatabase(SQLiteConnection s)
        {
            s.Open();
        }
        public static void StudentDataSource()
        {
            Students.Items.Clear();
            var sql = "SELECT * FROM students";
            var command = new SQLiteCommand(sql, Studentconn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var std = new Students
                {
                    Login = (string)reader["login"],
                    Password = (string)reader["passwd"],
                    Name = (string)reader["name"],
                    Group = (string)reader["gr"],
                    Speciality = (string)reader["specialty"],
                };
                Students.Items.Add(std);
            }
        }
        public static void TeacherDataSource()
        {
            Teachers.Items.Clear();
            const string sql = "SELECT * FROM teacher";
            var command = new SQLiteCommand(sql, Teacherconn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var std = new Teachers
                {
                    Login = (string)reader["login"],
                    Password = (string)reader["passwd"],
                    Name = (string)reader["name"]
                };
                Teachers.Items.Add(std);
            }
        }
        public static bool CheckUser(string name)
        {
            Students.Items.Clear();
            const string sql = "SELECT * FROM students";
            var command = new SQLiteCommand(sql, Studentconn);
            var namesql = false;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (name == (string)reader["name"])
                {
                    namesql = true;
                }
            }
            return namesql;
        }
        public static bool CheckLoginStudent(string login, string passwd)
        {
            Students.Items.Clear();
            const string sql = "SELECT * FROM students";
            var command = new SQLiteCommand(sql, Studentconn);
            var namesql = false;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (login == (string)reader["login"] &&
                    passwd == (string)reader["passwd"])
                {
                    namesql = true;
                }
            }
            return namesql;
        }
        public static bool CheckLoginTeacher(string login, string passwd)
        {
            Students.Items.Clear();
            const string sql = "SELECT * FROM teacher";
            var command = new SQLiteCommand(sql, Teacherconn);
            var namesql = false;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (login == (string)reader["login"] &&
                    passwd == (string)reader["passwd"])
                {
                    namesql = true;
                }
            }
            return namesql;
        }
        public static string FindStudentName(string login, string passwd)
        {
            Students.Items.Clear();
            var sql = string.Format("SELECT * FROM students WHERE login='{0}' AND passwd = '{1}'", login, passwd);
            var command = new SQLiteCommand(sql, Studentconn);
            var namesql = "";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                namesql = (string)reader["name"];
            }
            return namesql;
        }
        public static string FindTeacherName(string login, string passwd)
        {
            Students.Items.Clear();
            var sql = string.Format("SELECT * FROM teacher WHERE login='{0}' AND passwd = '{1}'", login, passwd);
            var command = new SQLiteCommand(sql, Teacherconn);
            var namesql = "";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                namesql = (string)reader["name"];
            }
            return namesql;
        }
        public static void DeleteTable(string name, string db, SQLiteConnection s)
        {
            var command = new SQLiteCommand(string.Format("DELETE FROM '{0}' WHERE name = '{1}';", db, name), s);
             command.ExecuteNonQuery();
        }

        public static void CreateTable(string query, SQLiteConnection s)
        {
            var command = new SQLiteCommand(query, s);
            command.ExecuteNonQuery();
        }
        public static void Insert(string querry, SQLiteConnection s)
        {
             var command = new SQLiteCommand(querry, s);
             command.ExecuteNonQuery();
        }
    }
}
