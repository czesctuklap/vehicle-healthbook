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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Production Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mileage (in km)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Insurance (valid till)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 367);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "MOT (valid till)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 416);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "License Plate Number";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.groupBox1.Location = new System.Drawing.Point(13, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(416, 456);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VEHICLE DATA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // licenseNumberBox
            // 
            this.licenseNumberBox.Location = new System.Drawing.Point(200, 413);
            this.licenseNumberBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.licenseNumberBox.Name = "licenseNumberBox";
            this.licenseNumberBox.Size = new System.Drawing.Size(190, 20);
            this.licenseNumberBox.TabIndex = 15;
            // 
            // mileageBox
            // 
            this.mileageBox.Location = new System.Drawing.Point(134, 248);
            this.mileageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mileageBox.Name = "mileageBox";
            this.mileageBox.Size = new System.Drawing.Size(255, 20);
            this.mileageBox.TabIndex = 14;
            // 
            // yearProducedBox
            // 
            this.yearProducedBox.Location = new System.Drawing.Point(136, 194);
            this.yearProducedBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yearProducedBox.Name = "yearProducedBox";
            this.yearProducedBox.Size = new System.Drawing.Size(254, 20);
            this.yearProducedBox.TabIndex = 13;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(136, 140);
            this.modelBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(254, 20);
            this.modelBox.TabIndex = 12;
            // 
            // producerBox
            // 
            this.producerBox.Location = new System.Drawing.Point(136, 87);
            this.producerBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(253, 20);
            this.producerBox.TabIndex = 11;
            // 
            // motDatePicker
            // 
            this.motDatePicker.Location = new System.Drawing.Point(200, 363);
            this.motDatePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.motDatePicker.Name = "motDatePicker";
            this.motDatePicker.Size = new System.Drawing.Size(190, 20);
            this.motDatePicker.TabIndex = 10;
            // 
            // insuranceDatePicker
            // 
            this.insuranceDatePicker.Location = new System.Drawing.Point(200, 306);
            this.insuranceDatePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.insuranceDatePicker.Name = "insuranceDatePicker";
            this.insuranceDatePicker.Size = new System.Drawing.Size(190, 20);
            this.insuranceDatePicker.TabIndex = 9;
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "car",
            "truck",
            "motorcycle",
            "bus",
            "van",
            "suv"});
            this.typeBox.Location = new System.Drawing.Point(136, 30);
            this.typeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(253, 20);
            this.typeBox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.surnameBox);
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(449, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(416, 136);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OWNER DATA*";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(136, 87);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(253, 20);
            this.surnameBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(136, 29);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(253, 20);
            this.nameBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "Surname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name";
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicleButton.Location = new System.Drawing.Point(449, 225);
            this.addVehicleButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(190, 58);
            this.addVehicleButton.TabIndex = 10;
            this.addVehicleButton.Text = "save";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(675, 225);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(190, 58);
            this.returnButton.TabIndex = 11;
            this.returnButton.Text = "go to vehicle list";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.goToForm1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(327, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 34);
            this.label11.TabIndex = 12;
            this.label11.Text = "ADD A VEHICLE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(810, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "optional*";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle HealthBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}