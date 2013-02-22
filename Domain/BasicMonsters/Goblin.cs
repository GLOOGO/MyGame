using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class Goblin : BasicMonster
    {
        public Goblin() : base("Goblin")
        {

            HealthPoints = 4;
            SubAbility fiveTrueDamage = new SubAbility(true, true, 5, 0, isTrueDamage:true);

            Abilities.Add(new Ability("Spear", "Does 5 true damage.", new List<SubAbility> {fiveTrueDamage}));
        }
    }
}