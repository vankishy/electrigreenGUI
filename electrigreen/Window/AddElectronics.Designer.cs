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
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            buttonAdd = new Button();
            label1 = new Label();
            NotifikasiBerhasil = new NotifyIcon(components);
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(535, 318);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(440, 39);
            textBox3.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 318);
            label5.Name = "label5";
            label5.Size = new Size(90, 32);
            label5.TabIndex = 19;
            label5.Text = "Voltase";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 393);
            label4.Name = "label4";
            label4.Size = new Size(66, 32);
            label4.TabIndex = 18;
            label4.Text = "Jenis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 240);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 17;
            label3.Text = "Merk";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Air Conditioner", "Handphone", "Kompor Listrik", "Lampu", "Laptop", "Pemanas Air", "Radio", "Rice Cooker", "Televisi" });
            comboBox1.Location = new Point(535, 385);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(440, 40);
            comboBox1.TabIndex = 16;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(535, 481);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 36);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Smarthome";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(535, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(440, 39);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(535, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 39);
            textBox1.TabIndex = 13;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(535, 574);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(286, 80);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(385, 163);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 11;
            label1.Text = "Nama";
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
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Name = "AddElectronics";
            Text = "AddElectronics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonAdd;
        private Label label1;
        private NotifyIcon NotifikasiBerhasil;
    }
}