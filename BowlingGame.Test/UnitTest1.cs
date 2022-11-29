using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test2Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 2 quilles
            partie.Lancer(2);

            // ALORS le score est de 0
            foreach(var j in partie.listeJoueurs)
            {
                Assert.AreEqual(0, j.score);
            }
            
        }


        [TestMethod]
        public void Test2Lancers1Quille()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(1);
            partie.Lancer(1);

            // ALORS le score est de 2
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(2, j.score);
            }
        }

        [TestMethod]
        public void Test1Quille()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber une quille
            partie.Lancer(1);

            // ALORS le score est de 0
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(0, j.score);
            }
        }

        [TestMethod]
        public void Test1Quille20Lancers()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber une quille 20 fois

            for (int i = 0; i < 20; i++)
            {
                partie.Lancer(1);
            }

            // ALORS le score est de 20
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(20, j.score);
            }
        }

        [TestMethod]
        public void TestLancerRaté()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 0 quilles
            partie.Lancer(0);

            // ALORS le score est de 0
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(0, j.score);
            }
        }

        [TestMethod]
        public void TestSpare8Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 10 quilles en 2 fois
            partie.Lancer(9);
            partie.Lancer(1);

            partie.Lancer(8);
            partie.Lancer(1);

            // ALORS le score est de 27
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(27, j.score);
            }
        }

        [TestMethod]
        public void TestSpare3Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 10 quilles en 2 fois
            partie.Lancer(9);
            partie.Lancer(1);
            //Score = 10

            partie.Lancer(3);
            //Score = 13

            partie.Lancer(2);
            //Score = 15

            //Avec bonus Score = 18

            // ALORS le score est de 18
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(18, j.score);
            };
        }

        [TestMethod]
        public void Test2Spare3Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 10 quilles en 2 fois
            for (int i = 0; i < 2; i++)
            {
                partie.Lancer(9); 
                partie.Lancer(1);
                //10 - 28
                partie.Lancer(3);
                //13 - 31
                partie.Lancer(2);
                //15 - 33
                //18 - 36
            }

            // ALORS le score est de 36
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(36, j.score);
            }
        }

        [TestMethod]
        public void TestStrike()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 10 quille
            partie.Lancer(10);
            //Score = 10

            partie.Lancer(3);
            //Score = 13

            partie.Lancer(2);
            //Score = 15

            //Avec bonus Score = 15 + 3+2 = 20

            // ALORS le score est de 20
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(20, j.score);
            }
        }
    }
}