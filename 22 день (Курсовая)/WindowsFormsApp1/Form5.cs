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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void departmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employessDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employessDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.employessDataSet.Departments);

        }
    }
}
