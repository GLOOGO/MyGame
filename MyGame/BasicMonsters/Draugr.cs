using System.Collections.Generic;
using MyGame.Abilities;

namespace MyGame.BasicMonsters
{
    public class Draugr : BasicMonster
    {
        public Draugr() : base("Draugr")
        {

            HealthPoints = 2;
            SubAbility fiveDamageWithStun = new SubAbility(true, true, 5, 0, 1, SpecialConditionType.TurnLoss);

            Abilities.Add(new Ability("Ancient Nord Warhammer", "Does 5 damage and stuns for 1 turn.", new List<SubAbility> {fiveDamageWithStun}));
        }
    }
}