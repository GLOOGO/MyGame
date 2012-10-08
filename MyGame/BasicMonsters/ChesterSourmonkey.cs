using System.Collections.Generic;

namespace MyGame.BasicMonsters
{
    public class ChesterSourmonkey: BasicMonster
    {
        public ChesterSourmonkey() : base("Chester Sourmonkey")
        {

            HealthPoints = 8;
            //TODO:Finish Chester Sourmoney, unable to use miss chances
            SubAbility fourDamageCannotMiss = new SubAbility(true, true, 4, 0);
            SubAbility eightDamageWithStun = new SubAbility();

            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
        }
    }
}