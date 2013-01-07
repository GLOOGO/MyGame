using System.Collections.Generic;

namespace MyGame.BasicMonsters
{
    public class ChesterSourmonkey: BasicMonster
    {
        public ChesterSourmonkey() : base("Chester Sourmonkey")
        {

            HealthPoints = 8;
            SubAbility fourDamageCannotMiss = new SubAbility(true, true, 4, 0, subAbilityChanceToFail: 0);
            SubAbility eightDamage = new SubAbility(true, true, 8, 0);
            SubAbility chanceToFail = new SubAbility(true, true, 8, 0, subAbilityChanceToFail: .5);
            SubAbility stun = new SubAbility(true, true, 0, 0, 2, SpecialConditionType.TurnLoss);

            Abilities.Add(new Ability("Seltzer Bottle", "Does 4 damage. Cannot miss.", new List<SubAbility> {fourDamageCannotMiss}));
            Abilities.Add(new Ability("Anvil", "50% chance to do 8 damage and stun for 2 turns.", new List<SubAbility> {eightDamage, chanceToFail, stun}));
        }
    }
}