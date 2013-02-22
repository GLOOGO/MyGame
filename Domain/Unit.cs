using System.Collections.Generic;
using Domain.Abilities;

namespace Domain
{
    public class Unit : Card
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public List<AppliedSpecialCondition> AppliedSpecialConditions { get; set; }
        public List<Ability> Abilities { get; set; }


        public Unit(string name, CardType cardType)
            : base(cardType, true)
        {
            Name = name;
            Abilities = new List<Ability>();
        }


    }
}
