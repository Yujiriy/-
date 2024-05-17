using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            connectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.employessConnectionString"].ConnectionString;

            // Получение списка статусов и вывод в ListBox
            LoadStatuses();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Добавление нового статуса
            statuses newStatus = new statuses { status_name = textBox1.Text };
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute("INSERT INTO statuses (status_name) VALUES (@status_name)", newStatus);
            }

            // Обновление списка статусов и вывод в ListBox
            LoadStatuses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение выбранного статуса из ListBox
                statuses selectedStatus = listBox1.SelectedItem as statuses;
                if (selectedStatus == null)
                {
                    MessageBox.Show("Please select a status to delete.");
                    return;
                }

                // Удаление выбранного статуса
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    connection.Execute("DELETE FROM statuses WHERE status_id = @status_id", selectedStatus);
                }

                // Обновление списка статусов и вывод в ListBox
                LoadStatuses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Получение выбранного статуса из ListBox
            statuses selectedStatus = listBox1.SelectedItem as statuses;
            if (selectedStatus == null)
            {
                MessageBox.Show("Please select a status to update.");
                return;
            }

            // Открытие формы для редактирования статуса
            StatusEditForm editForm = new StatusEditForm(selectedStatus);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Обновление статуса в базе данных
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    connection.Execute("UPDATE statuses SET status_name = @status_name WHERE status_id = @status_id", selectedStatus);
                }

                // Обновление списка статусов и вывод в ListBox
                LoadStatuses();
            }
        }

        private void LoadStatuses()
        {
            // Очистка ListBox
            listBox1.Items.Clear();

            // Получение списка статусов
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<statuses> statusList = connection.Query<statuses>("SELECT * FROM statuses").ToList();

                // Вывод статусов в ListBox
                foreach (statuses status in statusList)
                {
                    listBox1.Items.Add(status);
                }
            }
        }
    }

    public class statuses
    {
        public int status_id { get; set; }
        public string status_name { get; set; }

        public override string ToString()
        {
            return status_name;
        }
    }
}