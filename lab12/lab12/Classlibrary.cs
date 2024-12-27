using System;

namespace lab12.Association
{
    // Класс для демонстрации ассоциации
    public class Car
    {
        public string Model { get; set; }  // Свойство для модели машины

        public Car(string model)
        {
            Model = model;
        }
    }

    public class Person
    {
        public string Name;  // Поле для имени человека
        public Car Car { get; set; }  // Ассоциация с Car (используем свойство)

        public Person(string name, Car car)
        {
            Name = name;
            Car = car;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{Name} owns a {Car.Model}");  // Ассоциация: Person использует Car
        }
    }
}


namespace lab12.Aggregation
{
    // Классы для демонстрации агрегации
    public class Employee
    {
        public string Name; // Поле для имени сотрудника

        public Employee(string name)
        {
            Name = name;
        }
    }

    public class Department
    {
        public string DepartmentName; // Поле для имени департамента
        public Employee Employee;  // Поле для сотрудника (агрегация)

        public Department(string departmentName, Employee employee)
        {
            DepartmentName = departmentName;
            Employee = employee;  // Один сотрудник передается через конструктор
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{DepartmentName} department has 1 employee:");
            Console.WriteLine($"- {Employee.Name}");
        }
    }
}

namespace lab12.Composition
{
    // Классы для демонстрации композиции
    public class Room
    {
        public string RoomName; // Поле для имени комнаты

        public Room(string roomName)
        {
            RoomName = roomName;
        }
    }

    public class House
    {
        public string HouseName; // Поле для имени дома
        public Room Room;  // Поле для комнаты (композиция)

        public House(string houseName, Room room)
        {
            HouseName = houseName;
            Room = room;  // Инициализация комнаты
        }

        // Удаление комнаты при уничтожении дома
        public void DestroyHouse()
        {
            Room = null;  // Композиция: при уничтожении дома уничтожается комната
        }

        public void ShowDetails()
        {
            if (Room != null)
            {
                Console.WriteLine($"{HouseName} has 1 room:");
                Console.WriteLine($"- {Room.RoomName}");
            }
            else
            {
                Console.WriteLine($"{HouseName} has no rooms.");
            }
        }
    }
}
