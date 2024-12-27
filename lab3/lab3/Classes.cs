using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using lab3;

    public class InputData
    {
        public int _count;
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set
            {
                // Проверка на пустое значение
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Имя не может быть пустым.");
                _name = value;
                _count++;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                // Проверка на корректность возраста
                if (value < 0 || value > 120)
                    throw new ArgumentOutOfRangeException("Возраст должен быть в пределах от 0 до 120.");
                _age = value;
                _count++;

        }
        }
    }

    public class DefaultPropertyExample
    {
        public string Name { get; set; } // Автосвойство, аналогичное: private string _name; public string Name { get => _name; set => _name = value; }
        public int Age { get; set; }
    }
    public class Person
    {
        // Модификатор private для сеттера, чтобы не позволить изменять имя извне
        public string Name { get; private set; }

        // Полный доступ для геттера и сеттера
        public int Age { get; set; }
    }



