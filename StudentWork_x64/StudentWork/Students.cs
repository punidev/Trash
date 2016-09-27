using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWork
{
    public class Students
    {
        public static List<Students> Items = new List<Students>();
        public string Name { get; set; }
        public string Group { get; set; }
        public string Speciality { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public static object[] AsdObjects =
        {
            "1. Глава I",
            "2. Глава II",
            "3. Глава III",
            "4. Глава IV",
            "5. Глава V"
        };

        public static object[] OopObjects =
        {
            "1. Глава I",
            "2. Глава II",
            "3. Глава III",
            "4. Глава IV",
            "5. Глава V"
        };
        public override string ToString()
        {
            return string.Format("{0} гр.: {1} спец.: {2}", Name, Group, Speciality);
        }
    }
}
