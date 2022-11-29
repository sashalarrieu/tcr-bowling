using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Joueur
    {
        public int id;
        public string name;
        public int score = 0;
        public readonly List<int> _historique = new();
        public int ScoreSpare { get; set; } = 0;
        public int ScoreStrike { get; set; } = 0;

        public Joueur(int id, string name)
        {
            this.id = id;
            this.name = name;

        }

        public int getId()
        {
            return id;
        }

        public string getName()
        { 
            return name; 
        }

        public int getScore()
        {
            return score;
        }

        public void setScore(int score) { }

        public IEnumerable<int> DeuxDerniersLancers => _historique.AsEnumerable().Reverse().Take(2);
        public int PremierDeuxDerniersLancers => DeuxDerniersLancers.Reverse().First();
        public bool TermineUneFrame() => _historique.Count % 2 == 0;
        public bool EstUnSpare() => DeuxDerniersLancers.Sum() == 10 && PremierDeuxDerniersLancers != 10;
        public bool EstUnStrike() => DeuxDerniersLancers.Sum() == 10 && PremierDeuxDerniersLancers == 10;

    }
}
