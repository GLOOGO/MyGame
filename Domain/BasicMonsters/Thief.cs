using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class Thief : BasicMonster
    {
        public Thief() : base("Thief")
        {
            HealthPoints = 2;
            //TODO:Ability Missing, Finish Thief
            //SubAbility  = new SubAbility();

            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
            Abilities.Add(new Ability("Steal", "80% chance to steal 3 gems from another player. If it fails, do 4 damage.", new List<SubAbility> {}));
        }
    }
}