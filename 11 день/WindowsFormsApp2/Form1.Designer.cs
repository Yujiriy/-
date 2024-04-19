namespace WindowsFormsApp2
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fillQueueButton = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(88, 96);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 39);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ключ";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(24, 56);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(100, 22);
            this.keyTextBox.TabIndex = 2;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(143, 56);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(169, 22);
            this.valueTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(138, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значение(double)";
            // 
            // fillQueueButton
            // 
            this.fillQueueButton.Location = new System.Drawing.Point(226, 372);
            this.fillQueueButton.Name = "fillQueueButton";
            this.fillQueueButton.Size = new System.Drawing.Size(178, 51);
            this.fillQueueButton.TabIndex = 5;
            this.fillQueueButton.Text = "Заполнить очередь";
            this.fillQueueButton.UseVisualStyleBackColor = true;
            this.fillQueueButton.Click += new System.EventHandler(this.fillQueueButton_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(444, 136);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(209, 43);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Удалить n элементов";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(395, 81);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(574, 81);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(378, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Индекс начала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(556, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Кол-во удалить";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 216);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 131);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(226, 216);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(178, 131);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(221, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Очередь ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Словарь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.fillQueueButton);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fillQueueButton;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

