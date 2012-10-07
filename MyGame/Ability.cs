namespace MyGame
{
    public class Ability
    {
        public readonly string Name;
        public readonly string Description;
        public readonly bool CanTargetAlly;
        public readonly bool CanTargetEnemy;
        public readonly int Damage;
        public readonly int Heal;
        public readonly bool Invulnerability;
        public readonly int AppliedOverTurns;
        public readonly bool CausesTurnLoss;
        public readonly bool DestroyAllItems;
        public readonly bool MoveTarget;
        public readonly bool AffectsAdjacentUnits;
        public readonly short ChanceToCauseDamage;
        public readonly short ChanceToFail;
        public readonly short ChanceToInfatuate;
        public readonly short ChanceToMiss;
        public readonly short ChanceToSnapOut;
        public readonly short ChanceToThaw;
        public readonly short ChanceToRepeat;
        public readonly short ChanceToAttackAgain;
        public readonly short ChanceToReflectAttacks;
        public readonly short ChanceToReflectSpells;
        public readonly short ChanceToDelayAttack;

        public Ability(
            string name,
            string description,
            bool canTargetAlly,
            bool canTargetEnemy,
            int damage = 0,
            int heal = 0,
            bool invulnerability = false,
            int appliedOverTurns = 1,
            bool causesTurnLoss = false,
            bool destroyAllItems = false,
            bool moveTarget = false,
            bool affectsAdjacentUnits = false,
            short chanceToCauseDamage = 0,
            short chanceToFail = 0,
            short chanceToInfatuate = 0 ,
            short chanceToMiss = 0,
            short chanceToSnapOut = 0,
            short chanceToThaw = 0,
            short chanceToRepeat = 0,
            short chanceToAttackAgain = 0,
            short chanceToReflectAttacks = 0,
            short chanceToReflectSpells = 0,
            short chanceToDelayAttack = 0
            
            )

    {
        Name = name;
        Description = description;
        Damage = damage;
        Heal = heal;
        CanTargetAlly = canTargetAlly;
        CanTargetEnemy = canTargetEnemy;
        Invulnerability = invulnerability;
        AppliedOverTurns = appliedOverTurns;
        CausesTurnLoss = causesTurnLoss;
        CausesTurnLoss = causesTurnLoss;
        DestroyAllItems = destroyAllItems;
        AffectsAdjacentUnits = affectsAdjacentUnits;
        MoveTarget = moveTarget;
        ChanceToFail = chanceToFail;
        ChanceToCauseDamage = chanceToCauseDamage;
        ChanceToMiss = chanceToMiss;
        ChanceToSnapOut = chanceToSnapOut;
        ChanceToThaw = chanceToThaw;
        ChanceToRepeat = chanceToRepeat;
        ChanceToAttackAgain = chanceToAttackAgain;
        ChanceToInfatuate = chanceToInfatuate;
        ChanceToReflectAttacks = chanceToReflectAttacks;
        ChanceToReflectSpells = chanceToReflectSpells;
        ChanceToDelayAttack = chanceToDelayAttack;
    }
    }
}