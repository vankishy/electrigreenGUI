﻿namespace electrigreen.Window
{
    partial class ArtikelForm
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 262);
            label1.Name = "label1";
            label1.Size = new Size(439, 106);
            label1.TabIndex = 0;
            label1.Text = "Tes Artikel";
            // 
            // ArtikelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1407, 703);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ArtikelForm";
            Text = "Artikel_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}