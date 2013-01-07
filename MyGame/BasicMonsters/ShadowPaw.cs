using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class ShadowPaw : BasicMonster
    {
        public ShadowPaw() : base("Shadow Paw")
        {

            HealthPoints = 1;
            SubAbility sixDamageWithBleed = new SubAbility(true, true, 6, 0, specialConditionType:SpecialConditionType.Bleed);
            SubAbility stun = new SubAbility(true, true, 0, 0, 2, SpecialConditionType.TurnLoss);

            Abilities.Add(new Ability("Claw", "Does 6 damage. Causes bleed.", new List<SubAbility> {sixDamageWithBleed}));
            Abilities.Add(new Ability("Bash", "Stun for two turns.", new List<SubAbility> {stun}));
        }
    }
} 
