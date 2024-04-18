using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GameObject
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public GameObject(string name, int health)
        {
            Name = name;
            Health = health;
        }
        
    }

    // Класс, представляющий игру
    public class Game
    {
        // Делегаты для событий
        public delegate void AttackEventHandler(GameObject sender, GameObject target);
        public delegate void HealEventHandler(GameObject sender, GameObject target);

        // События
        public event AttackEventHandler Attack;
        public event HealEventHandler Heal;

        // Метод для запуска события Attack
        public void PerformAttack(GameObject sender, GameObject target)
        {
            Attack?.Invoke(sender, target);
        }

        // Метод для запуска события Heal
        public void PerformHeal(GameObject sender, GameObject target)
        {
            Heal?.Invoke(sender, target);
        }
    }
}
