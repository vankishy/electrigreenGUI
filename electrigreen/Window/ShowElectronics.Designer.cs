namespace electrigreen.Window
{
    partial class ShowElectronics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxElectronics;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelMerk;
        private System.Windows.Forms.Label labelVoltase;
        private System.Windows.Forms.Label labelJenis;
        private System.Windows.Forms.Label labelIsSmarthome;
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
            listBoxElectronics = new ListBox();
            labelNama = new Label();
            labelMerk = new Label();
            labelVoltase = new Label();
            labelJenis = new Label();
            labelIsSmarthome = new Label();
            buttonAddElectronicsPage = new Button();
            SuspendLayout();
            // 
            // listBoxElectronics
            // 
            listBoxElectronics.FormattingEnabled = true;
            listBoxElectronics.ItemHeight = 25;
            listBoxElectronics.Location = new Point(15, 19);
            listBoxElectronics.Margin = new Padding(4, 5, 4, 5);
            listBoxElectronics.Name = "listBoxElectronics";
            listBoxElectronics.Size = new Size(450, 604);
            listBoxElectronics.TabIndex = 0;
            listBoxElectronics.SelectedIndexChanged += listBoxElectronics_SelectedIndexChanged;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(503, 19);
            labelNama.Margin = new Padding(4, 0, 4, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(63, 25);
            labelNama.TabIndex = 1;
            labelNama.Text = "Nama:";
            // 
            // labelMerk
            // 
            labelMerk.AutoSize = true;
            labelMerk.Location = new Point(503, 66);
            labelMerk.Margin = new Padding(4, 0, 4, 0);
            labelMerk.Name = "labelMerk";
            labelMerk.Size = new Size(56, 25);
            labelMerk.TabIndex = 2;
            labelMerk.Text = "Merk:";
            // 
            // labelVoltase
            // 
            labelVoltase.AutoSize = true;
            labelVoltase.Location = new Point(503, 112);
            labelVoltase.Margin = new Padding(4, 0, 4, 0);
            labelVoltase.Name = "labelVoltase";
            labelVoltase.Size = new Size(73, 25);
            labelVoltase.TabIndex = 3;
            labelVoltase.Text = "Voltase:";
            // 
            // labelJenis
            // 
            labelJenis.AutoSize = true;
            labelJenis.Location = new Point(503, 159);
            labelJenis.Margin = new Padding(4, 0, 4, 0);
            labelJenis.Name = "labelJenis";
            labelJenis.Size = new Size(53, 25);
            labelJenis.TabIndex = 4;
            labelJenis.Text = "Jenis:";
            // 
            // labelIsSmarthome
            // 
            labelIsSmarthome.AutoSize = true;
            labelIsSmarthome.Location = new Point(503, 206);
            labelIsSmarthome.Margin = new Padding(4, 0, 4, 0);
            labelIsSmarthome.Name = "labelIsSmarthome";
            labelIsSmarthome.Size = new Size(109, 25);
            labelIsSmarthome.TabIndex = 5;
            labelIsSmarthome.Text = "Smarthome:";
            // 
            // buttonAddElectronicsPage
            // 
            buttonAddElectronicsPage.Location = new Point(511, 267);
            buttonAddElectronicsPage.Name = "buttonAddElectronicsPage";
            buttonAddElectronicsPage.Size = new Size(147, 34);
            buttonAddElectronicsPage.TabIndex = 6;
            buttonAddElectronicsPage.Text = "Add Electronics";
            buttonAddElectronicsPage.UseVisualStyleBackColor = true;
            buttonAddElectronicsPage.Click += buttonAddElectronicsPage_Click;
            // 
            // ShowElectronics
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 638);
            Controls.Add(buttonAddElectronicsPage);
            Controls.Add(labelIsSmarthome);
            Controls.Add(labelJenis);
            Controls.Add(labelVoltase);
            Controls.Add(labelMerk);
            Controls.Add(labelNama);
            Controls.Add(listBoxElectronics);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ShowElectronics";
            Text = "ShowElectronics";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonAddElectronicsPage;
    }
    #endregion
}
