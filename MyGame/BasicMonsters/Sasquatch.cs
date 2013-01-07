using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class Sasquatch : BasicMonster
    {
        public Sasquatch() : base("Sasquatch")
        {

            HealthPoints = 6;
            SubAbility stun = new SubAbility(true, true, 0, 0, 2, SpecialConditionType.TurnLoss);
            SubAbility sevenDamage = new SubAbility(true, true, 7, 0);

            Abilities.Add(new Ability("Fear", "Stun for 2 turns.", new List<SubAbility> {stun}));
            Abilities.Add(new Ability("Bonk", "Does 7 damage.", new List<SubAbility> {sevenDamage}));
        }
    }
}