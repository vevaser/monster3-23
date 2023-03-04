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

            Masha.SaveGame(); // Сохраняем данные для объекта
            Vasya.SaveGame();

            // Создаём список объектов класса Monster
            List<Monster> Players = new List<Monster>();
            Players.Add(Vasya);
            Players.Add(Masha);
            Console.WriteLine("************************************");
            foreach (Monster mon in Players)
                mon.Passport();

            Monster SubZero = new Monster(500, 500, "SubZero");
            Players.Add(SubZero);
            SubZero.Attack(Vasya, 80); // Побил Васю
            SubZero.Attack(Masha, 120); // Побил Машу
            Console.WriteLine("************************************");
            foreach (Monster mon in Players)
                mon.Passport();

            Monster.SaveAllGame(Players);

            // Создаём массив объектов
            Random rnd = new Random();
            const int n = 5;
            Monster[] stado = new Monster[n];
            for (int i = 0; i < n; i++)
            {
                stado[i] = new Monster(rnd.Next(1, 100), rnd.Next(1, 200),
                    "Crazy" + i.ToString());
                Players.Add(stado[i]);
            }
            Console.WriteLine("************************************");
            foreach (Monster x in stado) x.Passport();
            Monster.SaveAllGame(Players);  // Сохранили игру


            Console.ReadKey();
        }
    }
}
