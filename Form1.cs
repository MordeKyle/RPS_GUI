using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

            /*Program: Form RPS game with rockPaperScissors class
              Author: Kyle McBride A02609917
              Date: 09/23/2014
              Description: A windows form rock paper scissors game using rockPaperScissors class*/

namespace RPS_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            const string resultFile = "../../Results.txt";
            const string win = "You Win!";
            const string lose = "You Lose!";
            const string draw = "Draw.";
            InitializeComponent();
            winsLabel.Text = readHistory(resultFile, win).ToString(); //print number of wins on initialize
            losesLabel.Text = readHistory(resultFile, lose).ToString(); //print number of loses on initialize
            drawsLabel.Text = readHistory(resultFile, draw).ToString(); //print number of draws on initialize
        }

        private void drawsLabel_Click(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            const string resultFile = "../../Results.txt";
            string userChoice;
            string computerChoice;
            string userInput;
            string result;
            const string clear = "Clear";
            const string exit = "Exit";
            const string win = "You Win!";
            const string lose = "You Lose!";
            const string draw = "Draw.";

            userChoice = inputHandeler(); //determine user's choice
            computerChoice = computerInput(); //generate a computer choice

            rockPaperScissors rockPaperScissors = new rockPaperScissors();
            result = rockPaperScissors.playGame(userChoice, computerChoice); //play the game
            recordHistory(resultFile, result); //record results in Results.txt
            printResults(userChoice, computerChoice, result); //print results on form
            winsLabel.Text = readHistory(resultFile, win).ToString(); //print number of wins
            losesLabel.Text = readHistory(resultFile, lose).ToString(); //print number of loses
            drawsLabel.Text = readHistory(resultFile, draw).ToString(); //print number of draws
        }
        private string inputHandeler()
        {
            string m_result;
            if (rockRadio.Checked)
            {
                m_result = "Rock";
            }
            else if (paperRadio.Checked)
            {
                m_result = "Paper";
            }
            else if (scissorsRadio.Checked)
            {
                m_result = "Scissors";
            }
            else
            {
                MessageBox.Show("Make a selection, then click the play button.");
                m_result = "Error";
            }
            return m_result;
        }
        private string computerInput() //assign generated random to a game value
        {
            string m_result;
            int m_random;

            m_random = generateRandom();

            if (m_random == 1)
            {
                m_result = "Rock";
            }
            else if (m_random == 2)
            {
                m_result = "Paper";
            }
            else
            {
                m_result = "Scissors";
            }
            return m_result;
        }
        private int generateRandom() //generate random integer
        {
            int m_result;
            Random rand = new Random();
            m_result = rand.Next(3) + 1;
            return m_result;
        }
        private int readHistory(string m_resultFile, string m_result) //reads and prints result file
        {
            //declaring output
            int resultTotal = 0;

            //declaring streamreader
            StreamReader inputFile;
            //streamreading the results file
            inputFile = File.OpenText(m_resultFile);

            string readLine;

            while (inputFile.EndOfStream == false) //loop to count how many times win, lose, or draw is in the file
            {
                readLine = inputFile.ReadLine();

                if (readLine == m_result) //checks to se if each line is equal to win, lose, or draw
                {
                    ++resultTotal; //if so, add 1 to the counter
                }
            }
            inputFile.Close();

            return resultTotal; //output the counter, as it is equal to how many wins, loses, or draws
        }
        private void recordHistory(string m_resultFile, string m_result) //write results of game to result file
        {
            StreamWriter outputFile;
            outputFile = File.AppendText(m_resultFile);
            outputFile.WriteLine(m_result);
            outputFile.Close();
        }
        private void printResults(string m_userChoice, string m_computerChoice, string m_result)
        {
            userInputLabel.Text = m_userChoice;
            computerInputLabel.Text = m_computerChoice;
            resultsLabel.Text = m_result;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            const string m_resultFile = "../../Results.txt";
            const string win = "You Win!";
            const string lose = "You Lose!";
            const string draw = "Draw.";
            File.WriteAllText(m_resultFile, string.Empty);
            winsLabel.Text = readHistory(m_resultFile, win).ToString();
            losesLabel.Text = readHistory(m_resultFile, lose).ToString();
            drawsLabel.Text = readHistory(m_resultFile, draw).ToString();
        }
    }
}
