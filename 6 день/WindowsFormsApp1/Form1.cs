using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string Encrypt(string text, int shift)
        {
            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != ' ')
                {
                    chars[i] = (char)(chars[i] - shift);

                    if (chars[i] < 'а') // Проверка выхода за пределы алфавита
                        chars[i] = (char)(chars[i] + 32);
                }
            }

            return new string(chars);
        }

        static string Decrypt(string text, int shift)
        {
            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != ' ')
                {
                    chars[i] = (char)(chars[i] + shift);

                    if (chars[i] > 'я') // Проверка выхода за пределы алфавита
                        chars[i] = (char)(chars[i] - 32);
                }
            }

            return new string(chars);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Encrypt(textBox1.Text, (int)numericUpDown1.Value%33);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Decrypt(richTextBox1.Text, (int)numericUpDown1.Value%33);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            int repeatCount = 1;
            int currentDigit = 9;

            StringBuilder sb = new StringBuilder();

            while (currentDigit >= 1)
            {
                string digit = new string(char.Parse(currentDigit.ToString()), repeatCount);
                sb.Append(digit);

                Color randomColor = GetRandomColor();
                int startIndex = richTextBox2.TextLength;
                richTextBox2.AppendText(digit);
                richTextBox2.SelectionStart = startIndex;
                richTextBox2.SelectionLength = digit.Length;
                richTextBox2.SelectionColor = randomColor;

                currentDigit--;
                repeatCount++;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string S = txtInput.Text;
            char C = txtCharacter.Text.FirstOrDefault();

            // Вариант 1: с использованием стандартных процедур и функций для работы со строками
            string result1 = RemoveBetweenWithStandardMethods(S, C);
            txtOutput1.Text = result1;

            // Вариант 2: с использованием посимвольной обработки строк
            string result2 = RemoveBetweenWithCharacterProcessing(S, C);
            txtOutput2.Text = result2;
        }

        private string RemoveBetweenWithStandardMethods(string S, char C)
        {
            int firstIndex = S.IndexOf(C);
            int lastIndex = S.LastIndexOf(C);

            if (firstIndex != -1 && lastIndex != -1)
            {
                return S.Remove(firstIndex + 1, lastIndex - firstIndex - 1);
            }

            return S;
        }

        private string RemoveBetweenWithCharacterProcessing(string S, char C)
        {
            int firstIndex = -1;
            int lastIndex = -1;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                {
                    if (firstIndex == -1)
                        firstIndex = i;
                    lastIndex = i;
                }
            }

            if (firstIndex != -1 && lastIndex != -1)
            {
                return S.Remove(firstIndex + 1, lastIndex - firstIndex - 1);
            }

            return S;
        }


        
        private void replaceButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            char letter = letterTextBox.Text.FirstOrDefault(); // Получаем первую букву из введенного текста
            int count = (int)numericUpDown2.Value; // Получаем число из введенного текста

            string[] words = input.Split(','); // Разбиваем входную строку на слова
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int letterCount = 0;
                foreach (char c in word)
                {
                    if (c == letter)
                    {
                        letterCount++;
                    }
                }

                if (letterCount == count)
                {
                    words[i] = new string(letter, count); // Заменяем слово на строку из заданной буквы, повторенной count раз
                }
            }

            string output = string.Join(", ", words); // Объединяем слова в одну строку с запятыми
            
            outputTextBox1.Text = output;
            
        }



        //3 задание 5
        private void analyzeButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox1.Text.Trim();
            string[] words = inputText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            outputTextBox.Text = "";

            foreach (string word in words)
            {
                if (IsWordValid(word))
                {
                    outputTextBox.AppendText(word + Environment.NewLine);
                    count++;
                }
            }

            numericUpDown3.Value = count;
        }

        private bool IsWordValid(string word)
        {
            if (word.Length < 2)
                return false;

            char firstChar = word[0];
            char lastChar = word[word.Length - 1];

            return char.IsLower(firstChar) && char.IsLower(lastChar) && IsRussian(firstChar) && IsRussian(lastChar);
        }

        private bool IsRussian(char c)
        {
            return c >= 'а' && c <= 'я' || c == 'ё';
        }

        //3 задание 21

        private void transformButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox2.Text.Trim();
            string[] inputs = inputText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string transformedText = TransformText(inputs);
            outputTextBox2.Text = transformedText;
        }

        private string TransformText(string[] words)
        {
            StringBuilder transformedText = new StringBuilder();

            foreach (string word in words)
            {
                int k = (int)numericUpDown4.Value;
                string transformedWord = TransformWord(word.Split('=')[0], k);
                transformedText.Append(transformedWord).Append(" ");
            }

            return transformedText.ToString().Trim();
        }

        private string TransformWord(string word, int k)
        {
            char[] characters = word.ToCharArray();
            char targetChar = word[k - 1];

            for (int i = k - 2; i >= 0; i--)
            {
                if (characters[i] == targetChar)
                {
                    characters[i] = ' ';
                }
            }

            return new string(characters).Replace(" ", "");
        }

        //4 задание 5

        static string InsertSpaces(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                result += c + " ";
            }
            return result.Trim();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string inputString = richTextBox4.Text.Replace(" ", "");
            string outputString = InsertSpaces(inputString);
            richTextBox3.Text = outputString;
        }

        //4 задание 21
        private void button9_Click(object sender, EventArgs e)
        {
            string inputString = richTextBox6.Text;
            string substring = richTextBox5.Text;

            int lastIndex = inputString.LastIndexOf(substring);
            if (lastIndex != -1)
            {
                numericUpDown5.Value = lastIndex;
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private Color GetRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
