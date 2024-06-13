namespace electrigreen.Window
{
    partial class TargetForm
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
            checkedListBox1 = new CheckedListBox();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            panelElectrigreen1 = new ComponentControls.PanelElectrigreen();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            panelElectrigreen1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(877, 86);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(240, 328);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(192, 255, 192);
            progressBar1.Location = new Point(24, 55);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(394, 23);
            progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(24, 0);
            label2.Name = "label2";
            label2.Size = new Size(249, 32);
            label2.TabIndex = 4;
            label2.Text = "Progres Target Hari Ini";
            // 
            // panelElectrigreen1
            // 
            panelElectrigreen1.BackColor = Color.White;
            panelElectrigreen1.BorderColor = Color.FromArgb(230, 230, 230);
            panelElectrigreen1.BorderRadius = 1;
            panelElectrigreen1.BorderWidth = 2F;
            panelElectrigreen1.Controls.Add(label2);
            panelElectrigreen1.Controls.Add(progressBar1);
            panelElectrigreen1.ForeColor = SystemColors.ControlText;
            panelElectrigreen1.GradientAngle = 45F;
            panelElectrigreen1.GradientBottomColor = Color.White;
            panelElectrigreen1.GradientTopColor = Color.White;
            panelElectrigreen1.Location = new Point(117, 86);
            panelElectrigreen1.Name = "panelElectrigreen1";
            panelElectrigreen1.Size = new Size(444, 98);
            panelElectrigreen1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.rankBronze;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(228, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 238);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 202);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 7;
            label1.Text = "My Rank";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 399);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // TargetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1231, 527);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panelElectrigreen1);
            Controls.Add(checkedListBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TargetForm";
            Text = "TargetForm";
            panelElectrigreen1.ResumeLayout(false);
            panelElectrigreen1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private ProgressBar progressBar1;
        private Label label2;
        private ComponentControls.PanelElectrigreen panelElectrigreen1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
    }
}