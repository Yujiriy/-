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
    public partial class StatusEditForm : Form
    {
        private statuses status;

        public StatusEditForm(statuses selectedStatus)
        {
            InitializeComponent();
            status = selectedStatus;
            textBox1.Text = status.status_name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            status.status_name = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
