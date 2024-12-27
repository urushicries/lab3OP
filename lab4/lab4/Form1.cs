using System;
using System.Windows.Forms;
using lab4;

namespace lab4
{
    public partial class Form1 : Form
    {
        private ItemCollection itemCollection;

        public Form1()
        {
            InitializeComponent();
            itemCollection = new ItemCollection();
            InitializeData();
        }

        // Инициализация данных
        private void InitializeData()
        {
            itemCollection.AddItem(new Item("B E", "Big blue eyes", "C:\\Users\\urushi\\Pictures\\1.png"));
            itemCollection.AddItem(new Item("R E", "Big red eyes", "C:\\Users\\urushi\\Pictures\\2.png"));

            // Привязка данных к ListBox
            listBoxItems.DataSource = itemCollection.Items;
            listBoxItems.DisplayMember = "Name";
        }

        // Обработчик события выбора элемента в ListBox
        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                var selectedItem = (Item)listBoxItems.SelectedItem;
                textBoxDescription.Text = selectedItem.Description;
                pictureBox.ImageLocation = selectedItem.ImagePath;
            }
        }
    }
}
