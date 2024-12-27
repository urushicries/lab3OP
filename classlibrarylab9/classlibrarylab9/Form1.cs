using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classlibrarylab9
{
    public partial class Form1 : Form
    {
        private EventPublisher eventPublisher;
        private EventSubscriber eventSubscriber;
        public Form1()
        {
            InitializeComponent();

            // Инициализируем объекты
            eventPublisher = new EventPublisher();
            eventSubscriber = new EventSubscriber();

            // Подписываем обработчик события на событие
            eventPublisher.MyEvent += eventSubscriber.OnMyEvent;
        }
        // Обработчик кнопки для вызова события
        private void btnTriggerEvent_Click(object sender, EventArgs e)
        {
            eventPublisher.TriggerEvent(); // Генерируем событие
        }
    }
}
