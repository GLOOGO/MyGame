namespace MyGame.BasicMonsters
{
    public class CaptainFalcon : BasicMonster
    {
        public CaptainFalcon()
            : base("Captain Falcon")
        {
            HealthPoints = 8;
            Abilities.Add(new Ability("Falcon Punch!", "Does 6 damage",false, true, damage:6));
            Abilities.Add(new Ability("Big Blue", "Make one of your monsters invulnerable for two turns", true, false, invulnerability: true, appliedOverTurns:2));
        }
    }
}