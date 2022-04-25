namespace desafio_de_projeto_dotnet.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, string heroType, int level, int damage, int hp) : base(name, heroType, level, damage, hp){}

        public override void Attack(Hero target)
        {
            target._hp -= _damage;
        }

        public override void specialAbility()
        {
            _hp += 1;
            _damage += 1;
        }
    }
}