using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class Boots: BasicMonster
    {
        public Boots() : base("Boots")
        {

            HealthPoints = 5;
            SubAbility oneDamageWithDisorient = new SubAbility(true, true, 1, 0, specialConditionType: SpecialConditionType.Disorient);
            SubAbility threeDamage = new SubAbility(true, true, 3, 0);

            Abilities.Add(new Ability("Bad Manner", "Does 1 damage and disorients an enemy.", new List<SubAbility> {oneDamageWithDisorient}));
            Abilities.Add(new Ability("Smack", "Does 3 damage.", new List<SubAbility> {threeDamage}));
        }
    }
}