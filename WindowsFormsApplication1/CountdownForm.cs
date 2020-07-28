using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownApp
{
    public partial class CountdownForm : Form
    {
        protected string DictionaryFile = "externalfiles\\engmix.txt";
        protected List<string> Consonants = new List<string> { "A", "B", "C", "D", "F", "G", "H", "J", "K","L","M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z"};
        protected List<string> Vowels = new List<string> { "A", "E", "I", "O", "U" };
        protected List<string> SelectedLetters;
        protected int SecondsToGo = 60;
        protected Timer TimeLeft;
        protected IDictionary WordList = new Dictionary();

        public CountdownForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialise();
        }

        private void Initialise()
        {
            //reset everything for a new round
            LettersTextbox.Text = "";

            WordList = new Dictionary();
            WordList.Load(DictionaryFile);

            SelectedLetters = new List<string>();
            TimeLeftTextBox.Text = "60";
            SecondsToGo = 60;

            ConsonantButton.Enabled = true;
            VowelButton.Enabled = true;
            GoButton.Enabled = true;
            AnswerTextbox.ReadOnly = true;
        }

        private void ConsonantButton_Click(object sender, EventArgs e)
        {
            //work out which consonants are left and if too many consonants have been selected
            // at least 4 consonants and 3 vowels
            var letters = Consonants.Where(l => SelectedLetters.All(n => n != l));
            if (letters == null) letters = new List<string>();
            //random letter
            Random r = new Random();
            var nextLetter = 0;
            if (letters != null) nextLetter = r.Next(letters.Count());


            if (SelectedLetters.Count() > 8|| (letters == null || letters.Count() == 0 || SelectedLetters.Where(l => Consonants.Contains(l)).Count() > 5))
            {
                ConsonantButton.Text = "X Consonant";
                ConsonantButton.ForeColor = Color.Red;
                return;
            }
            
            var x = letters.ElementAt(nextLetter);
            LettersTextbox.Text += " " + x;
            SelectedLetters.Add(x);
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            TimeLeft = new Timer();

            TimeLeft.Interval = 1000;
            TimeLeft.Enabled = true;
            TimeLeft.Tick += new EventHandler(OnTimedEvent);
            TimeLeft.Start();

            AnswerTextbox.ReadOnly = false;
        }

        protected void OnTimedEvent(object sender, EventArgs e)
        {
            SecondsToGo -= 1;
            if (SecondsToGo == 0)
            {
                TimeLeft.Stop();
                Console.Beep();
                SecondsToGo = 60;
                Console.Beep();

                AnswerTextbox.ReadOnly = true;
                
                CheckResult();
            }
            
            TimeLeftTextBox.Text = SecondsToGo.ToString();
        }

        protected void EndOfRound()
        {
            //disable all comtrols, this round is over
            SecondsToGo = 60;
            TimeLeft.Stop();

            ConsonantButton.Enabled = false;
            VowelButton.Enabled = false;
            GoButton.Enabled = false;
            AnswerTextbox.ReadOnly = true;
        }

        protected string CheckResult()
        {
            //look up dictionary to see what possible work could be made from the selected letters.
            //Compare this to the users answer
            var result = WordList.MatchWord(new List<string>(LettersTextbox.Text.Split(' ')));
            return result;
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Initialise();
            ConsonantButton.ForeColor = Color.Black;
            ConsonantButton.Text = "Consonant";
            VowelButton.ForeColor = Color.Black;
            VowelButton.Text = "Vowel";
            AnswerTextbox.Text = "";
        }

        private void VowelButton_Click(object sender, EventArgs e)
        {
            //work out which vowels are left and if too many vowels have been selected
            // at least 4 consonants and 3 vowels
            var letters = Vowels.Where(l => SelectedLetters.All(n => n != l));
            if (letters == null) letters = new List<string>();
            //random letter
            Random r = new Random();
            var nextLetter = 0;
            if (letters != null) nextLetter = r.Next(letters.Count());

            if (SelectedLetters.Count() > 8 || (letters == null || letters.Count() == 0 || SelectedLetters.Where(l => Vowels.Contains(l)).Count() > 3))
            {
                VowelButton.Text = "X Vowel";
                VowelButton.ForeColor = Color.Red;
                return;
            }

            var x = letters.ElementAt(nextLetter);
            LettersTextbox.Text += " " + x;
            SelectedLetters.Add(x);
       }

        private void submitButton_Click(object sender, EventArgs e)
        {
            EndOfRound();
            string result = CheckResult();
            bestAnswerText.Text = result;
        }
    }
}
