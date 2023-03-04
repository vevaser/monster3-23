using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monster3_23
{
    class Daemon : Monster
    {
        // Daemon - это Monster, который умеет думать
        public Daemon()  // Конструктор 1
        {
            brain = 1;
        }

        public Daemon(string name, int brain)
            : base(name) // Конструктор 2
        {
            this.brain = brain;
        }

        public Daemon(int health, int ammo, string name, int brain)
           : base(health, ammo, name) // Конструктор 3
        {
            this.brain = brain;
        }

        new public void Passport()
        {
            Console.WriteLine("Daemon {0} health={1} ammo={2} brain={3}",
                Name, Health, Ammo, brain);
        }

        public void Think()
        {
            Console.WriteLine(Name + " is");
            for (int i = 0; i < brain; ++i)
                Console.WriteLine("thinking");
            Console.WriteLine("...");
        }

        private int brain; // Закрытое поле - УМ

    }
}
