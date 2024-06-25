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
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "typ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "producent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "rok produkcji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "przebieg (w km)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ubezpieczenie (ważne do)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 385);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "przegląd (ważny do)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 454);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(476, 512);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "dane pojazdu";
            // 
            // licenseNumberBox
            // 
            this.licenseNumberBox.Location = new System.Drawing.Point(228, 448);
            this.licenseNumberBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.licenseNumberBox.Name = "licenseNumberBox";
            this.licenseNumberBox.Size = new System.Drawing.Size(215, 22);
            this.licenseNumberBox.TabIndex = 15;
            // 
            // mileageBox
            // 
            this.mileageBox.Location = new System.Drawing.Point(157, 254);
            this.mileageBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mileageBox.Name = "mileageBox";
            this.mileageBox.Size = new System.Drawing.Size(285, 22);
            this.mileageBox.TabIndex = 14;
            // 
            // yearProducedBox
            // 
            this.yearProducedBox.Location = new System.Drawing.Point(157, 194);
            this.yearProducedBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearProducedBox.Name = "yearProducedBox";
            this.yearProducedBox.Size = new System.Drawing.Size(283, 22);
            this.yearProducedBox.TabIndex = 13;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(156, 143);
            this.modelBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(284, 22);
            this.modelBox.TabIndex = 12;
            // 
            // producerBox
            // 
            this.producerBox.Location = new System.Drawing.Point(157, 90);
            this.producerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(285, 22);
            this.producerBox.TabIndex = 11;
            // 
            // motDatePicker
            // 
            this.motDatePicker.Location = new System.Drawing.Point(228, 378);
            this.motDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.motDatePicker.Name = "motDatePicker";
            this.motDatePicker.Size = new System.Drawing.Size(216, 22);
            this.motDatePicker.TabIndex = 10;
            // 
            // insuranceDatePicker
            // 
            this.insuranceDatePicker.Location = new System.Drawing.Point(228, 310);
            this.insuranceDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insuranceDatePicker.Name = "insuranceDatePicker";
            this.insuranceDatePicker.Size = new System.Drawing.Size(216, 22);
            this.insuranceDatePicker.TabIndex = 9;
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "Motorcycle",
            "Bus",
            "Van",
            "SUV"});
            this.typeBox.Location = new System.Drawing.Point(101, 39);
            this.typeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(343, 24);
            this.typeBox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.surnameBox);
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(7, 538);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(476, 138);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "dane właściciela";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(157, 96);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(281, 22);
            this.surnameBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(157, 38);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(285, 22);
            this.nameBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "nazwisko";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "imię";
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Location = new System.Drawing.Point(571, 332);
            this.addVehicleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(240, 86);
            this.addVehicleButton.TabIndex = 10;
            this.addVehicleButton.Text = "zapisz";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(868, 340);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(252, 78);
            this.returnButton.TabIndex = 11;
            this.returnButton.Text = "powrót do spisu pojazdów";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.goToForm1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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