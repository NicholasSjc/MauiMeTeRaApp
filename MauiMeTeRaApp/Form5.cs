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
            Form MmtrGameScreenEng = new MmtrGameScreenEng();
            MmtrGameScreenEng.Show();
            this.Hide();
        }

        private void MaoriBtn_Click(object sender, EventArgs e)
        {
            Form MMmtrGameScreenMaori = new MmtrGameScreenMaori();
            MMmtrGameScreenMaori.Show();
            this.Hide();
        }
    }
}
