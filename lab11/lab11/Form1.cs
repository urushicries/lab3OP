using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{

    public partial class Form1 : Form
    {
        private Button btnPrint;
        public Form1()
        {
            // Инициализация элементов управления
            btnPrint = new Button();
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            btnPrint.Dock = DockStyle.Fill;

            Controls.Add(btnPrint);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Создаем объекты для различных типов, реализующих интерфейс IPrintable
            IPrintable document = new Document("This is a sample document.");
            IPrintable report = new Report("Annual Report", "This is the body of the report.");

            // Печатаем каждый объект
            document.Print();
            report.Print();
        }
    }
}
