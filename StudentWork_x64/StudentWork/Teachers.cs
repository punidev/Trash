using System.Collections.Generic;

namespace StudentWork
{
    internal class Teachers
    {
        public static List<Teachers> Items = new List<Teachers>();
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, [ (логин:пароль) | {1} : {2} ]", Name, Login, Password);
        }
    }
}
