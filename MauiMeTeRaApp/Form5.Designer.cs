namespace MauiMeTeRaApp
{
    partial class LngeScreen
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
            PikLngLbl = new Label();
            LblTtl = new Label();
            EngBtn = new Button();
            MaoriBtn = new Button();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // PikLngLbl
            // 
            PikLngLbl.AutoSize = true;
            PikLngLbl.Font = new Font("Gill Sans Ultra Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PikLngLbl.Location = new Point(374, 317);
            PikLngLbl.Name = "PikLngLbl";
            PikLngLbl.Size = new Size(520, 67);
            PikLngLbl.TabIndex = 0;
            PikLngLbl.Text = "Pick a Language:";
            // 
            // LblTtl
            // 
            LblTtl.AutoSize = true;
            LblTtl.BackColor = Color.FromArgb(237, 153, 45);
            LblTtl.Font = new Font("Gill Sans Ultra Bold", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LblTtl.Location = new Point(2, 0);
            LblTtl.Name = "LblTtl";
            LblTtl.Size = new Size(738, 170);
            LblTtl.TabIndex = 1;
            LblTtl.Text = "MAUI ME TE RA \r\n(Maui and the sun)";
            LblTtl.TextAlign = ContentAlignment.BottomCenter;
            // 
            // EngBtn
            // 
            EngBtn.Font = new Font("Gill Sans Ultra Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EngBtn.Location = new Point(21, 444);
            EngBtn.Name = "EngBtn";
            EngBtn.Size = new Size(500, 300);
            EngBtn.TabIndex = 2;
            EngBtn.Text = "English";
            EngBtn.UseVisualStyleBackColor = true;
            EngBtn.Click += EngBtn_Click;
            // 
            // MaoriBtn
            // 
            MaoriBtn.Font = new Font("Gill Sans Ultra Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaoriBtn.Location = new Point(739, 444);
            MaoriBtn.Name = "MaoriBtn";
            MaoriBtn.Size = new Size(500, 300);
            MaoriBtn.TabIndex = 3;
            MaoriBtn.Text = "Te Reo Maori";
            MaoriBtn.UseVisualStyleBackColor = true;
            MaoriBtn.Click += MaoriBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.IndianRed;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Location = new Point(1112, 907);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(150, 50);
            ExitBtn.TabIndex = 35;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // LngeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 153, 45);
            ClientSize = new Size(1262, 953);
            Controls.Add(ExitBtn);
            Controls.Add(MaoriBtn);
            Controls.Add(EngBtn);
            Controls.Add(LblTtl);
            Controls.Add(PikLngLbl);
            Name = "LngeScreen";
            Text = "LngeScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PikLngLbl;
        private Label LblTtl;
        private Button EngBtn;
        private Button MaoriBtn;
        private Button ExitBtn;
    }
}