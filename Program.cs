using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monster3_23
{
    class Program
    {
        static void Main(string[] args)
        {

            Monster Masha = new Monster(200, 200, "Masha");
            Masha.Passport();
            --Masha.Health;
            Masha.Ammo += 100;
            Masha.Passport();

            Monster Vasya = new Monster();
            Vasya.Passport();
            Vasya.Name = "Vasya";
            Vasya.Passport();

            Vasya.Attack(Masha, 50); // Vasya атакует Masha с силой 50
            Masha.Passport();
            Vasya.Passport();
            Console.WriteLine("************************************");


            Console.ReadKey();
        }
    }
}
