// See https://aka.ms/new-console-template for more information
using BowlingGame;

Console.WriteLine("Hello, World!");
Joueur Sasha = new Joueur(1, "Sasha");
Joueur Julie = new Joueur(2, "Julie");
Joueur Ahmed = new Joueur(3, "Ahmed");
Joueur Maxime = new Joueur(4, "Maxime");
Joueur[] tabJoueur = new Joueur[] {Sasha, Julie, Ahmed, Maxime };
Partie p = new Partie(tabJoueur);
p.Lancer(10);
//Score = 10

p.Lancer(3);
//Score = 13

p.Lancer(2);