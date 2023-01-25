namespace BowlingGame;

public class Partie
{
    public List<Joueur> listeJoueurs = new List<Joueur>();



    public Partie(Joueur[] joueur)
    {
        foreach(Joueur jo in joueur) { listeJoueurs.Add(jo); }
        if (!checkMinimumJoueurs()) { throw new ArgumentException("La partie ne compte aucun joueur, il faut au minimum un joueur"); }
    }

    public bool checkMinimumJoueurs()
    {
        if (this.listeJoueurs.Count <= 0)
        {
            return false;
        }

        return true;
    }

    public void Lancer(int nombreQuillesTombées)
    {
        foreach(var joueur in listeJoueurs)
        {
            Console.WriteLine("Tour de : " + joueur.name);
            joueur._historique.Add(nombreQuillesTombées);


            if (joueur.TermineUneFrame())
            {
                joueur.score += joueur.DeuxDerniersLancers.Sum();
                if (joueur.ScoreSpare == 10)
                {
                    joueur.score += joueur.PremierDeuxDerniersLancers;
                    joueur.ScoreSpare = 0;
                }
                if (joueur.ScoreStrike == 10)
                {
                    joueur.score += joueur.DeuxDerniersLancers.Sum();
                    joueur.ScoreStrike = 0;
                }

            }

            if (joueur.EstUnStrike())
            {
                joueur._historique.Add(0);
                joueur.ScoreStrike = joueur.DeuxDerniersLancers.Sum();
                joueur.score += 10;
            }
            if (joueur.EstUnSpare())
            {
                joueur.ScoreSpare = joueur.DeuxDerniersLancers.Sum();
            }


            Console.WriteLine("Score : " + joueur.score);
        }
    }
    


    
}