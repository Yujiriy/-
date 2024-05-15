using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Grades : Form
    {
       
        public Grades()
        {
            InitializeComponent();
        }

        private void gradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void Grades_Load(object sender, EventArgs e)
        {

            // Загрузка данных в форму Grades
            this.gradesTableAdapter.Fill(this.studentsDataSet.Grades);

        }


        public void FilterDataByField(int fieldValue)
        {
            // Получение представления данных DataGridView
            gradesBindingSource.Filter = "";
            gradesBindingSource.Filter = $"StudentID =  {fieldValue}";
            gradesDataGridView.Refresh();

            // Установка фильтра для поля
          

        }


    }
}
