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
    public partial class LngeScreen : Form
    {
        public LngeScreen()
        {
            InitializeComponent();
        }

        private void EngBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MmtrGameScreenEng = new MmtrGameScreenEng();
            MmtrGameScreenEng.Closed += (s, args) => this.Close();
            MmtrGameScreenEng.Show();
        }

        private void MaoriBtn_Click(object sender, EventArgs e)
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
    }
}
