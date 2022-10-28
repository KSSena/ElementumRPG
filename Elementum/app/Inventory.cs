using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Inventory
    {
        public List<InventoryItem> list { get; set; }

        public Inventory()
        {
            list = new List<InventoryItem>();
        }

        public void ListInventory()
        {
            foreach (InventoryItem invItem in list)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Item: " + invItem.item.name);
                Console.WriteLine("Quantity: " + invItem.quantity);
                Console.WriteLine("Item ID: " + invItem.item.id);
            }
        }

        public void AddItem(int id, int quantity)
        {
            Item item = World.SearchItem(id);

            if (item == null)
            {
                Console.WriteLine("ID não encontrado");
            }
            else
            {
                foreach (InventoryItem invItem in list)
                {
                    if (invItem.item.id == item.id)
                    {
                        if (quantity < 0 && -quantity > invItem.quantity)
                            Console.WriteLine("Quantidade insuficiente");
                        else if (quantity < 0 && -quantity == invItem.quantity)
                            list.Remove(invItem);
                        else
                            invItem.quantity += quantity;

                        return;
                    }
                }

                if (quantity > 0)
                    list.Add(new InventoryItem(item, quantity));
                else
                    Console
                        .WriteLine("Não foi possivel adicionar item ao inventario");
            }
        }
    }

    public class InventoryItem
    {
        public Item item { get; set; }

        public int quantity { get; set; }

        public InventoryItem(Item item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }
    }
}
