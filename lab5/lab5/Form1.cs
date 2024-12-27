using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataLibrary;

namespace lab5
{
    public partial class MainForm : Form
    {
        private readonly DataManager dataManager;
        private List<string> data;

        public MainForm()
        {
            InitializeComponent();
            dataManager = new DataManager("C:\\Users\\urushi\\Documents\\test\\еуче.txt");
            data = new List<string>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите данные.");
                return;
            }

            // Обработка через ref
            dataManager.ModifyData(ref input);
            data.Add(input);
            listBoxData.Items.Add(input);
            txtInput.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataManager.SaveData(data);
            MessageBox.Show("Данные сохранены.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            data = dataManager.LoadData();
            listBoxData.Items.Clear();
            listBoxData.Items.AddRange(data.ToArray());
            MessageBox.Show("Данные загружены.");
        }
    }
}
