
namespace MiloserdovExam
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Helping = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarDealership = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CarDriveTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CarTransmisson = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarEngineTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.CarBrandComboBox = new System.Windows.Forms.ComboBox();
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDealership)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Helping
            // 
            this.Helping.HelpNamespace = "C:\\Users\\Public\\Documents\\Help+Manual\\NewProject\\ExamHelpMiloserdov.chm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.creatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // creatorToolStripMenuItem
            // 
            this.creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
            this.creatorToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.creatorToolStripMenuItem.Text = "Creator";
            this.creatorToolStripMenuItem.Click += new System.EventHandler(this.creatorToolStripMenuItem_Click);
            // 
            // CarDealership
            // 
            this.CarDealership.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CarDealership.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CarDealership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDealership.Location = new System.Drawing.Point(31, 98);
            this.CarDealership.Name = "CarDealership";
            this.CarDealership.Size = new System.Drawing.Size(738, 165);
            this.CarDealership.TabIndex = 2;
            this.CarDealership.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Library_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Location = new System.Drawing.Point(862, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 203);
            this.panel1.TabIndex = 3;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(68, 152);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(149, 33);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(68, 92);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(149, 33);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(68, 25);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(149, 33);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CarDriveTypeComboBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CarTransmisson);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CarEngineTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ColorComboBox);
            this.panel2.Controls.Add(this.CarBrandComboBox);
            this.panel2.Controls.Add(this.ManufacturerComboBox);
            this.panel2.Controls.Add(this.ManufacturerLabel);
            this.panel2.Location = new System.Drawing.Point(764, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 374);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 30;
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
            this.CarDriveTypeComboBox.Location = new System.Drawing.Point(57, 274);
            this.CarDriveTypeComboBox.Name = "CarDriveTypeComboBox";
            this.CarDriveTypeComboBox.Size = new System.Drawing.Size(281, 21);
            this.CarDriveTypeComboBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Трансмиссия";
            // 
            // CarTransmisson
            // 
            this.CarTransmisson.FormattingEnabled = true;
            this.CarTransmisson.Items.AddRange(new object[] {
            "АКПП",
            "МКПП"});
            this.CarTransmisson.Location = new System.Drawing.Point(57, 228);
            this.CarTransmisson.Name = "CarTransmisson";
            this.CarTransmisson.Size = new System.Drawing.Size(281, 21);
            this.CarTransmisson.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Мощность двигателя (л.с.)";
            // 
            // CarEngineTextBox
            // 
            this.CarEngineTextBox.Location = new System.Drawing.Point(57, 182);
            this.CarEngineTextBox.Name = "CarEngineTextBox";
            this.CarEngineTextBox.Size = new System.Drawing.Size(281, 20);
            this.CarEngineTextBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Цвет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 23;
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
            this.ColorComboBox.Location = new System.Drawing.Point(57, 136);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(281, 21);
            this.ColorComboBox.TabIndex = 22;
            // 
            // CarBrandComboBox
            // 
            this.CarBrandComboBox.FormattingEnabled = true;
            this.CarBrandComboBox.Location = new System.Drawing.Point(57, 89);
            this.CarBrandComboBox.Name = "CarBrandComboBox";
            this.CarBrandComboBox.Size = new System.Drawing.Size(281, 21);
            this.CarBrandComboBox.TabIndex = 20;
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.FormattingEnabled = true;
            this.ManufacturerComboBox.Location = new System.Drawing.Point(57, 36);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.Size = new System.Drawing.Size(281, 21);
            this.ManufacturerComboBox.TabIndex = 19;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(57, 20);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(86, 13);
            this.ManufacturerLabel.TabIndex = 18;
            this.ManufacturerLabel.Text = "Производитель";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(42, 48);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(69, 23);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 512);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 7;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 665);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CarDealership);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Helping.SetHelpString(this, "Об авторе");
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Helping.SetShowHelp(this, true);
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForms);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDealership)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider Helping;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView CarDealership;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem creatorToolStripMenuItem;
        private System.Windows.Forms.Button GoBackButton;
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

