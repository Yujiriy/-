using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employessDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.employessDataSet.Employees);
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float min = (float)numericUpDown1.Value;
            float max = (float)numericUpDown2.Value;

            ReportParameter parameterMin = new ReportParameter("rep1", min.ToString());
            ReportParameter parameterMax = new ReportParameter("rep2", max.ToString());
            // Установка параметра в отчет
            this.reportViewer1.LocalReport.SetParameters(parameterMin);
            this.reportViewer1.LocalReport.SetParameters(parameterMax);
            
            this.reportViewer1.RefreshReport();


            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
