namespace MauiMeTeRaApp
{
    partial class MmtrTitleScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MmtrTitleScreen));
            LblTtl = new Label();
            richTextBox1 = new RichTextBox();
            PlayBtn = new Button();
            SunPic = new PictureBox();
            MauiBoysPic = new PictureBox();
            HwtPlyBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)SunPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MauiBoysPic).BeginInit();
            SuspendLayout();
            // 
            // LblTtl
            // 
            LblTtl.AutoSize = true;
            LblTtl.BackColor = Color.FromArgb(237, 153, 45);
            LblTtl.Font = new Font("Gill Sans Ultra Bold", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LblTtl.Location = new Point(174, 91);
            LblTtl.Name = "LblTtl";
            LblTtl.Size = new Size(984, 228);
            LblTtl.TabIndex = 0;
            LblTtl.Text = "MAUI ME TE RA \r\n(Maui and the sun)";
            LblTtl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 217);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(0, 0);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // PlayBtn
            // 
            PlayBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PlayBtn.BackColor = Color.FromArgb(237, 153, 45);
            PlayBtn.FlatStyle = FlatStyle.Flat;
            PlayBtn.Font = new Font("Gill Sans Ultra Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayBtn.Location = new Point(396, 349);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new Size(440, 266);
            PlayBtn.TabIndex = 2;
            PlayBtn.Text = "Press to play";
            PlayBtn.UseVisualStyleBackColor = false;
            PlayBtn.Click += PlayBtn_Click;
            // 
            // SunPic
            // 
            SunPic.AccessibleRole = AccessibleRole.None;
            SunPic.Image = (Image)resources.GetObject("SunPic.Image");
            SunPic.Location = new Point(905, 515);
            SunPic.Name = "SunPic";
            SunPic.Size = new Size(312, 236);
            SunPic.TabIndex = 3;
            SunPic.TabStop = false;
            // 
            // MauiBoysPic
            // 
            MauiBoysPic.AccessibleRole = AccessibleRole.None;
            MauiBoysPic.Image = (Image)resources.GetObject("MauiBoysPic.Image");
            MauiBoysPic.Location = new Point(47, 541);
            MauiBoysPic.Name = "MauiBoysPic";
            MauiBoysPic.Size = new Size(242, 210);
            MauiBoysPic.TabIndex = 4;
            MauiBoysPic.TabStop = false;
            // 
            // HwtPlyBtn
            // 
            HwtPlyBtn.BackColor = Color.FromArgb(237, 153, 45);
            HwtPlyBtn.FlatStyle = FlatStyle.Flat;
            HwtPlyBtn.Font = new Font("Gill Sans Ultra Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HwtPlyBtn.Location = new Point(404, 718);
            HwtPlyBtn.Name = "HwtPlyBtn";
            HwtPlyBtn.Size = new Size(416, 192);
            HwtPlyBtn.TabIndex = 5;
            HwtPlyBtn.Text = "How To Play";
            HwtPlyBtn.UseVisualStyleBackColor = false;
            HwtPlyBtn.Click += HwtPlyBtn_Click;
            // 
            // MmtrTitleScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 153, 45);
            ClientSize = new Size(1262, 953);
            Controls.Add(HwtPlyBtn);
            Controls.Add(MauiBoysPic);
            Controls.Add(SunPic);
            Controls.Add(PlayBtn);
            Controls.Add(richTextBox1);
            Controls.Add(LblTtl);
            Name = "MmtrTitleScreen";
            Text = "MmtrTitleScreen";
            ((System.ComponentModel.ISupportInitialize)SunPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)MauiBoysPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTtl;
        private RichTextBox richTextBox1;
        private Button PlayBtn;
        private PictureBox SunPic;
        private PictureBox MauiBoysPic;
        private Button HwtPlyBtn;
    }
}
