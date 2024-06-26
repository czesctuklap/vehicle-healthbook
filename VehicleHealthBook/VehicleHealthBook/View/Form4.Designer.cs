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
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.producerBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.yearProducedBox = new System.Windows.Forms.TextBox();
            this.mileageBox = new System.Windows.Forms.TextBox();
            this.insuranceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.motDatePicker = new System.Windows.Forms.DateTimePicker();
            this.licenseNumberBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.typeBox.Location = new System.Drawing.Point(68, 49);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 21);
            this.typeBox.TabIndex = 0;
            // 
            // producerBox
            // 
            this.producerBox.Location = new System.Drawing.Point(68, 85);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(100, 20);
            this.producerBox.TabIndex = 1;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(68, 129);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(100, 20);
            this.modelBox.TabIndex = 2;
            // 
            // yearProducedBox
            // 
            this.yearProducedBox.Location = new System.Drawing.Point(68, 178);
            this.yearProducedBox.Name = "yearProducedBox";
            this.yearProducedBox.Size = new System.Drawing.Size(100, 20);
            this.yearProducedBox.TabIndex = 3;
            // 
            // mileageBox
            // 
            this.mileageBox.Location = new System.Drawing.Point(68, 221);
            this.mileageBox.Name = "mileageBox";
            this.mileageBox.Size = new System.Drawing.Size(100, 20);
            this.mileageBox.TabIndex = 4;
            // 
            // insuranceDatePicker
            // 
            this.insuranceDatePicker.Location = new System.Drawing.Point(68, 260);
            this.insuranceDatePicker.Name = "insuranceDatePicker";
            this.insuranceDatePicker.Size = new System.Drawing.Size(200, 20);
            this.insuranceDatePicker.TabIndex = 5;
            // 
            // motDatePicker
            // 
            this.motDatePicker.Location = new System.Drawing.Point(68, 286);
            this.motDatePicker.Name = "motDatePicker";
            this.motDatePicker.Size = new System.Drawing.Size(200, 20);
            this.motDatePicker.TabIndex = 6;
            // 
            // licenseNumberBox
            // 
            this.licenseNumberBox.Location = new System.Drawing.Point(68, 325);
            this.licenseNumberBox.Name = "licenseNumberBox";
            this.licenseNumberBox.Size = new System.Drawing.Size(100, 20);
            this.licenseNumberBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(68, 361);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 8;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(68, 398);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 20);
            this.surnameBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.goToVehicleListButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.licenseNumberBox);
            this.Controls.Add(this.motDatePicker);
            this.Controls.Add(this.insuranceDatePicker);
            this.Controls.Add(this.mileageBox);
            this.Controls.Add(this.yearProducedBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.producerBox);
            this.Controls.Add(this.typeBox);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}