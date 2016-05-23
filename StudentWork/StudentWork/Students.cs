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
        public string Mark{ get; set; }
        public override string ToString()
        {
            return string.Format("{0} группа: {1} специальность: {2} оценка: {3}", Name, Group, Speciality, Mark);
        }
    }
}
