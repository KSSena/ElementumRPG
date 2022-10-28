using app.WarriorSkills;
using app.ArcherSkills;
using app.MageSkills;
using app.ClericSkills;

namespace app
{
    public abstract class Player
    {
        public int id { get; set; }

        public string name { get; set; }

        public int maxHp { get; set; }

        public int currentHp { get; set; }

        public int strength { get; set; }

        public int intelligence { get; set; }

        public int dexterity { get; set; }

        public int level { get; set; }

        public int xp { get; set; }

        public int gold { get; set; }

        public int initiative;

        public Inventory inventory;

        public Weapon currentWeapon;

        public List<Skill> skills;

        public Element element;

        public Player(string name, Element element)
        {
            this.name = name;
            this.element = element;
        }

        public abstract void useSkill(Monster monster);

        public override string ToString()
        {
            return (
            "----------------------------" +
            "\nName: " +
            name +
            "\nMaxHp: " +
            maxHp +
            "\nCurrentHp: " +
            currentHp +
            "\nLevel: " +
            level +
            "\nExperience: " +
            xp +
            "\nGold: " +
            gold +
            "\nStrenght: " +
            strength +
            "\nDexterity: " +
            dexterity +
            "\nIntelligence: " +
            intelligence +
            "\nID: " +
            id +
            "\nSequence:" +
            initiative +
            "\n----------------------------"
            );
        }
    }

    public class Warrior : Player
    {
        public Warrior(string name, Element element) :
            base(name, element)
        {
            this.name = name;
            this.maxHp = ClassStats.WARRIOR_START_HP;
            this.currentHp = ClassStats.WARRIOR_START_HP;
            this.level = ClassStats.START_LEVEL;
            this.xp = ClassStats.START_XP;
            this.gold = ClassStats.START_GOLD;
            this.strength = ClassStats.WARRIOR_START_STRENGTH;
            this.intelligence = ClassStats.WARRIOR_START_INTELLIGENCE;
            this.dexterity = ClassStats.WARRIOR_START_DEXTERITY;
            inventory = new Inventory();
            World.countPlayer += 1;
            this.id = World.countPlayer;
            this.currentWeapon = World.SearchWeapon(World.ITEM_ID_WAND);
            this.skills = new List<Skill>();
            skills.Add(new BasicAttack());
            skills.Add(new Provoke());
        }

        public override void useSkill(Monster monster){
            Console.WriteLine("Escolha a skill " + this.name + " :");
            foreach(var skill in skills){
                Console.WriteLine((skills.IndexOf(skill) +1 ) + ". " + skill.name);
            }
            Console.WriteLine("Digite o número:");
            int escolha = 1;
            skills[(escolha - 1)].utilize(this, monster);
            
        }
    }

    public class Archer : Player
    {
        public Archer(string name, Element element) :
            base(name, element)
        {
            this.name = name;
            this.maxHp = ClassStats.ARCHER_START_HP;
            this.currentHp = ClassStats.ARCHER_START_HP;
            this.level = ClassStats.START_LEVEL;
            this.xp = ClassStats.START_XP;
            this.gold = ClassStats.START_GOLD;
            this.strength = ClassStats.ARCHER_START_STRENGTH;
            this.intelligence = ClassStats.ARCHER_START_INTELLIGENCE;
            this.dexterity = ClassStats.ARCHER_START_DEXTERITY;
            inventory = new Inventory();
            World.countPlayer += 1;
            this.id = World.countPlayer;
            this.currentWeapon = World.SearchWeapon(World.ITEM_ID_WAND);
            this.skills = new List<Skill>();
            skills.Add(new BasicAttack());
            skills.Add(new Gust());
            skills.Add(new Aim());
            skills.Add(new DeadlyShot());
        }

