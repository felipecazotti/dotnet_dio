# Desafio de Projeto .NET
Repositório para desenvolvimento do desafio de código do bootcamp de .NET da DIO

## Introdução
O desafio proposto pelo bootcamp era contruir uma classe abstrata Hero a qual se derivariam as calsse Knight, Wizard e Ninja. Cada classe filha implementaria um método Attack que exibiria no console qual tipo de ataque foi executado. A classe Hero e, devido a heranças, suas filhas possuem os atributos \_name, \_HeroType, \_level, \_damage, \_hp.
Sendo assim, o proposto era apenas visual e com o objetivo de consolidar os estudos sobre POO, focando em Herança e polimorfismo, contudo, foi implementado funcionalidades extras que permitem dois jogadores batalharem em uma espécie de jogo de cartas estilo Hearthstone.

## Mudanças
### Dinamica dos Personagens
Foi adicionado uma dinâmica extra para alguns personagens, aumentando o dano de ataque dependendo do oponente. O Knight ganha um bônus de 2 de dano contra Wizard, a Wizard ganha um bônus de 1 de dano contra o Nija e o Ninja não possui bônus de dano.
Ademais, foi adicionado um método chamado specialHability() que aumenta um atributo de um personagem quanado chamada. A Wizard ganha 2 de HP, o Ninja ganha 1 de dano e 1 de HP e o Knight ganha 2 de dano.

### Classe Game
Como foi mensionado anteriormente, uma das mudanças foi criar uma dinamica de jogo entre dois _players_. Essa dinâmica é controlada pela classe Game.

A classe Game possui duas listas de Hero, representando os decks de cada jogador, o contrutor da classe já inicializa esses decks contendo uma carta de cada tipo, sendo assim, cada deck possui três cartas.

A classe possui o método init() que efetivamente inicia o jogo.

#### init()
O jogo funciona em rodadas e cada rodada começa pelo jogador 1 encolhendo qual personagem usar e qual personagem do jogador 2 atacar e em seguida a situação se inverte e o jogador 2 escolhe qual personagem usar e qual personagem do jogador 1 irá atacar. Ao fim de cada rodada a habilidade especial de cada herói de cada deck e chamada. Funções _private_ player1Attack() e player2Attack() foram criadas para auxiliar na execução dessa dinâmica.

## Sugestões de Mudanças
Embora fosse satisfatório modificar os objetivos iniciais do desafio, incrementando funcionalidades no projeto, por restrições de tempo, algumas melhorias foram deixadas de lado.

### Interface Gráfica
Todo jogo roda no Prompt de Comando baseado em comandos enviados pelo usuário quando solicitado. Uma interface gráfica tornaria o jogo muito mais amigável.

### Criar Personagens
Os três personagens do jogo são criados de maneira fixa e cada deck é automaticamente contruído no contrutor da classe Game com todos os personagens. Uma mudança interessante seria permitir a criação de mais personagens e permitir que o usuário monte seu deck antes de começar o jogo, já que haverá mais personagens disponíveis.

### Level
O atributo Level foi declarado como parte do objetivo inicial do desafio do bootcamp, contudo, ele não interfere na dinâmica do jogo. Esse valor poderia ser utilzado para aumentar os atributos dos personagens conforme o Level aumenta por exemplo.

### player1Attack() e player2Attack()
Esses dois cétodos são muito parecidos, podedo ser refatoradas e ser utilizado apenas um método de ataque para os dois jogadores.

