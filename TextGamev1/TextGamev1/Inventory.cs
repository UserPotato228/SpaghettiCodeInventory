using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGamev1
{
    public class Inventory
    {
        List<Item> inventory = new List<Item>(32);

        public InvStatus Add(Item item)
        {
            if (inventory.Count == 32) {
                Console.WriteLine("Инвентарь полон");
                return InvStatus.FULL;
            }
            Console.WriteLine($"Добавлено {item.Name}!");
            inventory.Add(item);
            return InvStatus.NOT_FULL;

        }

        public override string ToString()
        {
            if (inventory.Count == 0)
                return "Инвентарь пуст";

            string text = "Инвентарь:\n";
            foreach (var item in inventory)
            {
                text += $"Название: {item.Name}; Стоимость: {item.Cost}; Вес: {item.Weight}\n";
            }
            return (text);
        }

        public List<Item> Inv
            {
            get => inventory;
            }
    }
}
