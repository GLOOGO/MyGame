using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class Popo : BasicMonster
    {
        public Popo() : base("Popo")    
        {
            HealthPoints = 6;
            SubAbility fourDamage = new SubAbility(true, true, 4, 0);
            //TODO: Ability Missing, Finish Popo

            Abilities.Add(new Ability("Ice Cube", "Does 4 damage.", new List<SubAbility> { fourDamage }));
        }
    }
}