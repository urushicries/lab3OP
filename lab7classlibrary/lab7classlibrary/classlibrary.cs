using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7classlibrary
{
    public class BaseClass
    {
        // Обычное свойство
        public virtual string Property { get; set; } = "Base Property";

        // Метод с возможностью переопределения
        public virtual string Method()
        {
            return "Base Method";
        }

        // Метод, который будет переопределён и запечатан
        public virtual string SealedCandidateMethod()
        {
            return "Base Sealed Candidate Method";
        }

        // Свойство для сокрытия
        public string HiddenProperty { get; set; } = "Base Hidden Property";

        // Метод для сокрытия
        public string HiddenMethod()
        {
            return "Base Hidden Method";
        }
    }

    public class DerivedClass : BaseClass
    {
        // Переопределение свойства
        public override string Property { get; set; } = "Derived Property";

        // Переопределение метода
        public override string Method()
        {
            return "Derived Method";
        }

        // Переопределение и запечатывание метода
        public sealed override string SealedCandidateMethod()
        {
            return "Derived Sealed Method";
        }

        // Сокрытие свойства
        public new string HiddenProperty { get; set; } = "Derived Hidden Property";

        // Сокрытие метода
        public new string HiddenMethod()
        {
            return "Derived Hidden Method";
        }
    }
}

