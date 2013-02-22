using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class Spy: BasicMonster
    {
        public Spy() : base("Spy")
        {

            HealthPoints = 1;
            //TODO:Finish Spy, Spy's Abilities are currently not supported
//            SubAbility  = new SubAbility();
//            SubAbility  = new SubAbility();

            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
        }
    }
}