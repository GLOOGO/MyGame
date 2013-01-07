using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class DrMario : BasicMonster
    {
        public DrMario() : base("Dr. Mario")
        {
            HealthPoints = 6;
            SubAbility threeDamageOrHeal = new SubAbility(true, true, 3, 3);
            SubAbility freezeEnemy = new SubAbility(false, true, 0, 0, specialConditionType : SpecialConditionType.Freeze);

            Abilities.Add(new Ability("Pill", "Does 3 damage or healing.", new List<SubAbility>{threeDamageOrHeal}));
            Abilities.Add(new Ability("Chill", "Freeze an enemy.", new List<SubAbility> {freezeEnemy}));

        }

         
    }
}