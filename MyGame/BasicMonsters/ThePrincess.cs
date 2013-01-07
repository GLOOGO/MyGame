using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class ThePrincess : BasicMonster
    {
        public ThePrincess() : base("The Princess")
        {
            //TODO:Finish The Princess, no healthpoints, not technically a monster
            //HealthPoints = ;
            //SubAbility  = new SubAbility();
            //SubAbility  = new SubAbility();

            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
        }
    }
}