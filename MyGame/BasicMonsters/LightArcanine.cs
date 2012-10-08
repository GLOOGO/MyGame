using System.Collections.Generic;

namespace MyGame.BasicMonsters
{
    public class LightArcanine: BasicMonster
    {
        public LightArcanine() : base("Light Arcanine")
        {
            HealthPoints = 11;
            SubAbility  sixDamageWithBurn = new SubAbility(true, true, 6, 0, specialConditionType:SpecialConditionType.Burn);
            SubAbility fourDamage = new SubAbility(true, true, 4, 0);
            SubAbility stun = new SubAbility(true, true, 0, 0, 1, SpecialConditionType.TurnLoss);


            Abilities.Add(new Ability("Will-O-Wisp", "Does 6 damage and burns the target", new List<SubAbility> {sixDamageWithBurn}));
            Abilities.Add(new Ability("Bite", "Does 4 Damage and stuns for 1 turn", new List<SubAbility> {fourDamage, stun}));
        }
    }
}