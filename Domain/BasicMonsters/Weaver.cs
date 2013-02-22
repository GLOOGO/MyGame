using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class Weaver : BasicMonster
    {
        public Weaver () : base("Weaver")
        {
            HealthPoints = 7;
//            SubAbility damageReduction = new SubAbility();
//            SubAbility goBackTwoTurns = new SubAbility();
            SubAbility fourDamage = new SubAbility(true, true, 4, 0);
            //TODO:Abilities Missing, Finish Weaver
            Abilities.Add(new Ability("Shukuchi", "Weaver takes half damage, but only does half damage. Lasts until used again.", new List<SubAbility> {}));
            Abilities.Add(new Ability("Time Lapse", "Weaver returns to the state it was in 2 turns ago. 3 turn cooldown.", new List<SubAbility> {}));
            Abilities.Add(new Ability("Swarm", "Does 4 damage.", new List<SubAbility>{fourDamage}));
        }
    }
}