using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class StringProcessor
    {
        public static void RemovePunctuation(string input)
        {
            string result = new string(input
                .ToCharArray()
                .Where(c => !char.IsPunctuation(c))
                .ToArray());

            Console.WriteLine("Результат: " + result);
        }

        public static void AddPrefix(string input)
        {
            Console.WriteLine("Результат: " + "Префикс" + input);
        }

        public static void ConvertToUpper(string input)
        {
            Console.WriteLine("Результат: " + input.ToUpper());
        }

        public static void RemoveExtraSpaces(string input)
        {
            Console.WriteLine("Результат: " + string.Join(" ", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
        }

        public static void ReplaceSubstring(string input, string oldValue, string newValue)
        {
            Console.WriteLine("Результат: " + input.Replace(oldValue, newValue));
        }
    }
}
