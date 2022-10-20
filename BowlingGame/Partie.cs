namespace BowlingGame;

public class Partie
{
    private readonly List<int> _historique = new ();

    public void Lancer(int nombreQuillesTombées)
    {
        _historique.Add(nombreQuillesTombées);

        if(EstUnStrike()) return;
        if (EstUnSpare())
        {
            ScoreSpare = DeuxDerniersLancers.Sum();
        }

        if (TermineUneFrame())
        {
            Score = DeuxDerniersLancers.Sum();
            if (ScoreSpare == 10)
            {
                Score = Score + PremierDeuxDerniersLancers + ScoreSpare;
            }
        }
    }
    private IEnumerable<int> DeuxDerniersLancers => _historique.AsEnumerable().Reverse().Take(2);
    private int PremierDeuxDerniersLancers => DeuxDerniersLancers.Reverse().First();
    private bool TermineUneFrame() => _historique.Count % 2 == 0;
    private bool EstUnSpare() => DeuxDerniersLancers.Sum() == 10;
    private bool EstUnStrike() => _historique.Last() == 10;

    public int Score { get; private set; }
    public int ScoreSpare { get; private set; }
}