using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGamev1
{
    public class Item
    {
        int id;
        string name;
        Types type;
        int cost;
        int weight;

        public Item(int id, string name, int cost, int weight)
        {
            Id = id;
            Name = name;
            Type = Types.ITEM;
            Cost = cost;
            Weight = weight;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public Types Type
        {
            get => type;
            set => type = value;
        }
        public int Cost 
        {
        get =>cost; 
        set => cost = value;

        }
        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public override string ToString()
        {
            return $"Название: {Name}, Тип: {Type}, Вес: {Weight}, Стоимость: {Cost}";
        }
    }

    
}
