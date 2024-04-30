using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class User
    {
        public string name { get; }
        public string login { get; }
        public string password { get; }

        public User(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }

        public bool Enter(string login, string password)
        {
            return (this.login == login && this.password == password);
        }
    }

    public class Admin : User
    {
        public Admin(string name, string login, string password) : base(name, login, password)
        {
            
        }
    }

    public class Student : User
    {
        public int questionCount { get; set; }
        public int rightAnswers  { get; set; }

        public Student(string name, string login, string password) : base(name, login, password)
        {
            questionCount = 0;
            rightAnswers = 0;
        }

        public void GetAnswer(Question question, string answer)
        {
            if (question.IsCorrect(answer))
            {
                rightAnswers++;
            }
            questionCount++;
        }

        public void Clear()
        {
            questionCount = 0;
            rightAnswers = 0;
        }

        
    }
}
