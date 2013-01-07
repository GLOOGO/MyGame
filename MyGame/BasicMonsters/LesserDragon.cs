using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class LesserDragon: BasicMonster
    {
        public LesserDragon() : base("Lesser Dragon")
        {

            HealthPoints = 8;
            SubAbility threeDamageToAdjacentUnits = new SubAbility(true,true, 3, 0, affectsAdjacentUnits:true);
            //TODO:Finish Lesser Dragon, Ability Missing
            //SubAbility  = new SubAbility();

            Abilities.Add(new Ability("Tail Swing", "Does 3 damage to target and to adjacent units", new List<SubAbility> {threeDamageToAdjacentUnits}));
            Abilities.Add(new Ability("", "", new List<SubAbility> {}));
        }
    }
}