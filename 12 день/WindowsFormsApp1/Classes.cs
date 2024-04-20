using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string UniversityName { get; set; }

        public override string ToString()
        {
            return $"Имя:{this.Name}, Возраст:{this.Age}, Университет:{this.UniversityName}";
        }
    }

   
    class University
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"Университет:{this.Name}, Город:{this.Location}";
        }
    }
}
