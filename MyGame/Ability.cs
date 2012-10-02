namespace MyGame
{
    public class Ability
    {
        public Ability(string name, string description, int damage, int heal)
        {
            Name = Name;
            Description = description;
            Damage = damage;
            Heal = heal;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
        public int Heal { get; set; }
    }
}