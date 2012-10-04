namespace MyGame.BasicMonsters
{
    public class Slime : BasicMonster
    {
        public Slime() : base("Slime")
        {
            HealthPoints = 2;
            Abilities.Add(new Ability("Attack", "Does 2 damage", 2, 0, null, true, true));
        }
    }
}