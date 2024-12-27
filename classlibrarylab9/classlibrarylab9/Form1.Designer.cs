namespace classlibrarylab9
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
            this.btnTriggerEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTriggerEvent
            // 
            this.btnTriggerEvent.Location = new System.Drawing.Point(100, 100);
            this.btnTriggerEvent.Name = "btnTriggerEvent";
            this.btnTriggerEvent.Size = new System.Drawing.Size(200, 50);
            this.btnTriggerEvent.TabIndex = 0;
            this.btnTriggerEvent.Text = "Trigger Event";
            this.btnTriggerEvent.UseVisualStyleBackColor = true;
            this.btnTriggerEvent.Click += new System.EventHandler(this.btnTriggerEvent_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTriggerEvent);
            this.Name = "Form1";
            this.Text = "Event Trigger Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTriggerEvent;
    }
}
