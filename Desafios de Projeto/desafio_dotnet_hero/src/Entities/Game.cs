using System.Collections.Generic;
using System;

namespace desafio_de_projeto_dotnet.src.Entities
{
    public class Game
    {
        private List<Hero> _deckPlayer1 = new List<Hero>();
        private List<Hero> _deckPlayer2 = new List<Hero>();

        public Game()
        {
            
            _deckPlayer1.Add(new Knight("Arus", "Knight", 23, 2, 10));
            _deckPlayer1.Add(new Wizard("Jenica", "White Wizard", 23, 4, 5));
            _deckPlayer1.Add(new Ninja("Wedge", "Ninja", 23, 3, 7));

            _deckPlayer2.Add(new Knight("Arus", "Knight", 23, 2, 10));
            _deckPlayer2.Add(new Wizard("Jenica", "White Wizard", 23, 4, 5));
            _deckPlayer2.Add(new Ninja("Wedge", "Ninja", 23, 3, 7));
        }

        public void init(){
            do{
                if(player1Attack()){
                    break;
                }

                if(player2Attack()){
                    break;
                }

                foreach(Hero character in _deckPlayer1){
                    character.specialAbility();
                }

                foreach(Hero character in _deckPlayer2){
                    character.specialAbility();
                }
            }while(true);
        }

        private bool player1Attack(){
            Console.WriteLine("Vez do Jogador 1:");
            Console.WriteLine(@"    Escolha qual personagem usar:");
            for(int i = 0; i < _deckPlayer1.Count; i++){
                Console.WriteLine($"{i+1} - {_deckPlayer1[i]}");
            }
            int indexMyHero = int.Parse(Console.ReadLine());

            Console.WriteLine(@"    Escolha qual personagem atacar:");
            for(int i = 0; i < _deckPlayer2.Count; i++){
                Console.WriteLine($"{i+1} - {_deckPlayer2[i]}");
            }
            int indexTargetHero = int.Parse(Console.ReadLine());

            _deckPlayer1[indexMyHero-1].Attack(_deckPlayer2[indexTargetHero-1]);

            if(_deckPlayer2[indexTargetHero-1]._hp <= 0){
                _deckPlayer2.RemoveAt(indexTargetHero-1);
            }

            if(_deckPlayer2.Count == 0){
                Console.WriteLine("Fim de Jogo. O Jogador 1 Venceu!");
                return true;
            }
            else{
                return false;
            }
        }

        private bool player2Attack(){
            Console.WriteLine("Vez do Jogador 2:");
            Console.WriteLine(@"    Escolha qual personagem usar:");
            for(int i = 0; i < _deckPlayer2.Count; i++){
                Console.WriteLine($"{i+1} - {_deckPlayer2[i]}");
            }
            int indexMyHero = int.Parse(Console.ReadLine());

            Console.WriteLine(@"    Escolha qual personagem atacar:");
            for(int i = 0; i < _deckPlayer1.Count; i++){
                Console.WriteLine($"{i+1} - {_deckPlayer1[i]}");
            }
            int indexTargetHero = int.Parse(Console.ReadLine());

            _deckPlayer2[indexMyHero-1].Attack(_deckPlayer1[indexTargetHero-1]);

            if(_deckPlayer1[indexTargetHero-1]._hp <= 0){
                _deckPlayer1.RemoveAt(indexTargetHero-1);
            }

            if(_deckPlayer1.Count == 0){
                Console.WriteLine("Fim de Jogo. O Jogador 2 Venceu!");
                return true;
            }
            else{
                return false;
            }
        }
    }
}