using System.Collections.Generic;

namespace MyGame.BasicMonsters
{
    public class Goblin : BasicMonster
    {
        public Goblin() : base("Goblin")
        {

            HealthPoints = 4;
            SubAbility fiveTrueDamage = new SubAbility(true, true, 5, 0, isTrueDamage:true);

            Abilities.Add(new Ability("Spear", "Does 5 true damage.", new List<SubAbility> {fiveTrueDamage}));
        }
    }
}