using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class DistanceExamenator
    {
        public List<Student> users;
        public List<Question> questions;
        public Student currentUser;

        public DistanceExamenator()
        {
            users = new List<Student>();
            try
            {

                string json = File.ReadAllText("students.json");
                users = JsonConvert.DeserializeObject<List<Student>>(json);

            }
            catch (Exception ex)
            {
                throw ex;               //***********joke************// 
            }

            questions = new List<Question>();
            currentUser = null;
        }

        public void AddUser(string name, string login, string password, string repetition)
        {
            // Проверка наличия пользователя с таким логином
            if (users.Any(user => user.login == login))
            {
                return;
            }

            // Проверка совпадения пароля и повтора пароля
            if (password != repetition)
            {
                return;
            }

            User newUser = new User(name, login, password);
            //
        }

        public Student FindUser(string login, string password)
        {
            Student foundUser = users.FirstOrDefault(user => user.Enter(login, password));
            return foundUser;
        }

        public void Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText("students.json", json);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Load()
        {
            try
            {
                
                string json = File.ReadAllText("questions.json");
                questions = JsonConvert.DeserializeObject<List<Question>>(json);

            }
            catch (Exception ex)
            {
                throw ex;               //***********joke************// 
            }
            
        }

        public List<User> GetResults()
        {
            // Логика получения результатов пользователей
            List<User> results = new List<User>();
            // ...
            return results;
        }

        // Дополнительные методы и функциональность класса DistanceExamenator
    }
}
