using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public abstract class Item
    {
        public int id {get; set;}

        public string name {get; set;}

        public Item(int id, string name)
        {
        }
    }

    public class Weapon : Item
    {
        public Weapon(int id, string name, int typeWeapon, int damage) : base(id, name)
        {
            this.id = id;
            this.name = name;
            this.typeWeapon = typeWeapon;
            this.damage = damage;
        }

        public int typeWeapon { get; set; }

        public int damage { get; set; }
    }

    public class Potion : Item
    {
        public Potion(int id, string name) : base(id, name) {}
        
        public void effect(){}

    }

}
