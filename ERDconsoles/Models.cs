using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERDconsole
{
    public class Course
    {
        public Course(int id, string name)
        {
            this.id = id;
            this.name = name;
            
        }

        public int id { get; set; }

        public string name { get; set; }

        public List<ClassSchedule> ClassSchedules { get; set; } = new List<ClassSchedule>();
    }

    public class ClassSchedule
    {
        public int id { get; set; }

        public string ClassSlot { get; set; }

        public bool IsTaken { get; set; }
    }
}
