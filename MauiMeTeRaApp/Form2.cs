using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MauiMeTeRaApp
{
    public partial class MmtrGameScreenEng : Form
    {
        public MmtrGameScreenEng()
        {
            InitializeComponent();
        }

        private void LangBtn_Click(object sender, EventArgs e)
        {
            Form LngeScreen = new LngeScreen();
            LngeScreen.Show();
            this.Hide();
        }

        private void StryBtn_Click(object sender, EventArgs e)
        {
            Form StryScreen = new StryScreen();
            StryScreen.Show();
            this.Hide();
        }

        List<string> EnglishWords = new List<string>()
        {
            "digital", "plant", "love", "chicken", "color", "nose", "memory", "native", "poison", "global", "dragon", "spring", "angel","zebra","axis"

        };


    }
}
