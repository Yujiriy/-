namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label universityNameLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label nameLabel1;
            this.exeQueryBtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.universityNameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.addUnivBtn = new System.Windows.Forms.Button();
            this.ageNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ageLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            universityNameLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // exeQueryBtn
            // 
            this.exeQueryBtn.Location = new System.Drawing.Point(1013, 310);
            this.exeQueryBtn.Name = "exeQueryBtn";
            this.exeQueryBtn.Size = new System.Drawing.Size(167, 47);
            this.exeQueryBtn.TabIndex = 0;
            this.exeQueryBtn.Text = "Выполнить запрос";
            this.exeQueryBtn.UseVisualStyleBackColor = true;
            this.exeQueryBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(521, 42);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(397, 180);
            this.listBox2.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(30, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 180);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Студенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(518, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Университеты";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(31, 245);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(35, 16);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Age:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(31, 273);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(146, 270);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 9;
            // 
            // universityNameLabel
            // 
            universityNameLabel.AutoSize = true;
            universityNameLabel.Location = new System.Drawing.Point(31, 301);
            universityNameLabel.Name = "universityNameLabel";
            universityNameLabel.Size = new System.Drawing.Size(109, 16);
            universityNameLabel.TabIndex = 10;
            universityNameLabel.Text = "University Name:";
            // 
            // universityNameTextBox
            // 
            this.universityNameTextBox.Location = new System.Drawing.Point(146, 298);
            this.universityNameTextBox.Name = "universityNameTextBox";
            this.universityNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.universityNameTextBox.TabIndex = 11;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(520, 271);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(61, 16);
            locationLabel.TabIndex = 12;
            locationLabel.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(587, 268);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 22);
            this.locationTextBox.TabIndex = 13;
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(520, 299);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(47, 16);
            nameLabel1.TabIndex = 14;
            nameLabel1.Text = "Name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(587, 296);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox1.TabIndex = 15;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(97, 342);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(149, 34);
            this.addStudentBtn.TabIndex = 16;
            this.addStudentBtn.Text = "Добавить";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // addUnivBtn
            // 
            this.addUnivBtn.Location = new System.Drawing.Point(538, 342);
            this.addUnivBtn.Name = "addUnivBtn";
            this.addUnivBtn.Size = new System.Drawing.Size(149, 34);
            this.addUnivBtn.TabIndex = 17;
            this.addUnivBtn.Text = "Добавить";
            this.addUnivBtn.UseVisualStyleBackColor = true;
            this.addUnivBtn.Click += new System.EventHandler(this.addUnivBtn_Click);
            // 
            // ageNumericUpDown1
            // 
            this.ageNumericUpDown1.Location = new System.Drawing.Point(146, 238);
            this.ageNumericUpDown1.Name = "ageNumericUpDown1";
            this.ageNumericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.ageNumericUpDown1.TabIndex = 18;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(992, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(214, 180);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 458);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ageNumericUpDown1);
            this.Controls.Add(this.addUnivBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(ageLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(universityNameLabel);
            this.Controls.Add(this.universityNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.exeQueryBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exeQueryBtn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox universityNameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button addUnivBtn;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

