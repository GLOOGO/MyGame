namespace MyGame
{
    public class AppliedSpecialCondition
    {
        public SpecialCondition SpecialCondition { get; set; }
        public int TurnsRemaining;

        public AppliedSpecialCondition(SpecialCondition specialCondition, int turnsRemaining)
        {
            SpecialCondition = specialCondition;
            TurnsRemaining = turnsRemaining;
        }
    }
}