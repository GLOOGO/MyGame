using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class Pidgey: BasicMonster
    {
        public Pidgey() : base("Pidgey")
        {

            HealthPoints = 5;
            SubAbility threeDamage = new SubAbility(true, true, 3, 0);

            Abilities.Add(new Ability("Peck", "Does 3 damage.", new List<SubAbility> {threeDamage}));
        }
    }
}