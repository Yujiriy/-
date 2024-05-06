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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void statusesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statusesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employessDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employessDataSet.Statuses". При необходимости она может быть перемещена или удалена.
            this.statusesTableAdapter.Fill(this.employessDataSet.Statuses);

        }
    }
}
