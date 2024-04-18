using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Game game;
        
        private List<GameObject> gameObjects;
        public Form1()
        {
            InitializeComponent();

            gameObjects = new List<GameObject>();

            // Инициализация игры
            game = new Game();

            // Подписка на событие Attack
            game.Attack += (sender, target) =>
            {
                int damage = new Random().Next(15, 26);
                AppendHistoryText($"{sender.Name} attacks {target.Name} and deals {damage} damage");
                target.Health -= damage;
            };

            // Подписка на событие Heal
            game.Heal += (sender, target) =>
            {
                int heal = new Random().Next(5, 16);
                AppendHistoryText($"{sender.Name} heals {target.Name} for {heal} health");
                target.Health += heal;
            };

            // Проверка состояний игровых объектов
            AppendStatusText("Initial game state:");
            PrintHealthStatus();

            // Добавление начальных игровых объектов
            AddGameObject("Player 1", 100);
            AddGameObject("Player 2", 100);
            AddGameObject("Enemy", 200);
        }

        private void PerformAttack()
        {
            if (listBoxObjects.SelectedIndex >= 0 && listBoxObjects.SelectedIndex < gameObjects.Count)
            {
                GameObject sender = gameObjects[listBoxObjects.SelectedIndex];
                int tar = new Random().Next(0, gameObjects.Count);
                while (tar == listBoxObjects.SelectedIndex)
                {
                     tar = new Random().Next(0, gameObjects.Count);
                }
                GameObject target = gameObjects[tar];
                game.PerformAttack(sender, target);
                PrintHealthStatus();

                if (target.Health < 0)
                {
                    //gameObjects.Remove(target);
                    //PrintHealthStatus(); тут можно реализовать и что то наподобие убийства но там свои проблемы
                }
            }


        }

        // Метод для выполнения лечения и обновления состояния игры
        private void PerformHeal()
        {
            if (listBoxObjects.SelectedIndex >= 0 && listBoxObjects.SelectedIndex < gameObjects.Count)
            {
                GameObject sender = gameObjects[listBoxObjects.SelectedIndex];
                GameObject target = sender;
                game.PerformHeal(sender, target);
                PrintHealthStatus();
            }
        }

        // Метод для добавления игрового объекта и обновления состояния игры
        private void AddGameObject(string name, int health)
        {
            GameObject gameObject = new GameObject(name, health);
            gameObjects.Add(gameObject);
            listBoxObjects.Items.Add(gameObject.Name);
            PrintHealthStatus();
        }

        // Метод для вывода состояния здоровья игровых объектов
        private void PrintHealthStatus()
        {
            listBoxStatus.Items.Clear();
            foreach (var obj in gameObjects)
            {
                AppendStatusText($"{obj.Name}'s Health: {obj.Health}");
                listBoxStatus.Items.Add(obj.Name);
            }
            AppendStatusText("________________________________________");
            
        }

        // Метод для добавления текста в ListBox
        private void AppendStatusText(string text)
        {
            listBoxStatus.Items.Add(text);
        }

        private void AppendHistoryText(string text)
        {
            listBoxHistory.Items.Add(text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddGameObject(textBox1.Text, (int)numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerformAttack();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PerformHeal();
        }
    }
}
