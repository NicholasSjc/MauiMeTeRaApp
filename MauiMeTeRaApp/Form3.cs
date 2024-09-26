using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MauiMeTeRaApp
{
    public partial class MmtrGameScreenMaori : Form
    {
        public MmtrGameScreenMaori()
        {
            InitializeComponent();
            //select random word
            Random random = new Random();
            int index = random.Next(TeReoWords.Count);
            chosenWord = TeReoWords[index];

            //check num of characters then hide unwanted GusWrdRtb //declare method here
            HideGusWrdRtb();

        }

        int mistakeCounter = 0;
        int correctCounter = 0;

        private void HideGusWrdRtb()
        {
            switch (chosenWord.Length)
            {
                case 3:
                    GusWrdTeReoRtb4.Hide();
                    GusWrdTeReoRtb5.Hide();
                    GusWrdTeReoRtb6.Hide();
                    GusWrdTeReoRtb7.Hide();
                    GusWrdTeReoRtb8.Hide();
                    break;
                case 4:
                    GusWrdTeReoRtb5.Hide();
                    GusWrdTeReoRtb6.Hide();
                    GusWrdTeReoRtb7.Hide();
                    GusWrdTeReoRtb8.Hide();
                    break;
                case 5:
                    GusWrdTeReoRtb6.Hide();
                    GusWrdTeReoRtb7.Hide();
                    GusWrdTeReoRtb8.Hide();
                    break;
                case 6:
                    GusWrdTeReoRtb7.Hide();
                    GusWrdTeReoRtb8.Hide();
                    break;
                case 7:
                    GusWrdTeReoRtb8.Hide();
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
            private Random TeReoWords;

            public RandomStringFromListGenerator()
            {
                TeReoWords = new Random();
            }

            public string GenerateRandomStringFromList(string[] stringList)
            {
                if (stringList == null || stringList.Length == 0)
                {
                    throw new ArgumentException("String list must not be null or empty.");
                }

                int index = TeReoWords.Next(stringList.Length);
                return stringList[index];
            }
        }


        List<string> TeReoWords = new List<string>()
        {
            "hui", "marae", "waiata", "haka", "tane", "tamariki", "wahine", "whānau", "waka", "koha", "kaumātua", "tēnā koe", "kakī", "hapū", "tapu"

        };

        //create a variable to store the selected letter
        private string SelectedLetter;

        // create a variable to hold the chosen word
        private string chosenWord;







        private void NwGamBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MmtrGameScreenMaori = new MmtrGameScreenMaori();
            MmtrGameScreenMaori.Closed += (s, args) => this.Close();
            MmtrGameScreenMaori.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TeReoBtn(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int indexSlectedLetter = Convert.ToInt32(clickedButton.Tag);



            List<int> letterIndexes = new List<int>();

            



            //check if chosen word contains the clicked letter
            if (chosenWord.Contains(clickedButton.Text))
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
                        GusWrdTeReoRtb1.Text = clickedButton.Text;

                    }
                    else if (2 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdTeReoRtb2.Text = clickedButton.Text;

                    }
                    else if (3 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdTeReoRtb3.Text = clickedButton.Text;

                    }
                    else if (4 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdTeReoRtb4.Text = clickedButton.Text;

                    }
                    else if (5 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdTeReoRtb5.Text = clickedButton.Text;

                    }
                    else if (6 == index+1)
                    {


                        //then display letter in correct rtb
                        GusWrdTeReoRtb6.Text = clickedButton.Text;

                    }
                    else if (7 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdTeReoRtb7.Text = clickedButton.Text;

                    }
                    else if (8 == index+1)
                    {

                        //then display letter in correct rtb
                        GusWrdTeReoRtb8.Text = clickedButton.Text;

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
                int sideAmount = 150;

                int newS = GamSunPic.Location.X + sideAmount;
                int newU = GamSunPic.Location.Y;

                GamSunPic.Location = new Point(newS, newU);

                mistakeCounter++;

                clickedButton.BackColor = Color.Red;

                MistkBox.AppendText($"{clickedButton.Text}");
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
