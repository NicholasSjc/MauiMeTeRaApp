using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MauiMeTeRaApp
{
    public partial class MmtrGameScreenEng : Form
    {
        //global variables
        List<string> EnglishWords = new List<string>()
        {
            "digital", "plant", "love", "chicken", "colour", "nose", "memory", "native", "poison", "global", "dragon", "spring", "angel","zebra","axis",

        };

        //create a variable to store the selected letter
        private string SelectedLetter;


        // create a variable to hold the chosen word
        private string chosenWord;




        public MmtrGameScreenEng()
        {
            InitializeComponent();
            //select random word
            Random random = new Random();
            int index = random.Next(EnglishWords.Count);
            chosenWord = EnglishWords[index].ToUpper();

            //check num of characters then hide unwanted GusWrdRtb //declare method here
            HideGusWrdRtb();


        }

        int mistakeCounter = 0;
        int correctCounter = 0;


        private void LangBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form LngeScreen = new LngeScreen();
            LngeScreen.Closed += (s, args) => this.Close();
            LngeScreen.Show();
        }

        private void StryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form StryScreen = new StryScreen();
            StryScreen.Closed += (s, args) => this.Close();
            StryScreen.Show();
        }

        public class RandomStringFromListGenerator
        {
            private Random EnglishWords;


            public RandomStringFromListGenerator()
            {
                EnglishWords = new Random();
            }

            public string GenerateRandomStringFromList(string[] stringList)
            {
                if (stringList == null || stringList.Length == 0)
                {
                    throw new ArgumentException("String list must not be null or empty.");
                }

                int index = EnglishWords.Next(stringList.Length);
                return stringList[index];
            }
        }






        private void NwGamBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MmtrGameScreenEng = new MmtrGameScreenEng();
            MmtrGameScreenEng.Closed += (s, args) => this.Close();
            MmtrGameScreenEng.Show();


        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }






        private void HideGusWrdRtb()
        {
            switch (chosenWord.Length)
            {
                case 3:
                    GusWrdEngRtb4.Hide();
                    GusWrdEngRtb5.Hide();
                    GusWrdEngRtb6.Hide();
                    GusWrdEngRtb7.Hide();
                    GusWrdEngRtb8.Hide();
                    break;
                case 4:
                    GusWrdEngRtb5.Hide();
                    GusWrdEngRtb6.Hide();
                    GusWrdEngRtb7.Hide();
                    GusWrdEngRtb8.Hide();
                    break;
                case 5:
                    GusWrdEngRtb6.Hide();
                    GusWrdEngRtb7.Hide();
                    GusWrdEngRtb8.Hide();
                    break;
                case 6:
                    GusWrdEngRtb7.Hide();
                    GusWrdEngRtb8.Hide();
                    break;
                case 7:
                    GusWrdEngRtb8.Hide();
                    break;



            }
        }



        private List<int> GetCharacterIndexs(string letter)
        {
            List<int> indexSelectedLetter = new List<int>();

            //loop throught the string checking each character with the chosen character

            for (int index = 0; index < chosenWord.Length; index++)
            {
                if (chosenWord[index].ToString().Equals(letter))
                {
                    indexSelectedLetter.Add(index);
                }
            }
            return indexSelectedLetter;
        }






        private void Qbtn_Click_1(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int indexSlectedLetter = Convert.ToInt32(clickedButton.Tag);



            List<int> letterIndexes = new List<int>();



            //check if chosen word contains the clicked letter
            if (chosenWord.IndexOf(clickedButton.Text) != -1)
            {

                letterIndexes = GetCharacterIndexs(clickedButton.Text);



                clickedButton.BackColor = Color.Green;



                foreach (int index in letterIndexes)
                {
                    int upAmount = 20;

                    int newV = GamSunPic.Location.X;
                    int newA = GamSunPic.Location.Y + upAmount;

                    GamSunPic.Location = new Point(newV, newA);

                    if (1 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdEngRtb1.Text = clickedButton.Text;

                    }
                    else if (2 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdEngRtb2.Text = clickedButton.Text;

                    }
                    else if (3 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdEngRtb3.Text = clickedButton.Text;

                    }
                    else if (4 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdEngRtb4.Text = clickedButton.Text;

                    }
                    else if (5 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdEngRtb5.Text = clickedButton.Text;

                    }
                    else if (6 == index+1)
                    {


                        //then display letter in correct rtb
                        GusWrdEngRtb6.Text = clickedButton.Text;

                    }
                    else if (7 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdEngRtb7.Text = clickedButton.Text;

                    }
                    else if (8 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdEngRtb8.Text = clickedButton.Text;

                    }
                    else
                    {
                        //else display mistake in rightside rtb
                        MessageBox.Show("No match");

                    }
                }



            }
            else
            {
                //else display mistake in rightside rtb
                MistkBoxRtb.AppendText($"{clickedButton.Text}");

                int sideAmount = 150;

                int newS = GamSunPic.Location.X + sideAmount;
                int newU = GamSunPic.Location.Y;

                GamSunPic.Location = new Point(newS, newU);

                mistakeCounter++;

                if (mistakeCounter > 0)
                {
                   
                }
                clickedButton.BackColor = Color.Red;

            }

            clickedButton.Enabled = false;




            if (mistakeCounter > 4)
            {
                PicLossScreen.BringToFront();

                MessageBox.Show($"{chosenWord}");



            }



        }

        
    }
}
