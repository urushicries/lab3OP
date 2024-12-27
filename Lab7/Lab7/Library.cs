using System;

namespace lab7
{
    // Базовый класс
    public class BaseClass
    {
        public virtual string VirtualProperty { get; set; } = "Base Property";

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Base Method");
        }

        public void NonVirtualMethod()
        {
            Console.WriteLine("Non-Virtual Method");
        }

        // Убираем sealed, так как метод не override
        public void SealedMethod()
        {
            Console.WriteLine("Sealed Method in Base Class");
        }
    }

    // Производный класс
    public class DerivedClass : BaseClass
    {
        // Переопределение метода
        public override void VirtualMethod()
        {
            Console.WriteLine("Overridden Method in Derived Class");
        }

        // Переопределение свойства
        public override string VirtualProperty
        {
            get => "Overridden Property in Derived Class";
            set => base.VirtualProperty = value;
        }

        // Сокрытие метода
        public new void NonVirtualMethod()
        {
            Console.WriteLine("Hidden Non-Virtual Method in Derived Class");
        }

        // Сокрытие свойства (убрано override для избежания конфликта)
        public new string NewProperty { get; set; } = "Hidden Property in Derived Class";
    }
}
