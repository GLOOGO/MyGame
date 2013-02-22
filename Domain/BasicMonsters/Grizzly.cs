using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class Grizzly: BasicMonster
    {
        public Grizzly() : base("Grizzly")
        {

            HealthPoints = 9;
            SubAbility sixDamageWithBleed = new SubAbility(true, true, 6, 0, specialConditionType:SpecialConditionType.Bleed);
            SubAbility healSelf = new SubAbility(true, false, 0, 9);

            Abilities.Add(new Ability("Maul", "Does 6 damage and causes bleed.", new List<SubAbility> {sixDamageWithBleed}));
            Abilities.Add(new Ability("Sleep", "Heal Grizzly for full.", new List<SubAbility> {healSelf}));
        }
    }
}