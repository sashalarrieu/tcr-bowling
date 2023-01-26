using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            foreach (var j in partie.listeJoueurs)
            {
                // QUAND on fait tomber 2 quilles
                partie.Lancer(j, 2);
            }

            // ALORS le score est de 0
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(0, j.score);
            }

        }


        [TestMethod]
        public void Test2Lancers1Quille()
        {
            // ETANT DONNE une partie
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            foreach (var j in partie.listeJoueurs)
            {
                // QUAND on fait tomber 1 quilles deux fois
                partie.Lancer(j, 1);
                partie.Lancer(j, 1);
            }

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
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            foreach (var j in partie.listeJoueurs)
            {
                // QUAND on fait tomber une quille
                partie.Lancer(j, 1);
            }

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
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            // QUAND on fait tomber une quille 20 fois
            foreach (var j in partie.listeJoueurs)
            {
                for (int i = 0; i < 20; i++)
                {
                    partie.Lancer(j, 1);
                }
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
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            foreach (var j in partie.listeJoueurs)
            {
                // QUAND on fait tomber 0 quilles
                partie.Lancer(j, 0);
            }

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
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            foreach (var j in partie.listeJoueurs)
            {
                // QUAND on fait tomber 10 quilles en 2 fois
                partie.Lancer(j, 9);
                partie.Lancer(j, 1);

                partie.Lancer(j, 8);
                partie.Lancer(j, 1);
            }

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
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            foreach (var j in partie.listeJoueurs)
            {
                // QUAND on fait tomber 10 quilles en 2 fois
                partie.Lancer(j, 9);
                partie.Lancer(j, 1);
                //Score = 10

                partie.Lancer(j, 3);
                //Score = 13

                partie.Lancer(j, 2);
                //Score = 15

                //Avec bonus Score = 18
            }

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
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            foreach (var j in partie.listeJoueurs)
            {
                // QUAND on fait tomber 10 quilles en 2 fois
                for (int i = 0; i < 2; i++)
                {
                    partie.Lancer(j, 9);
                    partie.Lancer(j, 1);
                    //10 - 28
                    partie.Lancer(j, 3);
                    //13 - 31
                    partie.Lancer(j, 2);
                    //15 - 33
                    //18 - 36
                }
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
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            foreach (var j in partie.listeJoueurs)
            {
                // QUAND on fait tomber 10 quille
                partie.Lancer(j, 10);
                //Score = 10

                partie.Lancer(j, 3);
                //Score = 13

                partie.Lancer(j, 2);
                //Score = 15

                //Avec bonus Score = 15 + 3+2 = 20
            }

            // ALORS le score est de 20
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(20, j.score);
            }
        }

        [TestMethod]
        public void TestAddMultiplePlayers()
        {
            // ETANT DONNE une partie
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur Julie = new Joueur(2, "Julie");
            Joueur Ahmed = new Joueur(3, "Ahmed");
            Joueur Maxime = new Joueur(4, "Maxime");
            Joueur[] tabJoueur = new Joueur[] { Sasha, Julie, Ahmed, Maxime };
            Partie partie = new Partie(tabJoueur);

            // On créer des joueurs
            Joueur joueurTest = new Joueur(5, "JoueurTest");
            Joueur joueurTest2 = new Joueur(6, "JoueurTest2");
            Joueur joueurTest3 = new Joueur(7, "JoueurTest3");

            // On regarde combien de joueurs il y a avant d'en ajouter
            int nbJoueurs = partie.listeJoueurs.Count;

            // On ajoute à la partie les nouveaux joueurs
            partie.listeJoueurs.Add(joueurTest);
            partie.listeJoueurs.Add(joueurTest2);
            partie.listeJoueurs.Add(joueurTest3);


            // On vérifie le nombre de joueurs
            Assert.AreEqual(nbJoueurs + 3, partie.listeJoueurs.Count);

        }

        [TestMethod]
        public void TestAdd4Players()
        {
            // ETANT DONNE une partie
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur Julie = new Joueur(2, "Julie");
            Joueur Ahmed = new Joueur(3, "Ahmed");
            Joueur Maxime = new Joueur(4, "Maxime");
            Joueur[] tabJoueur = new Joueur[] { Sasha, Julie, Ahmed, Maxime };
            Partie partie = new Partie(tabJoueur);

            // On vide la liste de joueurs
            partie.listeJoueurs.Clear();

            // On créer des joueurs
            Joueur joueurTest = new Joueur(5, "JoueurTest");
            Joueur joueurTest2 = new Joueur(6, "JoueurTest2");
            Joueur joueurTest3 = new Joueur(7, "JoueurTest3");
            Joueur joueurTest4 = new Joueur(8, "JoueurTest4");

            // On ajoute à la partie les nouveaux joueurs
            partie.listeJoueurs.Add(joueurTest);
            partie.listeJoueurs.Add(joueurTest2);
            partie.listeJoueurs.Add(joueurTest3);
            partie.listeJoueurs.Add(joueurTest4);

            // On vérifie le nombre de joueurs
            Assert.AreEqual(4, partie.listeJoueurs.Count);

        }

        [TestMethod]
        public void TestAtLeast1Player()
        {
            // On créer une liste joueur vide
            Joueur[] joueur = new Joueur[] { };

            // ETANT DONNE une partie
            Partie partie;

            // On vide la liste de joueurs
            Assert.ThrowsException<ArgumentException>(() => partie = new Partie(joueur));
        }

        [TestMethod]
        public void TestStrikePuisSpare()
        {
            // ETANT DONNE une partie
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            foreach (var j in partie.listeJoueurs)
            {
                // QUAND on fait tomber 10 quille
                partie.Lancer(j, 10);
                //Score = 10

                partie.Lancer(j, 3);
                partie.Lancer(j, 7);
                //Score = 30 (10 + 10 * 2)

                partie.Lancer(j, 3);
                //Score = 33

                partie.Lancer(j, 2);
                //Score = 38 (33 + 2 + 3)
            }

            // ALORS le score est de 38
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(38, j.score);
            }
        }

        [TestMethod]
        public void TestSparePuisStrike()
        {
            // ETANT DONNE une partie
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);

            foreach (var j in partie.listeJoueurs)
            {
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
                //Score = 40 (33 + 2 + 3 + 2)
            }

            // ALORS le score est de 40
            foreach (var j in partie.listeJoueurs)
            {
                Assert.AreEqual(40, j.score);
            }
        }

        [TestMethod]
        public void TestClassementFinal()
        {
            // ETANT DONNE une partie
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur Julie = new Joueur(2, "Julie");
            Joueur Ahmed = new Joueur(3, "Ahmed");
            Joueur Maxime = new Joueur(4, "Maxime");
            Joueur[] tabJoueur = new Joueur[] { Sasha, Julie, Ahmed, Maxime };
            Partie partie = new Partie(tabJoueur);

            // LORSQUE la partie est jouée
            partie.Lancer(Sasha, 10);
            partie.Lancer(Julie, 2);
            partie.Lancer(Julie, 2);
            partie.Lancer(Maxime, 3);
            partie.Lancer(Maxime, 3);
            partie.Lancer(Ahmed, 1);
            partie.Lancer(Ahmed, 1);

            List<Joueur> classementListeJoueurs = new List<Joueur>
            {
                Sasha,
                Maxime,
                Julie,
                Ahmed
            };

            // ALORS le classement final est correct
            Assert.AreEqual(classementListeJoueurs.ToString(), partie.ClassementFinal().ToString());

        }

        [TestMethod]
        public void TestScoreMax300()
        {
            // ETANT DONNE une partie
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur[] tabJoueur = new Joueur[] { Sasha };
            Partie partie = new Partie(tabJoueur);
            partie.listeJoueurs[0].score= 301;
            Console.WriteLine(partie.listeJoueurs[0].ToString());
            Assert.ThrowsException<ArgumentException>(() => partie.Lancer(Sasha ,4));

        }

        [TestMethod]
        public void TestIdJoueurDifferent()
        {
            // ETANT DONNE une partie
            // On créer des joueurs dont 2 ont des id similaires
            Joueur Sasha = new Joueur(1, "Sasha");
            Joueur Julie = new Joueur(1, "Julie");
            Joueur Ahmed = new Joueur(3, "Ahmed");
            Joueur Maxime = new Joueur(4, "Maxime");
            Joueur[] tabJoueur = new Joueur[] { Sasha, Julie, Ahmed, Maxime };
            Partie partie = new Partie(tabJoueur);
            
            // On vérifie qu'on se retrouve avec 3 joueurs seulement
            Assert.AreEqual(3, partie.listeJoueurs.Count);
            
        }
    }
}