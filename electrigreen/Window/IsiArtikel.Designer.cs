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
            ISIANARTIKEL.Location = new Point(117, 48);
            ISIANARTIKEL.Name = "ISIANARTIKEL";
            ISIANARTIKEL.Size = new Size(892, 596);
            ISIANARTIKEL.TabIndex = 0;
            ISIANARTIKEL.Text = "";
            // 
            // IsiArtikel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1129, 678);
            Controls.Add(ISIANARTIKEL);
            Name = "IsiArtikel";
            Text = "IsiArtikel";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox ISIANARTIKEL;
    }
}