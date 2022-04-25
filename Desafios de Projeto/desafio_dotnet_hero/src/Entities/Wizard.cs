namespace desafio_de_projeto_dotnet.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, string heroType, int level, int damage, int hp) : base(name, heroType, level, damage, hp){}
        public override void Attack(Hero target)
        {
            if(target._heroType == "Ninja"){
                target._hp -= _damage + 1;
            }
            else{
                target._hp -= _damage;
            }
        }
        public override void specialAbility()
        {
            _hp += 2;
        }
    }
}