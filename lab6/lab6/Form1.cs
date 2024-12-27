using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using lab6classes; // Подключаем библиотеку с классами

namespace lab6
{
    public partial class Form1 : Form
    {
        // Список для хранения транспортных средств
        private List<Transport> transports = new List<Transport>();

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.MainForm_Load);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Настраиваем начальные данные для ComboBox
            cbTransportType.Items.Clear();  // Очищаем старые элементы
            cbTransportType.Items.Add("Car");
            cbTransportType.Items.Add("Bicycle");
            cbTransportType.SelectedIndex = 0; // Устанавливаем Car как выбранный по умолчанию
        }

        private void btnAddTransport_Click(object sender, EventArgs e)
        {
            try
            {
                string type = cbTransportType.SelectedItem.ToString();
                string name = tbName.Text;
                int speed = int.Parse(tbSpeed.Text);

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Введите имя транспорта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создание объекта соответствующего типа транспорта
                Transport newTransport = null;

                if (type == "Car")
                {
                    string fuelType = tbAdditional.Text;
                    if (string.IsNullOrWhiteSpace(fuelType))
                    {
                        MessageBox.Show("Введите тип топлива для автомобиля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Создание объекта Car
                    newTransport = new Car(name, speed, fuelType);
                }
                else if (type == "Bicycle")
                {
                    int gearCount = int.Parse(tbAdditional.Text);
                    // Создание объекта Bicycle
                    newTransport = new Bicycle(name, speed, gearCount);
                }
                else
                {
                    MessageBox.Show("Неизвестный тип транспорта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Добавляем новый объект в список
                transports.Add(newTransport);

                // Обновляем список в ListBox
                lbTransportList.Items.Add($"{newTransport.GetType().Name}: {newTransport.Name}, Speed: {newTransport.Speed}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения для скорости или передач.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (lbTransportList.SelectedItem is string selectedTransport)
            {
                // Находим транспорт по имени
                Transport transport = transports.FirstOrDefault(t => selectedTransport.Contains(t.Name));
                if (transport != null)
                {
                    transport.Move(); // Вызываем метод Move для объекта
                    MessageBox.Show($"{selectedTransport} начал движение.", "Действие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите транспортное средство.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (lbTransportList.SelectedItem is string selectedTransport)
            {
                // Находим транспорт по имени
                Transport transport = transports.FirstOrDefault(t => selectedTransport.Contains(t.Name));
                if (transport != null)
                {
                    transport.Stop(); // Вызываем метод Stop для объекта
                    MessageBox.Show($"{selectedTransport} остановился.", "Действие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите транспортное средство.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (lbTransportList.SelectedItem is string selectedTransport)
            {
                // Находим транспорт по имени
                Transport transport = transports.FirstOrDefault(t => selectedTransport.Contains(t.Name));
                if (transport != null)
                {
                    MessageBox.Show($"Детали: {selectedTransport}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите транспортное средство.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
