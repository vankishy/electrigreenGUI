namespace electrigreen.Window
{
    partial class IsiArtikel
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
            ISIANARTIKEL = new RichTextBox();
            SuspendLayout();
            // 
            // ISIANARTIKEL
            // 
            ISIANARTIKEL.Location = new Point(123, 47);
            ISIANARTIKEL.Margin = new Padding(2);
            ISIANARTIKEL.Name = "ISIANARTIKEL";
            ISIANARTIKEL.Size = new Size(1149, 583);
            ISIANARTIKEL.TabIndex = 0;
            ISIANARTIKEL.Text = "";
            ISIANARTIKEL.TextChanged += ISIANARTIKEL_TextChanged;
            // 
            // IsiArtikel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 143, 51);
            ClientSize = new Size(1389, 656);
            Controls.Add(ISIANARTIKEL);
            Margin = new Padding(2);
            Name = "IsiArtikel";
            Text = "IsiArtikel";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox ISIANARTIKEL;
    }
}