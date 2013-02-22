using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class TomNook: BasicMonster
    {
        public TomNook() : base("Tom Nook")
        {
            HealthPoints = 2;
            //TODO:Abilities Missing, Finish Tom Nook
//            SubAbility  = new SubAbility();
//            SubAbility  = new SubAbility();

            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
        }
    }
}