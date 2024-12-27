using System;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestIndexer_Click(object sender, EventArgs e)
        {
            // Тестируем SimpleIndexer
            var simpleIndexer = new SimpleIndexer();
            simpleIndexer[0] = 42;
            MessageBox.Show($"SimpleIndexer[0] = {simpleIndexer[0]}");

            // Тестируем MultiParamIndexer
            var multiParamIndexer = new MultiParamIndexer();
            multiParamIndexer[1, 2] = "Hello, World!";
            MessageBox.Show($"MultiParamIndexer[1,2] = {multiParamIndexer[1, 2]}");

            // Тестируем ListIndexer
            var listIndexer = new ListIndexer();
            listIndexer.Add("First");
            listIndexer.Add("Second");
            MessageBox.Show($"ListIndexer[0] = {listIndexer[0]}\nListIndexer[1] = {listIndexer[1]}");
        }
    }
}
