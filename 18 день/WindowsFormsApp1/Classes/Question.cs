using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Question
    {
        public string text;
        public string answer;

        public Question(string text, string answer)
        {
            this.text = text;
            this.answer = answer;
        }

        public string GetText()
        {
            return text;
        }

        public bool IsCorrect(string answer)
        {
            return string.Equals(this.answer, answer, StringComparison.OrdinalIgnoreCase);
        }
    }
}
