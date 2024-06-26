namespace VehicleHealthBook.View
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.producerBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.yearProducedBox = new System.Windows.Forms.TextBox();
            this.mileageBox = new System.Windows.Forms.TextBox();
            this.insuranceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.motDatePicker = new System.Windows.Forms.DateTimePicker();
            this.licenseNumberBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.typeBox.Location = new System.Drawing.Point(137, 33);
            this.typeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(253, 20);
            this.typeBox.TabIndex = 0;
            // 
            // producerBox
            // 
            this.producerBox.Location = new System.Drawing.Point(137, 87);
            this.producerBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(253, 20);
            this.producerBox.TabIndex = 1;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(137, 140);
            this.modelBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(253, 20);
            this.modelBox.TabIndex = 2;
            // 
            // yearProducedBox
            // 
            this.yearProducedBox.Location = new System.Drawing.Point(137, 194);
            this.yearProducedBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yearProducedBox.Name = "yearProducedBox";
            this.yearProducedBox.Size = new System.Drawing.Size(253, 20);
            this.yearProducedBox.TabIndex = 3;
            // 
            // mileageBox
            // 
            this.mileageBox.Location = new System.Drawing.Point(137, 248);
            this.mileageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mileageBox.Name = "mileageBox";
            this.mileageBox.Size = new System.Drawing.Size(253, 20);
            this.mileageBox.TabIndex = 4;
            // 
            // insuranceDatePicker
            // 
            this.insuranceDatePicker.Location = new System.Drawing.Point(200, 306);
            this.insuranceDatePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.insuranceDatePicker.Name = "insuranceDatePicker";
            this.insuranceDatePicker.Size = new System.Drawing.Size(190, 20);
            this.insuranceDatePicker.TabIndex = 5;
            // 
            // motDatePicker
            // 
            this.motDatePicker.Location = new System.Drawing.Point(200, 361);
            this.motDatePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.motDatePicker.Name = "motDatePicker";
            this.motDatePicker.Size = new System.Drawing.Size(190, 20);
            this.motDatePicker.TabIndex = 6;
            // 
            // licenseNumberBox
            // 
            this.licenseNumberBox.Location = new System.Drawing.Point(200, 413);
            this.licenseNumberBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.licenseNumberBox.Name = "licenseNumberBox";
            this.licenseNumberBox.Size = new System.Drawing.Size(190, 20);
            this.licenseNumberBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(241, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(467, 484);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 58);
            this.button2.TabIndex = 11;
            this.button2.Text = "go to vehicle list";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.goToVehicleListButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.licenseNumberBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.motDatePicker);
            this.groupBox1.Controls.Add(this.insuranceDatePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mileageBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.yearProducedBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.modelBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.producerBox);
            this.groupBox1.Controls.Add(this.typeBox);
            this.groupBox1.Location = new System.Drawing.Point(241, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(416, 456);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VEHICLE DATA";
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle HealthBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.TextBox producerBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox yearProducedBox;
        private System.Windows.Forms.TextBox mileageBox;
        private System.Windows.Forms.DateTimePicker insuranceDatePicker;
        private System.Windows.Forms.DateTimePicker motDatePicker;
        private System.Windows.Forms.TextBox licenseNumberBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}