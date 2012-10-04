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
        public readonly short ChanceToCauseDamage;
        public readonly short ChanceToFail;
        public readonly short ChanceToInfatuate;
        public readonly short ChanceToMiss;
        public readonly short ChanceToSnapOut;
        public readonly short ChanceToThaw;

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
            short chanceToCauseDamage = 0,
            short chanceToFail = 0,
            short chanceToInfatuate = 0 ,
            short chanceToMiss = 0,
            short chanceToSnapOut = 0,
            short chanceToThaw = 0
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
            MoveTarget = moveTarget;
            ChanceToFail = chanceToFail;
            ChanceToCauseDamage = chanceToCauseDamage;
            ChanceToMiss = chanceToMiss;
            ChanceToSnapOut = chanceToSnapOut;
            ChanceToThaw = chanceToThaw;
            ChanceToInfatuate = chanceToInfatuate;
        }
    }
}