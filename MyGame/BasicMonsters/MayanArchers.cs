using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class MayanArchers: BasicMonster
    {
        public MayanArchers() : base("Mayan Archers")
        {
            //TODO:Finish Mayan Archers, Damage and HP Depends on gems
//            HealthPoints = ;
//            SubAbility  = new SubAbility();
//            SubAbility  = new SubAbility();

            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
        }
    }
}