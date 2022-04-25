namespace desafio_de_projeto_dotnet.src.Entities
{
    public abstract class Hero
    {
        protected string _name;
        public string _heroType;
        protected int _level;
        public int _damage;
        public int _hp;

        public Hero(string name, string heroType, int level, int damage, int hp){
            _name = name;
            _heroType = heroType;
            _level = level;
            _damage = damage;
            _hp = hp;
        }

        public override string ToString(){
            return $"\tName: {_name}\n\tType: {_heroType}\n\tLevel: {_level}\n\tDamage: {_damage}\n\tHp: {_hp}\n";
        }

        public abstract void Attack(Hero target);

        public abstract void specialAbility();

    }
}