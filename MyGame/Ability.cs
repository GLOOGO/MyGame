using System.Collections.Generic;

namespace MyGame
{
    public class SubAbility
    {
        public readonly bool CanTargetAlly;
        public readonly bool CanTargetEnemy;
        public readonly int Damage;
        public readonly int Heal;
        public readonly int AppliedOverTurns;
        public readonly SpecialConditionType SpecialConditionType;
        public readonly double SpecialConditionChance;
        public readonly bool AffectsAdjacentUnits;
        public readonly double SubAbilityChanceToFail;
        public readonly double SubAbilityChanceToRepeat;
        public readonly double SubAbilityChanceToAttackAgain;
        public readonly double SubAbilityChanceToCrit;
        public readonly int CritAmount;
        public readonly bool IsTrueDamage;

        public SubAbility(
            bool canTargetAlly, 
            bool canTargetEnemy, 
            int damage, 
            int heal, 
            int appliedOverTurns = 1, 
            SpecialConditionType specialConditionType = SpecialConditionType.None, 
            double specialConditionChance = 100, 
            bool affectsAdjacentUnits = false, 
            double subAbilityChanceToFail = 0, 
            double subAbilityChanceToRepeat = 0, 
            double subAbilityChanceToAttackAgain= 0, 
            double subAbilityChanceToCrit = 0, 
            int critAmount = 0, 
            bool isTrueDamage = false)
        {
            CanTargetAlly = canTargetAlly;
            CanTargetEnemy = canTargetEnemy;
            Damage = damage;
            Heal = heal;
            AppliedOverTurns = appliedOverTurns;
            SpecialConditionType = specialConditionType;
            SpecialConditionChance = specialConditionChance;
            AffectsAdjacentUnits = affectsAdjacentUnits;
            SubAbilityChanceToFail = subAbilityChanceToFail;
            SubAbilityChanceToRepeat = subAbilityChanceToRepeat;
            SubAbilityChanceToAttackAgain = subAbilityChanceToAttackAgain;
            SubAbilityChanceToCrit = subAbilityChanceToCrit;
            CritAmount = critAmount;
            IsTrueDamage = isTrueDamage;
        }
    }

    public class Ability
    {
        public readonly string Name;
        public readonly string Description;
        public readonly List<SubAbility> SubAbilities;

        public Ability(
            string name,
            string description,
            List<SubAbility> subAbilities
            )
        {
            Name = name;
            Description = description;
            SubAbilities = subAbilities;
        }
    }
}