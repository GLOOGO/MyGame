using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class Hedwig: BasicMonster
    {
        public Hedwig() : base("Hedwig")
        {
            HealthPoints = 4;
            SubAbility oneDamage = new SubAbility(true, true, 1, 0);
            //SubAbility  = new SubAbility();
            //TODO:Ability Missing, Finish Hedwig
            Abilities.Add(new Ability("Scratch", "Does 1 damage.", new List<SubAbility> {oneDamage}));
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
        }
    }
}