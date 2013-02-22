using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class Treecko : BasicMonster
    {
        public Treecko() : base("Treecko")
        {
            HealthPoints = 3;
            SubAbility twoDamageWithCrit = new SubAbility(true, true, 2, 0, subAbilityChanceToCrit:.35, critAmount:7);

            Abilities.Add(new Ability("Bullet Seed", "Does 2 damage, 35% chance to crit.", new List<SubAbility> {twoDamageWithCrit}));
        }
    }
}