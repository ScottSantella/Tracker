using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Business.Entities;
using Tracker.Engine;
using static Tracker.Business.Entities.Enums;
using System.Collections.Generic;

namespace Tracker.Tests
{
    [TestClass]
    public class TestEngine
    {
        [TestMethod]
        public void TestMethod1()
        {

            var a = new Athlete()
            {
                Firstname = "Scott",
                Weight = 234,
                Height = 184,
                Gender = Gender.Male,
                Event = AtheleteEvent.Sprints,
                AthleteID = 1,
                Lastname = "Santella"
            };

            var calculator = new ScoreCalculator(a);

            Console.WriteLine(calculator.GetFinalScore());
            Console.WriteLine(calculator.GetFinalScore(100,200));
            Console.WriteLine(calculator.GetFinalScore(10, 2));

            var test1 = calculator.GetFinalScore(10, 2);
            Assert.AreEqual(76, test1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var scores = new List<AthleteTestScore>();
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = 275, Test = AthleteTest.Bench });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = 455, Test = AthleteTest.Deadlift });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = 36, Test = AthleteTest.Sprint300m });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = 4, Test = AthleteTest.Sprint30m });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = 22, Test = AthleteTest.PullUps });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = 16, Test = AthleteTest.OverheadShot });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = 3, Test = AthleteTest.BroadJump });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = 400, Test = AthleteTest.Squat });



            var a = new Athlete()
            {
                Firstname = "Scott",
                Weight = 200,
                Height = 188,
                Event = AtheleteEvent.Sprints,
                AthleteID = 1,
                Gender = Gender.Female,
                Lastname = "Santella",
                Scores = scores
            };

            var calculator = new ScoreCalculator(a);

            Console.WriteLine(calculator.GetFinalScore());
            //Console.WriteLine(calculator.GetFinalScore(100, 200));
            //Console.WriteLine(calculator.GetFinalScore(10, 2));

            //var test1 = calculator.GetFinalScore(10, 2);
            //Assert.AreEqual(76, test1);
        }
    }
}
