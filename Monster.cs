using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monster3_23
{
    class Monster
    {
        public Monster()    // Конструктор 1
        {
            this.name = "Noname";
            this.health = 100;
            this.ammo = 100;
        }

        public Monster(string name) : this()  // Конструктор 2
        {
            this.name = name;
        }

        public Monster(int health, int ammo, string name)  // Конструктор 3
        {
            this.name = name;
            this.health = health;
            this.ammo = ammo;
        }

        public int Health // свойство Health связано с полем health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > 0) health = value;
                else health = 0;
            }

        }

        public int Ammo // свойство Ammo связано с полем ammo
        {
            get
            {
                return ammo;
            }
            set
            {
                if (value > 0) ammo = value;
                else ammo = 0;
            }

        }

        public string Name // свойство Name связано с полем Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        public void Passport()
        {
            Console.WriteLine("Monster {0} \t healh={1} ammo={2}", name, health, ammo);
        }

        private string name;
        private int health;
        private int ammo;

    }
}
