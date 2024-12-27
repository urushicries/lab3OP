using System;
using System.Windows.Forms;
using lab6;
using lab6classes;

namespace lab6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cbTransportType;
        private TextBox tbName;
        private TextBox tbSpeed;
        private TextBox tbAdditional;
        private Button btnAddTransport;
        private ListBox lbTransportList;
        private Button btnMove;
        private Button btnStop;
        private Button btnDetails;

        public void InitializeComponent()
        {
            this.cbTransportType = new ComboBox();
            this.tbName = new TextBox();
            this.tbSpeed = new TextBox();
            this.tbAdditional = new TextBox();
            this.btnAddTransport = new Button();
            this.lbTransportList = new ListBox();
            this.btnMove = new Button();
            this.btnStop = new Button();
            this.btnDetails = new Button();

            this.SuspendLayout();

            // 
            // cbTransportType
            // 
            this.cbTransportType.FormattingEnabled = true;
            this.cbTransportType.Location = new System.Drawing.Point(12, 12);
            this.cbTransportType.Name = "cbTransportType";
            this.cbTransportType.Size = new System.Drawing.Size(260, 23);
            this.cbTransportType.TabIndex = 0;

            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 23);
            this.tbName.TabIndex = 1;
            this.tbName.Enter += new EventHandler(this.tbName_Enter);
            this.tbName.Leave += new EventHandler(this.tbName_Leave);

            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(12, 70);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(260, 23);
            this.tbSpeed.TabIndex = 2;
            this.tbSpeed.Enter += new EventHandler(this.tbSpeed_Enter);
            this.tbSpeed.Leave += new EventHandler(this.tbSpeed_Leave);

            // 
            // tbAdditional
            // 
            this.tbAdditional.Location = new System.Drawing.Point(12, 99);
            this.tbAdditional.Name = "tbAdditional";
            this.tbAdditional.Size = new System.Drawing.Size(260, 23);
            this.tbAdditional.TabIndex = 3;
            this.tbAdditional.Enter += new EventHandler(this.tbAdditional_Enter);
            this.tbAdditional.Leave += new EventHandler(this.tbAdditional_Leave);

            // 
            // btnAddTransport
            // 
            this.btnAddTransport.Location = new System.Drawing.Point(12, 128);
            this.btnAddTransport.Name = "btnAddTransport";
            this.btnAddTransport.Size = new System.Drawing.Size(260, 23);
            this.btnAddTransport.TabIndex = 4;
            this.btnAddTransport.Text = "Добавить транспорт";
            this.btnAddTransport.UseVisualStyleBackColor = true;
            this.btnAddTransport.Click += new EventHandler(this.btnAddTransport_Click);

            // 
            // lbTransportList
            // 
            this.lbTransportList.FormattingEnabled = true;
            this.lbTransportList.ItemHeight = 15;
            this.lbTransportList.Location = new System.Drawing.Point(12, 157);
            this.lbTransportList.Name = "lbTransportList";
            this.lbTransportList.Size = new System.Drawing.Size(260, 124);
            this.lbTransportList.TabIndex = 5;

            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(12, 287);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(80, 23);
            this.btnMove.TabIndex = 6;
            this.btnMove.Text = "Двигаться";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new EventHandler(this.btnMove_Click);

            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(98, 287);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Остановиться";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new EventHandler(this.btnStop_Click);

            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(184, 287);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(88, 23);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "Детали";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new EventHandler(this.btnDetails_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.cbTransportType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbAdditional);
            this.Controls.Add(this.btnAddTransport);
            this.Controls.Add(this.lbTransportList);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnDetails);
            this.Name = "Form1";
            this.Text = "Управление транспортом";
            this.Load += new EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "Имя транспорта")
            {
                tbName.Text = "";
                tbName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                tbName.Text = "Имя транспорта";
                tbName.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void tbSpeed_Enter(object sender, EventArgs e)
        {
            if (tbSpeed.Text == "Скорость (км/ч)")
            {
                tbSpeed.Text = "";
                tbSpeed.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void tbSpeed_Leave(object sender, EventArgs e)
        {
            if (tbSpeed.Text == "")
            {
                tbSpeed.Text = "Скорость (км/ч)";
                tbSpeed.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void tbAdditional_Enter(object sender, EventArgs e)
        {
            if (tbAdditional.Text == "Доп. свойство (топливо/передачи)")
            {
                tbAdditional.Text = "";
                tbAdditional.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void tbAdditional_Leave(object sender, EventArgs e)
        {
            if (tbAdditional.Text == "")
            {
                tbAdditional.Text = "Доп. свойство (топливо/передачи)";
                tbAdditional.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
