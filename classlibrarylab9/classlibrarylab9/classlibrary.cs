using System;

namespace classlibrarylab9
{

    // Делегат, который описывает подпись метода-обработчика
    public delegate void MyEventHandler(object sender, EventArgs e);

    // Класс, который будет генерировать событие
    public class EventPublisher
    {
        // Событие, которое будет оповещать об изменениях
        public event MyEventHandler MyEvent;

        // Метод для вызова события
        public void TriggerEvent()
        {
            // Если кто-то подписан на событие, вызываем событие
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }
    // Класс, который подписывается на событие
    public class EventSubscriber
    {
        // Обработчик события
        public void OnMyEvent(object sender, EventArgs e)
        {
            Console.WriteLine("event happend!");
        }
    }
}
