using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class DraugrDeathLord: BasicMonster
    {
        public DraugrDeathLord() : base("Draugr Death Lord")
        {

            HealthPoints = 6;
            SubAbility fourDamage = new SubAbility(true, true, 4, 0);
            SubAbility stun = new SubAbility(true, true, 0, 0, 2, SpecialConditionType.TurnLoss);
            SubAbility destroyItem = new SubAbility(true, true, 0, 0, specialConditionType:SpecialConditionType.DestroyAllItems);

            Abilities.Add(new Ability("Fus-Ro-Dah", "Does 4 damage and stuns for 2 turns.", new List<SubAbility> {fourDamage, stun}));
            Abilities.Add(new Ability("Disarm", "Destroy an item equipped to an enemy monster.", new List<SubAbility> {destroyItem}));
        }
    }
}