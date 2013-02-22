using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class CaptainFalcon : BasicMonster
    {
        public CaptainFalcon() : base("Captain Falcon")
        {
            HealthPoints = 8;
            SubAbility sixDamage = new SubAbility(false, true, 6, 0);
            SubAbility invulnerability = new SubAbility(true, false, 0, 0, 2, SpecialConditionType.Invulnerability);

            Abilities.Add(new Ability("Falcon Punch!", "Does 6 damage.", new List<SubAbility>{sixDamage}));
            Abilities.Add(new Ability("Big Blue", "Make one of your monsters invulnerable for two turns.", new List<SubAbility> { invulnerability }));
        }
    }
}