namespace MauiMeTeRaApp
{
    public partial class MmtrTitleScreen : Form
    {
        public MmtrTitleScreen()
        {
            InitializeComponent();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form LngeScreen = new LngeScreen();
            LngeScreen.Closed += (s, args) => this.Close();
            LngeScreen.Show();
        }

        private void HwtPlyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form HwToPlyScreen = new HwToPlyScreen();
            HwToPlyScreen.Closed += (s, args) => this.Close();
            HwToPlyScreen.Show();
        }
    }
}
