namespace Domain.MagicMonsters
{
    public class MagicMonster : Unit
    {
        private int _itemLimit = 0;
        private int _spellLimit = 1;

        public MagicMonster(string name) : base(name, CardType.MagicMonster)
        {
            
        }



    }
}