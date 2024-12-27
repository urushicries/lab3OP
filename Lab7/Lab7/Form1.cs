using System;
using System.Windows.Forms;
using lab7;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOverrideMethod_Click(object sender, EventArgs e)
        {
            BaseClass obj = new DerivedClass();
            obj.VirtualMethod(); // Вызов переопределённого метода
        }

        private void btnHideMethod_Click(object sender, EventArgs e)
        {
            DerivedClass obj = new DerivedClass();
            obj.NonVirtualMethod(); // Вызов скрытого метода
        }

        private void btnSealedMethod_Click(object sender, EventArgs e)
        {
            BaseClass obj = new DerivedClass();
            obj.SealedMethod(); // Вызов запечатанного метода
        }

        private void btnOverrideProperty_Click(object sender, EventArgs e)
        {
            BaseClass obj = new DerivedClass();
            MessageBox.Show(obj.VirtualProperty); // Вызов переопределённого свойства
        }
    }
}
