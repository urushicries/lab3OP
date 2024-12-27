using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
        public class Item
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImagePath { get; set; }

            public Item(string name, string description, string imagePath)
            {
                Name = name;
                Description = description;
                ImagePath = imagePath;
            }
        }

        public class ItemCollection
        {
            public List<Item> Items { get; private set; }

            public ItemCollection()
            {
                Items = new List<Item>();
            }

            public void AddItem(Item item)
            {
                Items.Add(item);
            }
        }
    }

