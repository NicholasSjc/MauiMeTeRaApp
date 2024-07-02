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
    public partial class MmtrGameScreenMaori : Form
    {
        public MmtrGameScreenMaori()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Kbtn_Click(object sender, EventArgs e)
        {

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

        List<string> TeReoWords = new List<string>()
        {
            "Hui", "marae", "waiata", "haka", "maunga", "tamariki", "wahine", "whānau", "waka", "koha", "kaumātua", "tēnā koe", "kakī", "hapū", "Tapu"   

        };

    }
}
