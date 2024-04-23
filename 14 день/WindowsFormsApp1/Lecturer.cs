using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    class Discipline
    {
        public string Title { get; set; }
        public int Semester { get; set; }
        public int Course { get; set; }
        public string Specialization { get; set; }
        public int LectureCount { get; set; }
        public int LabCount { get; set; }
        public string ControlType { get; set; }
        public Lecturer Lecturer { get; set; }

        public Discipline(string title, int semester, int course, string specialization,
                     int lectureCount, int labCount, string controlType, Lecturer lecturer)
        {
            if (!Validate(title, semester, course, specialization, lectureCount, labCount, controlType, lecturer))
            {
                throw new ArgumentException("Invalid discipline data.");
            }

            Title = title;
            Semester = semester;
            Course = course;
            Specialization = specialization;
            LectureCount = lectureCount;
            LabCount = labCount;
            ControlType = controlType;
            Lecturer = lecturer;
        }
        public bool Validate(string title, int semester, int course, string specialization,
                         int lectureCount, int labCount, string controlType, Lecturer lecturer)
        {
            // Валидация полей с использованием регулярных выражений
            Regex titleRegex = new Regex(@"^[A-Za-z\s]+$"); // Название должно состоять из букв и пробелов
            Regex semesterRegex = new Regex(@"^[1-2]$");
            Regex courseRegex = new Regex(@"^\d+$");
            Regex specializationRegex = new Regex(@"^(ПОИТ|ДЭВИ|ПОИБМС|ИСиТ)$");
            Regex controlTypeRegex = new Regex(@"^(экзамен|зачет)$");

            if (string.IsNullOrEmpty(title) ||
                !titleRegex.IsMatch(title) ||
                !semesterRegex.IsMatch(semester.ToString()) ||
                !courseRegex.IsMatch(course.ToString()) ||
                !specializationRegex.IsMatch(specialization) ||
                lectureCount < 0 ||
                labCount < 0 ||
                !controlTypeRegex.IsMatch(controlType) ||
                lecturer == null )
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return $"{Title},{Semester},{Course},{Specialization},{LectureCount},{LabCount},{ControlType},{Lecturer}";
        }
    }

    class Lecturer
    {
        public string Department { get; set; }
        public string FullName { get; set; }
        public string Classroom { get; set; }

        public Lecturer(string department, string fullName, string classroom)
        {
            if (!Validate(department, fullName, classroom))
            {
                throw new ArgumentException("Invalid lecturer data.");
            }

            Department = department;
            FullName = fullName;
            Classroom = classroom;
        }

        public bool Validate(string department, string fullName, string classroom)
        {
            // Валидация полей с использованием регулярных выражений
            Regex departmentRegex = new Regex(@"^[A-Za-z\s]+$"); // Название кафедры должно состоять из букв и пробелов
            Regex fullNameRegex = new Regex(@"^[A-Za-z\s]+$"); // Полное имя должно состоять из букв и пробелов
            Regex classroomRegex = new Regex(@"^[A-Za-z\d]+$"); // Аудитория должна состоять из букв и цифр

            if (string.IsNullOrEmpty(department) ||
                string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(classroom) ||
                !departmentRegex.IsMatch(department) ||
                !fullNameRegex.IsMatch(fullName) ||
                !classroomRegex.IsMatch(classroom))
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return $"{Department},{FullName},{Classroom}";
        }
    }
}
