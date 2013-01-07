using System.Collections.Generic;

namespace MyGame.BasicMonsters
{
    public class Spike : BasicMonster
    {
        public Spike () : base("Spike")
        {

            HealthPoints = 30;
            //TODO: Finish Spike, abilities are not currently supported
            SubAbility  = new SubAbility();
            SubAbility  = new SubAbility();

            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
        }
    }
}