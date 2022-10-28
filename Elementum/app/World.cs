namespace app
{
    public static class World
    {
        public static List<Item> items;

        public static List<Weapon> weapons;

        public static List<Monster> monsters;

        public static List<Player> players;

        public static int countPlayer = 0;

        //ID Items
        public const int ITEM_ID_SWORD = 1;

        public const int ITEM_ID_BOW = 2;

        public const int ITEM_ID_WAND = 3;

        public const int ITEM_ID_STAFF = 4;

        //ID Monsters
        static World()
        {
            items = new List<Item>();
            weapons = new List<Weapon>();
            monsters = new List<Monster>();
            players = new List<Player>();
            PopulateItems();
            PopulateWeapons();
        }

        private static void PopulateItems()
        {
        }

        private static void PopulateWeapons()
        {
            weapons.Add(new Weapon(ITEM_ID_SWORD, "SWORD", 1, 3));
            weapons.Add(new Weapon(ITEM_ID_BOW, "Bow", 2, 3));
            weapons.Add(new Weapon(ITEM_ID_WAND, "WAND", 3, 1));
            weapons.Add(new Weapon(ITEM_ID_STAFF, "STAFF", 4, 1));
        }

        private static void PopulateMonsters()
        {
        }

        public static Item SearchItem(int id)
        {
            foreach (Item item in items)
            {
                if (item.id == id) return item;
            }
            return null;
        }

        public static Weapon SearchWeapon(int id)
        {
            foreach (Weapon weapon in weapons)
            {
                if (weapon.id == id) return weapon;
            }
            return null;
        }

        public static Monster SearchMonster(int id)
        {
            foreach (Monster monster in monsters)
            {
                if (monster.id == id) return monster;
            }
            return null;
        }
    }

    public static class Skills
    {
        public const string BASIC_ATTACK_NAME = "Basic Attack";

        public const string
            BASIC_ATTACK_DESCRIPTION = "Basic Attack description";

        //WarriorSkills
        public const string PROVOKE_NAME = "Provoke";

        public const string PROVOKE_DESCRIPTION = "Provoke description";

        //Archer Skills
        public const string GUST_NAME = "Gust";

        public const string GUST_DESCRIPTION = "Gust description";

        public const string AIM_NAME = "Aim";

        public const string AIM_DESCRIPTION = "Aim description";

        public const string DEADLY_SHOT_NAME = "Deadly Shot";

        public const string DEADLY_SHOT_DESCRIPTION = "Deadly Shot description";

        //Mage Skills

        //Cleric Skill
    }

    public enum Element
    {
        Fire,
        Water,
        Earth,
        Air,
        Light,
        Shadow
    }
}
