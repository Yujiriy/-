namespace WindowsFormsApp1
{
    partial class ReflectorForm
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
            this.PrintDataOfClass = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GetInterfaces = new System.Windows.Forms.Button();
            this.GetMethods = new System.Windows.Forms.Button();
            this.GetFieldsAndProperties = new System.Windows.Forms.Button();
            this.PrintMethodsByParameter = new System.Windows.Forms.Button();
            this.CallMethodFromFile = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PrintDataOfClass
            // 
            this.PrintDataOfClass.Location = new System.Drawing.Point(23, 114);
            this.PrintDataOfClass.Name = "PrintDataOfClass";
            this.PrintDataOfClass.Size = new System.Drawing.Size(144, 47);
            this.PrintDataOfClass.TabIndex = 0;
            this.PrintDataOfClass.Text = "PrintDataOfClass";
            this.PrintDataOfClass.UseVisualStyleBackColor = true;
            this.PrintDataOfClass.Click += new System.EventHandler(this.PrintDataOfClass_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(531, 282);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // GetInterfaces
            // 
            this.GetInterfaces.Location = new System.Drawing.Point(372, 167);
            this.GetInterfaces.Name = "GetInterfaces";
            this.GetInterfaces.Size = new System.Drawing.Size(182, 47);
            this.GetInterfaces.TabIndex = 2;
            this.GetInterfaces.Text = "GetInterfaces";
            this.GetInterfaces.UseVisualStyleBackColor = true;
            this.GetInterfaces.Click += new System.EventHandler(this.GetInterfaces_Click);
            // 
            // GetMethods
            // 
            this.GetMethods.Location = new System.Drawing.Point(23, 167);
            this.GetMethods.Name = "GetMethods";
            this.GetMethods.Size = new System.Drawing.Size(144, 47);
            this.GetMethods.TabIndex = 3;
            this.GetMethods.Text = "GetMethods";
            this.GetMethods.UseVisualStyleBackColor = true;
            this.GetMethods.Click += new System.EventHandler(this.GetMethods_Click);
            // 
            // GetFieldsAndProperties
            // 
            this.GetFieldsAndProperties.Location = new System.Drawing.Point(173, 114);
            this.GetFieldsAndProperties.Name = "GetFieldsAndProperties";
            this.GetFieldsAndProperties.Size = new System.Drawing.Size(193, 47);
            this.GetFieldsAndProperties.TabIndex = 4;
            this.GetFieldsAndProperties.Text = "GetFieldsAndProperties";
            this.GetFieldsAndProperties.UseVisualStyleBackColor = true;
            this.GetFieldsAndProperties.Click += new System.EventHandler(this.GetFieldsAndProperties_Click);
            // 
            // PrintMethodsByParameter
            // 
            this.PrintMethodsByParameter.Location = new System.Drawing.Point(173, 167);
            this.PrintMethodsByParameter.Name = "PrintMethodsByParameter";
            this.PrintMethodsByParameter.Size = new System.Drawing.Size(193, 47);
            this.PrintMethodsByParameter.TabIndex = 5;
            this.PrintMethodsByParameter.Text = "PrintMethodsByParameter";
            this.PrintMethodsByParameter.UseVisualStyleBackColor = true;
            this.PrintMethodsByParameter.Click += new System.EventHandler(this.PrintMethodsByParameter_Click);
            // 
            // CallMethodFromFile
            // 
            this.CallMethodFromFile.Location = new System.Drawing.Point(372, 114);
            this.CallMethodFromFile.Name = "CallMethodFromFile";
            this.CallMethodFromFile.Size = new System.Drawing.Size(182, 47);
            this.CallMethodFromFile.TabIndex = 6;
            this.CallMethodFromFile.Text = "CallMethodFromFile";
            this.CallMethodFromFile.UseVisualStyleBackColor = true;
            this.CallMethodFromFile.Click += new System.EventHandler(this.CallMethodFromFile_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(531, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ReflectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 533);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CallMethodFromFile);
            this.Controls.Add(this.PrintMethodsByParameter);
            this.Controls.Add(this.GetFieldsAndProperties);
            this.Controls.Add(this.GetMethods);
            this.Controls.Add(this.GetInterfaces);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PrintDataOfClass);
            this.Name = "ReflectorForm";
            this.Text = "ReflectorForm";
            this.Load += new System.EventHandler(this.ReflectorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrintDataOfClass;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button GetInterfaces;
        private System.Windows.Forms.Button GetMethods;
        private System.Windows.Forms.Button GetFieldsAndProperties;
        private System.Windows.Forms.Button PrintMethodsByParameter;
        private System.Windows.Forms.Button CallMethodFromFile;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}