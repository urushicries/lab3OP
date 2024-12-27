
namespace Lab8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">Истинно, если управляемые ресурсы должны быть очищены; иначе — ложь.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        /// <summary>
        /// Требуемая функция для поддержки конструктора.
        /// Не изменяйте содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateAnimals = new System.Windows.Forms.Button();
            this.txtAnimalInfo = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateAnimals
            // 
            this.btnCreateAnimals.Location = new System.Drawing.Point(12, 70);
            this.btnCreateAnimals.Name = "btnCreateAnimals";
            this.btnCreateAnimals.Size = new System.Drawing.Size(220, 40);
            this.btnCreateAnimals.TabIndex = 0;
            this.btnCreateAnimals.Text = "Создать животных";
            this.btnCreateAnimals.UseVisualStyleBackColor = true;
            this.btnCreateAnimals.Click += new System.EventHandler(this.btnCreateAnimals_Click);
            // 
            // txtAnimalInfo
            // 
            this.txtAnimalInfo.Location = new System.Drawing.Point(12, 120);
            this.txtAnimalInfo.Multiline = true;
            this.txtAnimalInfo.Name = "txtAnimalInfo";
            this.txtAnimalInfo.ReadOnly = true;
            this.txtAnimalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnimalInfo.Size = new System.Drawing.Size(220, 100);
            this.txtAnimalInfo.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(230, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Нажмите кнопку для создания животных:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtAnimalInfo);
            this.Controls.Add(this.btnCreateAnimals);
            this.Name = "MainForm";
            this.Text = "Животные";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

   

        private System.Windows.Forms.Button btnCreateAnimals;
        private System.Windows.Forms.TextBox txtAnimalInfo;
        private System.Windows.Forms.Label lblInfo;
    }
}