        public override void useSkill(Monster monster){
            Console.WriteLine("Escolha a skill " + this.name + " :");
            foreach(var skill in skills){
                Console.WriteLine((skills.IndexOf(skill) +1 ) + ". " + skill.name);
            }
            Console.WriteLine("Digite o número:");
            int escolha = 1;
            skills[(escolha - 1)].utilize(this, monster);
        }
    }

    public class Mage : Player
    {
        public Mage(string name, Element element) :
            base(name, element)
        {
            this.name = name;
            this.maxHp = ClassStats.MAGE_START_HP;
            this.currentHp = ClassStats.MAGE_START_HP;
            this.level = ClassStats.START_LEVEL;
            this.xp = ClassStats.START_XP;
            this.gold = ClassStats.START_GOLD;
            this.strength = ClassStats.MAGE_START_STRENGTH;
            this.intelligence = ClassStats.MAGE_START_INTELLIGENCE;
            this.dexterity = ClassStats.MAGE_START_DEXTERITY;
            inventory = new Inventory();
            World.countPlayer += 1;
            this.id = World.countPlayer;
            this.currentWeapon = World.SearchWeapon(World.ITEM_ID_WAND);
            this.skills = new List<Skill>();
            skills.Add(new BasicAttack());
        }

        public override void useSkill(Monster monster){
            Console.WriteLine("Escolha a skill " + this.name + " :");
            foreach(var skill in skills){
                Console.WriteLine((skills.IndexOf(skill) +1 ) + ". " + skill.name);
            }
            Console.WriteLine("Digite o número:");
            int escolha = 1;
            skills[(escolha - 1)].utilize(this, monster);
        }
    }

    public class Cleric : Player
    {
        public Cleric(string name, Element element) :
            base(name, element)
        {
            this.name = name;
            this.maxHp = ClassStats.CLERIC_START_HP;
            this.currentHp = ClassStats.CLERIC_START_HP;
            this.level = ClassStats.START_LEVEL;
            this.xp = ClassStats.START_XP;
            this.gold = ClassStats.START_GOLD;
            this.strength = ClassStats.CLERIC_START_STRENGTH;
            this.intelligence = ClassStats.CLERIC_START_INTELLIGENCE;
            this.dexterity = ClassStats.CLERIC_START_DEXTERITY;
            inventory = new Inventory();
            World.countPlayer += 1;
            this.id = World.countPlayer;
            this.currentWeapon = World.SearchWeapon(World.ITEM_ID_WAND);
            this.skills = new List<Skill>();
            skills.Add(new BasicAttack());
        }

        public override void useSkill(Monster monster){
            Console.WriteLine("Escolha a skill " + this.name + " :");
            foreach(var skill in skills){
                Console.WriteLine((skills.IndexOf(skill) +1 ) + ". " + skill.name);
            }
            Console.WriteLine("Digite o número:");
            int escolha = 1;
            skills[(escolha - 1)].utilize(this, monster);
        }
    }

    public static class ClassStats
    {
        public const int START_LEVEL = 1;

        public const int START_XP = 0;

        public const int START_GOLD = 0;

        //WARRIOR
        public const int WARRIOR_START_HP = 20;

        public const int WARRIOR_START_STRENGTH = 20;

        public const int WARRIOR_START_INTELLIGENCE = 5;

        public const int WARRIOR_START_DEXTERITY = 10;

        //Archer
        public const int ARCHER_START_HP = 20;

        public const int ARCHER_START_STRENGTH = 15;

        public const int ARCHER_START_INTELLIGENCE = 5;

        public const int ARCHER_START_DEXTERITY = 20;

        //Mage
        public const int MAGE_START_HP = 20;

        public const int MAGE_START_STRENGTH = 5;

        public const int MAGE_START_INTELLIGENCE = 30;

        public const int MAGE_START_DEXTERITY = 5;


        //Cleric

        public const int CLERIC_START_HP = 20;

        public const int CLERIC_START_STRENGTH = 10;

        public const int CLERIC_START_INTELLIGENCE = 20;

        public const int CLERIC_START_DEXTERITY = 10;
    }
}
