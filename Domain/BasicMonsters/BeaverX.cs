using System.Collections.Generic;
using Domain.Abilities;

namespace Domain.BasicMonsters
{
    public class BeaverX : BasicMonster
    {
        public BeaverX() : base("Beaver X")
        {
            HealthPoints = 3;
            SubAbility fourDamageAndDestroyItem = new SubAbility(true, true, 4, 0, specialConditionType:SpecialConditionType.DestroyAllItems);

            Abilities.Add(new Ability("Cut Down", "Destroy an item and deal 4 damage to it's owner.", new List<SubAbility> {fourDamageAndDestroyItem}));
        }
    }
}