namespace MyGame
{
    public class AppliedCondition
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