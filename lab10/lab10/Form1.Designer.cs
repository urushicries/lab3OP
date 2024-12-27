namespace lab10
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            // Создание кнопки
            this.btnTestIndexer = new System.Windows.Forms.Button();
            this.btnTestIndexer.Location = new System.Drawing.Point(350, 200); // Расположение кнопки
            this.btnTestIndexer.Size = new System.Drawing.Size(100, 50); // Размер кнопки
            this.btnTestIndexer.Text = "Test Indexers"; // Текст на кнопке
            this.btnTestIndexer.Click += new System.EventHandler(this.btnTestIndexer_Click); // Обработчик события

            // Добавление кнопки на форму
            this.Controls.Add(this.btnTestIndexer);
        }

        #endregion

        // Добавление кнопки как поля класса
        private System.Windows.Forms.Button btnTestIndexer;
    }
}
