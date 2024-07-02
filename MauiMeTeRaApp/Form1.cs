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
            Form LngeScreen = new LngeScreen();
            LngeScreen.Show();
            this.Hide();
        }

        private void HwtPlyBtn_Click(object sender, EventArgs e)
        {
            Form HwToPlyScreen = new HwToPlyScreen();
            HwToPlyScreen.Show();
            this.Hide();
        }
    }
}
