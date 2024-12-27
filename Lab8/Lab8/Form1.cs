using System;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // инициализация компонентов формы
        }

        private void btnCreateAnimals_Click(object sender, EventArgs e)
        {
            Animal dog = new Dog("Buddy");
            Animal cat = new Cat("Whiskers");

            // Вывод информации о животных
            txtAnimalInfo.Text = dog.ToString() + Environment.NewLine + cat.ToString();
        }
    }


    public abstract class Animal
    {

        private string name;


        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public abstract void Speak();

        public override string ToString()
        {
            return $"Animal Name: {name}";
        }
    }

    public class Dog : Animal
    {
        // Конструктор с параметром для имени
        public Dog(string name) : base(name) { }

        public override void Speak()
        {
            MessageBox.Show($"{Name} says Woof!");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Type: Dog";
        }
    }

    public class Cat : Animal
    {
        // Конструктор с параметром для имени
        public Cat(string name) : base(name) { }

        public override void Speak()
        {
            MessageBox.Show($"{Name} says Meow!");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Type: Cat";
        }
    }
}
