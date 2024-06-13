namespace electrigreen.Window
{
    partial class AddElectronics
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
            components = new System.ComponentModel.Container();
            textBoxVoltase = new TextBox();
            labelVoltase = new Label();
            labelJenis = new Label();
            labelMerk = new Label();
            comboBoxJenisPerangkat = new ComboBox();
            checkBoxIsSmarthome = new CheckBox();
            textBoxMerk = new TextBox();
            textBoxNama = new TextBox();
            buttonAdd = new Button();
            labelNama = new Label();
            NotifikasiBerhasil = new NotifyIcon(components);
            SuspendLayout();
            // 
            // textBoxVoltase
            // 
            textBoxVoltase.Location = new Point(536, 317);
            textBoxVoltase.Name = "textBoxVoltase";
            textBoxVoltase.Size = new Size(439, 39);
            textBoxVoltase.TabIndex = 20;
            // 
            // labelVoltase
            // 
            labelVoltase.AutoSize = true;
            labelVoltase.Location = new Point(385, 317);
            labelVoltase.Name = "labelVoltase";
            labelVoltase.Size = new Size(90, 32);
            labelVoltase.TabIndex = 19;
            labelVoltase.Text = "Voltase";
            // 
            // labelJenis
            // 
            labelJenis.AutoSize = true;
            labelJenis.Location = new Point(385, 393);
            labelJenis.Name = "labelJenis";
            labelJenis.Size = new Size(66, 32);
            labelJenis.TabIndex = 18;
            labelJenis.Text = "Jenis";
            // 
            // labelMerk
            // 
            labelMerk.AutoSize = true;
            labelMerk.Location = new Point(385, 241);
            labelMerk.Name = "labelMerk";
            labelMerk.Size = new Size(69, 32);
            labelMerk.TabIndex = 17;
            labelMerk.Text = "Merk";
            // 
            // comboBoxJenisPerangkat
            // 
            comboBoxJenisPerangkat.FormattingEnabled = true;
            comboBoxJenisPerangkat.Items.AddRange(new object[] { "Air Conditioner", "Handphone", "Kompor Listrik", "Lampu", "Laptop", "Pemanas Air", "Radio", "Rice Cooker", "Televisi" });
            comboBoxJenisPerangkat.Location = new Point(536, 385);
            comboBoxJenisPerangkat.Name = "comboBoxJenisPerangkat";
            comboBoxJenisPerangkat.Size = new Size(439, 40);
            comboBoxJenisPerangkat.TabIndex = 16;
            // 
            // checkBoxIsSmarthome
            // 
            checkBoxIsSmarthome.AutoSize = true;
            checkBoxIsSmarthome.Location = new Point(536, 481);
            checkBoxIsSmarthome.Name = "checkBoxIsSmarthome";
            checkBoxIsSmarthome.Size = new Size(170, 36);
            checkBoxIsSmarthome.TabIndex = 15;
            checkBoxIsSmarthome.Text = "Smarthome";
            checkBoxIsSmarthome.UseVisualStyleBackColor = true;
            // 
            // textBoxMerk
            // 
            textBoxMerk.Location = new Point(536, 233);
            textBoxMerk.Name = "textBoxMerk";
            textBoxMerk.Size = new Size(439, 39);
            textBoxMerk.TabIndex = 14;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(536, 163);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(439, 39);
            textBoxNama.TabIndex = 13;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(536, 573);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(286, 79);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = SystemColors.Control;
            labelNama.Location = new Point(385, 163);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(77, 32);
            labelNama.TabIndex = 11;
            labelNama.Text = "Nama";
            // 
            // NotifikasiBerhasil
            // 
            NotifikasiBerhasil.Text = "notifyIcon1";
            NotifikasiBerhasil.Visible = true;
            // 
            // AddElectronics
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 817);
            Controls.Add(textBoxVoltase);
            Controls.Add(labelVoltase);
            Controls.Add(labelJenis);
            Controls.Add(labelMerk);
            Controls.Add(comboBoxJenisPerangkat);
            Controls.Add(checkBoxIsSmarthome);
            Controls.Add(textBoxMerk);
            Controls.Add(textBoxNama);
            Controls.Add(buttonAdd);
            Controls.Add(labelNama);
            Name = "AddElectronics";
            Text = "AddElectronics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxVoltase;
        private Label labelVoltase;
        private Label labelJenis;
        private Label labelMerk;
        private ComboBox comboBoxJenisPerangkat;
        private CheckBox checkBoxIsSmarthome;
        private TextBox textBoxMerk;
        private TextBox textBoxNama;
        private Button buttonAdd;
        private Label labelNama;
        private NotifyIcon NotifikasiBerhasil;
    }
}