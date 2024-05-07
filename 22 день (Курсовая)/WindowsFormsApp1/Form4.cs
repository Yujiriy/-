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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void positionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employessDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employessDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.employessDataSet.Positions);

        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = toolStripTextBox1.Text;

            PerformSearch(searchText);
        }
        private void PerformSearch(string searchText)
        {
            // Очистка фильтра BindingSource
            positionsBindingSource.Filter = "";

            // Установка фильтра для отображения только соответствующих строк
            positionsBindingSource.Filter = $"position_name LIKE '%{searchText}%'";

            // Обновление отображаемых данных в DataGridView
            positionsDataGridView.Refresh();
        }
    }
}
