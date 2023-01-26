// See https://aka.ms/new-console-template for more information
using BowlingGame;

Console.WriteLine("Hello, World!");
Joueur Sasha = new Joueur(1, "Sasha");
Joueur Julie = new Joueur(2, "Julie");
Joueur Ahmed = new Joueur(3, "Ahmed");
Joueur Maxime = new Joueur(4, "Maxime");
Joueur[] tabJoueur = new Joueur[] { Sasha, Julie, Ahmed, Maxime };
Partie partie = new Partie(tabJoueur);

foreach (var j in partie.listeJoueurs)
{
    partie.Lancer(j, 10);
    //Score = 10

    partie.Lancer(j, 3);
    //Score = 13

    partie.Lancer(j, 2);

    partie.Lancer(j, 3);
    //Score = 3
    partie.Lancer(j, 7);
    //Score = 10

    // QUAND on fait tomber 10 quille
    partie.Lancer(j, 10);
    //Score = 30 (10 + 10 * 2)

    partie.Lancer(j, 3);
    //Score = 33

    partie.Lancer(j, 2);
}