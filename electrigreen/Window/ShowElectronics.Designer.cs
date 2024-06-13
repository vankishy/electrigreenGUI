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
            addElectronicsPageButton = new ComponentControls.AuthButton();
            SuspendLayout();
            // 
            // listBoxElectronics
            // 
            listBoxElectronics.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxElectronics.FormattingEnabled = true;
            listBoxElectronics.ItemHeight = 28;
            listBoxElectronics.Location = new Point(62, 49);
            listBoxElectronics.Margin = new Padding(4, 5, 4, 5);
            listBoxElectronics.Name = "listBoxElectronics";
            listBoxElectronics.Size = new Size(589, 760);
            listBoxElectronics.TabIndex = 0;
            listBoxElectronics.SelectedIndexChanged += listBoxElectronics_SelectedIndexChanged;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Font = new Font("Segoe UI", 12F);
            labelNama.Location = new Point(724, 49);
            labelNama.Margin = new Padding(4, 0, 4, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(82, 32);
            labelNama.TabIndex = 1;
            labelNama.Text = "Nama:";
            // 
            // labelMerk
            // 
            labelMerk.AutoSize = true;
            labelMerk.Font = new Font("Segoe UI", 12F);
            labelMerk.Location = new Point(724, 103);
            labelMerk.Margin = new Padding(4, 0, 4, 0);
            labelMerk.Name = "labelMerk";
            labelMerk.Size = new Size(74, 32);
            labelMerk.TabIndex = 2;
            labelMerk.Text = "Merk:";
            // 
            // labelVoltase
            // 
            labelVoltase.AutoSize = true;
            labelVoltase.Font = new Font("Segoe UI", 12F);
            labelVoltase.Location = new Point(724, 156);
            labelVoltase.Margin = new Padding(4, 0, 4, 0);
            labelVoltase.Name = "labelVoltase";
            labelVoltase.Size = new Size(95, 32);
            labelVoltase.TabIndex = 3;
            labelVoltase.Text = "Voltase:";
            // 
            // labelJenis
            // 
            labelJenis.AutoSize = true;
            labelJenis.Font = new Font("Segoe UI", 12F);
            labelJenis.Location = new Point(724, 211);
            labelJenis.Margin = new Padding(4, 0, 4, 0);
            labelJenis.Name = "labelJenis";
            labelJenis.Size = new Size(71, 32);
            labelJenis.TabIndex = 4;
            labelJenis.Text = "Jenis:";
            // 
            // labelIsSmarthome
            // 
            labelIsSmarthome.AutoSize = true;
            labelIsSmarthome.Font = new Font("Segoe UI", 12F);
            labelIsSmarthome.Location = new Point(724, 264);
            labelIsSmarthome.Margin = new Padding(4, 0, 4, 0);
            labelIsSmarthome.Name = "labelIsSmarthome";
            labelIsSmarthome.Size = new Size(143, 32);
            labelIsSmarthome.TabIndex = 5;
            labelIsSmarthome.Text = "Smarthome:";
            // 
            // addElectronicsPageButton
            // 
            addElectronicsPageButton.BackColor = Color.FromArgb(114, 199, 72);
            addElectronicsPageButton.FlatAppearance.BorderSize = 0;
            addElectronicsPageButton.FlatStyle = FlatStyle.Flat;
            addElectronicsPageButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addElectronicsPageButton.ForeColor = Color.White;
            addElectronicsPageButton.Location = new Point(1414, 743);
            addElectronicsPageButton.Name = "addElectronicsPageButton";
            addElectronicsPageButton.Size = new Size(225, 60);
            addElectronicsPageButton.TabIndex = 7;
            addElectronicsPageButton.Text = "Add Electronics";
            addElectronicsPageButton.UseVisualStyleBackColor = false;
            addElectronicsPageButton.Click += addElectronicsPageButton_Click;
            // 
            // ShowElectronics
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1759, 879);
            Controls.Add(addElectronicsPageButton);
            Controls.Add(labelIsSmarthome);
            Controls.Add(labelJenis);
            Controls.Add(labelVoltase);
            Controls.Add(labelMerk);
            Controls.Add(labelNama);
            Controls.Add(listBoxElectronics);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ShowElectronics";
            Text = "ShowElectronics";
            ResumeLayout(false);
            PerformLayout();
        }

        private ComponentControls.AuthButton addElectronicsPageButton;
    }
    #endregion
}
