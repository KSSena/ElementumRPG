namespace app
{
    public class Monster
    {
        public int id { get; set; }

        public string name { get; set; }

        public int maxHp;

        public int currentHp{ get; set; }

        public int damage;

        public int dropXp;

        public int dropGold;
        
        public int dexterity{get; set;}
        public int initiative;

        public Element element;

        public Monster(string name, int dexterity, int maxHp, Element element){
            this.id = id;
            this.name = name;
            this.dexterity = dexterity;
            this.maxHp = maxHp;
            this.element = element;
        }
    }
}
