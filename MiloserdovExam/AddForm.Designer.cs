
namespace MiloserdovExam
{
    partial class AddForm
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
            this.AddFormPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CarDriveTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CarTransmisson = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarEngineTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.SaveNewFormButton = new System.Windows.Forms.Button();
            this.CarBrandComboBox = new System.Windows.Forms.ComboBox();
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.AddFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFormPanel
            // 
            this.AddFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddFormPanel.Controls.Add(this.label5);
            this.AddFormPanel.Controls.Add(this.CarDriveTypeComboBox);
            this.AddFormPanel.Controls.Add(this.label4);
            this.AddFormPanel.Controls.Add(this.CarTransmisson);
            this.AddFormPanel.Controls.Add(this.label3);
            this.AddFormPanel.Controls.Add(this.CarEngineTextBox);
            this.AddFormPanel.Controls.Add(this.label2);
            this.AddFormPanel.Controls.Add(this.label1);
            this.AddFormPanel.Controls.Add(this.ColorComboBox);
            this.AddFormPanel.Controls.Add(this.SaveNewFormButton);
            this.AddFormPanel.Controls.Add(this.CarBrandComboBox);
            this.AddFormPanel.Controls.Add(this.ManufacturerComboBox);
            this.AddFormPanel.Controls.Add(this.ManufacturerLabel);
            this.AddFormPanel.Location = new System.Drawing.Point(183, 55);
            this.AddFormPanel.Name = "AddFormPanel";
            this.AddFormPanel.Size = new System.Drawing.Size(380, 420);
            this.AddFormPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Привод";
            // 
            // CarDriveTypeComboBox
            // 
            this.CarDriveTypeComboBox.FormattingEnabled = true;
            this.CarDriveTypeComboBox.Items.AddRange(new object[] {
            "Передний",
            "Задний",
            "Полный",
            "Переключаемый"});
            this.CarDriveTypeComboBox.Location = new System.Drawing.Point(59, 286);
            this.CarDriveTypeComboBox.Name = "CarDriveTypeComboBox";
            this.CarDriveTypeComboBox.Size = new System.Drawing.Size(281, 21);
            this.CarDriveTypeComboBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Трансмиссия";
            // 
            // CarTransmisson
            // 
            this.CarTransmisson.FormattingEnabled = true;
            this.CarTransmisson.Items.AddRange(new object[] {
            "АКПП",
            "МКПП"});
            this.CarTransmisson.Location = new System.Drawing.Point(59, 240);
            this.CarTransmisson.Name = "CarTransmisson";
            this.CarTransmisson.Size = new System.Drawing.Size(281, 21);
            this.CarTransmisson.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Мощность двигателя (л.с.)";
            // 
            // CarEngineTextBox
            // 
            this.CarEngineTextBox.Location = new System.Drawing.Point(59, 194);
            this.CarEngineTextBox.Name = "CarEngineTextBox";
            this.CarEngineTextBox.Size = new System.Drawing.Size(281, 20);
            this.CarEngineTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Цвет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Марка";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Черный",
            "Белый",
            "Синий",
            "Красный",
            "Желтый",
            "Серебристый"});
            this.ColorComboBox.Location = new System.Drawing.Point(59, 148);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(281, 21);
            this.ColorComboBox.TabIndex = 9;
            // 
            // SaveNewFormButton
            // 
            this.SaveNewFormButton.Location = new System.Drawing.Point(151, 335);
            this.SaveNewFormButton.Name = "SaveNewFormButton";
            this.SaveNewFormButton.Size = new System.Drawing.Size(75, 23);
            this.SaveNewFormButton.TabIndex = 8;
            this.SaveNewFormButton.Text = "Сохранить";
            this.SaveNewFormButton.UseVisualStyleBackColor = true;
            this.SaveNewFormButton.Click += new System.EventHandler(this.SaveNewFormButton_Click);
            // 
            // CarBrandComboBox
            // 
            this.CarBrandComboBox.FormattingEnabled = true;
            this.CarBrandComboBox.Location = new System.Drawing.Point(59, 101);
            this.CarBrandComboBox.Name = "CarBrandComboBox";
            this.CarBrandComboBox.Size = new System.Drawing.Size(281, 21);
            this.CarBrandComboBox.TabIndex = 4;
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.FormattingEnabled = true;
            this.ManufacturerComboBox.Location = new System.Drawing.Point(59, 48);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.Size = new System.Drawing.Size(281, 21);
            this.ManufacturerComboBox.TabIndex = 2;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(59, 32);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(86, 13);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "Производитель";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 576);
            this.Controls.Add(this.AddFormPanel);
            this.Name = "AddForm";
            this.Text = "Добавить автомобиль";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.AddFormPanel.ResumeLayout(false);
            this.AddFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddFormPanel;
        private System.Windows.Forms.Button SaveNewFormButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CarDriveTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CarTransmisson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CarEngineTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.ComboBox CarBrandComboBox;
        private System.Windows.Forms.ComboBox ManufacturerComboBox;
        private System.Windows.Forms.Label ManufacturerLabel;
    }
}