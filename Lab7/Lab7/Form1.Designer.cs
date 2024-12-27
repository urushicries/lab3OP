namespace lab7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnOverrideMethod = new System.Windows.Forms.Button();
            this.btnHideMethod = new System.Windows.Forms.Button();
            this.btnSealedMethod = new System.Windows.Forms.Button();
            this.btnOverrideProperty = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // btnOverrideMethod
            // 
            this.btnOverrideMethod.Location = new System.Drawing.Point(12, 12);
            this.btnOverrideMethod.Name = "btnOverrideMethod";
            this.btnOverrideMethod.Size = new System.Drawing.Size(200, 30);
            this.btnOverrideMethod.TabIndex = 0;
            this.btnOverrideMethod.Text = "Переопределение метода";
            this.btnOverrideMethod.UseVisualStyleBackColor = true;
            this.btnOverrideMethod.Click += new System.EventHandler(this.btnOverrideMethod_Click);

            // 
            // btnHideMethod
            // 
            this.btnHideMethod.Location = new System.Drawing.Point(12, 48);
            this.btnHideMethod.Name = "btnHideMethod";
            this.btnHideMethod.Size = new System.Drawing.Size(200, 30);
            this.btnHideMethod.TabIndex = 1;
            this.btnHideMethod.Text = "Сокрытие метода";
            this.btnHideMethod.UseVisualStyleBackColor = true;
            this.btnHideMethod.Click += new System.EventHandler(this.btnHideMethod_Click);

            // 
            // btnSealedMethod
            // 
            this.btnSealedMethod.Location = new System.Drawing.Point(12, 84);
            this.btnSealedMethod.Name = "btnSealedMethod";
            this.btnSealedMethod.Size = new System.Drawing.Size(200, 30);
            this.btnSealedMethod.TabIndex = 2;
            this.btnSealedMethod.Text = "Запечатанный метод";
            this.btnSealedMethod.UseVisualStyleBackColor = true;
            this.btnSealedMethod.Click += new System.EventHandler(this.btnSealedMethod_Click);

            // 
            // btnOverrideProperty
            // 
            this.btnOverrideProperty.Location = new System.Drawing.Point(12, 120);
            this.btnOverrideProperty.Name = "btnOverrideProperty";
            this.btnOverrideProperty.Size = new System.Drawing.Size(200, 30);
            this.btnOverrideProperty.TabIndex = 3;
            this.btnOverrideProperty.Text = "Переопределение свойства";
            this.btnOverrideProperty.UseVisualStyleBackColor = true;
            this.btnOverrideProperty.Click += new System.EventHandler(this.btnOverrideProperty_Click);

            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 156);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(360, 120);
            this.txtOutput.TabIndex = 4;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnOverrideProperty);
            this.Controls.Add(this.btnSealedMethod);
            this.Controls.Add(this.btnHideMethod);
            this.Controls.Add(this.btnOverrideMethod);
            this.Name = "MainForm";
            this.Text = "Демонстрация методов и свойств";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnOverrideMethod;
        private System.Windows.Forms.Button btnHideMethod;
        private System.Windows.Forms.Button btnSealedMethod;
        private System.Windows.Forms.Button btnOverrideProperty;
        private System.Windows.Forms.TextBox txtOutput;
    }
}