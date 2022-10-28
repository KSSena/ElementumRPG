using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class Combat
    {
        public void CreateCombat(Monster monster){
            monster.currentHp = monster.maxHp;
            Sequence(monster);
            while(monster.currentHp > 0){
                Boolean monsterTurn = false;
                foreach(var player in World.players){
                    if(monster.initiative > player.initiative && !monsterTurn){
                        MonsterTurn(monster);
                        monsterTurn = true;
                    }
                    PlayerTurn(player, monster);

                    if(monster.currentHp <= 0){
                        Console.WriteLine("Monstro foi derrotado");
                        break;
                    } 
                }
            }   
        }

        public void Sequence(Monster monster){
            foreach(Player player in World.players){
                player.initiative = Dice.D20(player.dexterity);
            }
            World.players = World.players.OrderByDescending(player => player.initiative).ToList();
            monster.initiative = Dice.D20(monster.dexterity);
        }

        public void PlayerTurn(Player player, Monster monster){
            player.useSkill(monster);
            Console.WriteLine("A vida do monstro é de " + monster.currentHp);
        }

        public void MonsterTurn(Monster monster){
            Console.WriteLine("Monster's turn."); 
        }
    }
}