namespace app
{
    public abstract class Skill
    {
        public string name;

        public string description;

        public Skill()
        {
        }

        public virtual void utilize(Player player, Monster monster)
        {
            Console.WriteLine("Error Player");
        }

        public virtual void utilize(Warrior player, Monster monster)
        {
            Console.WriteLine("Error");
        }

        public virtual void utilize(Archer player, Monster monster)
        {
            Console.WriteLine("Error");
        }

        public virtual void utilize(Mage player, Monster monster)
        {
            Console.WriteLine("Error");
        }

        public virtual void utilize(Cleric player, Monster monster)
        {
            Console.WriteLine("Error");
        }
    }

    public class BasicAttack : Skill
    {
        public BasicAttack()
        {
            this.name = Skills.BASIC_ATTACK_NAME;
            this.description = Skills.BASIC_ATTACK_DESCRIPTION;
        }

        public override void utilize(Warrior player, Monster monster)
        {
            int damage =
                player.currentWeapon.damage + Dice.Bonus(player.strength);
            monster.currentHp = monster.currentHp - damage;
            Console.WriteLine(player.name + " deu " + damage + " de dano.");
        }

        public override void utilize(Archer player, Monster monster)
        {
            int damage =
                player.currentWeapon.damage + Dice.Bonus(player.dexterity);
            monster.currentHp = monster.currentHp - damage;
            Console.WriteLine(player.name + " deu " + damage + " de dano.");
        }

        public override void utilize(Mage player, Monster monster)
        {
            int damage =
                player.currentWeapon.damage + Dice.Bonus(player.intelligence);
            monster.currentHp = monster.currentHp - damage;
            Console.WriteLine(player.name + " deu " + damage + " de dano.");
        }

        public override void utilize(Cleric player, Monster monster)
        {
            int damage =
                player.currentWeapon.damage + Dice.Bonus(player.intelligence);
            monster.currentHp = monster.currentHp - damage;
            Console.WriteLine(player.name + " deu " + damage + " de dano.");
        }
    }

    namespace WarriorSkills
    {
        public class Provoke : Skill
        {
            public Provoke()
            {
                this.name = Skills.PROVOKE_NAME;
                this.description = Skills.PROVOKE_DESCRIPTION;
            }

            public override void utilize(Warrior player, Monster monster)
            {
            }
        }
    }

    namespace ArcherSkills
    {
        public class Gust : Skill
        {
            public Gust()
            {
                this.name = Skills.GUST_NAME;
                this.description = Skills.GUST_DESCRIPTION;
            }

            public override void utilize(Archer player, Monster monster)
            {
            }
        }

        public class Aim : Skill
        {
            public Aim()
            {
                this.name = Skills.AIM_NAME;
                this.description = Skills.AIM_DESCRIPTION;
            }

            public override void utilize(Archer player, Monster monster)
            {
            }
        }

        public class DeadlyShot : Skill
        {
            public DeadlyShot()
            {
                this.name = Skills.DEADLY_SHOT_NAME;
                this.description = Skills.DEADLY_SHOT_DESCRIPTION;
            }

            public override void utilize(Archer player, Monster monster)
            {
            }
        }
    }

    namespace MageSkills
    {}

    namespace ClericSkills
    { }


}
