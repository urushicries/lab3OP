namespace lab12
{
    partial class Form1
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
            this.btnAssociation = new System.Windows.Forms.Button();
            this.btnAggregation = new System.Windows.Forms.Button();
            this.btnComposition = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // btnAssociation
            // 
            this.btnAssociation.Location = new System.Drawing.Point(12, 12);
            this.btnAssociation.Name = "btnAssociation";
            this.btnAssociation.Size = new System.Drawing.Size(160, 30);
            this.btnAssociation.TabIndex = 0;
            this.btnAssociation.Text = "Demonstrate Association";
            this.btnAssociation.UseVisualStyleBackColor = true;
            this.btnAssociation.Click += new System.EventHandler(this.btnAssociation_Click);

            // 
            // btnAggregation
            // 
            this.btnAggregation.Location = new System.Drawing.Point(12, 48);
            this.btnAggregation.Name = "btnAggregation";
            this.btnAggregation.Size = new System.Drawing.Size(160, 30);
            this.btnAggregation.TabIndex = 1;
            this.btnAggregation.Text = "Demonstrate Aggregation";
            this.btnAggregation.UseVisualStyleBackColor = true;
            this.btnAggregation.Click += new System.EventHandler(this.btnAggregation_Click);

            // 
            // btnComposition
            // 
            this.btnComposition.Location = new System.Drawing.Point(12, 84);
            this.btnComposition.Name = "btnComposition";
            this.btnComposition.Size = new System.Drawing.Size(160, 30);
            this.btnComposition.TabIndex = 2;
            this.btnComposition.Text = "Demonstrate Composition";
            this.btnComposition.UseVisualStyleBackColor = true;
            this.btnComposition.Click += new System.EventHandler(this.btnComposition_Click);

            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 120);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(350, 150);
            this.outputTextBox.TabIndex = 3;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.btnComposition);
            this.Controls.Add(this.btnAggregation);
            this.Controls.Add(this.btnAssociation);
            this.Name = "Form1";
            this.Text = "Lab12 - Object Relationships";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAssociation;
        private System.Windows.Forms.Button btnAggregation;
        private System.Windows.Forms.Button btnComposition;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}
