namespace BowlingGame;

public class Partie
{
    public List<Joueur> listeJoueurs = new List<Joueur>();



    public Partie(Joueur[] joueur)
    {
        foreach (Joueur jo in joueur) { if (!checkIfPlayerIdAlreadyExist(jo)) { listeJoueurs.Add(jo); } }
        if (!checkMinimumJoueurs()) { throw new ArgumentException("La partie ne compte aucun joueur, il faut au minimum un joueur"); }
    }

    public bool checkIfPlayerIdAlreadyExist(Joueur joueur)
    {
        foreach(Joueur jo in listeJoueurs)
        {
            if(jo.id== joueur.id) return true;
        }

        return false;
    }

    public bool checkMinimumJoueurs()
    {
        if (this.listeJoueurs.Count <= 0)
        {
            return false;
        }

        return true;
    }

    public bool checkNombreQuilleTombees(int nombreQuille)
    {
        if(nombreQuille>10 || nombreQuille<0) { return false; }
        return true;
    }

    public void Lancer(Joueur joueur, int nombreQuillesTombées)
    {
        if(!checkNombreQuilleTombees(nombreQuillesTombées)) { throw new ArgumentException("Vous ne pouvez pas lancer plus de 10 quilles"); }
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
        if (joueur.score > 300)
        {
            throw new ArgumentException("Le score ne peut pas être supérieur à 300");
        }
        Console.WriteLine("Score : " + joueur.score);
    }

    public List<Joueur> ClassementFinal()
    {
        // trier la liste de joueurs en fonction de leur score
        listeJoueurs = listeJoueurs.OrderByDescending(j => j.score).ToList();
        // afficher le classement final des joueurs
        for (int i = 0; i < listeJoueurs.Count; i++)
        {
            Console.WriteLine((i + 1) + ": " + listeJoueurs[i].name + " - Score: " + listeJoueurs[i].score);
        }
        return listeJoueurs;
    }

    public override string ToString()
    {
        string result = "";
        foreach (var joueur in listeJoueurs)
        {
            result += joueur.ToString() + "\n";
        }
        return result;
    }

}