using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tracker.Business.Entities;
using static Tracker.Business.Entities.Enums;

namespace Tracker.Engine
{
    public class ScoreCalculator
    {

        private Athlete _athlete;

   

        public ScoreCalculator()
        {

        }

        public ScoreCalculator(Athlete athlete)
        {
            _athlete = athlete;
        }

        public int GetFinalScore(double weight, double height)
        {
            int finalScore = 0;

            finalScore = (int)(weight * height);
            return finalScore;

        }

        public double GetFinalScore()
        {
            //int finalScore = 0;
            //double secretNumber = 56;
            //var sum = _athlete.Scores.Sum(x => x.Score);
            //finalScore = _athlete.Scores[(int)Enums.AthleteTest.Bench].Score + (int)(_athlete.Weight * _athlete.Height + secretNumber);
            //return finalScore;

            //Control KC and Control KU to turn things into comments


            double finalScore = 0;
            int numberOfEvents = _athlete.Scores.Count();
            Gender gender = _athlete.Gender;

            //var sum = _athlete.Scores.Sum(x => x.Score);
            //finalScore = _athlete.Scores[(int)Enums.AthleteTest.Bench].Score + _athlete.Scores[(int)Enums.AthleteTest.Squat].Score + (int)(_athlete.Weight * _athlete.Height);
            //return finalScore;


            double Sprint30mScore = _athlete.Scores.FirstOrDefault(x => x.Test == AthleteTest.Sprint30m).Score;

            finalScore = CalculateBroadJumpScore(gender, _athlete.Scores.FirstOrDefault(x => x.Test == AthleteTest.BroadJump).Score);
            finalScore = finalScore + Calculate30mSprintScore(gender, _athlete.Scores.FirstOrDefault(x => x.Test == AthleteTest.Sprint30m).Score);
            finalScore = finalScore + Calculate300mSprintScore(gender, _athlete.Scores.FirstOrDefault(x => x.Test == AthleteTest.Sprint300m).Score);
            finalScore = finalScore + CalculateOverheadshot(gender, _athlete.Scores.FirstOrDefault(x => x.Test == AthleteTest.OverheadShot).Score);
            finalScore = finalScore + CalculateBench(gender, _athlete.Scores.FirstOrDefault(x => x.Test == AthleteTest.Bench).Score);
            finalScore = finalScore + CalculateSquat(gender, _athlete.Scores.FirstOrDefault(x => x.Test == AthleteTest.Squat).Score);
            finalScore = finalScore + CalculateDeadlift(gender, _athlete.Scores.FirstOrDefault(x => x.Test == AthleteTest.Deadlift).Score);
            finalScore = finalScore + CalculatePullUps(gender, _athlete.Scores.FirstOrDefault(x => x.Test == AthleteTest.PullUps).Score);





            return finalScore / numberOfEvents;

        



            // we need gender, weight, scores, score type

        }

        private double CalculatePullUps(Gender gender, double score)
        {
            
            // PullUps (m) 34 = 100
            // PullUps (f) 21 = 100
            double maleMultiplier = 34;
            double femaleMultiplier = 21;

            if (gender == Gender.Male)
            {
                return (score / maleMultiplier) * 100;
            }
            else
            {
                return (score / femaleMultiplier) * 100;
            }

        }

        private double CalculateDeadlift(Gender gender, double score)
        {
            // Deadlift (m) 3.0x bodyweight = 100
            // Deadlift (f) 2.4x bodyweight = 100

            double maleMultiplier = _athlete.Weight * 3;
            double femaleMultiplier = _athlete.Weight * 2.4;

            if (gender == Gender.Male)
            {
                return (score / maleMultiplier) * 100;
            }
            else
            {
                return (score / femaleMultiplier) * 100;
            }


        }

        private double CalculateSquat(Gender gender, double score)
        {
            // Squat (m) 2.6x bodyweight = 100
            // squat (f) 2.1x bodyweight = 100

            double maleMultiplier = _athlete.Weight * 2.6;
            double femaleMultiplier = _athlete.Weight * 2.1;

            if (gender == Gender.Male)
            {
                return (score / maleMultiplier) * 100;
            }
            else
            {
                return (score / femaleMultiplier) * 100;
            }

        }

        private double CalculateBench(Gender gender, double score)
        {
            // Bench (m) 2x bodyweight = 100
            // Bench (f) 1.5x bodyweight = 100

            double maleMultiplier = _athlete.Weight * 2;
            double femaleMultiplier = _athlete.Weight * 1.5;

            if (gender == Gender.Male)
            {
                return (score / maleMultiplier) * 100;
            }
            else
            {
                return (score / femaleMultiplier) * 100;
            }
        }

        private double CalculateOverheadshot(Gender gender, double score)
        {
            // Overheadshot (m) = 18.5 = 100
            // Overheadshot (f) = 16.5 = 100

            double maleMultiplier = 18.5;
            double femaleMultiplier = 16.5;

            if (gender == Gender.Male)
            {
                return (score / maleMultiplier) * 100;
            }
            else
            {
                return (score / femaleMultiplier) * 100;
            }

        }

        private double Calculate300mSprintScore(Gender gender, double score)
        {
            // Sprint300m (m) = 32 = 100
            // Sprint300m (f) = 36 = 100

            double maleMultiplier = 32;
            double femaleMultiplier = 36;

            if (gender == Gender.Male)
            {
                return (maleMultiplier / score) * 100;
            }
            else
            {
                return (femaleMultiplier / score) * 100;
            }
        }

        private double CalculateBroadJumpScore(Gender gender, double score)
        {
            // Broad Jump (m) = 3.5 = 100 (D/3.5 x 100 = score)
            // Broad Jump (f) = 2.7 = 100 (D/2.7 x 100  = score)
            double maleMultiplier = 3.5;
            double femaleMultiplier = 2.7;

            if (gender == Gender.Male)
            {
                return (score / maleMultiplier) * 100;
            }
            else
            {
                return (score / femaleMultiplier) * 100;
            }
        }

        private double Calculate30mSprintScore(Gender gender, double score)
        {
            // Sprint30m (m) = 3.3 = 100
            // Sprint30m (f) = 3.75 = 100
            double maleMultiplier = 3.3;
            double femaleMultiplier = 3.75;

            if (gender == Gender.Male)
            {
                return (maleMultiplier / score) * 100;
            }
            else
            {
                return (femaleMultiplier / score) * 100;
            }
        }
    }
}
