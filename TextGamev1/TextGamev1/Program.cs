using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextGamev1
{
    internal class Program
    {
        static void Dialogue(string message) 
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadKey();
        }

       
        static void Search(Inventory inventory, string search) 
        {
            Console.Clear();
            try {
                foreach (var item in inventory.Inv) {
                    if (item.Name.Contains(search)) { Console.WriteLine(item); }
                }
            }
            catch{ Console.WriteLine("Такого предмета нет"); }
        }

        static void Filter(Inventory inventory) 
        {
            Dictionary<int, Types> types = new Dictionary<int, Types>
            {
                [0] = Types.ITEM,
                [1] = Types.ARMOR,
                [2] = Types.WEAPON
            };
            int count = 0;
            bool work = true;
           
            while (work) 
            {
                Console.WriteLine("Стелка Влево - Назад. Стрелка Вправо - Вперед. Backspace - Выйти.");
                
                Console.Write("Вывести по: ");
                Console.Write(types[count]);
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.Clear();
                
                switch (choice.Key) 
                {
                    case (ConsoleKey.LeftArrow):
                        count--;
                        if(count == -1) count = 0;
                        break;
                    case (ConsoleKey.RightArrow):
                        count++;
                        if(count == 3) count = 2;
                        break;
                    case (ConsoleKey.Enter):
                        foreach(var i in inventory.Inv.Where(n => n.Type == types[count]))
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case (ConsoleKey.Backspace):
                        work = false;
                        break;

                }
                
            }
        }
        static void InventoryMenu(Inventory inventory, Equipment equipment) 
        {
            Console.Clear();
            Dictionary<int, string> keys = new Dictionary<int, string>
            {
                [0] = "Вывести обычно",
                [1] = "Поиск предметов",
                [2] = "Отсортировать по.."
            };

            

            int count = 0;
            
            bool work = true;
            while (work) {
                Console.WriteLine("Стрелка Влево - Назад. Стрелка Вправо - Вперед. Backspace - Выйти.");
                Console.Write("Сортировка: "); Console.Write(keys[count]);
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.Clear();
                switch (choice.Key)
                {
                case (ConsoleKey.LeftArrow):
                        count--;
                        if(count == -1) count=0;
                        break;
                case (ConsoleKey.RightArrow):
                        count++;
                        if (count == 3) count = 2;
                        break;
                    case (ConsoleKey.Enter):
                        if (count == 0) Console.WriteLine(inventory.ToString()); 
                        else if(count == 1) { Console.Write("Поиск: "); string search = Console.ReadLine(); Search(inventory ,search); }
                        else { Filter(inventory); }
                        break;
                    case (ConsoleKey.Backspace):
                        work = false;
                        break;
                }
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, string> menu = new Dictionary<int, string>
            {
                [0] = "бой",
                [1] = "проверить",
                [2] = "инвентарь"
            };
            Dictionary<int, string> answers = new Dictionary<int, string>
            {
                [0] = "Вокруг пусто, вам не с кем драться",
                [1] = "Вокруг вас буквально ничего, вокруг темно и тихо, только загадочный свет освещает вас"
            };

            Player player = new Player("John Doe", 100, 14);
            Inventory inventory = new Inventory();
            Equipment equipment = new Equipment(player);
            // add things
            inventory.Add(new Item(0, "Какая-то чтука", 100, 5));
            inventory.Add(new Item(1, "Сожженый фурсьют", 1, 1));
            inventory.Add(new Weapon(2, "Отмена в Твиттере", 100, 21, 1000));
            inventory.Add(new Armor(3, "Резиновые калоши и треники", 68, 15, 15));
            // add things

            int count = 0;
            while (true)
            {
                
                Console.Clear();
                Console.WriteLine("Стрелка Влево - Назад. Стрелка Вправо - Вперед.");
                Console.WriteLine(menu[count]);  
                ConsoleKeyInfo choice = Console.ReadKey();
                switch (choice.Key)
                {
                    case ConsoleKey.LeftArrow:
                        count -= 1;
                        if (count < 0) count = 0;
                        break;
                    case ConsoleKey.RightArrow:
                        count += 1;
                        if (count == 3) count = 2;
                        break;
                    case ConsoleKey.Enter:
                        if (count != 2)
                        {
                           Dialogue(answers[count]);
                        }
                        else 
                        {
                            InventoryMenu(inventory, equipment);
                        }

                        break;

                }

                Thread.Sleep(500);
            }

            Console.ReadLine();
        }
    }
}
