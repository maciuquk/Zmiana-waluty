namespace Zmiana_waluty_V1._0
{
    partial class ZmianaWaluty
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
            this.ZamienBox = new System.Windows.Forms.TextBox();
            this.ZamienButton = new System.Windows.Forms.Button();
            this.radioButtonZeuro = new System.Windows.Forms.RadioButton();
            this.radioButtonZdolar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonZgbp = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonZrub = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dataKursowLabel = new System.Windows.Forms.Label();
            this.zaktualizujKursButton = new System.Windows.Forms.Button();
            this.aktualneKursyLabel = new System.Windows.Forms.Label();
            this.kursyWalutTrescLabel = new System.Windows.Forms.Label();
            this.dataKursuPicker = new System.Windows.Forms.DateTimePicker();
            this.aktualizacjaKursuWgDaty = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZamienBox
            // 
            this.ZamienBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZamienBox.Location = new System.Drawing.Point(15, 30);
            this.ZamienBox.Name = "ZamienBox";
            this.ZamienBox.Size = new System.Drawing.Size(241, 62);
            this.ZamienBox.TabIndex = 1;
            // 
            // ZamienButton
            // 
            this.ZamienButton.Location = new System.Drawing.Point(276, 30);
            this.ZamienButton.Name = "ZamienButton";
            this.ZamienButton.Size = new System.Drawing.Size(111, 62);
            this.ZamienButton.TabIndex = 2;
            this.ZamienButton.Text = "Zamień walutę";
            this.ZamienButton.UseVisualStyleBackColor = true;
            this.ZamienButton.Click += new System.EventHandler(this.ZamienButton_Click);
            // 
            // radioButtonZeuro
            // 
            this.radioButtonZeuro.AutoSize = true;
            this.radioButtonZeuro.Checked = true;
            this.radioButtonZeuro.Location = new System.Drawing.Point(49, 55);
            this.radioButtonZeuro.Name = "radioButtonZeuro";
            this.radioButtonZeuro.Size = new System.Drawing.Size(31, 17);
            this.radioButtonZeuro.TabIndex = 3;
            this.radioButtonZeuro.TabStop = true;
            this.radioButtonZeuro.Text = "€";
            this.radioButtonZeuro.UseVisualStyleBackColor = true;
            this.radioButtonZeuro.CheckedChanged += new System.EventHandler(this.radioButtonZeuro_CheckedChanged);
            // 
            // radioButtonZdolar
            // 
            this.radioButtonZdolar.AutoSize = true;
            this.radioButtonZdolar.Location = new System.Drawing.Point(49, 78);
            this.radioButtonZdolar.Name = "radioButtonZdolar";
            this.radioButtonZdolar.Size = new System.Drawing.Size(31, 17);
            this.radioButtonZdolar.TabIndex = 4;
            this.radioButtonZdolar.Text = "$";
            this.radioButtonZdolar.UseVisualStyleBackColor = true;
            this.radioButtonZdolar.Click += new System.EventHandler(this.radioButtonZdolar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj kwotę do zamiany";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "0,00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "zł";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jaka waluta:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioButtonZgbp
            // 
            this.radioButtonZgbp.AutoSize = true;
            this.radioButtonZgbp.Location = new System.Drawing.Point(49, 101);
            this.radioButtonZgbp.Name = "radioButtonZgbp";
            this.radioButtonZgbp.Size = new System.Drawing.Size(47, 17);
            this.radioButtonZgbp.TabIndex = 4;
            this.radioButtonZgbp.Text = "GBP";
            this.radioButtonZgbp.UseVisualStyleBackColor = true;
            this.radioButtonZgbp.CheckedChanged += new System.EventHandler(this.radioButtonZgbp_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonZrub);
            this.panel1.Controls.Add(this.radioButtonZeuro);
            this.panel1.Controls.Add(this.radioButtonZdolar);
            this.panel1.Controls.Add(this.radioButtonZgbp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(650, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 154);
            this.panel1.TabIndex = 6;
            // 
            // radioButtonZrub
            // 
            this.radioButtonZrub.AutoSize = true;
            this.radioButtonZrub.Location = new System.Drawing.Point(49, 124);
            this.radioButtonZrub.Name = "radioButtonZrub";
            this.radioButtonZrub.Size = new System.Drawing.Size(48, 17);
            this.radioButtonZrub.TabIndex = 6;
            this.radioButtonZrub.Text = "RUB";
            this.radioButtonZrub.UseVisualStyleBackColor = true;
            this.radioButtonZrub.CheckedChanged += new System.EventHandler(this.radioButtonZrub_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(185, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data pobranego kursu waluty";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataKursowLabel
            // 
            this.dataKursowLabel.AutoSize = true;
            this.dataKursowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataKursowLabel.Location = new System.Drawing.Point(194, 368);
            this.dataKursowLabel.Name = "dataKursowLabel";
            this.dataKursowLabel.Size = new System.Drawing.Size(0, 55);
            this.dataKursowLabel.TabIndex = 5;
            this.dataKursowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dataKursowLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // zaktualizujKursButton
            // 
            this.zaktualizujKursButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.zaktualizujKursButton.Location = new System.Drawing.Point(394, 30);
            this.zaktualizujKursButton.Name = "zaktualizujKursButton";
            this.zaktualizujKursButton.Size = new System.Drawing.Size(89, 62);
            this.zaktualizujKursButton.TabIndex = 9;
            this.zaktualizujKursButton.Text = "Aktualizacja kursu wg ostatniej tabeli";
            this.zaktualizujKursButton.UseVisualStyleBackColor = false;
            this.zaktualizujKursButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // aktualneKursyLabel
            // 
            this.aktualneKursyLabel.AutoSize = true;
            this.aktualneKursyLabel.Location = new System.Drawing.Point(15, 351);
            this.aktualneKursyLabel.Name = "aktualneKursyLabel";
            this.aktualneKursyLabel.Size = new System.Drawing.Size(108, 13);
            this.aktualneKursyLabel.TabIndex = 10;
            this.aktualneKursyLabel.Text = "Aktualne kursy walut:";
            // 
            // kursyWalutTrescLabel
            // 
            this.kursyWalutTrescLabel.AutoSize = true;
            this.kursyWalutTrescLabel.Location = new System.Drawing.Point(18, 368);
            this.kursyWalutTrescLabel.Name = "kursyWalutTrescLabel";
            this.kursyWalutTrescLabel.Size = new System.Drawing.Size(0, 13);
            this.kursyWalutTrescLabel.TabIndex = 11;
            // 
            // dataKursuPicker
            // 
            this.dataKursuPicker.Location = new System.Drawing.Point(490, 70);
            this.dataKursuPicker.Name = "dataKursuPicker";
            this.dataKursuPicker.Size = new System.Drawing.Size(200, 20);
            this.dataKursuPicker.TabIndex = 12;
            // 
            // aktualizacjaKursuWgDaty
            // 
            this.aktualizacjaKursuWgDaty.Location = new System.Drawing.Point(489, 30);
            this.aktualizacjaKursuWgDaty.Name = "aktualizacjaKursuWgDaty";
            this.aktualizacjaKursuWgDaty.Size = new System.Drawing.Size(201, 41);
            this.aktualizacjaKursuWgDaty.TabIndex = 13;
            this.aktualizacjaKursuWgDaty.Text = "Aktualizuj kurs wg podanej daty";
            this.aktualizacjaKursuWgDaty.UseVisualStyleBackColor = true;
            this.aktualizacjaKursuWgDaty.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(31, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 55);
            this.label4.TabIndex = 5;
            this.label4.Text = "0,00";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(21, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 37);
            this.label7.TabIndex = 5;
            this.label7.Text = "€";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(694, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Zaokrąglenie do";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(739, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(712, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "4 miejsc";
            // 
            // ZmianaWaluty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.aktualizacjaKursuWgDaty);
            this.Controls.Add(this.dataKursuPicker);
            this.Controls.Add(this.kursyWalutTrescLabel);
            this.Controls.Add(this.aktualneKursyLabel);
            this.Controls.Add(this.zaktualizujKursButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataKursowLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZamienButton);
            this.Controls.Add(this.ZamienBox);
            this.Name = "ZmianaWaluty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zmiana waluty V1.0";
            this.Load += new System.EventHandler(this.ZmianaWaluty_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ZamienBox;
        private System.Windows.Forms.Button ZamienButton;
        private System.Windows.Forms.RadioButton radioButtonZeuro;
        private System.Windows.Forms.RadioButton radioButtonZdolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonZgbp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dataKursowLabel;
        private System.Windows.Forms.RadioButton radioButtonZrub;
        private System.Windows.Forms.Button zaktualizujKursButton;
        private System.Windows.Forms.Label aktualneKursyLabel;
        private System.Windows.Forms.Label kursyWalutTrescLabel;
        private System.Windows.Forms.DateTimePicker dataKursuPicker;
        private System.Windows.Forms.Button aktualizacjaKursuWgDaty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
    }
}

