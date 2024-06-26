namespace VehicleHealthBook.View
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.licenseNumberBox = new System.Windows.Forms.TextBox();
            this.mileageBox = new System.Windows.Forms.TextBox();
            this.yearProducedBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.producerBox = new System.Windows.Forms.TextBox();
            this.motDatePicker = new System.Windows.Forms.DateTimePicker();
            this.insuranceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "typ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "producent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "rok produkcji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "przebieg (w km)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ubezpieczenie (ważne do)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "przegląd (ważny do)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "numer rejestracyjny";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.licenseNumberBox);
            this.groupBox1.Controls.Add(this.mileageBox);
            this.groupBox1.Controls.Add(this.yearProducedBox);
            this.groupBox1.Controls.Add(this.modelBox);
            this.groupBox1.Controls.Add(this.producerBox);
            this.groupBox1.Controls.Add(this.motDatePicker);
            this.groupBox1.Controls.Add(this.insuranceDatePicker);
            this.groupBox1.Controls.Add(this.typeBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 416);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "dane pojazdu";
            // 
            // licenseNumberBox
            // 
            this.licenseNumberBox.Location = new System.Drawing.Point(171, 364);
            this.licenseNumberBox.Name = "licenseNumberBox";
            this.licenseNumberBox.Size = new System.Drawing.Size(162, 20);
            this.licenseNumberBox.TabIndex = 15;
            // 
            // mileageBox
            // 
            this.mileageBox.Location = new System.Drawing.Point(118, 206);
            this.mileageBox.Name = "mileageBox";
            this.mileageBox.Size = new System.Drawing.Size(215, 20);
            this.mileageBox.TabIndex = 14;
            // 
            // yearProducedBox
            // 
            this.yearProducedBox.Location = new System.Drawing.Point(118, 158);
            this.yearProducedBox.Name = "yearProducedBox";
            this.yearProducedBox.Size = new System.Drawing.Size(213, 20);
            this.yearProducedBox.TabIndex = 13;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(117, 116);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(214, 20);
            this.modelBox.TabIndex = 12;
            // 
            // producerBox
            // 
            this.producerBox.Location = new System.Drawing.Point(118, 73);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(215, 20);
            this.producerBox.TabIndex = 11;
            // 
            // motDatePicker
            // 
            this.motDatePicker.Location = new System.Drawing.Point(171, 307);
            this.motDatePicker.Name = "motDatePicker";
            this.motDatePicker.Size = new System.Drawing.Size(163, 20);
            this.motDatePicker.TabIndex = 10;
            // 
            // insuranceDatePicker
            // 
            this.insuranceDatePicker.Location = new System.Drawing.Point(171, 252);
            this.insuranceDatePicker.Name = "insuranceDatePicker";
            this.insuranceDatePicker.Size = new System.Drawing.Size(163, 20);
            this.insuranceDatePicker.TabIndex = 9;
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "car",
            "truck",
            "motorcycle",
            "bus",
            "van",
            "suv"});
            this.typeBox.Location = new System.Drawing.Point(76, 32);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(258, 21);
            this.typeBox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.surnameBox);
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(5, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 112);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "dane właściciela";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(118, 78);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(212, 20);
            this.surnameBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(118, 31);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(215, 20);
            this.nameBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "nazwisko";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "imię";
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Location = new System.Drawing.Point(428, 270);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(180, 70);
            this.addVehicleButton.TabIndex = 10;
            this.addVehicleButton.Text = "zapisz";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(651, 276);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(189, 63);
            this.returnButton.TabIndex = 11;
            this.returnButton.Text = "powrót do spisu pojazdów";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.goToForm1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mileageBox;
        private System.Windows.Forms.TextBox yearProducedBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox producerBox;
        private System.Windows.Forms.DateTimePicker motDatePicker;
        private System.Windows.Forms.DateTimePicker insuranceDatePicker;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.TextBox licenseNumberBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button returnButton;
    }
}