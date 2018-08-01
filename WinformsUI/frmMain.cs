using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracker.Business.Entities;
using Tracker.Engine;
using static Tracker.Business.Entities.Enums;

namespace WinformsUI
{
    public partial class frmMain : Form
    {
        private object txtBroadjump;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGender.SelectedIndex = 0;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello cramer");
            FemaleAll.Left = 400;
        }

        private void labelTst_Click(object sender, EventArgs e)
        {

        }

        private void CurrentAthlete_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AllAthlete_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FemaleCurrent_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaleAll_Click(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {

        }

        private double StringToDouble(string input)
        {
            double output = 0;
            double.TryParse(input, out output);
            return output;
        }

        private void GetScore()
        {
            var scores = new List<AthleteTestScore>();
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = StringToDouble(txtBench.Text), Test = AthleteTest.Bench });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = StringToDouble(txtDeadlift.Text), Test = AthleteTest.Deadlift });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = StringToDouble(txtSprint300.Text), Test = AthleteTest.Sprint300m });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = StringToDouble(txtSprint30.Text), Test = AthleteTest.Sprint30m });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = StringToDouble(txtPullUps.Text), Test = AthleteTest.PullUps });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = StringToDouble(txtOHShot.Text), Test = AthleteTest.OverheadShot });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = StringToDouble(txtBroad.Text), Test = AthleteTest.BroadJump });
            scores.Add(new AthleteTestScore() { AthleteID = 1, Score = StringToDouble(txtSquat.Text), Test = AthleteTest.Squat });


            Gender gender;
            if (cboGender.Text == "Male")
            {
                gender = Gender.Male;
            }
            else
            {
                gender = Gender.Female;
            }

            var a = new Athlete()
            {
                Firstname = "Scott",
                Weight = StringToDouble(txtWeight.Text),
                Height = 188,
                Event = AtheleteEvent.Sprints,
                AthleteID = 1,
                Gender = gender,
                Lastname = "Santella",
                Scores = scores
            };

            var calculator = new ScoreCalculator(a);


            var finalScore = calculator.GetFinalScore();

            Console.WriteLine(finalScore);
            txtFinalScore.Text = finalScore.ToString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetScore();
        }

        private void Sprint30m_Click(object sender, EventArgs e)
        {

        }

        private void txtBroadJump_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
