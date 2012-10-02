namespace MyGame.MagicMonsters
{
    public class Slime : BasicMonster
    {
        public Slime() : base("Slime")
        {
            HealthPoints = 11;
            Abilities.Add(new Ability("Attack", "Does 2 damage", 2, 0));
        }
    }
}