using System;
using System.Collections.Generic;
using System.Windows.Forms;
using lab12.Aggregation;
using lab12.Association;
using lab12.Composition;

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик для кнопки ассоциации
        private void btnAssociation_Click(object sender, EventArgs e)
        {
            // Демонстрация ассоциации
            Car car = new Car("BMW");
            Person person = new Person("John", car);
            person.ShowDetails();
        }

        // Обработчик для кнопки агрегации
        private void btnAggregation_Click(object sender, EventArgs e)
        {
            // Демонстрация агрегации
            Employee employee = new Employee("Alice");
            Department department = new Department("HR", employee);  // Один сотрудник передается через конструктор
            department.ShowDetails();
        }

        // Обработчик для кнопки композиции
        private void btnComposition_Click(object sender, EventArgs e)
        {
            // Демонстрация композиции
            Room room1 = new Room("Living Room");
            House house = new House("Dream House", room1);  // Создаем дом с одной комнатой

            house.ShowDetails();

            // Удаление дома (комната будет уничтожена)
            house.DestroyHouse();
            house.ShowDetails();
        }
    }
}
