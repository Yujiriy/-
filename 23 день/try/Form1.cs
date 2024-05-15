using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using @try;

// ...

namespace @try
{
    public partial class Form1 : Form
    {
        private employessEntities context; // Добавьте поле для хранения экземпляра контекста модели EDM

        public Form1()
        {
            InitializeComponent();
            context = new employessEntities(); // Создайте экземпляр контекста модели EDM
            LoadDepartments(); // Загрузите список отделов при запуске формы
        }

        private void LoadDepartments()
        {
            var departments = context.Departments.ToList();
            dataGridView1.DataSource = departments.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Departments newDepartment = new Departments
            {
                department_name = txtName.Text,
            };

            context.Departments.Add(newDepartment);
            context.SaveChanges();

            LoadDepartments();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["department_id"].Value);
                Departments department = context.Departments.Find(departmentId);

                department.department_name = txtName.Text;

                context.SaveChanges();
                LoadDepartments();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["department_id"].Value);
                Departments department = context.Departments.Find(departmentId);

                context.Departments.Remove(department);
                context.SaveChanges();

                LoadDepartments();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Сортировка по заданному критерию (например, по названию отдела)
            var sortedDepartments = context.Departments.OrderBy(d => d.department_name).ToList();
            dataGridView1.DataSource = sortedDepartments;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;

            // Поиск по двум полям (например, по названию отдела и другому полю)
            var departments = context.Departments
                .Where(d => d.department_name.Contains(searchText) || d.location.Contains(searchText))
                .ToList();

            dataGridView1.DataSource = departments;
        }
    }
}