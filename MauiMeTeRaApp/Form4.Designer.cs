namespace MauiMeTeRaApp
{
    partial class StryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StryScreen));
            MaoriDisgn1Pic = new PictureBox();
            MaoriDisgnPic2 = new PictureBox();
            HwMstsLbl = new Label();
            label1 = new Label();
            ExitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)MaoriDisgn1Pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaoriDisgnPic2).BeginInit();
            SuspendLayout();
            // 
            // MaoriDisgn1Pic
            // 
            MaoriDisgn1Pic.Image = (Image)resources.GetObject("MaoriDisgn1Pic.Image");
            MaoriDisgn1Pic.Location = new Point(-150, 0);
            MaoriDisgn1Pic.Name = "MaoriDisgn1Pic";
            MaoriDisgn1Pic.Size = new Size(434, 952);
            MaoriDisgn1Pic.TabIndex = 0;
            MaoriDisgn1Pic.TabStop = false;
            // 
            // MaoriDisgnPic2
            // 
            MaoriDisgnPic2.Image = (Image)resources.GetObject("MaoriDisgnPic2.Image");
            MaoriDisgnPic2.Location = new Point(913, 0);
            MaoriDisgnPic2.Name = "MaoriDisgnPic2";
            MaoriDisgnPic2.Size = new Size(499, 952);
            MaoriDisgnPic2.TabIndex = 1;
            MaoriDisgnPic2.TabStop = false;
            // 
            // HwMstsLbl
            // 
            HwMstsLbl.AutoSize = true;
            HwMstsLbl.Font = new Font("Gill Sans Ultra Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HwMstsLbl.Location = new Point(290, 9);
            HwMstsLbl.Name = "HwMstsLbl";
            HwMstsLbl.Size = new Size(602, 170);
            HwMstsLbl.TabIndex = 2;
            HwMstsLbl.Text = "How Maui\r\nSlowed the Sun\r\n";
            HwMstsLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 169);
            label1.Name = "label1";
            label1.Size = new Size(782, 800);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(857, 856);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(215, 96);
            ExitBtn.TabIndex = 35;
            ExitBtn.Text = "Exit back\r\nto game\r\n";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // StryScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 153, 45);
            ClientSize = new Size(1262, 953);
            Controls.Add(ExitBtn);
            Controls.Add(label1);
            Controls.Add(HwMstsLbl);
            Controls.Add(MaoriDisgnPic2);
            Controls.Add(MaoriDisgn1Pic);
            Name = "StryScreen";
            Text = "StryScreen";
            ((System.ComponentModel.ISupportInitialize)MaoriDisgn1Pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaoriDisgnPic2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MaoriDisgn1Pic;
        private PictureBox MaoriDisgnPic2;
        private Label HwMstsLbl;
        private Label label1;
        private Button ExitBtn;
    }
}