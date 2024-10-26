using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;

namespace HutyraDA2
{
    public partial class Form1 : Form
    {
        //Initialize global variables
        List<Label> labelList = new List<Label>();
        int curRow = 0;
        int curCol = 0;
        string word = "";
        HashSet<string> wordList = new HashSet<string>();
        int guessAmount = 1;

        /// <summary>
        /// Have methods be called so they function
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Generate_Labels();
            Load_Words();
            this.KeyPress += Key_Press;
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Generate the text boxes for input and checking
        /// </summary>
        public void Generate_Labels()
        {
            //Variables initialized
            int width = 50;
            int height = 50;
            int xSpacing = 10;
            int ySpacing = 30;
            int rowWidth = (width * 5) + (xSpacing * 4);
            int x = (this.ClientSize.Width - rowWidth) / 2;
            int y = 60;

            //For loop to give 6 chance rows and 5 letter inputs
            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    //Make new label with correct size, color, placement, font, etc.
                    Label lb = new Label();
                    lb.Text = "";
                    lb.Font = new Font("Rockwell", 24, FontStyle.Bold);
                    lb.Size = new Size(width, height);
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.BorderStyle = BorderStyle.FixedSingle;
                    lb.BackColor = Color.White;
                    lb.Location = new Point(x + j * (width + xSpacing), y);

                    //Add to controls and to list
                    this.Controls.Add(lb);
                    labelList.Add(lb);
                }
                //Move down by height + spacing
                y += height + ySpacing;
            }
        }

        /// <summary>
        /// Input script that checks if the input is valid, is a letter, and if you won or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            //Temp variables
            string guess = "";
            char letter = ' ';
            //If input is a letter
            if (char.IsLetter(e.KeyChar))
            {
                if (curCol < (curRow + 1) * 5)
                {
                    //letter is the input but uppercase
                    letter = char.ToUpper(e.KeyChar);
                    //Add letter to label list
                    labelList[curCol].Text = letter.ToString();
                    curCol += 1;

                }
            }
            //If you backspace
            else if (e.KeyChar == '\b' && curCol > curRow * 5)
            {
                //Goes back from the current column and sets it to blank
                curCol -= 1;
                labelList[curCol].Text = "";
            }
            //If you press enter and every input is filled
            else if (e.KeyChar == (char)(Keys.Enter))
            {
                //Build word from list
                guess = Build_Word();
                MessageBox.Show("The built word is: " + guess);
                //Check if it's a valid word
                if (Check_Valid(guess))
                {
                    //Increase the guess amount and updates the labels so they're right, wrong, or right but in the wrong place
                    guessAmount++;
                    Update_Labels(guess);

                    //Check if the word was guessed correctly and make a win text, then exit
                    if (Check_Win(guess))
                    {
                        MessageBox.Show("You Win!");
                        Application.Exit();
                        return;
                    }
                    //Check if the player guessed too many times and make lose text, then exit
                    else if (guessAmount > 6)
                    {
                        MessageBox.Show("You Lost! Word was: " + word);
                        Application.Exit();
                        return;
                    }
                    //Move onto next row
                    curRow++;
                    curCol = curRow * 5;
                }
                //If guess isn't a real word, say that's it's not a real word
                else
                {
                    MessageBox.Show("Not a valid word!");
                }
            }
        }
        
        /// <summary>
        /// Load words from files with valid and guess ones
        /// </summary>
        public void Load_Words()
        {
            //Initialize new temp variables for loading words
            string tempGuessWord = "";
            string tempValidWord = "";
            Random rng = new Random();
            int element = 0;
            //Try reading the file
            try
            {
                //Add all words that exist in the file into a string array
                string[] allGuessWords = File.ReadAllLines("D:\\GitHub\\CS-3020\\HutyraDA2\\HutyraDA2\\wordSelect.txt");

                //For each word in the list
                foreach (string words in allGuessWords)
                {
                    //Trim them so there's no white space and convert it to uppercase
                    tempGuessWord = words.Trim();
                    tempGuessWord = tempGuessWord.ToUpper();
                    //Add edited words to list
                    wordList.Add(tempGuessWord);
                }
            }
            //Catch if there is an issue with the file
            catch (IOException ex)
            {
                MessageBox.Show("Problem with word file: wordSelect.txt");
            }

            //Element chooses random word from all the list using rng and uses it to get the word
            element = rng.Next(0, wordList.Count);
            word = wordList.ElementAt(element);

            //For debugging
            //word = "SASSY";
            //MessageBox.Show("The word is: " + word);
            //Try reading the file
            try
            {
                //Add all words that exist in the file into a string array
                string[] allValidWords = File.ReadAllLines("D:\\GitHub\\CS-3020\\HutyraDA2\\HutyraDA2\\validWords.txt");
                //For each word in the list
                foreach (string words in allValidWords)
                {
                    //Trim them so there's no white space and convert it to uppercase
                    tempValidWord = words.Trim();
                    tempValidWord = tempValidWord.ToUpper();
                    //Add edited words to list
                    wordList.Add(tempValidWord);
                }
            }
            //Catch if there is an issue with the file
            catch (IOException ex)
            {
                MessageBox.Show("Problem with word file: validWords.txt");
            }
        }
        /// <summary>
        /// Updates the color of the labels
        /// </summary>
        /// <param name="guess"></param>
        public void Update_Labels(string guess)
        {
            //Initialize variables
            int startIndex = 0;
            bool[] matchedIndex = new bool[5];
            bool[] matchedInGuess = new bool[5];
            bool[] matchedInWord = new bool[5];

            startIndex = curRow * 5;
            //For loop
            for (int i = 0; i < 5; i++)
            {
                //Check if the guess's letters and word's letters are in the same place
                if (guess[i] == word[i])
                {
                    //Change it to green and set everything to true for that index position
                    labelList[startIndex + i].BackColor = Color.Green;
                    matchedIndex[i] = true;
                    matchedInGuess[i] = true;
                    matchedInWord[i] = true;
                }
            }
            //Does another loop to check if it matches the characters
            for (int i = 0; i < 5; i++)
            {
                //If the matched index isn't true check for if the letter exists in the word at all
                if (!matchedIndex[i])
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (guess[i] == word[j] && !matchedInGuess[j] && !matchedInWord[i])
                        {
                            //Set it to yellow if that's true
                            labelList[startIndex + i].BackColor = Color.Yellow;
                            matchedInGuess[i] = true;
                            matchedInWord[i] = true;
                            break;
                        }
                    }
                }
            }
            
        }

        /// <summary>
        /// Build word
        /// </summary>
        /// <returns></returns>
        public string Build_Word()
        {
            string builtWord = "";
            for(int i = curRow * 5; i < (curRow + 1) * 5; i++)
            {
                builtWord += labelList[i].Text;
            }
            return builtWord;
        }

        
        /// <summary>
        /// Checks if the guess is the correct word
        /// </summary>
        /// <param name="guess"></param>
        /// <returns></returns>
        public bool Check_Win(string guess)
        {
            if(word == guess)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if guess is a valid word
        /// </summary>
        /// <param name="guess"></param>
        /// <returns></returns>
        public bool Check_Valid(string guess)
        {
            if (wordList.Contains(guess))
            {
                return true;
            }
            return false;
        }
    }
}
