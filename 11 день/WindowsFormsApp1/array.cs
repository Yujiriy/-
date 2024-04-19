using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ArrayProcessor
    {
        public int[] array;

        public ArrayProcessor(int size)
        {
            array = new int[size];
            FillArrayWithNaturalNumbers();
        }

        public int Length => array.Length;

        public int SumOfAbsoluteValuesAfterMax()
        {
            int maxIndex = GetMaxAbsoluteValueIndex();

            int sum = 0;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                sum += Math.Abs(array[i]);
            }

            return sum;
        }

        public int[] GetArray()
        {
            return array;
        }

        public void LoadFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    int[] numbers = lines.SelectMany(line => line.Split(';'))
                                         .Select(str => int.Parse(str))
                                         .ToArray();

                   
                    
                        Array.Resize(ref array, numbers.Length);
                    

                    Array.Copy(numbers, array, numbers.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}");
                }
            }
        }

        private void FillArrayWithNaturalNumbers()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }

        private int GetMaxAbsoluteValueIndex()
        {
            int maxIndex = 0;
            int maxAbsValue = Math.Abs(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                int absValue = Math.Abs(array[i]);
                if (absValue > maxAbsValue)
                {
                    maxAbsValue = absValue;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
