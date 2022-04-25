namespace desafio_de_projeto_dotnet.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, string heroType, int level, int damage, int hp) : base(name, heroType, level, damage, hp){}

        public override void Attack(Hero target)
        {
            if(target._heroType == "Wizard"){
                target._hp -= _damage + 2;
            }
            else{
                target._hp -= _damage;
            }
        }

        public override void specialAbility()
        {
            _damage += 2;
        }
    }
}