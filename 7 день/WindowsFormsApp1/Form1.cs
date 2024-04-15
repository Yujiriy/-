using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Lombard> lombardItems = new List<Lombard>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Lombard item = new Lombard
                {
                    ClientData = textBoxClientData.Text,
                    TovarName = textBoxTovarName.Text,
                    EvalPrice = decimal.Parse(textBoxEvalPrice.Text),
                    ZalogSum = decimal.Parse(textBoxZalogSum.Text),
                    DateOfDue = dateTimePickerDateOfDue.Value,
                    TimeOfSave = int.Parse(textBoxTimeOfSave.Text)
                };

                lombardItems.Add(item);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lombardItems;
                dataGridView1.Refresh();

                ClearFields();
            }
            catch (Exception ex) { errorProvider1.SetError(textBoxEvalPrice, "Некоректно"); }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                lombardItems.RemoveAt(selectedIndex);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lombardItems;
            }
        }

        private void ClearFields()
        {
            textBoxClientData.Text = string.Empty;
            textBoxTovarName.Text = string.Empty;
            textBoxEvalPrice.Text = string.Empty;
            textBoxZalogSum.Text = string.Empty;
            dateTimePickerDateOfDue.Value = DateTime.Now;
            textBoxTimeOfSave.Text = string.Empty;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;

            // Фильтрация данных по истечении срока хранения и наименованию товара
            List<Lombard> filteredItems = lombardItems.Where(item =>
                item.DateOfDue <= DateTime.Now && // Истекший срок хранения
                item.TovarName.Contains(searchTerm)) // Поиск по наименованию товара
                .ToList();

            if (filteredItems.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filteredItems;
                dataGridView1.Refresh();
            }
            else
            {
               // MessageBox.Show("Товары не найдены");
            }
            if (searchTerm.Length == 0) {


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lombardItems;
                dataGridView1.Refresh();
            }
        }


    }

   
}
