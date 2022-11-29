namespace BowlingGame;

public class Partie
{
    private readonly List<int> _historique = new ();

    public void Lancer(int nombreQuillesTombées)
    {
        _historique.Add(nombreQuillesTombées);

        if (TermineUneFrame())
        {
            Score += DeuxDerniersLancers.Sum();
            if (ScoreSpare == 10)
            {
                Score += PremierDeuxDerniersLancers;
                ScoreSpare = 0;
            }
            if (ScoreStrike == 10)
            {
                Score += DeuxDerniersLancers.Sum();
                ScoreStrike = 0;
            }
        }
        
        if(EstUnStrike()) 
        {
            //_historique.Add(0);
            ScoreStrike = DeuxDerniersLancers.Sum();
        }
        if (EstUnSpare())
        {
            ScoreSpare = DeuxDerniersLancers.Sum();
        }
    }
    
    private IEnumerable<int> DeuxDerniersLancers => _historique.AsEnumerable().Reverse().Take(2);
    private int PremierDeuxDerniersLancers => DeuxDerniersLancers.Reverse().First();
    private bool TermineUneFrame() => _historique.Count % 2 == 0;
    private bool EstUnSpare() => DeuxDerniersLancers.Sum() == 10 && PremierDeuxDerniersLancers != 10;
    private bool EstUnStrike() => DeuxDerniersLancers.Sum() == 10 && PremierDeuxDerniersLancers == 10;

    public int Score { get; private set; }
    public int ScoreSpare { get; private set; } = 0;
    public int ScoreStrike { get; private set; } = 0;
}