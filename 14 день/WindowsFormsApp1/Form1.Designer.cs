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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label controlTypeLabel;
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label labCountLabel;
            System.Windows.Forms.Label lectureCountLabel;
            System.Windows.Forms.Label semesterLabel;
            System.Windows.Forms.Label specializationLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label classroomLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label fullNameLabel;
            this.controlTypeTextBox = new System.Windows.Forms.TextBox();
            this.specializationTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.classroomTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            controlTypeLabel = new System.Windows.Forms.Label();
            courseLabel = new System.Windows.Forms.Label();
            labCountLabel = new System.Windows.Forms.Label();
            lectureCountLabel = new System.Windows.Forms.Label();
            semesterLabel = new System.Windows.Forms.Label();
            specializationLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            classroomLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // controlTypeLabel
            // 
            controlTypeLabel.AutoSize = true;
            controlTypeLabel.Location = new System.Drawing.Point(20, 39);
            controlTypeLabel.Name = "controlTypeLabel";
            controlTypeLabel.Size = new System.Drawing.Size(87, 16);
            controlTypeLabel.TabIndex = 0;
            controlTypeLabel.Text = "Control Type:";
            // 
            // controlTypeTextBox
            // 
            this.controlTypeTextBox.Location = new System.Drawing.Point(120, 36);
            this.controlTypeTextBox.Name = "controlTypeTextBox";
            this.controlTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.controlTypeTextBox.TabIndex = 1;
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new System.Drawing.Point(20, 67);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(53, 16);
            courseLabel.TabIndex = 2;
            courseLabel.Text = "Course:";
            // 
            // labCountLabel
            // 
            labCountLabel.AutoSize = true;
            labCountLabel.Location = new System.Drawing.Point(20, 95);
            labCountLabel.Name = "labCountLabel";
            labCountLabel.Size = new System.Drawing.Size(70, 16);
            labCountLabel.TabIndex = 4;
            labCountLabel.Text = "Lab Count:";
            // 
            // lectureCountLabel
            // 
            lectureCountLabel.AutoSize = true;
            lectureCountLabel.Location = new System.Drawing.Point(20, 123);
            lectureCountLabel.Name = "lectureCountLabel";
            lectureCountLabel.Size = new System.Drawing.Size(91, 16);
            lectureCountLabel.TabIndex = 6;
            lectureCountLabel.Text = "Lecture Count:";
            // 
            // semesterLabel
            // 
            semesterLabel.AutoSize = true;
            semesterLabel.Location = new System.Drawing.Point(20, 151);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new System.Drawing.Size(68, 16);
            semesterLabel.TabIndex = 8;
            semesterLabel.Text = "Semester:";
            // 
            // specializationLabel
            // 
            specializationLabel.AutoSize = true;
            specializationLabel.Location = new System.Drawing.Point(20, 179);
            specializationLabel.Name = "specializationLabel";
            specializationLabel.Size = new System.Drawing.Size(94, 16);
            specializationLabel.TabIndex = 10;
            specializationLabel.Text = "Specialization:";
            // 
            // specializationTextBox
            // 
            this.specializationTextBox.Location = new System.Drawing.Point(120, 176);
            this.specializationTextBox.Name = "specializationTextBox";
            this.specializationTextBox.Size = new System.Drawing.Size(100, 22);
            this.specializationTextBox.TabIndex = 11;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(20, 207);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(36, 16);
            titleLabel.TabIndex = 12;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(120, 204);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 22);
            this.titleTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.disciplineBindingSource;
            // 
            // classroomLabel
            // 
            classroomLabel.AutoSize = true;
            classroomLabel.Location = new System.Drawing.Point(296, 39);
            classroomLabel.Name = "classroomLabel";
            classroomLabel.Size = new System.Drawing.Size(75, 16);
            classroomLabel.TabIndex = 29;
            classroomLabel.Text = "Classroom:";
            // 
            // classroomTextBox
            // 
            this.classroomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "Lecturer.Classroom", true));
            this.classroomTextBox.Location = new System.Drawing.Point(382, 36);
            this.classroomTextBox.Name = "classroomTextBox";
            this.classroomTextBox.Size = new System.Drawing.Size(100, 22);
            this.classroomTextBox.TabIndex = 30;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(296, 67);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(80, 16);
            departmentLabel.TabIndex = 31;
            departmentLabel.Text = "Department:";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "Lecturer.Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(382, 64);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 22);
            this.departmentTextBox.TabIndex = 32;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(296, 95);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(71, 16);
            fullNameLabel.TabIndex = 33;
            fullNameLabel.Text = "Full Name:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "Lecturer.FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(382, 92);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.fullNameTextBox.TabIndex = 34;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(522, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 363);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 149);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 36;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(120, 61);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 37;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(120, 120);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 38;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(120, 91);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown4.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Discipline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Lecturer";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(834, 36);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(296, 363);
            this.richTextBox2.TabIndex = 42;
            this.richTextBox2.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(856, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 43;
            
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1003, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 25);
            this.button2.TabIndex = 44;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataSource = typeof(WindowsFormsApp1.Discipline);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(classroomLabel);
            this.Controls.Add(this.classroomTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(controlTypeLabel);
            this.Controls.Add(this.controlTypeTextBox);
            this.Controls.Add(courseLabel);
            this.Controls.Add(labCountLabel);
            this.Controls.Add(lectureCountLabel);
            this.Controls.Add(semesterLabel);
            this.Controls.Add(specializationLabel);
            this.Controls.Add(this.specializationTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox controlTypeTextBox;
        private System.Windows.Forms.TextBox specializationTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private System.Windows.Forms.TextBox classroomTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button2;
    }
}

