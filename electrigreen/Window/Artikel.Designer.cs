namespace electrigreen.Window
{
    partial class Artikel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Artikel));
            TITLE = new Label();
            GambarArtikel1 = new PictureBox();
            GambarArtikel3 = new PictureBox();
            GambarArtikel4 = new PictureBox();
            GambarArtikel2 = new PictureBox();
            Back_Menu = new Button();
            ARTIKEL1 = new Button();
            ARTIKEL3 = new Button();
            ARTIKEL4 = new Button();
            ARTIKEL2 = new Button();
            ((System.ComponentModel.ISupportInitialize)GambarArtikel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GambarArtikel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GambarArtikel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GambarArtikel2).BeginInit();
            SuspendLayout();
            // 
            // TITLE
            // 
            TITLE.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TITLE.BackColor = SystemColors.ButtonFace;
            TITLE.Font = new Font("Stencil", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TITLE.Location = new Point(715, 84);
            TITLE.Name = "TITLE";
            TITLE.Size = new Size(249, 72);
            TITLE.TabIndex = 4;
            TITLE.Text = "ARTIKEL";
            TITLE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GambarArtikel1
            // 
            GambarArtikel1.Image = (Image)resources.GetObject("GambarArtikel1.Image");
            GambarArtikel1.Location = new Point(252, 197);
            GambarArtikel1.Name = "GambarArtikel1";
            GambarArtikel1.Size = new Size(406, 225);
            GambarArtikel1.SizeMode = PictureBoxSizeMode.StretchImage;
            GambarArtikel1.TabIndex = 6;
            GambarArtikel1.TabStop = false;
            // 
            // GambarArtikel3
            // 
            GambarArtikel3.Image = (Image)resources.GetObject("GambarArtikel3.Image");
            GambarArtikel3.Location = new Point(252, 510);
            GambarArtikel3.Name = "GambarArtikel3";
            GambarArtikel3.Size = new Size(406, 225);
            GambarArtikel3.SizeMode = PictureBoxSizeMode.StretchImage;
            GambarArtikel3.TabIndex = 7;
            GambarArtikel3.TabStop = false;
            // 
            // GambarArtikel4
            // 
            GambarArtikel4.Image = (Image)resources.GetObject("GambarArtikel4.Image");
            GambarArtikel4.Location = new Point(999, 510);
            GambarArtikel4.Name = "GambarArtikel4";
            GambarArtikel4.Size = new Size(406, 225);
            GambarArtikel4.SizeMode = PictureBoxSizeMode.StretchImage;
            GambarArtikel4.TabIndex = 8;
            GambarArtikel4.TabStop = false;
            // 
            // GambarArtikel2
            // 
            GambarArtikel2.Image = (Image)resources.GetObject("GambarArtikel2.Image");
            GambarArtikel2.Location = new Point(999, 197);
            GambarArtikel2.Name = "GambarArtikel2";
            GambarArtikel2.Size = new Size(406, 225);
            GambarArtikel2.SizeMode = PictureBoxSizeMode.StretchImage;
            GambarArtikel2.TabIndex = 9;
            GambarArtikel2.TabStop = false;
            // 
            // Back_Menu
            // 
            Back_Menu.BackColor = SystemColors.ControlDarkDark;
            Back_Menu.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Back_Menu.Location = new Point(755, 766);
            Back_Menu.Name = "Back_Menu";
            Back_Menu.Size = new Size(179, 34);
            Back_Menu.TabIndex = 10;
            Back_Menu.Text = "BACK";
            Back_Menu.UseVisualStyleBackColor = false;
            Back_Menu.Click += Back_Menu_Click;
            // 
            // ARTIKEL1
            // 
            ARTIKEL1.BackColor = SystemColors.InactiveCaption;
            ARTIKEL1.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ARTIKEL1.Location = new Point(297, 428);
            ARTIKEL1.Name = "ARTIKEL1";
            ARTIKEL1.Size = new Size(314, 48);
            ARTIKEL1.TabIndex = 11;
            ARTIKEL1.Text = "Kekurangan Smart Home?";
            ARTIKEL1.UseVisualStyleBackColor = false;
            ARTIKEL1.Click += ARTIKEL1_Click;
            // 
            // ARTIKEL3
            // 
            ARTIKEL3.BackColor = SystemColors.InactiveCaption;
            ARTIKEL3.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ARTIKEL3.Location = new Point(297, 741);
            ARTIKEL3.Name = "ARTIKEL3";
            ARTIKEL3.Size = new Size(314, 48);
            ARTIKEL3.TabIndex = 13;
            ARTIKEL3.Text = "Smart Home Rumah Impian";
            ARTIKEL3.UseVisualStyleBackColor = false;
            ARTIKEL3.Click += ARTIKEL3_Click;
            // 
            // ARTIKEL4
            // 
            ARTIKEL4.BackColor = SystemColors.InactiveCaption;
            ARTIKEL4.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ARTIKEL4.Location = new Point(1074, 741);
            ARTIKEL4.Name = "ARTIKEL4";
            ARTIKEL4.Size = new Size(264, 48);
            ARTIKEL4.TabIndex = 14;
            ARTIKEL4.Text = "Home Smart Home";
            ARTIKEL4.UseVisualStyleBackColor = false;
            ARTIKEL4.Click += ARTIKEL4_Click;
            // 
            // ARTIKEL2
            // 
            ARTIKEL2.BackColor = SystemColors.InactiveCaption;
            ARTIKEL2.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ARTIKEL2.Location = new Point(1074, 428);
            ARTIKEL2.Name = "ARTIKEL2";
            ARTIKEL2.Size = new Size(264, 48);
            ARTIKEL2.TabIndex = 12;
            ARTIKEL2.Text = "Mengenal Smart Home";
            ARTIKEL2.UseVisualStyleBackColor = false;
            ARTIKEL2.Click += ARTIKEL2_Click;
            // 
            // Artikel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1737, 823);
            Controls.Add(ARTIKEL4);
            Controls.Add(ARTIKEL3);
            Controls.Add(ARTIKEL2);
            Controls.Add(ARTIKEL1);
            Controls.Add(Back_Menu);
            Controls.Add(GambarArtikel2);
            Controls.Add(GambarArtikel4);
            Controls.Add(GambarArtikel3);
            Controls.Add(GambarArtikel1);
            Controls.Add(TITLE);
            Name = "Artikel";
            Text = "Artikel";
            ((System.ComponentModel.ISupportInitialize)GambarArtikel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GambarArtikel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)GambarArtikel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)GambarArtikel2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label TITLE;
        private PictureBox GambarArtikel1;
        private PictureBox GambarArtikel3;
        private PictureBox GambarArtikel4;
        private PictureBox GambarArtikel2;
        private Button Back_Menu;
        private Button ARTIKEL1;
        private Button ARTIKEL3;
        private Button ARTIKEL4;
        private Button ARTIKEL2;
    }
}