namespace MauiMeTeRaApp
{
    partial class HwToPlyScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HwToPlyScreen));
            LblTtl = new Label();
            HwtoPlyLbl = new Label();
            MaoriDisgnPic2 = new PictureBox();
            pictureBox1 = new PictureBox();
            HwToPlyTxt = new Label();
            ExitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)MaoriDisgnPic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblTtl
            // 
            LblTtl.AutoSize = true;
            LblTtl.BackColor = Color.FromArgb(237, 153, 45);
            LblTtl.Font = new Font("Gill Sans Ultra Bold", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LblTtl.Location = new Point(267, 9);
            LblTtl.Name = "LblTtl";
            LblTtl.Size = new Size(738, 170);
            LblTtl.TabIndex = 2;
            LblTtl.Text = "MAUI ME TE RA \r\n(Maui and the sun)";
            LblTtl.TextAlign = ContentAlignment.BottomCenter;
            // 
            // HwtoPlyLbl
            // 
            HwtoPlyLbl.AutoSize = true;
            HwtoPlyLbl.Font = new Font("Gill Sans Ultra Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HwtoPlyLbl.Location = new Point(392, 167);
            HwtoPlyLbl.Name = "HwtoPlyLbl";
            HwtoPlyLbl.Size = new Size(499, 85);
            HwtoPlyLbl.TabIndex = 3;
            HwtoPlyLbl.Text = "How to Play:";
            // 
            // MaoriDisgnPic2
            // 
            MaoriDisgnPic2.Image = (Image)resources.GetObject("MaoriDisgnPic2.Image");
            MaoriDisgnPic2.Location = new Point(897, -1);
            MaoriDisgnPic2.Name = "MaoriDisgnPic2";
            MaoriDisgnPic2.Size = new Size(499, 961);
            MaoriDisgnPic2.TabIndex = 4;
            MaoriDisgnPic2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-133, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 952);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // HwToPlyTxt
            // 
            HwToPlyTxt.AutoSize = true;
            HwToPlyTxt.Location = new Point(317, 232);
            HwToPlyTxt.Name = "HwToPlyTxt";
            HwToPlyTxt.Size = new Size(688, 680);
            HwToPlyTxt.TabIndex = 6;
            HwToPlyTxt.Text = resources.GetString("HwToPlyTxt.Text");
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(843, 864);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(215, 96);
            ExitBtn.TabIndex = 36;
            ExitBtn.Text = "Exit back\r\nto game\r\n";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // HwToPlyScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 153, 45);
            ClientSize = new Size(1262, 953);
            Controls.Add(ExitBtn);
            Controls.Add(HwToPlyTxt);
            Controls.Add(HwtoPlyLbl);
            Controls.Add(LblTtl);
            Controls.Add(MaoriDisgnPic2);
            Controls.Add(pictureBox1);
            Name = "HwToPlyScreen";
            Text = "HwToPlyScreen";
            ((System.ComponentModel.ISupportInitialize)MaoriDisgnPic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTtl;
        private Label HwtoPlyLbl;
        private PictureBox MaoriDisgnPic2;
        private PictureBox pictureBox1;
        private Label HwToPlyTxt;
        private Button ExitBtn;
    }
}