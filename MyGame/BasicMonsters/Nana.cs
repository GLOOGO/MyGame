using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class Nana : BasicMonster
    {
       public Nana() : base ("Nana")
       {
           HealthPoints = 8;
           SubAbility fiveDamage = new SubAbility(true, true, 5, 0);
           SubAbility freezeEnemy = new SubAbility(false, true, 0, 0, specialConditionType:SpecialConditionType.Freeze);

           Abilities.Add(new Ability("Hammer", "Does 5 damage.", new List<SubAbility> {fiveDamage}));
           Abilities.Add(new Ability("Freeze", "Freeze an enemy.", new List<SubAbility>{freezeEnemy}));
       }
    }
}