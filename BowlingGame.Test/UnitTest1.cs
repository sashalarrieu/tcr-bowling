using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.AreEqual(0, partie.Score);
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
            Assert.AreEqual(2, partie.Score);
        }

        [TestMethod]
        public void Test1Quille()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber une quille
            partie.Lancer(1);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
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
            Assert.AreEqual(20, partie.Score);
        }

        [TestMethod]
        public void TestLancerRaté()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 0 quilles
            partie.Lancer(0);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
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
            Assert.AreEqual(27, partie.Score);
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
            Assert.AreEqual(18, partie.Score);
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
            Assert.AreEqual(36, partie.Score);
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
            Assert.AreEqual(20, partie.Score);
        }
    }
}