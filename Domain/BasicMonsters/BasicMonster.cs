namespace Domain.BasicMonsters
{
    public class BasicMonster : Unit
    {
        public BasicMonster(string name) :base(name, CardType.BasicMonster)
        {
            
        }
        private int _itemLimit = 1;
        private int _spellLimit = 0;

    }
}