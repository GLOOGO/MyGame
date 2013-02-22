using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class Imp: BasicMonster
    {
        public Imp() : base("Imp")
        {

            HealthPoints = 3;
            SubAbility twoDamage = new SubAbility(true, true, 2, 0);
            //TODO:Finish Imp, Passive ability missing
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));

        }
    }
}