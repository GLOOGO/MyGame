using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class Slenderman: BasicMonster
    {
        public Slenderman() : base("Slenderman")
        {
            //TODO:Finish slenderman, unit is played differently; not technically a monster
//            HealthPoints = ;
//            SubAbility  = new SubAbility();
//            SubAbility  = new SubAbility();
//
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
        }
    }
}